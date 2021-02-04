using UnityEngine;

namespace HassakuLab.CircuitTD.Ingames.Presentations
{
    /// <summary>
    /// バックグラウンド描画
    /// </summary>
    [RequireComponent(typeof(MeshRenderer))]
    public class BackgroundRenderer : MonoBehaviour
    {
        private MeshRenderer meshRenderer;

        private void Awake()
        {
            meshRenderer = GetComponent<MeshRenderer>();
            meshRenderer.material.SetVector("GridSize", transform.localScale);
        }
    }
}
