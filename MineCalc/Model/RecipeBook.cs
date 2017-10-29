using System.Collections.Generic;
using System.Collections.Immutable;

namespace MineCalc.Model
{
    class RecipeBook
    {
        public ImmutableList<BlockType> BlockTypes { get; }

        public ImmutableList<Recipe> Recipes { get; }

        public RecipeBook(
            IEnumerable<BlockType> blockTypes, 
            IEnumerable<Recipe> recipes)
        {
            BlockTypes = blockTypes.ToImmutableList();
            Recipes = recipes.ToImmutableList();
        }
    }
}
