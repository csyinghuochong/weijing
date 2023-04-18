using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIUnionShowComponent : Entity, IAwake
    {
        public UIUnionListComponent UIUnionListComponent;
        public UIUnionCreateComponent UIUnionCreateComponent;

        public GameObject ButtonCreate;
        public GameObject Btn_Return;
    }

    public class UIUnionShowComponentAwake : AwakeSystem<UIUnionShowComponent>
    {
        public override void Awake(UIUnionShowComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            GameObject UIUnionList = rc.Get<GameObject>("UIUnionList");
            self.UIUnionListComponent = self.AddChild<UIUnionListComponent, GameObject>(UIUnionList);

            GameObject UIUnionCreate = rc.Get<GameObject>("UIUnionCreate");
            self.UIUnionCreateComponent = self.AddChild<UIUnionCreateComponent, GameObject>(UIUnionCreate);


            self.ButtonCreate = rc.Get<GameObject>("ButtonCreate");
            self.ButtonCreate.GetComponent<Button>().onClick.AddListener(() =>
            {
                self.UIUnionListComponent.GameObject.SetActive(false);
                self.UIUnionCreateComponent.GameObject.SetActive(true);
            });

            self.Btn_Return = rc.Get<GameObject>("Btn_Return");
            self.Btn_Return.GetComponent<Button>().onClick.AddListener(() =>
            {
                self.UIUnionListComponent.GameObject.SetActive(true);
                self.UIUnionCreateComponent.GameObject.SetActive(false);
            });

            self.GetParent<UI>().OnUpdateUI = self.OnUpdateUI;
        }
    }

    public static class UIUnionShowComponentSystem
    {
        public static void OnCreateUnion(this UIUnionShowComponent self)
        {
            self.UIUnionListComponent.GameObject.SetActive(true);
            self.UIUnionCreateComponent.GameObject.SetActive(false);
            self.UIUnionListComponent.ResetUI();
            self.UIUnionListComponent.OnUpdateUI().Coroutine();
        }

        public static void OnUpdateUI(this UIUnionShowComponent self)
        {
            self.UIUnionListComponent.GameObject.SetActive(true);
            self.UIUnionCreateComponent.GameObject.SetActive(false);

            self.UIUnionListComponent.OnUpdateUI().Coroutine();
        }
    }
}
