using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIHuntRankingPlayerInfoItemComponent: Entity, IAwake<GameObject>
    {
        public GameObject NameText;
        public GameObject HuntNumText;
    }

    public class UIHuntRankingItemComponentAwakeSystem: AwakeSystem<UIHuntRankingPlayerInfoItemComponent, GameObject>
    {
        public override void Awake(UIHuntRankingPlayerInfoItemComponent self, GameObject gameObject)
        {
            self.Awake(gameObject);
        }
    }

    public static class UIHuntRankingPlayerInfoItemComponentSystem
    {
        public static void Awake(this UIHuntRankingPlayerInfoItemComponent self, GameObject gameObject)
        {
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.NameText = rc.Get<GameObject>("NameText");
            self.HuntNumText = rc.Get<GameObject>("HuntNumText");
        }

        public static void OnUpdate(this UIHuntRankingPlayerInfoItemComponent self, RankShouLieInfo rankShouLieInfo, int index)
        {
            self.NameText.GetComponent<Text>().text = $"   {index}    {rankShouLieInfo.PlayerName}";
            self.HuntNumText.GetComponent<Text>().text = $"狩猎数量:{rankShouLieInfo.KillNumber}";
        }
    }
}