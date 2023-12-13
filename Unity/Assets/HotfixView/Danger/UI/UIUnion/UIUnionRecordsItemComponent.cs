using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIUnionRecordsItemComponent: Entity, IAwake<GameObject>
    {
        public GameObject GameObject;
        public GameObject TextContent;
    }

    public class UIUnionRecordsItemComponentAwake: AwakeSystem<UIUnionRecordsItemComponent, GameObject>
    {
        public override void Awake(UIUnionRecordsItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.TextContent = rc.Get<GameObject>("TextContent");
        }
    }

    public static class UIUnionRecordsItemComponentSystem
    {
        public static void UpdateInfo(this UIUnionRecordsItemComponent self, string record)
        {
            string[] strs = record.Split('_');
            self.TextContent.GetComponent<Text>().text =
                    $"<color=#{ComHelp.QualityReturnColor(4)}>{strs[0]}</color> " +
                    $"通过{ItemHelper.ItemGetWayNameList[int.Parse(strs[1])]} " +
                    $"增加了<color=#{ComHelp.QualityReturnColor(2)}>{strs[3]}</color>{ItemConfigCategory.Instance.Get(int.Parse(strs[2])).ItemName}";
        }
    }
}