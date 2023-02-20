using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UISettingTitleItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject RawImage;
        public GameObject Text_value;
        public GameObject ButtonActivite;

        public GameObject GameObject;
        public int Title;
    }

    [ObjectSystem]
    public class UISettingTitleItemComponentAwake : AwakeSystem<UISettingTitleItemComponent, GameObject>
    {
        public override void Awake(UISettingTitleItemComponent self, GameObject a)
        {
            self.GameObject = a;

            ReferenceCollector rc = a.GetComponent<ReferenceCollector>();
            self.Text_value = rc.Get<GameObject>("Text_value");

            self.ButtonActivite = rc.Get<GameObject>("ButtonActivite");
            ButtonHelp.AddListenerEx(self.ButtonActivite, () => { self.OnButtonActivite().Coroutine(); });

            self.RawImage = rc.Get<GameObject>("RawImage");
        }
    }

    public static class UISettingTitleItemComponentSystem
    {
        public static async ETTask OnButtonActivite(this UISettingTitleItemComponent self)
        {
            C2M_TitleUseRequest  request = new C2M_TitleUseRequest() { TitleId = self.Title };
            M2C_TitleUseResponse response= (M2C_TitleUseResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);

            UI uI = UIHelper.GetUI(self.ZoneScene(), UIType.UISetting);
            uI.GetComponent<UISettingComponent>().OnTitleUse();

            await ETTask.CompletedTask;
        }

        public static void OnInitUI(this UISettingTitleItemComponent self, KeyValuePairInt titieInfo)
        {
            self.Title = titieInfo.KeyId;
            TitleConfig titleConfig = TitleConfigCategory.Instance.Get(titieInfo.KeyId);
            self.Text_value.GetComponent<Text>().text = titleConfig.Name;

            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.ChengHaoIcon, titleConfig.Icon.ToString());
            self.RawImage.GetComponent<Image>().sprite = sp;

            self.Text_value.GetComponent<Text>().text = titleConfig.Des;

            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            int titleId = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.TitleID);
            self.ButtonActivite.SetActive(titleId != titieInfo.KeyId);
        }
    }
}
