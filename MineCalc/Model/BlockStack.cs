using System;
using System.Collections.Immutable;
using Newtonsoft.Json;

namespace MineCalc.Model
{
    public class BlockStack : IRecipe, IEquatable<BlockStack>
    {
        public BlockType Type { get; }

        public decimal Count { get; }

        public BlockStack(
            BlockType type, 
            decimal count)
        {
            Type = type;
            Count = count;
        }

        [JsonIgnore]
        public BlockStack Result => this;

        [JsonIgnore]
        public ImmutableList<BlockStack> Requirements =>
            ImmutableList.Create(this);

        public override string ToString() => $"{Type} x{Count}";

        #region Equality
        public bool Equals(BlockStack other) =>
            !Equals(other, null)
            && Type.Equals(other.Type)
            && Count == other.Count;

        public override bool Equals(object obj) =>
            Equals(obj as BlockStack);

        public override int GetHashCode() =>
            Type.GetHashCode() ^ Count.GetHashCode();

        public static bool operator == (BlockStack a, BlockStack b) =>
            Equals(a, null)
                ? Equals(b, null)
                : a.Equals(b);

        public static bool operator != (BlockStack a, BlockStack b) =>
            !(a == b);

        #endregion
    }
}
