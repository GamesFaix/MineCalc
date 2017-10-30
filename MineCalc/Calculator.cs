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
            var recipes = stacks
                .Select(Expand)
                .ToList();

            var ingredients = MergeIngredients(recipes.SelectMany(rec => rec.Ingredients));

            var equipment = MergeEquipment(recipes.SelectMany(rec => rec.Equipment));

            return ingredients
                .Concat(equipment.Select(e => new ItemStack(e, 1)));
        }
        
        public IRecipe Expand(IRecipe recipe)
        {
            IRecipe ExpandOnce(IRecipe rec)
            {
                if (!rec.Ingredients.Any()) return rec;

                var subRecipes = rec.Ingredients
                    .Select(stack => GetRecipe(stack))
                    .ToList();
                
                return new Recipe(rec.Result, 
                    MergeIngredients(subRecipes.SelectMany(r => r.Ingredients)),
                    MergeEquipment(rec.Equipment.Concat(subRecipes.SelectMany(r => r.Equipment))));
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

        private IEnumerable<ItemStack> MergeIngredients(IEnumerable<ItemStack> stacks)
        {
            return stacks
                .GroupBy(stack => stack.Type)
                .Select(group => new ItemStack(group.Key, group.Sum(stack => stack.Count)))
                .OrderBy(stack => stack.Type.Name);
        }

        private IEnumerable<ItemType> MergeEquipment(IEnumerable<ItemType> items)
        {
            return items.Distinct();
        }

        private IRecipe GetRecipe(ItemStack stack)
        {
            var recipe = _book.Recipes
                .FirstOrDefault(rec => rec.Result.Type == stack.Type);

            if (recipe == null) return stack;

            var scale = stack.Count / recipe.Result.Count;
            var ingredients = recipe.Ingredients.Select(stk => Scale(stk, scale));
            return new Recipe(stack.Result, ingredients, recipe.Equipment);
        }

        private ItemStack Scale(ItemStack @this, decimal scale) =>
              new ItemStack(@this.Type, scale * @this.Count);
    }
}
