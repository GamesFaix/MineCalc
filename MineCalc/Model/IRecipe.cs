using System.Collections.Immutable;

namespace MineCalc.Model
{
    public interface IRecipe
    {
        BlockStack Result { get; }

        ImmutableList<BlockStack> Requirements { get; }
    }
}
