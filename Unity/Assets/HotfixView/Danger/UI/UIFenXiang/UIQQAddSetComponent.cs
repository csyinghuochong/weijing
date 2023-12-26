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
            Application.OpenURL("http://qm.qq.com/cgi-bin/qm/qr?_wv=1027&k=lO16qovjL3YUFcBxPedlJUQDTwbsiUGg&authKey=fQK6IldA%2FhZiZ6Ow2zIWOwb33MvxOD7FHU2WzxBdbOmJ622V8oHvReMCybgXreeC&noverify=0&group_code=690868439");
        }
    }
}