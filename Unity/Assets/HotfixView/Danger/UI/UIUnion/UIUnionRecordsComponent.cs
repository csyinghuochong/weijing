using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIUnionRecordsComponent: Entity, IAwake
    {
        public GameObject ButtonClose;
        public GameObject UIUnionRecordsItemListNode;
        public GameObject UIUnionRecordsItem;
    }

    public class UIUnionRecordsComponentAwakeSystem: AwakeSystem<UIUnionRecordsComponent>
    {
        public override void Awake(UIUnionRecordsComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ButtonClose = rc.Get<GameObject>("ButtonClose");
            self.UIUnionRecordsItemListNode = rc.Get<GameObject>("UIUnionRecordsItemListNode");
            self.UIUnionRecordsItem = rc.Get<GameObject>("UIUnionRecordsItem");

            self.UIUnionRecordsItem.SetActive(false);
            self.ButtonClose.GetComponent<Button>().onClick.AddListener(() => { self.OnButtonClose(); });
        }
    }

    public static class UIUnionRecordsComponentSystem
    {
        public static void UpdateInfo(this UIUnionRecordsComponent self, UnionInfo unionInfo)
        {
            foreach (string record in unionInfo.ActiveRecord)
            {
                GameObject go = UnityEngine.Object.Instantiate(self.UIUnionRecordsItem);
                UIUnionRecordsItemComponent component = self.AddChild<UIUnionRecordsItemComponent, GameObject>(go);
                component.UpdateInfo(record);
                UICommonHelper.SetParent(go, self.UIUnionRecordsItemListNode);
                go.SetActive(true);
            }
        }

        public static void OnButtonClose(this UIUnionRecordsComponent self)
        {
            UIHelper.Remove(self.ZoneScene(), UIType.UIUnionRecords);
        }
    }
}