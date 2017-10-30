using MineCalc.Model;
using System.Linq;
using MoreLinq;

namespace MineCalc.ViewModel
{
    static class ViewModelExtensions
    {
        public static ItemStackViewModel ToViewModel(this ItemStack stack)
        {
            return new ItemStackViewModel
            {
                Item = stack.Type.Name,
                Count = stack.Count.ToString("f2")
            };
        }

        public static RecipeViewModel ToViewModel(this Recipe recipe)
        {
            return new RecipeViewModel
            {
                Result = recipe.Result.ToString(),
                Ingredients = recipe.Ingredients
                    .Select(stack => stack.ToString())
                    .ToDelimitedString(", "),
                Equipment = recipe.Equipment
                    .Select(item => item.Name)
                    .ToDelimitedString(", ")
            };
        }
    }
}
