using UnityEngine.UI;

namespace ET
{
    public class UIRaycast : MaskableGraphic
    {
        protected UIRaycast()
        {
            useLegacyMeshGeneration = false;
        }

        protected override void OnPopulateMesh(VertexHelper vh)
        {
            vh.Clear();
        }
    }
}