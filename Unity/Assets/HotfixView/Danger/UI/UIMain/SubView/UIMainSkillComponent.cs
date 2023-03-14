using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ET
{
    public class UIMainSkillComponent : Entity, IAwake, IDestroy
    {
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

        public float LockTime;
    }

    [ObjectSystem]
    public class UIMainSkillComponentDestroySystem : DestroySystem<UIMainSkillComponent>
    {
        public override void Destroy(UIMainSkillComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.SkillCDUpdate, self);
            DataUpdateComponent.Instance.RemoveListener(DataType.SkillBeging, self);
            DataUpdateComponent.Instance.RemoveListener(DataType.SkillFinish, self);
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

            self.shiquButton = rc.Get<GameObject>("Btn_ShiQu");
            ButtonHelp.AddListenerEx(self.shiquButton, self.OnShiquItem);

            self.Button_ZhuaPu = rc.Get<GameObject>("Button_ZhuaPu");
            ButtonHelp.AddListenerEx(self.Button_ZhuaPu, self.OnButton_ZhuaPu);
            self.Button_ZhuaPu.SetActive(false);

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

            DataUpdateComponent.Instance.AddListener(DataType.SkillCDUpdate, self);
            DataUpdateComponent.Instance.AddListener(DataType.SkillBeging, self);
            DataUpdateComponent.Instance.AddListener(DataType.SkillFinish, self);
        }
    }

    public static class UIMainSkillComponentSystem
    {

        public static void OnButton_ZhuaPu(this UIMainSkillComponent self)
        {
            Log.Debug("111");
        }

        public static void OnShiquItem(this UIMainSkillComponent self)
        {
            if (self.ZoneScene().GetComponent<BagComponent>().GetLeftSpace() == 0)
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
            if (Time.time - self.LockTime > 5)
            {
                lockTargetComponent.LastLockId = 0;
                lockTargetComponent.LockTargetUnit(true);
                self.LockTime = Time.time;
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
            for (int i = 0; i < UIMainEvent.SkillButtonNumber; i++)
            {
                UISkillGridComponent skillgrid = self.UISkillGirdList[i];
                SkillPro skillid = skillSetComponent.GetByPosition(i + 1);
                skillgrid.UpdateSkillInfo(skillid);
            }
        }
    }
}
