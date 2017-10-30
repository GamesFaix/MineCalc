using System;
using System.Collections.Immutable;
using Newtonsoft.Json;

namespace MineCalc.Model
{
    public class ItemStack : IRecipe, IEquatable<ItemStack>
    {
        public ItemType Type { get; }

        public decimal Count { get; }

        public ItemStack(
            ItemType type, 
            decimal count)
        {
            Type = type;
            Count = count;
        }

        [JsonIgnore]
        public ItemStack Result => this;

        [JsonIgnore]
        public ImmutableList<ItemStack> Ingredients =>
            ImmutableList.Create(this);

        [JsonIgnore]
        public ImmutableList<ItemType> Equipment =>
            ImmutableList.Create<ItemType>();

        public override string ToString() => $"{Type} x{Count:n2}";

        #region Equality
        public bool Equals(ItemStack other) =>
            !Equals(other, null)
            && Type.Equals(other.Type)
            && Count == other.Count;

        public override bool Equals(object obj) =>
            Equals(obj as ItemStack);

        public override int GetHashCode() =>
            Type.GetHashCode() ^ Count.GetHashCode();

        public static bool operator == (ItemStack a, ItemStack b) =>
            Equals(a, null)
                ? Equals(b, null)
                : a.Equals(b);

        public static bool operator != (ItemStack a, ItemStack b) =>
            !(a == b);

        #endregion
    }
}
