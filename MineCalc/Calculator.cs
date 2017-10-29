using System.Collections.Generic;
using System.Linq;

namespace MineCalc.Model
{
    class Calculator
    {
        private readonly RecipeBook _book;

        public Calculator(RecipeBook book)
        {
            _book = book;
        }

        public IEnumerable<BlockStack> GetRequirements(IEnumerable<BlockStack> stacks)
        {
            var requirements = stacks
                .Select(Expand)
                .SelectMany(rec => rec.Requirements);

            return Merge(requirements)
                .ToList();
        }
        
        public IRecipe Expand(IRecipe recipe)
        {
            IRecipe ExpandOnce(IRecipe rec)
            {
                if (!rec.Requirements.Any()) return rec;

                var requirements = rec.Requirements
                    .SelectMany(r => GetRecipe(r).Requirements);

                return new Recipe(rec.Result, Merge(requirements));
            }

            const int maxDepth = 20;

            IRecipe last = recipe;

            for (var i = 1; i <= maxDepth; i++)
            {
                var temp = ExpandOnce(last);
                if (temp == last) return temp;
                last = temp;
            }

            return last;
        }

        private IEnumerable<BlockStack> Merge(IEnumerable<BlockStack> stacks)
        {
            return stacks
                .GroupBy(r => r.Type)
                .Select(g => new BlockStack(g.Key, g.Sum(bs => bs.Count)))
                .OrderBy(stack=>stack.Type.Name);
        }

        private IRecipe GetRecipe(BlockStack stack)
        {
            var recipe = _book.Recipes
                .FirstOrDefault(r => r.Result.Type == stack.Type);

            if (recipe == null) return stack;

            var scale = stack.Count / recipe.Result.Count;
            var requirements = recipe.Requirements.Select(stk => Scale(stk, scale));
            return new Recipe(stack.Result, requirements);
        }

        private BlockStack Scale(BlockStack @this, decimal scale) =>
              new BlockStack(@this.Type, scale * @this.Count);
    }
}
