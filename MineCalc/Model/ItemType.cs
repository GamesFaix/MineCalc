using System;

namespace MineCalc.Model
{
    public class ItemType : IEquatable<ItemType>
    {
        public string Name { get; }

        public ItemType(
            string name)
        {
            Name = name;
        }

        public override string ToString() => Name;

        #region Equality
        public bool Equals(ItemType other) =>
            !Equals(other, null)
            && Equals(Name, other.Name);

        public override bool Equals(object obj) => 
            Equals(obj as ItemType);

        public override int GetHashCode() => 
            Name.GetHashCode();

        public static bool operator == (ItemType a, ItemType b) => 
            Equals(a, null) 
                ? Equals(b, null)
                : a.Equals(b);

        public static bool operator !=(ItemType a, ItemType b) => 
            !(a == b);

        #endregion
    }
}
