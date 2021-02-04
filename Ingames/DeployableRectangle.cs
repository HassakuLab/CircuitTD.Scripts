using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HassakuLab.CircuitTD.Ingames
{
    /// <summary>
    /// 配置可能な領域
    /// </summary>
    [CreateAssetMenu(fileName = "DeployableRect", menuName = "CircuitTD/DeployableRect")]
    public class DeployableRectangle : ScriptableObject
    {
        [SerializeField] private int left;
        [SerializeField] private int right;
        [SerializeField] private int top;
        [SerializeField] private int bottom;

        /// <summary>
        /// 左端の座標
        /// </summary>
        public int Left => left;

        /// <summary>
        /// 右端の座標
        /// </summary>
        public int Right => right;

        /// <summary>
        /// 上端の座標
        /// </summary>
        public int Top => top;

        /// <summary>
        /// 下端の座標
        /// </summary>
        public int Bottom => bottom;

        /// <summary>
        /// 領域の幅を取得する
        /// </summary>
        public int Width => Right - Left + 1;

        /// <summary>
        /// 領域の高さを取得する
        /// </summary>
        public int Height => Top - Bottom + 1;
    }
}
