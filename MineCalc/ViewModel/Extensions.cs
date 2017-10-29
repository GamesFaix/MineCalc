using MineCalc.Model;
using System.Linq;
using MoreLinq;

namespace MineCalc.ViewModel
{
    static class Extensions
    {
        public static BlockStackViewModel ToViewModel(this BlockStack stack)
        {
            return new BlockStackViewModel
            {
                BlockType = stack.Type.Name,
                Count = stack.Count
            };
        }

        public static RecipeViewModel ToViewModel(this Recipe recipe)
        {
            return new RecipeViewModel
            {
                Result = recipe.Result.ToString(),
                Requirements = recipe.Requirements
                    .Select(req => req.ToString())
                    .ToDelimitedString(", ")
            };
        }
    }
}
