using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UICountryHuoDongJieShaoComponent : Entity, IAwake
    {
        public GameObject TextTitle;
        public GameObject TextJieShao;
        public GameObject BtnClose;
    }


    public class UICountryHuoDongJieShaoComponentAwakeSystem : AwakeSystem<UICountryHuoDongJieShaoComponent>
    {

        public override void Awake(UICountryHuoDongJieShaoComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.BtnClose = rc.Get<GameObject>("BtnClose");
            self.BtnClose.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_Close(); });

            self.TextJieShao = rc.Get<GameObject>("TextJieShao");
            self.TextTitle = rc.Get<GameObject>("TextTitle");
        }
    }

    public static class UICountryHuoDongJieShaoComponentSystem
    {
        public static void OnBtn_Close(this UICountryHuoDongJieShaoComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UICountryHuoDongJieShao);
        }

        public static void OnUpdateJieShao(this UICountryHuoDongJieShaoComponent self, string title, string jieshao)
        {
            self.TextTitle.GetComponent<Text>().text = title;
            self.TextJieShao.GetComponent<Text>().text = jieshao;
        }
    }
}
