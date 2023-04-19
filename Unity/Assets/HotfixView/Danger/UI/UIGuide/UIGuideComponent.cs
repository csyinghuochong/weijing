using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIGuideComponent : Entity, IAwake, IDestroy
    {
        public GameObject ImageDi;
        public GameObject Text1;
        public GameObject PositionSet;
        public GameObject ImageButton;
        public GameObject ShowLab;
        public GameObject ShowLabSet;

        public GuideConfig guidCof;
    }


    public class UIGuideComponentAwakeSystem : AwakeSystem<UIGuideComponent>
    {
        public override void Awake(UIGuideComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ImageDi = rc.Get<GameObject>("ImageDi");
            self.Text1 = rc.Get<GameObject>("Text1");
            self.PositionSet = rc.Get<GameObject>("PositionSet");
            self.PositionSet.SetActive(false);

            self.ImageButton = rc.Get<GameObject>("ImageButton");
            self.ShowLab = rc.Get<GameObject>("ShowLab");
            self.ShowLabSet = rc.Get<GameObject>("ShowLabSet");
        }
    }


    public class UIGuideComponentDestroySystem : DestroySystem<UIGuideComponent>
    {
        public override void Destroy(UIGuideComponent self)
        {
            GameObject.Destroy(self.ImageButton);
        }
    }

    public static class UIGuideComponentSystem
    {

        public static void SetPosition(this UIGuideComponent self, GameObject gameObject)
        {
            //Vector2 pos;
            //Vector3 vector3 = UIComponent.Instance.UICamera.WorldToScreenPoint(gameObject.transform.position);
            //Canvas canvas = UIEventComponent.Instance.UILayers[(int)UILayer.Low].GetComponent<Canvas>();
            //if (RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas.transform as RectTransform,
            //vector3, UIComponent.Instance.UICamera, out pos))
            //{
            //    self.ImageButton.transform.localPosition = pos;
            //}
            //else
            //{
            //}

            UICommonHelper.SetParent(self.GetParent<UI>().GameObject, gameObject);
            //self.ShowLab.GetComponent<Text>().text = "123";

            if (self.guidCof != null)
            {
                self.ShowLabSet.SetActive(true);
                self.ShowLab.GetComponent<Text>().text = self.guidCof.Text;
            }
            else {
                self.ShowLabSet.SetActive(false);
            }

        }
    }
}
