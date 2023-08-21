using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIRankUnionItemComponent: Entity, IAwake<GameObject>
    {
        public GameObject NameText;
        public GameObject NumText;
    }

    public class UIRankUnionItemComponentAwakeSystem: AwakeSystem<UIRankUnionItemComponent, GameObject>
    {
        public override void Awake(UIRankUnionItemComponent self, GameObject gameObject)
        {
            self.Awake(gameObject);
        }
    }

    public static class UIRankUnionItemComponentSystem
    {
        public static void Awake(this UIRankUnionItemComponent self, GameObject gameObject)
        {
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.NameText = rc.Get<GameObject>("NameText");
            self.NumText = rc.Get<GameObject>("NumText");
        }

        public static void OnUpdate(this UIRankUnionItemComponent self, RankShouLieInfo rankShouLieInfo, int index)
        {
            self.NameText.GetComponent<Text>().text = $"   {index}    {rankShouLieInfo.PlayerName}";
            self.NumText.GetComponent<Text>().text = $"{rankShouLieInfo.KillNumber}";
        }
    }
}