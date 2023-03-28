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
            ButtonHelp.AddListenerEx(self.ButtonTalk, () =>   { self.OnButtonTalk(); });
            ButtonHelp.AddListenerEx(self.ButtonTarget, () => { self.OnButtonTarget(); });
        }
    }

    public static class UIJiaYuanMainComponentSystem
    {
        public static async ETTask OnButtonGather(this UIJiaYuanMainComponent self)
        {
            await ETTask.CompletedTask;
        }

        public static void OnButtonTalk(this UIJiaYuanMainComponent self)
        {
            DuiHuaHelper.MoveToNpcDialog(self.ZoneScene());
        }

        public static void OnButtonTarget(this UIJiaYuanMainComponent self)
        {
            self.ZoneScene().CurrentScene().GetComponent<JiaYuanViewComponent>().LockTargetUnit().Coroutine();
        }
    }
}