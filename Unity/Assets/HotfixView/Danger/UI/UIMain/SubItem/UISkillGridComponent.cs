using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ET
{

    [ObjectSystem]
    public class UISkillButtonComponentAwakeSystem : AwakeSystem<UISkillGridComponent, GameObject>
    {
        public override void Awake(UISkillGridComponent self, GameObject gameObjectnt)
        {
            self.Awake(gameObjectnt);
        }
    }

    public class UISkillGridComponent : Entity, IAwake, IAwake<GameObject>
    {
        public GameObject SkillDi;
        public GameObject Btn_SkillStart;
        public GameObject Img_SkillIcon;
        public GameObject Text_SkillItemNum;
        public Image Img_SkillCD;
        public Text Text_SkillCD;
        public Image Img_PublicSkillCD;
        public GameObject Img_Mask;

        public SkillConfig SkillWuqiConfig;
        public SkillConfig SkillBaseConfig;

        public bool UseSkill;
        public bool CancelSkill;
        public SkillPro skillPro;
        public Action<bool> SkillCancelHandler;

        public void Awake(GameObject gameObject)
        {
            this.SkillDi = gameObject.transform.Find("SkillDi").gameObject;
            this.Btn_SkillStart = gameObject.transform.Find("Btn_SkillStart").gameObject;
            this.Img_SkillIcon = gameObject.transform.Find("Img_Mask/Img_SkillIcon").gameObject;
            this.Text_SkillItemNum = gameObject.transform.Find("Text_SkillItemNum").gameObject;
            this.Img_SkillCD = gameObject.transform.Find("Img_SkillCD").gameObject.GetComponent<Image>();
            this.Text_SkillCD = gameObject.transform.Find("Text_SkillCD").gameObject.GetComponent<Text>();
            this.Img_PublicSkillCD = gameObject.transform.Find("Img_PublicSkillCD").gameObject.GetComponent<Image>();
            this.Img_Mask = gameObject.transform.Find("Img_Mask").gameObject;
            //this.BackIcon = gameObject.transform.Find("BackIcon").gameObject;

            ButtonHelp.AddEventTriggers(this.Btn_SkillStart, (PointerEventData pdata) => { this.Draging(pdata); }, EventTriggerType.Drag);
            ButtonHelp.AddEventTriggers(this.Btn_SkillStart, (PointerEventData pdata) => { this.EndDrag(pdata); }, EventTriggerType.EndDrag);
            ButtonHelp.AddEventTriggers(this.Btn_SkillStart, (PointerEventData pdata) => { this.OnPointDown(pdata); }, EventTriggerType.PointerDown);
            ButtonHelp.AddEventTriggers(this.Btn_SkillStart, (PointerEventData pdata) => { this.PointerUp(pdata); }, EventTriggerType.PointerUp);
            ButtonHelp.AddEventTriggers(this.Btn_SkillStart, (PointerEventData pdata) => { this.OnCancel(pdata); }, EventTriggerType.Cancel);
        }
    }

    public static class UISkillGridComponentSystem
    {

        public static void OnCancel(this UISkillGridComponent self, PointerEventData eventData)
        {
        }

        public static int GetSkillId(this UISkillGridComponent self)
        {
            return self.SkillBaseConfig != null ? self.SkillBaseConfig.Id : 0;
        }

        public static void OnUpdate(this UISkillGridComponent self, long leftCDTime, long pulicCd)
        { 
            //显示冷却CD
            if (leftCDTime > 0)
            {
                int showCostTime = (int)(leftCDTime / 1000) + 1;
                self.Text_SkillCD.text = showCostTime.ToString();
                float proValue = (float)leftCDTime / ((float)self.SkillBaseConfig.SkillCD * 1000f);
                self.Img_SkillCD.fillAmount = proValue;
            }
            else
            {
                self.Img_SkillCD.fillAmount = 0f;
                self.Text_SkillCD.text = string.Empty;
            }

            //显示公共CD
            if (pulicCd > 0)
            {
                float proValue = (float)(pulicCd / 1000f);     //1秒公共CD
                self.Img_PublicSkillCD.fillAmount = proValue;
            }
            else
            {
                self.Img_PublicSkillCD.fillAmount = 0f;
            }
        }

        public static void Draging(this UISkillGridComponent self, PointerEventData eventData)
        {
            if (self.IfShowSkillZhishi() == false || !self.UseSkill)
            {
                return;
            }
            self.ZoneScene().GetComponent<SkillIndicatorComponent>().OnMouseDrag(eventData.delta);
        }

        public static void SetSkillCancelHandler(this UISkillGridComponent self, Action<bool> action)
        {
            self.SkillCancelHandler = action;
        }

        public static void EndDrag(this UISkillGridComponent self, PointerEventData eventData)
        {
            self.SkillCancelHandler(false);
            if (self.IfShowSkillZhishi() == false || !self.UseSkill)
            {
                return;
            }
            self.UseSkill = false;
            self.SendUseSkill(self.GetTargetAngle(), self.GetTargetDistance());
            self.ZoneScene().GetComponent<SkillIndicatorComponent>().RecoveryEffect();
        }

        /// <summary>
        /// 0  立即释放,自身中心点
        /// 1  技能指示器
        /// 2  立即释放,目标中心点[需要传目标ID]
        /// </summary>
        /// <returns></returns>
        public static bool IfShowSkillZhishi(this UISkillGridComponent self)
        {
            if (self.SkillWuqiConfig == null)
                return false;
            return self.SkillWuqiConfig.SkillZhishiType > 0;
        }

        public static void SendUseSkill(this UISkillGridComponent self, int angle, float distance)
        {
            self.SkillCancelHandler(false);
            if (self.CancelSkill)
            {
                return;
            }

            Unit myUnit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            long targetId = self.ZoneScene().GetComponent<LockTargetComponent>().LastLockId;
            if (self.SkillWuqiConfig.SkillTargetType == (int)SkillTargetType.TargetOnly)
            {
                Unit targetUnit = null;
                if (targetId != 0)
                {
                    UnitComponent unitComponent = self.DomainScene().CurrentScene().GetComponent<UnitComponent>();
                    targetUnit = unitComponent.Get(targetId);

                    if (targetUnit == null)
                    {
                        FloatTipManager.Instance.ShowFloatTip("请选中施法目标");
                        return;
                    }
                    if (PositionHelper.Distance2D(targetUnit, myUnit) >= self.SkillWuqiConfig.SkillRangeSize)
                    {
                        FloatTipManager.Instance.ShowFloatTip("距离过远!");
                        return;
                    }
                }
                if (targetId == 0)
                {
                    targetUnit = MapHelper.GetNearestUnit(myUnit);
                    if (targetUnit == null)
                    {
                        FloatTipManager.Instance.ShowFloatTip("请选中施法目标");
                        return;
                    }
                    if (targetUnit != null && PositionHelper.Distance2D(targetUnit, myUnit) >= self.SkillWuqiConfig.SkillRangeSize)
                    {
                        FloatTipManager.Instance.ShowFloatTip("请选中施法目标");
                        return;
                    }
                    targetId = targetUnit.Id;
                }
                Vector3 direction = targetUnit.Position - myUnit.Position;
                angle = Mathf.FloorToInt(Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg);
            }

            EventType.BeforeSkill.Instance.ZoneScene = self.ZoneScene();
            EventSystem.Instance.PublishClass(EventType.BeforeSkill.Instance);
            if (self.skillPro.SkillSetType == (int)SkillSetEnum.Skill)
            {
                myUnit.GetComponent<SkillManagerComponent>().SendUseSkill(self.SkillBaseConfig.Id, 0, angle,  targetId, distance).Coroutine();
            }
            else
            {
                BagInfo bagInfo = self.ZoneScene().GetComponent<BagComponent>().GetBagInfo(self.skillPro.SkillID);
                if (bagInfo == null)
                {
                    return;
                }
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(self.skillPro.SkillID);
                myUnit.GetComponent<SkillManagerComponent>().SendUseSkill(int.Parse(itemConfig.ItemUsePar), self.skillPro.SkillID, angle, targetId, distance).Coroutine();
            }
        }

        public static void PointerUp(this UISkillGridComponent self, PointerEventData eventData)
        {
            if (!self.UseSkill)
            {
                return;
            }
            self.UseSkill = false;
            self.SendUseSkill(self.GetTargetAngle(), self.GetTargetDistance());
            self.ZoneScene().GetComponent<SkillIndicatorComponent>().RecoveryEffect();
        }

        public static void OnPointDown(this UISkillGridComponent self, PointerEventData eventData)
        {
            if (self.SkillBaseConfig == null)
            {
                return;
            }
            self.CancelSkill = false;
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            if (!self.IfShowSkillZhishi())
            {
                self.UseSkill = false;
                self.SkillCancelHandler(false);
                self.SendUseSkill((int)unit.Rotation.eulerAngles.y, 0);
                self.ZoneScene().GetComponent<SkillIndicatorComponent>().RecoveryEffect();
                return;
            }
            
            self.UseSkill = true;
            self.SkillCancelHandler(true);
            Scene zoneScene = self.ZoneScene();
            zoneScene.GetComponent<SkillIndicatorComponent>().ShowSkillIndicator(self.SkillWuqiConfig);
            zoneScene.GetComponent<SkillIndicatorComponent>().OnMouseDown(zoneScene.GetComponent<LockTargetComponent>().LastLockId);
        }

        public static int GetTargetAngle(this UISkillGridComponent self)
        {
            return self.ZoneScene().GetComponent<SkillIndicatorComponent>().GetIndicatorAngle();
        }

        //X100
        public static float GetTargetDistance(this UISkillGridComponent self)
        {
            return self.ZoneScene().GetComponent<SkillIndicatorComponent>().GetIndicatorDistance();
        }

        public static void OnEnterCancelButton(this UISkillGridComponent self)
        {
            self.CancelSkill = true;
        }

        public static void UpdateItemNumber(this UISkillGridComponent self)
        {
            self.Text_SkillItemNum.SetActive(false);
            if (self.skillPro == null)
            {
                return;
            }
            if (self.skillPro.SkillSetType!= (int)SkillSetEnum.Item)
            {
                return;
            }
            long number = self.ZoneScene().GetComponent<BagComponent>().GetItemNumber(self.skillPro.SkillID);
            self.Text_SkillItemNum.SetActive(true);
            self.Text_SkillItemNum.GetComponent<Text>().text = number.ToString();

            UICommonHelper.SetImageGray( self.SkillDi.gameObject, number==0);
            UICommonHelper.SetImageGray( self.Img_SkillIcon.gameObject, number == 0);
        }

        public static void UpdateSkillInfo(this UISkillGridComponent self , SkillPro skillpro)
        {
            self.skillPro = skillpro;
            self.UpdateItemNumber();
            if (skillpro == null)
            {
                self.SkillWuqiConfig = null;
                self.SkillBaseConfig = null;
                self.skillPro = null;
                self.Img_PublicSkillCD.fillAmount = 0;
                self.Img_SkillIcon.SetActive(false);
                self.Img_Mask.SetActive(false);
                return;
            }
            if (skillpro.SkillSetType == (int)SkillSetEnum.Skill)
            {
                BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
                SkillConfig skillConfig = SkillConfigCategory.Instance.Get(SkillHelp.GetWeaponSkill(skillpro.SkillID, bagComponent.GetEquipType()));
                Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.RoleSkillIcon, skillConfig.SkillIcon);
                self.Img_SkillIcon.GetComponent<Image>().sprite = sp;

                self.SkillWuqiConfig = skillConfig;
                self.SkillBaseConfig = SkillConfigCategory.Instance.Get(skillpro.SkillID);
            }
            else
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(skillpro.SkillID);
                int skillId = int.Parse(itemConfig.ItemUsePar);

                self.SkillWuqiConfig = SkillConfigCategory.Instance.Get(skillId);
                self.SkillBaseConfig = self.SkillWuqiConfig;
                Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.ItemIcon, itemConfig.Icon);
                self.Img_SkillIcon.GetComponent<Image>().sprite = sp;
            }
            self.Img_SkillIcon.SetActive(true);
            self.Img_Mask.SetActive(true);
        }
    }
}
