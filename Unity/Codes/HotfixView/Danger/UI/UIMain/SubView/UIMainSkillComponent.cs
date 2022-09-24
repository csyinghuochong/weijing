using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ET
{

    [Timer(TimerType.UIMainSkill)]
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

        public UI UIFangunComponet;
        public UI UIAttackGrid;
        public List<UI> UISkillGirdList = new List<UI>();
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
            UI uiattackButton = self.AddChild<UI, string, GameObject>("UI_MainRose_attack", self.UI_MainRose_attack);
            uiattackButton.AddComponent<UIAttackGridComponent>();
            OccupationConfig occConfig = OccupationConfigCategory.Instance.Get(self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Occ);
            uiattackButton.GetComponent<UIAttackGridComponent>().UpdateSkillInfo(occConfig.InitActSkillID);
            self.UIAttackGrid = uiattackButton;

            //翻滚技能
            UI uiFangun = self.AddChild<UI, string, GameObject>("FanGunSkill", self.Btn_FanGun);
            uiFangun.AddComponent<UIFangunSkillComponent>();
            self.UIFangunComponet = uiFangun;

            //获取玩家携带的技能
            SkillSetComponent skillSetComponent = self.ZoneScene().GetComponent<SkillSetComponent>();
            for (int i = 0; i < UIMainEvent.SkillButtonNumber; i++)
            {
                string name = "UI_MainRoseSkill_" + (i + 1);
                GameObject go = self.UI_RoseSkillSet.transform.GetChild(i).gameObject;
                UI uiskillButton = self.AddChild<UI, string, GameObject>(name, go);
                UISkillGridComponent skillgrid = uiskillButton.AddComponent<UISkillGridComponent, int>(i);
                skillgrid.SetSkillCancelHandler((bool val) => { self.ShowCancelButton(val); });
                self.UISkillGirdList.Add(uiskillButton);
            }


        }
    }

    public static class SubMainSkillComponentSystem
    {
        public static void OnUseSkill(this UIMainSkillComponent self)
        {
            if (self.Timer == 0)
            {
                self.Timer = TimerComponent.Instance.NewFrameTimer(TimerType.UIMainSkill, self);
            }
        }

        public static void OnUpdate(this UIMainSkillComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            SkillManagerComponent skillManagerComponent = unit.GetComponent<SkillManagerComponent>();

            long serverTime = TimeHelper.ServerNow();
            for (int i = 0; i < self.UISkillGirdList.Count; i++)
            {
                UISkillGridComponent uISkillGridComponent = self.UISkillGirdList[i].GetComponent<UISkillGridComponent>();
                uISkillGridComponent.OnUpdate(skillManagerComponent.GetCdTime(uISkillGridComponent.GetSkillId(), serverTime), skillManagerComponent.SkillPublicCDTime);
            }
            //UIFangunSkillComponent uIFangunSkillComponent = self.UIFangunComponet.GetComponent<UIFangunSkillComponent>();
            //uIFangunSkillComponent.OnUpdate(skillManagerComponent.GetCdTime(uIFangunSkillComponent.SkillId));

            if (skillManagerComponent.SkillCDs.Count == 0 && TimeHelper.ClientNow() > skillManagerComponent.SkillPublicCDTime)
            {
                TimerComponent.Instance?.Remove(ref self.Timer);
            }
        }

        public static void OnExitBattle(this UIMainSkillComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }

        public static void ResetUI(this UIMainSkillComponent self, bool reset)
        {
            if (!reset)
            {
                return;
            }
            for (int i = 0; i < self.UISkillGirdList.Count; i++)
            {
                self.UISkillGirdList[i].GetComponent<UISkillGridComponent>().ResetUI();
            }
        }

        public static void OnLockTargetUnit(this UIMainSkillComponent self)
        {
            LockTargetComponent lockTargetComponent = self.ZoneScene().CurrentScene().GetComponent<LockTargetComponent>();
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
                self.UISkillGirdList[i].GetComponent<UISkillGridComponent>().OnEnterCancelButton();
            }
        }

        public static void OnBagItemUpdate(this UIMainSkillComponent self)
        {
            for (int i = 0; i < self.UISkillGirdList.Count; i++)
            {
                self.UISkillGirdList[i].GetComponent<UISkillGridComponent>().UpdateItemNumber();
            }
        }

        public static void OnSkillSetUpdate(this UIMainSkillComponent self)
        {
            SkillSetComponent skillSetComponent = self.ZoneScene().GetComponent<SkillSetComponent>();
            for (int i = 0; i < UIMainEvent.SkillButtonNumber; i++)
            {
                UISkillGridComponent skillgrid = self.UISkillGirdList[i].GetComponent<UISkillGridComponent>();
                SkillPro skillid = skillSetComponent.GetByPosition(i + 1);
                skillgrid.UpdateSkillInfo(skillid);
            }
            self.UIAttackGrid.GetComponent<UIAttackGridComponent>().UpdateComboTime();
        }

    }
}
