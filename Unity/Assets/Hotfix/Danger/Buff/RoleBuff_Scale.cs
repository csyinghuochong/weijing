using System;
using UnityEngine;

namespace ET
{

    [BuffHandler]
    public class RoleBuff_Scale : RoleBuff_Base
    {
        public override void OnInit(BuffData buffData, Unit theUnitBelongto)
        {
            base.OnInit(buffData, theUnitBelongto);


            EventType.BuffScale.Instance.Unit = this.TheUnitBelongto;
            EventType.BuffScale.Instance.ZoneScene = this.TheUnitBelongto.ZoneScene();
            EventType.BuffScale.Instance.ABuffHandler = this;
            EventType.BuffScale.Instance.OperateType = 1;
            EventSystem.Instance.PublishClass(EventType.BuffScale.Instance);
        }

        public override void OnFinished()
        {
            EventType.BuffScale.Instance.Unit = this.TheUnitBelongto;
            EventType.BuffScale.Instance.ZoneScene = this.TheUnitBelongto.ZoneScene();
            EventType.BuffScale.Instance.ABuffHandler = this;
            EventType.BuffScale.Instance.OperateType = 2;
            EventSystem.Instance.PublishClass(EventType.BuffScale.Instance);

            base.OnFinished();
        }
    }
}
