using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIRoleXiLianExplainComponent: Entity, IAwake, IDestroy
    {
        public GameObject Text_Title_1;
        public GameObject Text_Content_1;
        public GameObject Text_Title_2;
        public GameObject Text_Content_2;
        public GameObject Img_Panel;
        public GameObject Btn_Close;
    }

    public class UIXiLianExplainComponentAwakeSystem: AwakeSystem<UIRoleXiLianExplainComponent>
    {
        public override void Awake(UIRoleXiLianExplainComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Text_Title_1 = rc.Get<GameObject>("Text_Title_1");
            self.Text_Content_1 = rc.Get<GameObject>("Text_Content_1");
            self.Text_Title_2 = rc.Get<GameObject>("Text_Title_2");
            self.Text_Content_2 = rc.Get<GameObject>("Text_Content_2");
            self.Img_Panel = rc.Get<GameObject>("Img_Panel");
            
            self.Btn_Close = rc.Get<GameObject>("Btn_Close");
            self.Btn_Close.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_Close(); });
            
            self.OnLanguageUpdate();
            DataUpdateComponent.Instance.AddListener(DataType.LanguageUpdate, self);
        }
    }

    public class UIRoleXiLianExplainComponentDestroySystem : DestroySystem<UIRoleXiLianExplainComponent>
    {
        public override void Destroy(UIRoleXiLianExplainComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.LanguageUpdate, self);
        }
    }
    
    public static class UIXiLianExplainComponentSystem
    {
        public static void OnLanguageUpdate(this UIRoleXiLianExplainComponent self)
        {
            self.Img_Panel.GetComponent<RectTransform>().sizeDelta = GameSettingLanguge.Language == 0? new Vector2(900, 600) : new Vector2(1000, 700);
            self.Text_Title_1.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 38 : 28;
            self.Text_Title_2.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 38 : 28;
            self.Text_Content_1.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 30 : 26;
            self.Text_Content_2.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 30 : 26;
        }

        public static void OnBtn_Close(this UIRoleXiLianExplainComponent self)
        {
            UIHelper.Remove(self.ZoneScene(), UIType.UIRoleXiLianExplain);
        }
    }
}