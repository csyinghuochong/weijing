using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIQueueComponent : Entity, IAwake
    {
        public GameObject TextTime;
        public GameObject TextNumber;
        public GameObject BtnOther;
    }


    public class UIQueueComponentAwakeSystem : AwakeSystem<UIQueueComponent>
    {

        public override void Awake(UIQueueComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.TextTime = rc.Get<GameObject>("TextTime");
            self.TextNumber = rc.Get<GameObject>("TextNumber");
            self.BtnOther = rc.Get<GameObject>("BtnOther");
            self.BtnOther.SetActive(false);
            ButtonHelp.AddListenerEx( self.BtnOther,  self.OnBtnOther);
        }

    }

    public static class UIQueueComponentSystem
    {

        public static void ShowQueueNumber(this UIQueueComponent self, string number)
        {
            self.TextTime.GetComponent<Text>().text = $"{number}分钟";
            self.TextNumber.GetComponent<Text>().text = number;
        }

        public static void OnBtnOther(this UIQueueComponent self)
        { 
            
        }
    }
}
