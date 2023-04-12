using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ET
{
    public class UIMainSkillComponent : Entity, IAwake, IDestroy
    {

        public GameObject Btn_JingLing;
        public GameObject Button_ZhuaPu;
        public GameObject shiquButton;
        public GameObject Btn_Target;
        public GameObject Btn_CancleSkill;
        public GameObject UI_MainRose_attack;
        public GameObject UI_RoseSkillSet;
        public GameObject Btn_FanGun;

        public UIAttackGridComponent UIAttackGrid;
        public UIFangunSkillComponent UIFangunComponet;
        public List<UISkillGridComponent> UISkillGirdList = new List<UISkillGridComponent>();
        public SkillManagerComponent SkillManagerComponent;

        public float LastLockTime;
        public float LastPickTime;
    }


    public class UIMainSkillComponentDestroySystem : DestroySystem<UIMainSkillComponent>
    {
        public override void Destroy(UIMainSkillComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.SkillCDUpdate, self);
            DataUpdateComponent.Instance.RemoveListener(DataType.SkillBeging, self);
            DataUpdateComponent.Instance.RemoveListener(DataType.SkillFinish, self);
            DataUpdateComponent.Instance.RemoveListener(DataType.JingLingButton, self);
        }
    }


    public class UIMainSkillComponentAwakeSystem : AwakeSystem<UIMainSkillComponent>
    {
        public override void Awake(UIMainSkillComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.UISkillGirdList.Clear();
            self.Btn_FanGun = rc.Get<GameObject>("Btn_FanGun");
            self.Btn_CancleSkill = rc.Get<GameObject>("Btn_CancleSkill");
            self.UI_MainRose_attack = rc.Get<GameObject>("UI_MainRose_attack");
            self.UI_RoseSkillSet = rc.Get<GameObject>("UI_RoseSkillSet");

            self.Btn_Target = rc.Get<GameObject>("Btn_Target");
            self.Btn_Target.GetComponent<Button>().onClick.AddListener(() => { self.OnLockTargetUnit(); });

            self.shiquButton = rc.Get<GameObject>("Btn_ShiQu");
            ButtonHelp.AddListenerEx(self.shiquButton, self.OnShiquItem);

            self.Button_ZhuaPu = rc.Get<GameObject>("Button_ZhuaPu");
            ButtonHelp.AddListenerEx(self.Button_ZhuaPu, self.OnButton_ZhuaPu);
            self.Button_ZhuaPu.SetActive(false);

            self.Btn_CancleSkill.SetActive(false);
            ButtonHelp.AddEventTriggers(self.Btn_CancleSkill, (PointerEventData pdata) => { self.OnEnterCancelButton(); }, EventTriggerType.PointerEnter);

            self.Btn_JingLing = rc.Get<GameObject>("Btn_JingLing");
            ButtonHelp.AddListenerEx(self.Btn_JingLing, () => { self.OnBtn_JingLing().Coroutine(); });

            //普通攻击
            OccupationConfig occConfig = OccupationConfigCategory.Instance.Get(self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Occ);
            self.UIAttackGrid = self.AddChild<UIAttackGridComponent, GameObject>(self.UI_MainRose_attack); ;

            //翻滚技能
            self.UIFangunComponet = self.AddChild<UIFangunSkillComponent, GameObject>(self.Btn_FanGun);

            //获取玩家携带的技能
            SkillSetComponent skillSetComponent = self.ZoneScene().GetComponent<SkillSetComponent>();
            for (int i = 0; i < 10; i++)
            {
                string name = "UI_MainRoseSkill_" + (i + 1);
                GameObject go = self.UI_RoseSkillSet.transform.GetChild(i).gameObject;
                UISkillGridComponent skillgrid = self.AddChild<UISkillGridComponent, GameObject>(go);
                skillgrid.SetSkillCancelHandler((bool val) => { self.ShowCancelButton(val); });
                self.UISkillGirdList.Add(skillgrid);
            }

            DataUpdateComponent.Instance.AddListener(DataType.SkillCDUpdate, self);
            DataUpdateComponent.Instance.AddListener(DataType.SkillBeging, self);
            DataUpdateComponent.Instance.AddListener(DataType.SkillFinish, self);
            DataUpdateComponent.Instance.AddListener(DataType.JingLingButton, self);
        }
    }

    public static class UIMainSkillComponentSystem
    {
        public static void CheckJingLingFunction(this UIMainSkillComponent self)
        {
            self.Btn_JingLing.SetActive(false);
            ChengJiuComponent chengJiuComponent = self.ZoneScene().GetComponent<ChengJiuComponent>();
            if (chengJiuComponent.JingLingId == 0)
            {
                return;
            }
            bool showButton = false;
            JingLingConfig jingLingConfig = JingLingConfigCategory.Instance.Get(chengJiuComponent.JingLingId);
            switch (jingLingConfig.FunctionType)
            {
                case 1:
                    showButton = chengJiuComponent.RandomDrop == 0;
                    break;
                case 7:
                    showButton = true;
                    break;
                default:
                    showButton = false;
                    break;
            }
            self.Btn_JingLing.SetActive(showButton);
        }

        public static async ETTask OnBtn_JingLing(this UIMainSkillComponent self)
        {
            ChengJiuComponent chengJiuComponent = self.ZoneScene().GetComponent<ChengJiuComponent>();
            if (chengJiuComponent.JingLingId == 0)
            {
                return;
            }
            JingLingConfig jingLingConfig = JingLingConfigCategory.Instance.Get(chengJiuComponent.JingLingId);
            switch (jingLingConfig.FunctionType)
            {
                case 1:
                    if (chengJiuComponent.RandomDrop == 1)
                    {
                        FloatTipManager.Instance.ShowFloatTip("每日只能获取一次奖励！");
                        return;
                    }
                    C2M_JingLingDropRequest  request = new C2M_JingLingDropRequest();
                    M2C_JingLingDropResponse response = (M2C_JingLingDropResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
                    chengJiuComponent.RandomDrop = 1;
                    self.CheckJingLingFunction();
                    break;
                case 7:
                    int functionId = int.Parse(jingLingConfig.FunctionValue);
                    FuntionConfig funtionConfig = FuntionConfigCategory.Instance.Get(functionId);
                    string uipath = FunctionUI.GetInstance().GetUIPath(funtionConfig.Name);
                    UIHelper.Create(self.ZoneScene(), uipath).Coroutine();
                    break;
                default:
                    break;
            }

        }

        public static void OnLockUnit(this UIMainSkillComponent self, Unit unitlock)
        {
            if (unitlock == null || unitlock.Type != UnitType.Monster)
            {
                self.Button_ZhuaPu.SetActive(false);
                return;
            }
            MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(unitlock.ConfigId);
            self.Button_ZhuaPu.SetActive(monsterConfig.MonsterSonType == 58 || monsterConfig.MonsterSonType == 59);
        }

        public static void OnButton_ZhuaPu(this UIMainSkillComponent self)
        {
            long lockTargetId = self.ZoneScene().GetComponent<LockTargetComponent>().LastLockId;
            if (lockTargetId == 0)
            {
                return;
            }
            Unit main = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            Unit target = main.GetParent<UnitComponent>().Get(lockTargetId);
            if (target == null)
            {
                return;
            }
            if (PositionHelper.Distance2D(main, target) <= 3)
            {
                self.OnArriveNpc(target);
                return;
            }

            Vector3 dir = (main.Position - target.Position).normalized;
            Vector3 position = target.Position + dir * 2f;
            self.MoveToNpc(target, position).Coroutine();
        }

        public static void OnArriveNpc(this UIMainSkillComponent self, Unit target)
        {
            if (target == null || target.IsDisposed)
            {
                return;
            }

            UIHelper.CurrentNpcId = target.ConfigId;
            UIHelper.CurrentNpcUI = UIType.UIZhuaPu;
            UI uimain = UIHelper.GetUI(self.ZoneScene(), UIType.UIMain);
            uimain.GetComponent<UIMainComponent>().JoystickMove.SetActive(false);
            CameraComponent cameraComponent = self.ZoneScene().CurrentScene().GetComponent<CameraComponent>();
            cameraComponent.SetBuildEnter(target, () => { self.OnBuildEnter().Coroutine(); });
        }

        public static async ETTask MoveToNpc(this UIMainSkillComponent self, Unit target, Vector3 position)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            if (ErrorCore.ERR_Success != unit.GetComponent<StateComponent>().CanMove())
                return;

            int ret = await unit.MoveToAsync2(position, true);
            if (ret != 0)
            {
                return;
            }
            if (PositionHelper.Distance2D(unit.Position, position) > 3f)
            {
                return;
            }
            self.OnArriveNpc(target);
        }


        public static async ETTask OnBuildEnter(this UIMainSkillComponent self)
        {
            UI uimain = UIHelper.GetUI(self.ZoneScene(), UIType.UIMain);
            uimain.GetComponent<UIMainComponent>().JoystickMove.SetActive(true);
            long lockTargetId = self.ZoneScene().GetComponent<LockTargetComponent>().LastLockId;
            if (lockTargetId == 0)
            {
                return;
            }
            Unit unit = self.ZoneScene().CurrentScene().GetComponent<UnitComponent>().Get(lockTargetId);
            if (unit == null || unit.Type!=UnitType.Monster)
            {
                return;
            }

            //创建UI
            UI ui = await UIHelper.Create(self.ZoneScene(), UIType.UIZhuaPu);
            ui.GetComponent<UIZhuaPuComponent>().OnInitUI(unit);
        }

        public static void OnShiquItem(this UIMainSkillComponent self)
        {
            if (self.ZoneScene().GetComponent<BagComponent>().GetLeftSpace() <= 0)
            {
                ErrorHelp.Instance.ErrorHint(ErrorCore.ERR_BagIsFull);
                return;
            }
            Unit main = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            if (main.GetComponent<SkillManagerComponent>().IsSkillMoveTime())
            {
                return;
            }
            List<DropInfo> ids = MapHelper.GetCanShiQu(self.ZoneScene());
            if (ids.Count > 0)
            {
                self.RequestShiQu(ids).Coroutine();
                return;
            }
            else
            {
                Unit unit = MapHelper.GetNearItem(self.ZoneScene());
                if (unit != null)
                {
                    Vector3 dir = (main.Position - unit.Position).normalized;
                    Vector3 tar = unit.Position + dir * 1f;
                    self.MoveToShiQu(tar).Coroutine();
                    return;
                }
            }

            long chestId = MapHelper.GetChestBox(self.ZoneScene());
            if (chestId != 0)
            {
                self.ZoneScene().CurrentScene().GetComponent<OperaComponent>().OnClickChest(chestId);
            }
        }

        public static async ETTask RequestShiQu(this UIMainSkillComponent self, List<DropInfo> ids)
        {
            if (Time.time - self.LastPickTime < 1f)
            {
                return;
            }

            self.LastPickTime = Time.time;
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            if (!unit.GetComponent<MoveComponent>().IsArrived())
            {
                self.ZoneScene().GetComponent<SessionComponent>().Session.Send(new C2M_Stop());
            }

            unit.GetComponent<FsmComponent>().ChangeState(FsmStateEnum.FsmShiQuItem);
            MapHelper.SendShiquItem(self.ZoneScene(), ids).Coroutine();

            unit.GetComponent<StateComponent>().SetNetWaitEndTime(TimeHelper.ClientNow() + 200);
            await TimerComponent.Instance.WaitAsync(200);
            unit.GetComponent<FsmComponent>().ChangeState(FsmStateEnum.FsmIdleState);
        }

        public static async ETTask MoveToShiQu(this UIMainSkillComponent self, Vector3 position)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            int value = await unit.MoveToAsync2(position, true);
            List<DropInfo> ids = MapHelper.GetCanShiQu(self.ZoneScene());
            if (value == 0 && ids.Count > 0)
            {
                self.RequestShiQu(ids).Coroutine();
            }
        }


        public static void OnSkillBeging(this UIMainSkillComponent self, string dataParams)
        { 
            int skillId = int.Parse(dataParams);
            for (int i = 0; i < self.UISkillGirdList.Count; i++)
            {
                if (self.UISkillGirdList[i].SkillPro==null)
                {
                    continue;
                }
                if (self.UISkillGirdList[i].SkillPro.SkillID == skillId)
                {
                    self.UISkillGirdList[i].Button_Cancle.SetActive(true);
                }
            }
        }

        public static void OnSkillFinish(this UIMainSkillComponent self, string dataParams)
        {
            int skillId = int.Parse(dataParams);
            for (int i = 0; i < self.UISkillGirdList.Count; i++)
            {
                if (self.UISkillGirdList[i].SkillPro == null)
                {
                    continue;
                }
                if (self.UISkillGirdList[i].SkillPro.SkillID == skillId)
                {
                    self.UISkillGirdList[i].Button_Cancle.SetActive(false);
                }
            }
        }

        public static void OnSkillCDUpdate(this UIMainSkillComponent self)
        {
            if (self.SkillManagerComponent == null)
            {
                Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
                self.SkillManagerComponent = unit.GetComponent<SkillManagerComponent>();
            }
            long serverTime = TimeHelper.ServerNow();
            for (int i = 0; i < self.UISkillGirdList.Count; i++)
            {
                UISkillGridComponent uISkillGridComponent = self.UISkillGirdList[i];
                uISkillGridComponent.OnUpdate(self.SkillManagerComponent.GetCdTime(uISkillGridComponent.GetSkillId(), serverTime), 
                                              self.SkillManagerComponent.SkillPublicCDTime - serverTime);
            }
            self.UIFangunComponet.OnUpdate(self.SkillManagerComponent.GetCdTime(self.UIFangunComponet.SkillId, serverTime));
        }

        public static void OnEnterScene(this UIMainSkillComponent self, Unit unit)
        {
            self.SkillManagerComponent = unit.GetComponent<SkillManagerComponent>();
            self.OnSkillCDUpdate();
            self.CheckJingLingFunction();
        }

        public static void ResetUI(this UIMainSkillComponent self)
        {
            for (int i = 0; i < self.UISkillGirdList.Count; i++)
            {
                UISkillGridComponent uISkillGridComponent = self.UISkillGirdList[i];
                uISkillGridComponent.OnUpdate(0,0);
                uISkillGridComponent.UseSkill = false;
            }
            self.UIFangunComponet.OnUpdate(0);
        }

        public static void OnLockTargetUnit(this UIMainSkillComponent self)
        {
            LockTargetComponent lockTargetComponent = self.ZoneScene().GetComponent<LockTargetComponent>();
            if (Time.time - self.LastLockTime > 5)
            {
                lockTargetComponent.LastLockId = 0;
                lockTargetComponent.LockTargetUnit(true);
                self.LastLockTime = Time.time;
            }
            else
            {
                lockTargetComponent.LockTargetUnit();
            }
        }

        public static void ShowCancelButton(this UIMainSkillComponent self, bool show)
        {
            self.Btn_CancleSkill.SetActive(show);
        }

        public static void OnEnterCancelButton(this UIMainSkillComponent self)
        {
            FloatTipManager.Instance.ShowFloatTip("取消技能施法");

            for (int i = 0; i < self.UISkillGirdList.Count; i++)
            {
                self.UISkillGirdList[i].OnEnterCancelButton();
            }
        }

        public static void OnBagItemUpdate(this UIMainSkillComponent self)
        {
            for (int i = 0; i < self.UISkillGirdList.Count; i++)
            {
                self.UISkillGirdList[i].UpdateItemNumber();
            }
        }

        public static void OnSkillSetUpdate(this UIMainSkillComponent self)
        {
            SkillSetComponent skillSetComponent = self.ZoneScene().GetComponent<SkillSetComponent>();
            for (int i = 0; i < 10; i++)
            {
                UISkillGridComponent skillgrid = self.UISkillGirdList[i];
                SkillPro skillid = skillSetComponent.GetByPosition(i + 1);
                skillgrid.UpdateSkillInfo(skillid);
            }
        }
    }
}
