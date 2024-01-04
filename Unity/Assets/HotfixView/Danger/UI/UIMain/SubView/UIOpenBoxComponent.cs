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

    public class UIOpenBoxComponent : Entity, IAwake, IDestroy
    {
        public GameObject Img_Progress;
        public long TotalTime = 3000;
        public long EndTime = 0;
        public long BoxUnitId;
        public long Timer;
    }


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


    public class UIOpenBoxComponentDestroy : DestroySystem<UIOpenBoxComponent>
    {
        public override void Destroy(UIOpenBoxComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }

    public static class UIOpenBoxComponentSystem
    {
        public static void OnUpdate(this UIOpenBoxComponent self)
        {
            if (self.BoxUnitId == 0)
            {
                self.OnOpenBox(null);
                return;
            }
            if (self.ZoneScene().CurrentScene().GetComponent<UnitComponent>().Get(self.BoxUnitId) == null)
            {
                self.OnOpenBox(null);
                return;
            }
            long leftTime = self.EndTime - TimeHelper.ClientNow();
            if (leftTime <= 0)
            {
                self.SendOpenBox().Coroutine();
                self.OnOpenBox(null);
                return;
            }
            self.Img_Progress.transform.localScale = new Vector3((self.TotalTime - leftTime) * 1f / self.TotalTime, 1f, 1f);
        }

        public static void OnOpenBox(this UIOpenBoxComponent self, Unit box)
        {
            self.EndTime = 0;
            self.BoxUnitId = box!=null ? box.Id : 0;
            self.GetParent<UI>().GameObject.SetActive(box!=null);
            TimerComponent.Instance?.Remove(ref self.Timer);

            if (box == null)
            {
                return;
            }
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
          
            int monsterid = box.ConfigId;
            MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(monsterid);
           
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            if (userInfo.PiLao <= 0 && monsterConfig.MonsterSonType == 56)
            {
                FloatTipManager.Instance.ShowFloatTip("体力不足,无法拾取");
                return;
            }

            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            if (bagComponent.GetLeftSpace() < 1 && monsterConfig.MonsterSonType == 57)
            {
                FloatTipManager.Instance.ShowFloatTip("背包空间不足,无法拾取");
                return;
            }

            string itemneeds = "";
            if (monsterConfig.Parameter != null && monsterConfig.Parameter.Length > 0
                && monsterConfig.Parameter[0] > 0)
            {
                itemneeds = $"{monsterConfig.Parameter[0]};{monsterConfig.Parameter[1]}";
            }
            if (itemneeds.Length > 2 && !bagComponent.CheckNeedItem(itemneeds))
            {
                self.GetParent<UI>().GameObject.SetActive(false);
                FloatTipManager.Instance.ShowFloatTip($"道具不足，需要道具 {UICommonHelper.GetNeedItemDesc(itemneeds)}！");
                return;
            }

            if (box !=null)
            {
                self.EndTime = TimeHelper.ClientNow() + self.TotalTime;
                self.Timer = TimerComponent.Instance.NewFrameTimer(TimerType.OpenBoxTimer, self);

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
            MapComponent mapComponent = self.ZoneScene().GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum == SceneTypeEnum.JiaYuan)
            {
                long masterid = self.ZoneScene().GetComponent<JiaYuanComponent>().MasterId;
                Actor_JiaYuanPickRequest actor_PickBoxRequest = new Actor_JiaYuanPickRequest() { UnitId = self.BoxUnitId, MasterId = masterid };
                Actor_JiaYuanPickResponse actor_PickItemResponse = await self.DomainScene().GetComponent<SessionComponent>().Session.Call(actor_PickBoxRequest) as Actor_JiaYuanPickResponse;
            }
            else
            {
                Unit zhupuUnit = self.ZoneScene().CurrentScene().GetComponent<UnitComponent>().Get(self.BoxUnitId);
                if (zhupuUnit == null)
                {
                    return;
                }
                MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(zhupuUnit.ConfigId);
                if (monsterConfig.MonsterType == 5 && monsterConfig.MonsterSonType == 58)
                {
                    Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
                    UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
                    int maxNum = PetHelper.GetPetMaxNumber(unit, userInfo.Lv);
                    if (PetHelper.GetBagPetNum(self.ZoneScene().GetComponent<PetComponent>().RolePetInfos) >= maxNum)
                    {
                        FloatTipManager.Instance.ShowFloatTip("宠物格子不足！");
                        return;
                    }
                }

                Actor_OpenBoxRequest actor_PickBoxRequest = new Actor_OpenBoxRequest() { UnitId = self.BoxUnitId };
                await self.DomainScene().GetComponent<SessionComponent>().Session.Call(actor_PickBoxRequest);
            }
        }
    }
}
