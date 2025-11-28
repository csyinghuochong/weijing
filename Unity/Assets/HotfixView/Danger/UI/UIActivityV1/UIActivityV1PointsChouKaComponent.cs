using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIActivityV1PointsChouKaComponent : Entity, IAwake
    {
        public Text TextTip;
        public Button OpenBtn;
        public GameObject RewardItemListNode;
        public GameObject UICommonItem;
        public List<UIItemComponent> UIItemList = new List<UIItemComponent>();

    }

    public class UIActivityV1PointsChouKaComponentAwake : AwakeSystem<UIActivityV1PointsChouKaComponent>
    {
        public override void Awake(UIActivityV1PointsChouKaComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.UICommonItem = rc.Get<GameObject>("UICommonItem");
            self.UICommonItem.SetActive(false);

            self.TextTip = rc.Get<GameObject>("TextTip").GetComponent<Text>();
            self.OpenBtn = rc.Get<GameObject>("OpenBtn").GetComponent<Button>();
            ButtonHelp.AddListenerEx(self.OpenBtn.gameObject, () => { self.OnButton_TimerChouKa().Coroutine(); });

            self.RewardItemListNode = rc.Get<GameObject>("RewardItemListNode");

            self.ShowRewardList();
            self.ShowLeftPoints();
            self.OnUpdateUI();
        }
    }

    public static class UIActivityV1PointsChouKaComponentSystem
    {
        public static void ShowRewardList(this UIActivityV1PointsChouKaComponent self)
        {
            foreach(var choukaitem in ActivityConfigHelper.PointsChouKaList)
            {
                string itemvalue = choukaitem.ItemInfo;
                string[] iteminfo = itemvalue.Split(';');
                int ItemID = int.Parse(iteminfo[0]);
                int ItemNum = int.Parse(iteminfo[1]);

                GameObject itemSpace = GameObject.Instantiate(self.UICommonItem);
                itemSpace.SetActive(true);
                UICommonHelper.SetParent(itemSpace, self.RewardItemListNode);
                UIItemComponent uIItemComponent = self.AddChild<UIItemComponent, GameObject>(itemSpace);
                uIItemComponent.UpdateItem(new BagInfo() { ItemID = ItemID, ItemNum = ItemNum }, ItemOperateEnum.None);
                uIItemComponent.Label_ItemName.SetActive(false);
                uIItemComponent.Label_ItemNum.SetActive(false);
                uIItemComponent.Image_Binding.SetActive(true);
                itemSpace.transform.Find("Image_Recvived").gameObject.SetActive(false);
                itemSpace.transform.localScale = Vector3.one * 1f;

                self.UIItemList.Add(uIItemComponent);
            }
        }

        public static void OnUpdateUI(this UIActivityV1PointsChouKaComponent self)
        {

        }

        public static void ShowLeftPoints(this UIActivityV1PointsChouKaComponent self)
        {
            self.TextTip.GetComponent<Text>().text =
                 string.Format(GameSettingLanguge.LoadLocalization("{0}"), UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene()).GetComponent<NumericComponent>().GetAsLong(NumericType.V1TotalPoints));
        }

        public static async ETTask OnButton_TimerChouKa(this UIActivityV1PointsChouKaComponent self)
        {
            await ETTask.CompletedTask;
        }

    }
}