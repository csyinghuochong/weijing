using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIWatchEquipComponent : Entity, IAwake
    {
        public GameObject EquipSet1;
        public GameObject EquipSet2;

        public UIEquipSetComponent UIEquipSetComponent1;
        public UIEquipSetComponent UIEquipSetComponent2;
    }


    public class UIWatchEquipComponentAwake : AwakeSystem<UIWatchEquipComponent>
    {
        public override void Awake(UIWatchEquipComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.EquipSet1 = rc.Get<GameObject>("EquipSet1");
            self.EquipSet2 = rc.Get<GameObject>("EquipSet2");

            self.UIEquipSetComponent1 = self.AddChild<UIEquipSetComponent, GameObject, int>(self.EquipSet1, 0);
            self.UIEquipSetComponent1.Position = 4;

            self.UIEquipSetComponent2 = self.AddChild<UIEquipSetComponent, GameObject, int>(self.EquipSet2, 1);
            self.UIEquipSetComponent1.Position = 5;

            self.OnInitUI();
        }
    }

    public static class UIWatchEquipComponentSystem
    {
        public static void OnInitUI(this UIWatchEquipComponent self)
        {
            UI uI = UIHelper.GetUI(self.ZoneScene(), UIType.UIWatch);
            F2C_WatchPlayerResponse m2C_WatchPlayerResponse = uI.GetComponent<UIWatchComponent>().F2C_WatchPlayerResponse;
            self.UIEquipSetComponent1.PlayerLv(m2C_WatchPlayerResponse.Lv);
            self.UIEquipSetComponent1.PlayerName(m2C_WatchPlayerResponse.Name);
            self.UIEquipSetComponent1.UpdateBagUI(m2C_WatchPlayerResponse.EquipList, m2C_WatchPlayerResponse.Occ, ItemOperateEnum.Watch);

            BagInfo bagInfo = ItemHelper.GetEquipByWeizhi(m2C_WatchPlayerResponse.EquipList, (int)ItemSubTypeEnum.Wuqi);
            self.UIEquipSetComponent1.ShowPlayerModel(bagInfo, m2C_WatchPlayerResponse.Occ);

            int selfOcc = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Occ;
            self.UIEquipSetComponent2.PlayerLv(self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Lv);
            self.UIEquipSetComponent2.PlayerName(self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Name);
            self.UIEquipSetComponent2.UpdateBagUI(self.ZoneScene().GetComponent<BagComponent>().GetEquipList(), selfOcc, ItemOperateEnum.Watch);
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            BagInfo bagInfo2 = bagComponent.GetEquipBySubType((int)ItemSubTypeEnum.Wuqi);
            self.UIEquipSetComponent2.ShowPlayerModel(bagInfo2, selfOcc);
        }
    }
}
