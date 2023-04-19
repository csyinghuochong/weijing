using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UINoticeComponent : Entity, IAwake
    {

        public GameObject Content;
        public GameObject CloseButton;
        public GameObject Btn_Close;

    }

    public class UINoticeComponentAwake : AwakeSystem<UINoticeComponent>
    {
        public override void Awake(UINoticeComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Content = rc.Get<GameObject>("Content");

            self.CloseButton = rc.Get<GameObject>("CloseButton");
            self.CloseButton.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove(self.ZoneScene(), UIType.UINotice); });

            self.Btn_Close = rc.Get<GameObject>("Btn_Close");
            self.Btn_Close.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove(self.ZoneScene(), UIType.UINotice); });

            self.OnInitUI();
        }
    }

    public static class UINoticeComponentSystem
    {
        public static void OnInitUI(this UINoticeComponent self)
        {
            AccountInfoComponent accountInfoComponent = self.ZoneScene().GetComponent<AccountInfoComponent>();
            self.Content.GetComponent<Text>().text = accountInfoComponent.NoticeText;
        }
    }
}
