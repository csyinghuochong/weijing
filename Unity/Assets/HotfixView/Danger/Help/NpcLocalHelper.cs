using UnityEngine;

namespace ET
{
    public static class NpcLocalHelper
    {
        public static void OnMainHero(Transform topTf, Transform mainTf, int sceneTypeEnum)
        {
            Camera camera = UIComponent.Instance.MainCamera;
            camera.GetComponent<MyCamera_1>().enabled = sceneTypeEnum == SceneTypeEnum.MainCityScene;
            camera.GetComponent<MyCamera_1>().Target = topTf;

            GameObject shiBingSet = GameObject.Find("ShiBingSet");
            if (shiBingSet != null)
            {
                string path_2 = ABPathHelper.GetUGUIPath($"Battle/UINpcLocal");
                GameObject npc_go = ResourcesComponent.Instance.LoadAsset<GameObject>(path_2);
                for (int i = 0; i < shiBingSet.transform.childCount; i++)
                {
                    GameObject shiBingItem = shiBingSet.transform.GetChild(i).gameObject;
                    NpcLocal npcLocal = shiBingItem.GetComponent<NpcLocal>();
                    if (npcLocal == null)
                    {
                        continue;
                    }
                    NpcConfig npcConfig = NpcConfigCategory.Instance.Get(npcLocal.NpcId);
                    npcLocal.Target = mainTf;
                    npcLocal.NpcName = npcConfig.Name;
                    npcLocal.NpcSpeak = npcConfig.SpeakText;
                    npcLocal.AssetBundle = npc_go;
                }
            }
        }


    }
}
