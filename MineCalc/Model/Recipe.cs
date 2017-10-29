using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using MoreLinq;

namespace MineCalc.Model
{
    public class Recipe : IRecipe, IEquatable<Recipe>
    {
        public Recipe(
            BlockStack result, 
            IEnumerable<BlockStack> requirements)
        {
            Result = result;
            Requirements = requirements.ToImmutableList();
        }

        public BlockStack Result { get; }

        public ImmutableList<BlockStack> Requirements { get; }

        public override string ToString() =>
            $"{Result} ({Requirements.ToDelimitedString(", ")})";

        #region Equality
        public bool Equals(Recipe other) =>
            !Equals(other, null)
            && Result.Equals(other.Result)
            && Requirements.IsEqualSet(other.Requirements);

        public override bool Equals(object obj) =>
            Equals(obj as Recipe);

        public override int GetHashCode() =>
            Result.GetHashCode();

        public static bool operator ==(Recipe a, Recipe b) =>
            Equals(a, null)
                ? Equals(b, null)
                : a.Equals(b);

        public static bool operator !=(Recipe a, Recipe b) =>
            !(a == b);

        #endregion
    }
}
