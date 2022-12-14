using System;
using UnityEngine;

namespace ET
{

    [Timer(TimerType.OpenBoxTimer)]
    public class OpenBoxTimer : ATimer<UIOpenBoxComponent>
    {
        public override void Run(UIOpenBoxComponent self)
        {
            try
            {
                self.OnUpdate();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    public class UIOpenBoxComponent : Entity, IAwake
    {
        public GameObject Img_Progress;
        public long TotalTime = 3000;
        public long EndTime = 0;
        public long BoxUnitId;
        public long Timer;
    }

    [ObjectSystem]
    public class UIOpenBoxComponentAwakeSystem : AwakeSystem<UIOpenBoxComponent>
    {

        public override void Awake(UIOpenBoxComponent self)
        {
            self.Timer = 0;
            self.BoxUnitId = 0;

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.Img_Progress = rc.Get<GameObject>("Img_Progress");
            self.GetParent<UI>().GameObject.SetActive(false);
        }
    }

    public static class UIOpenBoxComponentSystem
    {
        public static void OnUpdate(this UIOpenBoxComponent self)
        {
            if (self.BoxUnitId == 0)
            {
                self.OnOpenBox(0);
                return;
            }
            if (self.ZoneScene().CurrentScene().GetComponent<UnitComponent>().Get(self.BoxUnitId) == null)
            {
                self.OnOpenBox(0);
                return;
            }
            long leftTime = self.EndTime - TimeHelper.ClientNow();
            if (leftTime <= 0)
            {
                self.SendOpenBox().Coroutine();
                self.OnOpenBox(0);
                return;
            }
            self.Img_Progress.transform.localScale = new Vector3((self.TotalTime - leftTime) * 1f / self.TotalTime, 1f, 1f);
        }

        public static void OnOpenBox(this UIOpenBoxComponent self, long unitId)
        {
            self.EndTime = 0;
            self.BoxUnitId = unitId;
            self.GetParent<UI>().GameObject.SetActive(unitId != 0);
            TimerComponent.Instance?.Remove(ref self.Timer);

            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            Unit box = unit.GetParent<UnitComponent>().Get(unitId);
            if (box == null)
            {
                return;
            }
            int monsterid = box.ConfigId;
            MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(monsterid);

            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            if (userInfo.PiLao <= 0 && (monsterConfig.MonsterSonType == 56))
            {
                FloatTipManager.Instance.ShowFloatTip("体力不足,无法拾取");
                return;
            }

            string itemneeds = "";
            if (monsterConfig.Parameter != null && monsterConfig.Parameter.Length > 0
                && monsterConfig.Parameter[0] > 0)
            {
                itemneeds = $"{monsterConfig.Parameter[0]};{monsterConfig.Parameter[1]}";
            }
            if (itemneeds.Length > 2 && !self.ZoneScene().GetComponent<BagComponent>().CheckNeedItem(itemneeds))
            {
                self.GetParent<UI>().GameObject.SetActive(false);
                FloatTipManager.Instance.ShowFloatTip($"需要道具 {UICommonHelper.GetNeedItemDesc(itemneeds)}！");
                return;
            }

            if (unitId > 0)
            {
                self.EndTime = TimeHelper.ClientNow() + self.TotalTime;
                self.Timer = TimerComponent.Instance.NewFrameTimer(TimerType.OpenBoxTimer, self);
            }
            
            if (unitId > 0)
            {
                Vector3 direction = box.Position - unit.Position;
                int ange = Mathf.FloorToInt(Mathf.Rad2Deg * Mathf.Atan2(direction.x, direction.z));
                unit.GetComponent<StateComponent>().SendUpdateState(1, StateTypeEnum.OpenBox, ange.ToString());
            }
            else
            {
                unit.GetComponent<StateComponent>().SendUpdateState( 2, StateTypeEnum.OpenBox, "0");
            }
        }

        public static async ETTask SendOpenBox(this UIOpenBoxComponent self)
        {
            Actor_PickBoxRequest actor_PickBoxRequest = new Actor_PickBoxRequest() {   UnitId = self.BoxUnitId };
            Actor_PickBoxResponse actor_PickItemResponse = await self.DomainScene().GetComponent<SessionComponent>().Session.Call(actor_PickBoxRequest) as Actor_PickBoxResponse;
        }
    }
}
