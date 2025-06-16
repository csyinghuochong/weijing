using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIProLucklyExplainComponent: Entity, IAwake, IDestroy
    {
        public GameObject Btn_Close;
        public GameObject Img_Panel;
        public GameObject Text_Title_1;
        public GameObject Text_Content_1;
        public GameObject Text_Title_2;
        public GameObject Text_Content_2;
    }

    public class UIProLucklyExplainComponentAwakeSystem: AwakeSystem<UIProLucklyExplainComponent>
    {
        public override void Awake(UIProLucklyExplainComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Btn_Close = rc.Get<GameObject>("Btn_Close");
            self.Btn_Close.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_Close(); });
            
            self.Img_Panel = rc.Get<GameObject>("Img_Panel");
            self.Text_Title_1 = rc.Get<GameObject>("Text_Title_1");
            self.Text_Content_1 = rc.Get<GameObject>("Text_Content_1");
            self.Text_Title_2 = rc.Get<GameObject>("Text_Title_2");
            self.Text_Content_2 = rc.Get<GameObject>("Text_Content_2");
            
            self.StoreUIdData();
            self.OnLanguageUpdate();
            DataUpdateComponent.Instance.AddListener(DataType.LanguageUpdate, self);
        }
    }
    
    public class UIProLucklyExplainComponentDestroySystem : DestroySystem<UIProLucklyExplainComponent>
    {
        public override void Destroy(UIProLucklyExplainComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.LanguageUpdate, self);
        }
    }

    public static class UIProLucklyExplainComponentSystem
    {
        public static void StoreUIdData(this UIProLucklyExplainComponent self)
        {

        }

        public static void OnLanguageUpdate(this UIProLucklyExplainComponent self)
        {
            RectTransform rt = self.Img_Panel.GetComponent<RectTransform>();
            Vector2 size = rt.sizeDelta;
            size.x = GameSettingLanguge.Language == 0? 900 : 1000;
            self.Img_Panel.GetComponent<RectTransform>().sizeDelta = size;
            self.Text_Title_1.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 38 : 35;
            self.Text_Content_1.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 30 : 26;
            self.Text_Title_2.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 38 : 35;
            self.Text_Content_2.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 30 : 26;
        }
        
        public static void OnBtn_Close(this UIProLucklyExplainComponent self)
        {
            UIHelper.Remove(self.ZoneScene(), UIType.UIProLucklyExplain);
        }
    }
}