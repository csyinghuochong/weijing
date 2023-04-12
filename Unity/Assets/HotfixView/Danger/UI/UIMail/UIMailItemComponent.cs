
using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIMailItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject TextConent;
        public GameObject ImageButton;
        public GameObject ImageSelect;

        public MailInfo MailInfo;
        public Action ActionClick;

        public GameObject GameObject;
    }


    public class UIMailItemComponentAwakeSystem : AwakeSystem<UIMailItemComponent, GameObject>
    {
        public override void Awake(UIMailItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.TextConent = rc.Get<GameObject>("TextConent");
            self.ImageButton = rc.Get<GameObject>("ImageButton");
            self.ImageSelect = rc.Get<GameObject>("ImageSelect");

            self.ImageSelect.SetActive(false);
            self.ImageButton.GetComponent<Button>().onClick.AddListener(() => { self.OnImageButton(); });
        }
    }

    public static class UIMailItemComponentSystem
    {

        public static void OnUpdateUI(this UIMailItemComponent self, MailInfo mailInfo)
        {
            self.MailInfo = mailInfo;
            self.TextConent.GetComponent<Text>().text = mailInfo.Title;
        }

        public static void OnImageButton(this UIMailItemComponent self)
        {
            self.ZoneScene().GetComponent<MailComponent>().SelectMail = self.MailInfo;
            self.ActionClick();
        }

        public static void SetSelected(this UIMailItemComponent self, MailInfo value)
        {
            self.ImageSelect.SetActive(self.MailInfo == value);
        }

        public static void ResetUI(this UIMailItemComponent self)
        {
            self.MailInfo = null;
        }

        public static void SetClickHandler(this UIMailItemComponent self, Action action)
        {
            self.ActionClick = action;
        }

    }
}
