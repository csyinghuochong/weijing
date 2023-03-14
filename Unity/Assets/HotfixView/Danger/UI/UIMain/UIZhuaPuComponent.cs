using System;
using UnityEngine;

namespace ET
{
    [Timer(TimerType.UIZhuaPuTimer)]
    public class UIZhuaPuTimer : ATimer<UIZhuaPuComponent>
    {
        public override void Run(UIZhuaPuComponent self)
        {
            try
            {
                self.OnTimer();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    public class UIZhuaPuComponent: Entity, IAwake, IDestroy
    {
        public GameObject Img_Node;
        public GameObject Img_ChanZi;
        public GameObject ButtonDig;   
        public GameObject Img_Pos;
        public GameObject TextGaiLv;

        public long Timer;
    }

    [ObjectSystem]
    public class UIZhuaPuComponentAwake : AwakeSystem<UIZhuaPuComponent>
    {
        public override void Awake(UIZhuaPuComponent self)
        {
            GameObject go = self.GetParent<UI>().GameObject;

            self.Img_Pos = go.Get<GameObject>("Img_Pos");
            self.ButtonDig = go.Get<GameObject>("ButtonDig");
            ButtonHelp.AddListenerEx(self.ButtonDig, () => { self.OnButtonDig(); });

            self.Img_ChanZi = go.Get<GameObject>("Img_ChanZi");
            self.Img_Node = go.Get<GameObject>("Img_Node");

            self.TextGaiLv = go.Get<GameObject>("Img_Node");
        }
    }

    [ObjectSystem]
    public class UIZhuaPuComponentDestroy : DestroySystem<UIZhuaPuComponent>
    {
        public override void Destroy(UIZhuaPuComponent self)
        {

        }
    }

    public static class UIZhuaPuComponentSystem
    {

        public static void OnTimer(this UIZhuaPuComponent self)
        { 
            
        }

        public static void OnInitUI(this UIZhuaPuComponent self)
        { 
            
        }

        public static void OnButtonDig(this UIZhuaPuComponent self)
        { 
            
        }
    }
}
