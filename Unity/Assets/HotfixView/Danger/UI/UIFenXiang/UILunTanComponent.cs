using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UILunTanComponent : Entity, IAwake
    {
        public GameObject ButtonGet;
    }

    public class UILunTanComponentAwake : AwakeSystem<UILunTanComponent>
    {
        public override void Awake(UILunTanComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.ButtonGet = rc.Get<GameObject>("ButtonGet");
            ButtonHelp.AddListenerEx(self.ButtonGet, () => { self.OnButtonGet(); });
        }

    }

    public static class UILunTanComponentSystem
    {
        public static void OnButtonGet(this UILunTanComponent self)
        {
            Application.OpenURL("https://l.tapdb.net/jYTd08hD?channel=rep-rep_6t3lta8ujdb_h5url65");
        }
    }
}
