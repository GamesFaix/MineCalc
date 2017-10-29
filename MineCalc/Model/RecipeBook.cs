using System.Collections.Generic;
using System.Collections.Immutable;

namespace MineCalc.Model
{
    class RecipeBook
    {
        public ImmutableList<ItemType> Items { get; }

        public ImmutableList<Recipe> Recipes { get; }

        public RecipeBook(
            IEnumerable<ItemType> items, 
            IEnumerable<Recipe> recipes)
        {
            Items = items.ToImmutableList();
            Recipes = recipes.ToImmutableList();
        }
    }
}
