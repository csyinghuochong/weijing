using System;
using UnityEngine;
using UnityEngine.UI;


namespace ET
{
    public class UIQQAddSetComponent : Entity, IAwake
    {
        public GameObject ItemList;
        public GameObject Button_AddQQ;
    }

    public class UIQQAddSetComponentAwake : AwakeSystem<UIQQAddSetComponent>
    {
        public override void Awake(UIQQAddSetComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ItemList = rc.Get<GameObject>("ItemList");
            UICommonHelper.ShowItemList(ActivityConfigCategory.Instance.Get(34002).Par_3, self.ItemList, self);
   
            self.Button_AddQQ = rc.Get<GameObject>("Button_AddQQ");
            ButtonHelp.AddListenerEx(self.Button_AddQQ, () => { self.OnButton_AddQQ(); });

            if (GlobalHelp.GetPlatform() == 5 || GlobalHelp.GetPlatform() == 6)
            {
                self.Button_AddQQ.SetActive(false);
            }
            else
            {
                self.Button_AddQQ.SetActive(true);
            }
        }
    }

    public static class UIQQAddSetComponentSystem
    {
        public static void OnButton_AddQQ(this UIQQAddSetComponent self)
        {
            Application.OpenURL("http://qm.qq.com/cgi-bin/qm/qr?_wv=1027&k=QWL7Ed6RtjIIB0Z1U1LUFvOeD71i_M2j&authKey=1glgSHXDGzy9gsSHwqOu2RqEX7lGY2g8V9VSljhHTHeqtg5AMZNMM8889wRFep1J&noverify=0&group_code=473268983");
        }
    }
}