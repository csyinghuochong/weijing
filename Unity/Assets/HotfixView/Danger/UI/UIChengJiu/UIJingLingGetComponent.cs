using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIJingLingGetComponent : Entity, IAwake
    {
        public GameObject TextSkinName;
        public GameObject RawImage;
        public GameObject Btn_Close;

        public UIModelShowComponent uIModelShowComponent;
    }

    public class UIJingLingGetComponentAwake : AwakeSystem<UIJingLingGetComponent>
    {
        public override void Awake(UIJingLingGetComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.TextSkinName = rc.Get<GameObject>("TextSkinName");
            self.RawImage = rc.Get<GameObject>("RawImage");

            self.Btn_Close = rc.Get<GameObject>("Btn_Close");
            self.Btn_Close.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove(self.ZoneScene(), UIType.UIJingLingGet); });
        }
    }

    public static class UIJingLingGetComponentSystem
    {
      
        public static void OnInitUI(this UIJingLingGetComponent self, int jinglingid)
        {
            //模型展示界面
            var path = ABPathHelper.GetUGUIPath("Common/UIModelShow1");
            GameObject bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UICommonHelper.SetParent(gameObject, self.RawImage);
            UI ui = self.AddChild<UI, string, GameObject>("UIModelShow", gameObject);
            self.uIModelShowComponent = ui.AddComponent<UIModelShowComponent, GameObject>(self.RawImage);

            //配置摄像机位置[0,115,257]
            gameObject.transform.Find("Camera").localPosition = new Vector3(0f, 115, 257f);

            //PetConfig petConfig = PetConfigCategory.Instance.Get(rolePetInfo.ConfigId);
            JingLingConfig petSkinConfig = JingLingConfigCategory.Instance.Get(jinglingid);
            self.uIModelShowComponent.ShowOtherModel("JingLing/" + petSkinConfig.Assets).Coroutine();
        }
    }
}
