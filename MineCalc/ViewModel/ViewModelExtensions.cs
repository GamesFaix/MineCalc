using MineCalc.Model;
using System.Linq;
using MoreLinq;

namespace MineCalc.ViewModel
{
    static class ViewModelExtensions
    {
        public static BlockStackViewModel ToViewModel(this BlockStack stack)
        {
            return new BlockStackViewModel
            {
                BlockType = stack.Type.Name,
                Count = stack.Count.ToString("f2")
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
