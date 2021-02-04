using System;
using UnityEngine;

namespace HassakuLab.CircuitTD.Ingames
{
    /// <summary>
    /// Int型座標
    /// </summary>
    [Serializable]
    public struct Position
    {
        [SerializeField] private int x;
        [SerializeField] private int y;

        /// <summary>
        /// x座標
        /// </summary>
        public int X => x;

        /// <summary>
        /// y座標
        /// </summary>
        public int Y => y;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="x">x座標</param>
        /// <param name="y">y座標</param>
        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override bool Equals(object obj)
        {
            return obj is Position p &&
                   this == p;
        }

        public static bool operator ==(Position left, Position right)
        {
            return left.X == right.X && left.Y == right.Y;
        }

        public static bool operator !=(Position left, Position right)
        {
            return !(left == right);
        }

        public override string ToString()
        {
            return string.Format("({0}, {1})", X, Y);
        }

        public override int GetHashCode()
        {
            return (X, Y).GetHashCode();
        }
    }
}
