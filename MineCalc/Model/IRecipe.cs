using System.Collections.Immutable;

namespace MineCalc.Model
{
    public interface IRecipe
    {
        ItemStack Result { get; }

        ImmutableList<ItemStack> Ingredients { get; }
    }
}
