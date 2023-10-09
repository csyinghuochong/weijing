using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace ET
{

    public class UIUnionJingXuanComponent : Entity, IAwake
    {

        public GameObject ButtonList;
        public GameObject AlreadyJingXuan;
        public GameObject ButtonConfirm;
        public GameObject ButtonCancel;
        public GameObject ImageButton;
        public GameObject ItemNodeList;
        public GameObject JingXuanItem;

        public List<UIUnionJingXuanItemComponent> JingXuanItemList = new List<UIUnionJingXuanItemComponent> ();

        public UnionInfo UnionInfo;
    }

    public class UIUnionJingXuanComponentAwake : AwakeSystem<UIUnionJingXuanComponent>
    {
        public override void Awake(UIUnionJingXuanComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.JingXuanItemList.Clear();
            self.ImageButton = rc.Get<GameObject>("ImageButton");
            self.ImageButton.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove( self.ZoneScene(), UIType.UIUnionJingXuan );  });

            self.ButtonConfirm = rc.Get<GameObject>("ButtonConfirm");
            self.ButtonCancel = rc.Get<GameObject>("ButtonCancel");

            self.ButtonList = rc.Get<GameObject>("ButtonList");
            self.AlreadyJingXuan = rc.Get<GameObject>("AlreadyJingXuan");

            ButtonHelp.AddListenerEx(self.ButtonConfirm, () => { self.OnButtonConfirm(1).Coroutine();  }); 
            ButtonHelp.AddListenerEx(self.ButtonCancel, self.OnButtonCancel);

            self.JingXuanItem = rc.Get<GameObject>("JingXuanItem");
            self.JingXuanItem.SetActive(false);

            self.ItemNodeList = rc.Get<GameObject>("ItemNodeList");
        }
    }

    public static class UIUnionJingXuanComponentSystem
    {

        public static void OnButtonCancel(this UIUnionJingXuanComponent self)
        {
            PopupTipHelp.OpenPopupTip( self.ZoneScene(), "取消申请", "是否确认取消申请族长?", ()=>
            {
                self.OnButtonConfirm(0).Coroutine();

            }, null).Coroutine();
        }

        public static async ETTask OnButtonConfirm(this UIUnionJingXuanComponent self, int operateType)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            C2U_UnionJingXuanRequest request = new C2U_UnionJingXuanRequest()
            {
                UnitId = unit.Id,   
                UnionId = unit.GetComponent<NumericComponent>().GetAsLong(NumericType.UnionId_0),
                OperateType = operateType,
            };

            long instanceid = self.InstanceId;
            U2C_UnionJingXuanResponse response = await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request) as U2C_UnionJingXuanResponse;
            if(instanceid != self.InstanceId)
            {
                return;    
            }
           
            self.UnionInfo.JingXuanList = response.JingXuanList;
            self.UnionInfo.JingXuanEndTime = response.JingXuanEndTime;
            self.OnUpdateUI(self.UnionInfo);

            if (response.JingXuanList.Count == 0)
            {
                UIHelper.Remove(self.ZoneScene(), UIType.UIUnionJingXuan);
                return;
            }
        }

        public static UnionPlayerInfo GetUnionPlayerInfo(this UIUnionJingXuanComponent self, long playerid)
        {
            for (int i = 0; i < self.UnionInfo.UnionPlayerList.Count; i++)
            {
                if (self.UnionInfo.UnionPlayerList[i].UserID == playerid)
                {
                    return self.UnionInfo.UnionPlayerList[i];
                }
            }
            return null;
        }

        public static  void  OnUpdateUI(this UIUnionJingXuanComponent self, UnionInfo  unionInfo)
        {
            self.UnionInfo = unionInfo;

            int number = 0;
            for (int i = 0; i < unionInfo.JingXuanList.Count; i++)
            {
                UnionPlayerInfo unionPlayerInfo = self.GetUnionPlayerInfo(unionInfo.JingXuanList[i]);
                if (unionPlayerInfo == null)
                {
                    continue;
                }

                UIUnionJingXuanItemComponent ui_1 = null;
                if (number < self.JingXuanItemList.Count)
                {
                    ui_1 = self.JingXuanItemList[number];
                    ui_1.GameObject.SetActive(true);
                }
                else
                {
                    GameObject storeItem = GameObject.Instantiate(self.JingXuanItem);
                    UICommonHelper.SetParent(storeItem, self.ItemNodeList);
                    storeItem.SetActive(true);
                    ui_1 = self.AddChild<UIUnionJingXuanItemComponent, GameObject>(storeItem);
                    self.JingXuanItemList.Add(ui_1);
                }
                ui_1.OnUpdateUI(i, unionPlayerInfo);
                number++;
            }

            for (int i = number; i < self.JingXuanItemList.Count; i++)
            {
                self.JingXuanItemList[i].GameObject.SetActive(false);
            }

            Unit unit = UnitHelper.GetMyUnitFromZoneScene( self.ZoneScene() );
            bool haveself = unionInfo.JingXuanList.Contains( unit.Id );
            self.ButtonConfirm.SetActive(!haveself);
            self.AlreadyJingXuan.SetActive(haveself);
        }
    }
}