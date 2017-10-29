using System.Collections.Generic;
using System.Linq;

namespace MineCalc.Model
{
    class Calculator
    {
        public BlockStack Scale(BlockStack @this, decimal scale) =>
              new BlockStack(@this.Type, scale * @this.Count);

        public bool IsPrimitive(RecipeBook book, BlockType type) =>
            !book.Recipes.Any(r => r.Result.Type == type);

        public IRecipe GetRecipe(RecipeBook book, BlockStack stack)
        {
            var recipe = book.Recipes
                .FirstOrDefault(r => r.Result.Type == stack.Type);

            if (recipe == null)
            {
                return stack;
            }
            else
            {
                var scale = stack.Count / recipe.Result.Count;
                var requirements = recipe.Requirements.Select(stk => Scale(stk, scale));
                return new Recipe(stack.Result, requirements);
            }
        }

        public Recipe Merge(BlockStack result, IEnumerable<IRecipe> requirements)
        {
            var inputs = requirements
                .SelectMany(r => r.Requirements)
                .GroupBy(r => r.Type)
                .Select(g => new BlockStack(g.Key, g.Sum(bs => bs.Count)));

            return new Recipe(result, inputs);
        }

        public IRecipe Expand(IRecipe recipe, RecipeBook book)
        {
            const int maxDepth = 20;

            IRecipe last = recipe;

            for (var i = 1; i<= maxDepth; i++)
            {                
                var temp = ExpandOnce(last, book);
                if (temp == last) return temp;
                last = temp;
            }

            return last;
        }
        
        private IRecipe ExpandOnce(IRecipe recipe, RecipeBook book)
        {
            if (!recipe.Requirements.Any())
            {
                return recipe;
            }
            else
            {
                var list = new List<BlockStack>();
                foreach (var r in recipe.Requirements)
                {
                    var temp = GetRecipe(book, r).Requirements;

                    list.AddRange(temp);
                }

               // var requirements = recipe.Requirements.SelectMany(stack => GetRecipe(book, stack).Requirements);
                return Merge(recipe.Result, list);
            }
        }
    }
}
