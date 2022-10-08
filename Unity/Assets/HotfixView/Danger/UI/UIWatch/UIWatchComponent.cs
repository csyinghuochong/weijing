using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIWatchComponent : Entity, IAwake
    {
        public GameObject Img_Back;
        public GameObject EquipSet1;
        public GameObject EquipSet2;

        public UIEquipSetComponent UIEquipSetComponent1;
        public UIEquipSetComponent UIEquipSetComponent2;
    }

    [ObjectSystem]
    public class UIWatchComponentAwakeSystem : AwakeSystem<UIWatchComponent>
    {
        public override void Awake(UIWatchComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Img_Back = rc.Get<GameObject>("Img_Back");
            self.Img_Back.GetComponent<Button>().onClick.AddListener(() => { self.OnClickImageBg(); });
            rc.Get<GameObject>("Img_Return").GetComponent<Button>().onClick.AddListener(() => { self.OnClickImageBg(); });

            self.EquipSet1 = rc.Get<GameObject>("EquipSet1");
            self.EquipSet2 = rc.Get<GameObject>("EquipSet2");

            UI uiEquipset1 = self.AddChild<UI, string, GameObject>( "EquipSet1", self.EquipSet1);
            self.UIEquipSetComponent1 = uiEquipset1.AddComponent<UIEquipSetComponent,int>(0);

            UI uiEquipset2 = self.AddChild<UI, string, GameObject>( "EquipSet2", self.EquipSet2);
            self.UIEquipSetComponent2 = uiEquipset2.AddComponent<UIEquipSetComponent,int>(1);
        }

    }

    public static class UIWatchComponentSystem
    {
        public static void OnClickImageBg(this UIWatchComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UIWatch);
        }

        public static void OnUpdateUI(this UIWatchComponent self, F2C_WatchPlayerResponse m2C_WatchPlayerResponse)
        {
            self.UIEquipSetComponent1.PlayerLv(m2C_WatchPlayerResponse.Lv);
            self.UIEquipSetComponent1.PlayerName(m2C_WatchPlayerResponse.Name);
            self.UIEquipSetComponent1.UpdateBagUI(m2C_WatchPlayerResponse.EquipList, m2C_WatchPlayerResponse.Occ, ItemOperateEnum.Watch);

            BagInfo bagInfo = ItemHelper.GetEquipByWeizhi(m2C_WatchPlayerResponse.EquipList, (int)ItemSubTypeEnum.Wuqi);
            self.UIEquipSetComponent1.ShowPlayerModel(bagInfo, m2C_WatchPlayerResponse.Occ).Coroutine();

            int selfOcc = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Occ;
            self.UIEquipSetComponent2.PlayerLv(self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Lv);
            self.UIEquipSetComponent2.PlayerName(self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Name);
            self.UIEquipSetComponent2.UpdateBagUI(self.ZoneScene().GetComponent<BagComponent>().GetEquipList(), selfOcc, ItemOperateEnum.Watch);
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            BagInfo bagInfo2 = bagComponent.GetEquipByWeizhi((int)ItemSubTypeEnum.Wuqi);
            self.UIEquipSetComponent2.ShowPlayerModel(bagInfo2, selfOcc).Coroutine();
        }
    }

}
