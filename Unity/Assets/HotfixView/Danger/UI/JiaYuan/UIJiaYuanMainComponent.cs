using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIJiaYuanMainComponent : Entity, IAwake, IDestroy
    {
        public GameObject ButtonGather;
        public GameObject ButtonTalk;
        public GameObject ButtonTarget;
    }

    [ObjectSystem]
    public class UIJiaYuanMainComponentAwake : AwakeSystem<UIJiaYuanMainComponent>
    {
        public override void Awake(UIJiaYuanMainComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ButtonGather = rc.Get<GameObject>("ButtonGather");
            self.ButtonTalk = rc.Get<GameObject>("ButtonTalk");
            self.ButtonTarget = rc.Get<GameObject>("ButtonTarget");

            ButtonHelp.AddListenerEx(self.ButtonGather, () => { self.OnButtonGather().Coroutine();  });
            ButtonHelp.AddListenerEx(self.ButtonTalk, () =>   { self.OnButtonTalk().Coroutine(); });
            ButtonHelp.AddListenerEx(self.ButtonTarget, () => { self.OnButtonTarget().Coroutine(); });
        }
    }

    public static class UIJiaYuanMainComponentSystem
    {
        public static async ETTask OnButtonGather(this UIJiaYuanMainComponent self)
        {
            await ETTask.CompletedTask;
        }

        public static async ETTask OnButtonTalk(this UIJiaYuanMainComponent self)
        {
            await ETTask.CompletedTask;
        }

        public static async ETTask OnButtonTarget(this UIJiaYuanMainComponent self)
        {
            await ETTask.CompletedTask;
        }
    }
   
}