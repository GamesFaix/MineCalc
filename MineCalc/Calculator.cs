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

        public IEnumerable<ItemStack> GetIngredients(IEnumerable<ItemStack> stacks)
        {
            var requirements = stacks
                .Select(Expand)
                .SelectMany(rec => rec.Ingredients);

            return Merge(requirements)
                .ToList();
        }
        
        public IRecipe Expand(IRecipe recipe)
        {
            IRecipe ExpandOnce(IRecipe rec)
            {
                if (!rec.Ingredients.Any()) return rec;

                var requirements = rec.Ingredients
                    .SelectMany(stack => GetRecipe(stack).Ingredients);

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

        private IEnumerable<ItemStack> Merge(IEnumerable<ItemStack> stacks)
        {
            return stacks
                .GroupBy(stack => stack.Type)
                .Select(group => new ItemStack(group.Key, group.Sum(stack => stack.Count)))
                .OrderBy(stack => stack.Type.Name);
        }

        private IRecipe GetRecipe(ItemStack stack)
        {
            var recipe = _book.Recipes
                .FirstOrDefault(rec => rec.Result.Type == stack.Type);

            if (recipe == null) return stack;

            var scale = stack.Count / recipe.Result.Count;
            var requirements = recipe.Ingredients.Select(stk => Scale(stk, scale));
            return new Recipe(stack.Result, requirements);
        }

        private ItemStack Scale(ItemStack @this, decimal scale) =>
              new ItemStack(@this.Type, scale * @this.Count);
    }
}
