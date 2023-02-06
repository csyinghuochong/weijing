using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIRoleZodiacComponent : Entity, IAwake, IDestroy
    {
        public GameObject ButtonColse;
        public GameObject ZodiacList;
        public GameObject BtnItemTypeSet;

        public UIPageButtonComponent UIPageButtonComponent;
    }

    [ObjectSystem]
    public class UIRoleZodiacComponentAwake : AwakeSystem<UIRoleZodiacComponent>
    {
        public override void Awake(UIRoleZodiacComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ZodiacList = rc.Get<GameObject>("ZodiacList");
            self.BtnItemTypeSet = rc.Get<GameObject>("BtnItemTypeSet");

            self.ButtonColse = rc.Get<GameObject>("ButtonColse");
            self.ButtonColse.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove(self.ZoneScene(), UIType.UIRoleZodiac); });

            //单选组件
            GameObject BtnItemTypeSet = rc.Get<GameObject>("BtnItemTypeSet");
            UI uiPage = self.AddChild<UI, string, GameObject>("BtnItemTypeSet", BtnItemTypeSet);
            UIPageButtonComponent pageButton = uiPage.AddComponent<UIPageButtonComponent>();
            self.UIPageButtonComponent = pageButton;
            pageButton.SetClickHandler((int page) => {
                self.OnClickPageButton(page);
            });
            pageButton.OnSelectIndex(0);
        }
    }

    [ObjectSystem]
    public class UIRoleZodiacComponentDestroy : DestroySystem<UIRoleZodiacComponent>
    {
        public override void Destroy(UIRoleZodiacComponent self)
        {
            
        }
    }

    public static class UIRoleZodiacComponentSystem
    {
        public static void OnClickPageButton(this UIRoleZodiacComponent self, int page)
        { 

        }
    }
}