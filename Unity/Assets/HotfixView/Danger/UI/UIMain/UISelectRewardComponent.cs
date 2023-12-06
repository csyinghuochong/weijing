using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UISelectRewardComponent: Entity, IAwake
    {
        public GameObject TitleText;
        public GameObject ItemListNode;
        public GameObject RewardItem;
        public GameObject Btn_Close;

        public int Key;
        public int Type; // 0等级领取 1击败领取
    }

    public class UISelectRewardAwakeSystem: AwakeSystem<UISelectRewardComponent>
    {
        public override void Awake(UISelectRewardComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.TitleText = rc.Get<GameObject>("TitleText");
            self.ItemListNode = rc.Get<GameObject>("ItemListNode");
            self.RewardItem = rc.Get<GameObject>("RewardItem");
            self.Btn_Close = rc.Get<GameObject>("Btn_Close");

            self.RewardItem.SetActive(false);
            self.Btn_Close.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove(self.ZoneScene(), UIType.UISelectReward); });
        }
    }

    public static class UISelectRewardComponentSystem
    {
        public static void UpdateInfo(this UISelectRewardComponent self, int key, int type)
        {
            self.Key = key;
            self.Type = type;

            string[] occItems;
            switch (type)
            {
                case 0:
                    self.TitleText.GetComponent<Text>().text = "等级领取";
                    occItems = ConfigHelper.LeavlRewardItem[key].Split('&');
                    break;
                case 1:
                    self.TitleText.GetComponent<Text>().text = "击败怪物领取";
                    occItems = ConfigHelper.KillMonsterReward[key].Split('&');
                    break;
                default:
                    return;
            }

            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
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

        public static async ETTask OnGetBtn(this UISelectRewardComponent self, int index)
        {
            switch (self.Type)
            {
                case 0:
                {
                    C2M_LeavlRewardRequest request = new C2M_LeavlRewardRequest() { LvKey = self.Key, Index = index };
                    M2C_LeavlRewardResponse response =
                            await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request) as M2C_LeavlRewardResponse;
                    UIHelper.GetUI(self.ZoneScene(), UIType.UIMain).GetComponent<UIMainComponent>().UpdateLvReward();
                    break;
                }
                case 1:
                {
                    C2M_KillMonsterRewardRequest request = new C2M_KillMonsterRewardRequest() { Key = self.Key, Index = index };
                    M2C_KillMonsterRewardResponse response =
                            await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request) as M2C_KillMonsterRewardResponse;
                    UIHelper.GetUI(self.ZoneScene(), UIType.UIMain).GetComponent<UIMainComponent>().UpdateKillMonsterReward();
                    break;
                }
            }

            UIHelper.Remove(self.ZoneScene(), UIType.UISelectReward);
        }
    }
}