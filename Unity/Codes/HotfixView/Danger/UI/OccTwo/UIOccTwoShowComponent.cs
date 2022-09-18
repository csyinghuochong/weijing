using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UIOccTwoShowComponent : Entity, IAwake
    {
        public GameObject Btn_Close;
        public GameObject TextOccTwoName;
        public GameObject SkillListItem;
        public GameObject RawImage;

        public UIModelShowComponent uIModelShowComponent;
    }

    [ObjectSystem]
    public class UIOccTwoShowComponentAwakeSystem : AwakeSystem<UIOccTwoShowComponent>
    {
        public override void Awake(UIOccTwoShowComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            
            self.Btn_Close = rc.Get<GameObject>("Btn_Close");
            self.Btn_Close.GetComponent<Button>().onClick.AddListener(() =>
            {
                UIHelper.Remove( self.ZoneScene(), UIType.UIOccTwoShow ).Coroutine();
            });

            self.TextOccTwoName = rc.Get<GameObject>("TextOccTwoName");
            self.SkillListItem = rc.Get<GameObject>("SkillListItem");
            self.RawImage = rc.Get<GameObject>("RawImage");
            self.RawImage.SetActive(false);

            self.OnInitUI();
        }
    }

    public static class UIOccTwoShowComponentSystem
    {
        public static void OnInitUI(this UIOccTwoShowComponent self)
        {
            int occTwo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.OccTwo;

            self.InitModelShowView().Coroutine();
            self.ShowSkillList(occTwo).Coroutine();
        }

        public static async ETTask ShowSkillList(this UIOccTwoShowComponent self, int occTwo)
        {
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonSkillItem");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            OccupationTwoConfig twoConfig = OccupationTwoConfigCategory.Instance.Get(occTwo);
            UICommonHelper.ShowSkillItem(bundleGameObject, self.SkillListItem, self, twoConfig.SkillID, ABAtlasTypes.RoleSkillIcon );
        }

        public static async ETTask InitModelShowView(this UIOccTwoShowComponent self)
        {
            long instance = self.InstanceId;
            //模型展示界面
            var path = ABPathHelper.GetUGUIPath("Common/UIModelShow1");
            GameObject bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UICommonHelper.SetParent(gameObject, self.RawImage);

            OccupationTwoConfig twoCof = OccupationTwoConfigCategory.Instance.Get(self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.OccTwo);

            self.TextOccTwoName.GetComponent<Text>().text = twoCof.OccupationName;

            UI ui = self.AddChild<UI, string, GameObject>("UIModelShow", gameObject);
            self.uIModelShowComponent = ui.AddComponent<UIModelShowComponent, GameObject>(self.RawImage);
            //配置摄像机位置[0,115,257]
            gameObject.transform.Find("Camera").localPosition = new Vector3(0f, 70f, 150f);
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            BagInfo bagInfo = bagComponent.GetEquipByWeizhi((int)ItemSubTypeEnum.Wuqi);
            self.uIModelShowComponent.ShowPlayerModel(bagInfo, userInfo.Occ).Coroutine();

            await TimerComponent.Instance.WaitAsync(200);
            if (instance != self.InstanceId)
            {
                return;
            }
            self.RawImage.SetActive(true);
        }
    }
}