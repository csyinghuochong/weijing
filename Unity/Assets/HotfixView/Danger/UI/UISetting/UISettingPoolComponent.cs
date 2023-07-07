using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Profiling;

namespace ET
{

    public class UISettingPoolComponent : Entity, IAwake
    {
        public GameObject TextPool;
        public GameObject ImageDiClose;
        public GameObject ButtonClose;
    }

    public class UISettingPoolComponentAwake : AwakeSystem<UISettingPoolComponent>
    {

        public override void Awake(UISettingPoolComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.TextPool = rc.Get<GameObject>("TextPool");
            self.ImageDiClose = rc.Get<GameObject>("ImageDiClose");
            self.ButtonClose = rc.Get<GameObject>("ButtonClose");

            self.OnInitUI();
        }
    }

    public static class UISettingPoolComponentSystem
    {
        public static void OnInitUI(this UISettingPoolComponent self)
        {
            self.TextPool.GetComponent<Text>().text = EventSystem.Instance.ToString() + "\n" 
                + ObjectPool.Instance.ToString() + "\n" + MonoPool.Instance.ToString();
        }
    }
}