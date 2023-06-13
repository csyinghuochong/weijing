using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIYinSiComponent : Entity, IAwake
    {
        public GameObject TextButton_2;
        public GameObject TextButton_1;

        public GameObject TextYinSi;
        public GameObject YongHuXieYiClose;
        public GameObject YinSiXieYiClose;
        public GameObject YongHuXieYi;

        public GameObject YinSiXieYi;
        public GameObject ButtonRefuse;
        public GameObject ButtonAgree;
        public GameObject ButtonClose;
    }

    public class UIYinSiComponentAwake : AwakeSystem<UIYinSiComponent>
    {
        public override void Awake(UIYinSiComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.YongHuXieYi = rc.Get<GameObject>("YongHuXieYi");
            self.YinSiXieYi = rc.Get<GameObject>("YinSiXieYi");

            self.TextButton_2 = rc.Get<GameObject>("TextButton_2");
            self.TextButton_1 = rc.Get<GameObject>("TextButton_1");
            self.TextButton_2.GetComponent<Button>().onClick.AddListener(() => { self.YongHuXieYi.SetActive(true); });
            self.TextButton_1.GetComponent<Button>().onClick.AddListener(() => { self.YinSiXieYi.SetActive(true); });
            
            self.TextYinSi = rc.Get<GameObject>("TextYinSi");
            self.TextYinSi.GetComponent<TextMeshProUGUI>().text = UILoginHelper.GetYingSiText();

            self.YongHuXieYiClose = rc.Get<GameObject>("YongHuXieYiClose");
            self.YongHuXieYiClose.GetComponent<Button>().onClick.AddListener(() => { self.YongHuXieYi.SetActive(false); });

            self.YinSiXieYiClose = rc.Get<GameObject>("YinSiXieYiClose");
            self.YinSiXieYiClose.GetComponent<Button>().onClick.AddListener(() => { self.YinSiXieYi.SetActive(false); });

            self.ButtonRefuse = rc.Get<GameObject>("ButtonRefuse");
            self.ButtonRefuse.GetComponent<Button>().onClick.AddListener( self.OnButtonRefuse);

            self.ButtonAgree = rc.Get<GameObject>("ButtonAgree");
            self.ButtonAgree.GetComponent<Button>().onClick.AddListener(self.OnButtonAgree);

            self.ButtonClose = rc.Get<GameObject>("ButtonClose");
            self.ButtonClose.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove(self.ZoneScene(), UIType.UIYinSi); } );
        }
    }

    public static class UIYinSiComponentSystem
    {
        public static void OnButtonRefuse(this UIYinSiComponent self)
        { 
            
        }

        public static void OnButtonAgree(this UIYinSiComponent self)
        { 
            
        }
    }
}