using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ET
{

    [Timer(TimerType.MainSkillTimer)]
    public class UIMainSkillTimer : ATimer<UIMainSkillComponent>
    {
        public override void Run(UIMainSkillComponent self)
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

    public class UIMainSkillComponent : Entity, IAwake, IDestroy
    {
        public GameObject Btn_Target;
        public GameObject Btn_CancleSkill;
        public GameObject UI_MainRose_attack;
        public GameObject UI_RoseSkillSet;
        public GameObject Btn_FanGun;

        public UIAttackGridComponent UIAttackGrid;
        public UIFangunSkillComponent UIFangunComponet;
        public List<UISkillGridComponent> UISkillGirdList = new List<UISkillGridComponent>();
        public long Timer;
    }

    [ObjectSystem]
    public class UIMainSkillComponentDestroySystem : DestroySystem<UIMainSkillComponent>
    {
        public override void Destroy(UIMainSkillComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }

    [ObjectSystem]
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

            self.Btn_CancleSkill.SetActive(false);
            ButtonHelp.AddEventTriggers(self.Btn_CancleSkill, (PointerEventData pdata) => { self.OnEnterCancelButton(); }, EventTriggerType.PointerEnter);

            //普通攻击
            OccupationConfig occConfig = OccupationConfigCategory.Instance.Get(self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Occ);
            self.UIAttackGrid = self.AddChild<UIAttackGridComponent, GameObject>(self.UI_MainRose_attack); ;

            //翻滚技能
            self.UIFangunComponet = self.AddChild<UIFangunSkillComponent, GameObject>(self.Btn_FanGun);

            //获取玩家携带的技能
            SkillSetComponent skillSetComponent = self.ZoneScene().GetComponent<SkillSetComponent>();
            for (int i = 0; i < UIMainEvent.SkillButtonNumber; i++)
            {
                string name = "UI_MainRoseSkill_" + (i + 1);
                GameObject go = self.UI_RoseSkillSet.transform.GetChild(i).gameObject;
                UISkillGridComponent skillgrid = self.AddChild<UISkillGridComponent, GameObject>(go);
                skillgrid.SetSkillCancelHandler((bool val) => { self.ShowCancelButton(val); });
                self.UISkillGirdList.Add(skillgrid);
            }


        }
    }

    public static class UIMainSkillComponentSystem
    {
        public static void OnUseSkill(this UIMainSkillComponent self)
        {
            if (self.Timer == 0)
            {
                self.Timer = TimerComponent.Instance.NewFrameTimer(TimerType.MainSkillTimer, self);
            }
        }

        public static void OnUpdate(this UIMainSkillComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            SkillManagerComponent skillManagerComponent = unit.GetComponent<SkillManagerComponent>();

            long serverTime = TimeHelper.ServerNow();
            for (int i = 0; i < self.UISkillGirdList.Count; i++)
            {
                UISkillGridComponent uISkillGridComponent = self.UISkillGirdList[i];
                uISkillGridComponent.OnUpdate(skillManagerComponent.GetCdTime(uISkillGridComponent.GetSkillId(), serverTime), skillManagerComponent.SkillPublicCDTime);
            }
            self.UIFangunComponet.OnUpdate(skillManagerComponent.GetCdTime(self.UIFangunComponet.SkillId, serverTime));

            if (skillManagerComponent.SkillCDs.Count == 0 && TimeHelper.ClientNow() > skillManagerComponent.SkillPublicCDTime)
            {
                TimerComponent.Instance?.Remove(ref self.Timer);
            }
        }

        public static void OnExitBattle(this UIMainSkillComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }

        public static void CancelSkill(this UIMainSkillComponent self)
        {
            for (int i = 0; i < self.UISkillGirdList.Count; i++)
            {
                self.UISkillGirdList[i].UseSkill = false;
            }
        }

        public static void ResetUI(this UIMainSkillComponent self, bool reset)
        {
            if (!reset)
            {
                return;
            }
            for (int i = 0; i < self.UISkillGirdList.Count; i++)
            {
                self.UISkillGirdList[i].ResetUI();
            }
        }

        public static void OnLockTargetUnit(this UIMainSkillComponent self)
        {
            LockTargetComponent lockTargetComponent = self.ZoneScene().GetComponent<LockTargetComponent>();
            lockTargetComponent.LockTargetUnit();

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
            for (int i = 0; i < UIMainEvent.SkillButtonNumber; i++)
            {
                UISkillGridComponent skillgrid = self.UISkillGirdList[i];
                SkillPro skillid = skillSetComponent.GetByPosition(i + 1);
                skillgrid.UpdateSkillInfo(skillid);
            }
        }
    }
}
