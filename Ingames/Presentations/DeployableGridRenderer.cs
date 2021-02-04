using UnityEngine;

namespace HassakuLab.CircuitTD.Ingames.Presentations
{
    /// <summary>
    /// 配置可能な位置に表示するグリッド
    /// </summary>
    [RequireComponent(typeof(MeshRenderer))]
    public class DeployableGridRenderer : MonoBehaviour
    {
        [SerializeField] private DeployableRectangle rect;

        private MeshRenderer meshRenderer;

        private void SetPosition()
        {
            transform.position = new Vector3((rect.Right + rect.Left) / 2f, (rect.Top + rect.Bottom) / 2f, 0f);
        }

        private void SetObjectSize()
        {
            transform.localScale = new Vector3(rect.Width, rect.Height, 1f);
            meshRenderer.material.SetVector("GridSize", new Vector4(rect.Width, rect.Height, 0f, 0f));
        }

        private void Awake()
        {
            meshRenderer = GetComponent<MeshRenderer>();
            SetPosition();
            SetObjectSize();
        }
    }
}
