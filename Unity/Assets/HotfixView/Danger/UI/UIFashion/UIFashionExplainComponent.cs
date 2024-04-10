using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIFashionExplainComponent : Entity, IAwake
    {
        public GameObject Btn_Close;
        public Text TextExplain;
    }

    public class UIFashionExplainComponentAwake : AwakeSystem<UIFashionExplainComponent>
    {
        public override void Awake(UIFashionExplainComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Btn_Close = rc.Get<GameObject>("Btn_Close");
            self.Btn_Close.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_Close(); });

            self.TextExplain = rc.Get<GameObject>("TextExplain").GetComponent<Text>();
        }
    }

    public static class UIFashionExplainComponentSystem
    {
        public static void OnBtn_Close(this UIFashionExplainComponent self)
        {
            UIHelper.Remove(self.ZoneScene(), UIType.UIFashionExplain);
        }

        public static void OnInitData(this UIFashionExplainComponent self , int fashionid)
        { 
            FashionConfig fashionConfig = FashionConfigCategory.Instance.Get(fashionid);
            self.TextExplain.text = fashionConfig.PropertyDes;
        }
    }
}