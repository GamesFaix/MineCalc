using System;

namespace MineCalc.Model
{
    public class BlockType : IEquatable<BlockType>
    {
        public string Name { get; }

        public BlockType(
            string name)
        {
            Name = name;
        }

        public override string ToString() => Name;

        #region Equality
        public bool Equals(BlockType other) =>
            !Equals(other, null)
            && Equals(Name, other.Name);

        public override bool Equals(object obj) => 
            Equals(obj as BlockType);

        public override int GetHashCode() => 
            Name.GetHashCode();

        public static bool operator == (BlockType a, BlockType b) => 
            Equals(a, null) 
                ? Equals(b, null)
                : a.Equals(b);

        public static bool operator !=(BlockType a, BlockType b) => 
            !(a == b);

        #endregion
    }
}
