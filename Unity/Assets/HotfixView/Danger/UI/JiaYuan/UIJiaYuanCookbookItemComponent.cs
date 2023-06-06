using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Experimental.AI;
using UnityEngine.UI;

namespace ET
{
    public class UIJiaYuanCookbookItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject MakeItem;
        public GameObject MakeItemList;
        public GameObject GameObject;
        public UIItemComponent UICommonItem;

        public List<UIItemComponent> NeedItemList = new List<UIItemComponent>();
        public int MakeItemId = 0;  
    }

    public class UIJiaYuanCookbookItemComponentAwake : AwakeSystem<UIJiaYuanCookbookItemComponent,GameObject>
    {
        public override void Awake(UIJiaYuanCookbookItemComponent self, GameObject gameObject)
        {
            self.NeedItemList.Clear();
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.MakeItem = rc.Get<GameObject>("MakeItem");
            self.MakeItem.SetActive(false);
            self.MakeItemList = rc.Get<GameObject>("MakeItemList");

            GameObject uICommonItem = rc.Get<GameObject>("UICommonItem");
            self.UICommonItem = self.AddChild<UIItemComponent,GameObject>(uICommonItem);
        }
    }

    public static class UIJiaYuanCookbookItemComponentSystem
    {

        public static void OnImage_Lock(this UIJiaYuanCookbookItemComponent self)
        {
            if (self.MakeItemId == 0)
            {
                return;
            }
            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            ItemConfig itemCof = ItemConfigCategory.Instance.Get(self.MakeItemId);
            long needcost = JiaYuanHelper.GetCookBookCost(itemCof.UseLv);

            JiaYuanComponent jiaYuanComponent = self.ZoneScene().GetComponent<JiaYuanComponent>();
            if (jiaYuanComponent.LearnMakeIds_7.Contains(self.MakeItemId))
            {
                FloatTipManager.Instance.ShowFloatTip("已经学习过该食谱！");
                return;
            }
            if (userInfoComponent.UserInfo.JiaYuanFund < needcost)
            {
                FloatTipManager.Instance.ShowFloatTip("家园资金不足！");
                return;
            }

            PopupTipHelp.OpenPopupTip( self.ZoneScene(), "学习食谱", $"是否消耗{needcost}家园资金学习该食谱?" , ()=>
            {
                self.RequestLearn(self.MakeItemId).Coroutine();
            }, null).Coroutine();
        }

        public static async ETTask RequestLearn(this UIJiaYuanCookbookItemComponent self, int itemid)
        {
            C2M_JiaYuanCookBookOpen request     = new C2M_JiaYuanCookBookOpen() { LearnMakeId = itemid };
            M2C_JiaYuanCookBookOpen response    = (M2C_JiaYuanCookBookOpen)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (response.Error != ErrorCore.ERR_Success || self.IsDisposed)
            {
                return;
            }
            JiaYuanComponent jiaYuanComponent = self.ZoneScene().GetComponent<JiaYuanComponent>();
            jiaYuanComponent.LearnMakeIds_7 = response.LearnMakeIds;
            self.OnUpdateUI(self.MakeItemId, true);
        }

        public static void OnUpdateUI(this UIJiaYuanCookbookItemComponent self, int itmeid, bool active)
        {
            self.MakeItemId = itmeid;
            self.UICommonItem.UpdateItem(new BagInfo() { ItemID = itmeid, ItemNum = 1 }, ItemOperateEnum.None);
            self.UICommonItem.Label_ItemNum.SetActive(false);
            UICommonHelper.SetImageGray(self.UICommonItem.Image_Lock, !active);
            int makeid = EquipMakeConfigCategory.Instance.GetMakeId(itmeid);
          
            EquipMakeConfig equipMakeConfig = EquipMakeConfigCategory.Instance.Get(makeid);
            string[] iteminfos = equipMakeConfig.NeedItems.Split('@');

            for (int i = 0; i < iteminfos.Length; i++)
            {
                UIItemComponent uIItemComponent = null;
                int needitmeid = int.Parse(iteminfos[i].Split(';')[0]);
                if (i < self.NeedItemList.Count)
                {
                    uIItemComponent = self.NeedItemList[i];
                    uIItemComponent.GameObject.SetActive(true);
                }
                else
                {
                    GameObject go = GameObject.Instantiate(self.MakeItem);
                    UICommonHelper.SetParent(go, self.MakeItemList);
                    uIItemComponent = self.AddChild<UIItemComponent, GameObject>(go);
                    uIItemComponent.Image_Lock.GetComponent<Button>().onClick.AddListener( self.OnImage_Lock);
                    self.NeedItemList.Add(uIItemComponent);
                    go.SetActive(true);
                }
                BagInfo bagInfo = active ? new BagInfo() {ItemID = needitmeid, ItemNum = 1 } : null;    
                uIItemComponent.UpdateItem(bagInfo, ItemOperateEnum.None);
                uIItemComponent.Image_ItemQuality.SetActive(true);
                if (active)
                {
                    uIItemComponent.Image_Lock.SetActive(false);
                }
                else
                {
                    uIItemComponent.Image_Lock.SetActive(true);
                }
            }
        }
    }
}
