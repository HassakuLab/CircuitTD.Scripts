using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HassakuLab.CircuitTD.Ingames
{
    /// <summary>
    /// �z�u�\�ȗ̈�
    /// </summary>
    [CreateAssetMenu(fileName = "DeployableRect", menuName = "CircuitTD/DeployableRect")]
    public class DeployableRectangle : ScriptableObject
    {
        [SerializeField] private int left;
        [SerializeField] private int right;
        [SerializeField] private int top;
        [SerializeField] private int bottom;

        /// <summary>
        /// ���[�̍��W
        /// </summary>
        public int Left => left;

        /// <summary>
        /// �E�[�̍��W
        /// </summary>
        public int Right => right;

        /// <summary>
        /// ��[�̍��W
        /// </summary>
        public int Top => top;

        /// <summary>
        /// ���[�̍��W
        /// </summary>
        public int Bottom => bottom;

        /// <summary>
        /// �̈�̕����擾����
        /// </summary>
        public int Width => Right - Left + 1;

        /// <summary>
        /// �̈�̍������擾����
        /// </summary>
        public int Height => Top - Bottom + 1;
    }
}
