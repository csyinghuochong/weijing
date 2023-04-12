using System;
using UnityEngine;

namespace ET
{
    public class UIRoleXiLianTenItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject GameObject;
        public GameObject ButtonSelect;
        public GameObject Obj_EquipPropertyText;
        public GameObject EquipBaseSetList;
        
        public ItemXiLianResult ItemXiLianResult;
        public BagInfo BagInfo;
    }


    public class UIRoleXiLianTenItemComponentAwakeSystem : AwakeSystem<UIRoleXiLianTenItemComponent, GameObject>
    {
        public override void Awake(UIRoleXiLianTenItemComponent self, GameObject a)
        {
            self.GameObject = a;
            ReferenceCollector rc = a.GetComponent<ReferenceCollector>();

            self.ButtonSelect = rc.Get<GameObject>("ButtonSelect");
            ButtonHelp.AddListenerEx(self.ButtonSelect, () => { self.OnButtonSelect().Coroutine(); });

            self.Obj_EquipPropertyText = rc.Get<GameObject>("Obj_EquipPropertyText");
            self.Obj_EquipPropertyText.SetActive(false);
            self.EquipBaseSetList = rc.Get<GameObject>("EquipBaseSetList");
        }
    }

    public static class UIRoleXiLianTenItemComponentSystem
    {
        public static void OnInitUI(this UIRoleXiLianTenItemComponent self, BagInfo bagInfo, ItemXiLianResult index)
        { 
            self.BagInfo = bagInfo;
            self.ItemXiLianResult = index;
            ItemViewHelp.ShowBaseAttribute(bagInfo, self.Obj_EquipPropertyText, self.EquipBaseSetList);
        }

        public static async ETTask OnButtonSelect(this UIRoleXiLianTenItemComponent self)
        {
            C2M_ItemXiLianSelectRequest request = new C2M_ItemXiLianSelectRequest()
            {
                OperateBagID = self.BagInfo.BagInfoID,
                ItemXiLianResult = self.ItemXiLianResult
            };
            M2C_ItemXiLianSelectResponse response = (M2C_ItemXiLianSelectResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (response.Error != ErrorCore.ERR_Success)
            {
                return;
            }
            UI uI = UIHelper.GetUI(self.ZoneScene(), UIType.UIRoleXiLian);
            uI.GetComponent<UIRoleXiLianComponent>().OnXiLianReturn();
            UIHelper.Remove(self.ZoneScene(), UIType.UIRoleXiLianTen);
        }
    }
}
