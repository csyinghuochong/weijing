using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UILeavlRewardComponent: Entity, IAwake
    {
        public GameObject ItemListNode;
        public GameObject RewardItem;
        public GameObject Btn_Close;

        public int LvKey;
    }

    public class UILeavlRewardComponentAwakeSystem: AwakeSystem<UILeavlRewardComponent>
    {
        public override void Awake(UILeavlRewardComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ItemListNode = rc.Get<GameObject>("ItemListNode");
            self.RewardItem = rc.Get<GameObject>("RewardItem");
            self.Btn_Close = rc.Get<GameObject>("Btn_Close");

            self.RewardItem.SetActive(false);
            self.Btn_Close.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove(self.ZoneScene(), UIType.UILeavlReward); });
        }
    }

    public static class UILeavlRewardComponentSystem
    {
        public static void UpdateInfo(this UILeavlRewardComponent self, int lvKey)
        {
            self.LvKey = lvKey;

            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            string[] occItems = ConfigHelper.LeavlRewardItem[lvKey].Split('&');
            string[] items;
            if (occItems.Length == 3)
            {
                items = occItems[userInfoComponent.UserInfo.Occ - 1].Split('@');
            }
            else
            {
                items = occItems[0].Split('@');
            }

            for (int i = 0; i < items.Length; i++)
            {
                string[] item = items[i].Split(';');

                GameObject go = UnityEngine.Object.Instantiate(self.RewardItem);
                UIItemComponent uI = null;
                uI = self.AddChild<UIItemComponent, GameObject>(go.GetComponent<ReferenceCollector>().Get<GameObject>("UICommonItem"));
                uI.UpdateItem(new BagInfo() { ItemID = int.Parse(item[0]), ItemNum = int.Parse(item[1]) }, ItemOperateEnum.None);
                int i1 = i;
                go.GetComponent<ReferenceCollector>().Get<GameObject>("GetBtn").GetComponent<Button>().onClick
                        .AddListener(() => { self.OnGetBtn(i1).Coroutine(); });
                UICommonHelper.SetParent(go, self.ItemListNode);
                go.SetActive(true);
            }
        }

        public static async ETTask OnGetBtn(this UILeavlRewardComponent self, int index)
        {
            C2M_LeavlRewardRequest request = new C2M_LeavlRewardRequest() { LvKey = self.LvKey, Index = index };
            M2C_LeavlRewardResponse response =
                    await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request) as M2C_LeavlRewardResponse;
            UIHelper.GetUI(self.ZoneScene(), UIType.UIMain).GetComponent<UIMainComponent>().UpdateLvReward();
            UIHelper.Remove(self.ZoneScene(), UIType.UILeavlReward);
        }
    }
}