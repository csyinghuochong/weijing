using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPopupComponent : Entity, IAwake, IDestroy
    {
        public GameObject titleText;
        public GameObject contentText;
        public GameObject closeButton;
        public GameObject confirButton;
        public GameObject cancelButton;

        public Action confirHandler;
        public Action cancelHandler;

        public string UIType;
    }

    [ObjectSystem]
    public class UIPopupComponentAwakeSystem : AwakeSystem<UIPopupComponent>
    {
        public override void Awake(UIPopupComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.titleText = rc.Get<GameObject>("title");
            self.contentText = rc.Get<GameObject>("Text");
            self.closeButton = rc.Get<GameObject>("Btn_Close");
            self.cancelButton = rc.Get<GameObject>("Btn_SelectFalse");
            self.confirButton = rc.Get<GameObject>("Btn_SelectTreue");

            self.closeButton.GetComponent<Button>().onClick.AddListener(() => { self.OnCloseButton(); });
            self.cancelButton.GetComponent<Button>().onClick.AddListener(() => { self.OnCancelButton(); });
            ButtonHelp.AddListenerEx(self.confirButton, self.OnConfirButton);

            self.UIType = UIType.UIPopupview;
        }
    }

    [ObjectSystem]
    public class UIPopupComponentDestroySystem : DestroySystem<UIPopupComponent>
    {
        public override void Destroy(UIPopupComponent self)
        {
            self.confirHandler = null;
            self.cancelHandler = null;
        }
    }

    public static class UIPopupComponentSystem
    {

        public static void OnConfirButton(this UIPopupComponent self)
        {
            self.confirHandler?.Invoke();
            self.confirHandler = null;
            UIHelper.Remove(self.DomainScene(), self.UIType);
        }

        public static void OnCancelButton(this UIPopupComponent self)
        {
            self.confirButton.SetActive(false);
            self.cancelHandler?.Invoke();
            self.cancelHandler = null;
            UIHelper.Remove(self.DomainScene(), self.UIType);
        }

        public static void OnCloseButton(this UIPopupComponent self)
        {
            UIHelper.Remove(self.DomainScene(), self.UIType);
        }

        public static void InitData(this UIPopupComponent self, string title, string content, Action okhandle, Action cancelHandle)
        {
            if (!string.IsNullOrEmpty(title))
            {
                self.titleText.GetComponent<Text>().text = title;
            }
            self.contentText.GetComponent<Text>().text = content;

            self.confirHandler = okhandle;
            self.cancelHandler = cancelHandle;
        }
    }

}