using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UISettingTitleItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject Text_value;
        public GameObject ButtonActivite;

        public GameObject GameObject;
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
        }
    }

    public static class UISettingTitleItemComponentSystem
    {
        public static void OnInitUI(this UISettingTitleItemComponent self, KeyValuePairInt titieInfo)
        {
            TitleConfig titleConfig = TitleConfigCategory.Instance.Get(titieInfo.KeyId);
            self.Text_value.GetComponent<Text>().text = titleConfig.Name;
        }
    }
}
