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

        public long GatherTime;
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
            if (TimeHelper.ClientNow() - self.GatherTime < 2000)
            {
                return;
            }
            self.GatherTime = TimeHelper.ClientNow();

            int gatherNumber = 0;
            long instanceid = self.InstanceId;
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            List<Unit> planlist = UnitHelper.GetUnitList(self.ZoneScene().CurrentScene(), UnitType.Plant);
            for (int i = planlist.Count - 1; i >= 0; i--)
            {
                if (PositionHelper.Distance2D(unit, planlist[i]) > 5f)
                {
                    continue;
                }
                NumericComponent numericComponent = planlist[i].GetComponent<NumericComponent>();
                long StartTime = numericComponent.GetAsLong(NumericType.StartTime);
                int GatherNumber = numericComponent.GetAsInt(NumericType.GatherNumber);
                long LastGameTime = numericComponent.GetAsLong(NumericType.LastGameTime);
                int cellIndex = numericComponent.GetAsInt(NumericType.CellIndex);
                int getcode = JiaYuanHelper.GetPlanShouHuoItem(planlist[i].ConfigId, StartTime, GatherNumber, LastGameTime);
                if (getcode == ErrorCore.ERR_Success)
                {
                    gatherNumber++;
                    C2M_JiaYuanGatherRequest request = new C2M_JiaYuanGatherRequest() { CellIndex = cellIndex, UnitId = planlist[i].Id, OperateType = 1 };
                    M2C_JiaYuanGatherResponse response = (M2C_JiaYuanGatherResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
                }
                if (instanceid != self.InstanceId)
                {
                    return;
                }
            }

            List<Unit> pasturelist = UnitHelper.GetUnitList(self.ZoneScene().CurrentScene(), UnitType.Pasture);
            for (int i = pasturelist.Count - 1; i >= 0; i--)
            {
                if (PositionHelper.Distance2D(unit, pasturelist[i]) > 5f)
                {
                    continue;
                }
                NumericComponent numericComponent = pasturelist[i].GetComponent<NumericComponent>();
                long StartTime = numericComponent.GetAsLong(NumericType.StartTime);
                int GatherNumber = numericComponent.GetAsInt(NumericType.GatherNumber);
                long LastGameTime = numericComponent.GetAsLong(NumericType.LastGameTime);

                int getcode = JiaYuanHelper.GetPastureShouHuoItem(pasturelist[i].ConfigId, StartTime, GatherNumber, LastGameTime);
                if (getcode == ErrorCore.ERR_Success)
                {
                    gatherNumber++;
                    C2M_JiaYuanGatherRequest request = new C2M_JiaYuanGatherRequest() { UnitId = pasturelist[i].Id, OperateType = 2 };
                    M2C_JiaYuanGatherResponse response = (M2C_JiaYuanGatherResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
                }
                if (instanceid != self.InstanceId)
                {
                    return;
                }
            }

            if (gatherNumber == 0)
            { 
                FloatTipManager.Instance.ShowFloatTip("附近没有可收获的道具！");
            }
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