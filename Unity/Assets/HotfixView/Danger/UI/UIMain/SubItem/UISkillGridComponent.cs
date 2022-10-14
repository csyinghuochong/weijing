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
        public GameObject Img_SkillCD;
        public GameObject Text_SkillCD;
        public GameObject Img_PublicSkillCD;
        public GameObject Img_Mask;
        public GameObject BackIcon;

        public SkillConfig SkillWuqiConfig;
        public SkillConfig SkillBaseConfig;

        public SkillPro skillPro;
        public bool UseSkill;
        public bool CancelSkill;
        public Camera UIcam;
        public Action<bool> SkillCancelHandler;

        public void Awake(GameObject gameObject)
        {
            this.UIcam = GameObject.Find("Global/UI/UICamera").GetComponent<Camera>();
          
            this.SkillDi = gameObject.transform.Find("SkillDi").gameObject;
            this.Btn_SkillStart = gameObject.transform.Find("Btn_SkillStart").gameObject;
            this.Img_SkillIcon = gameObject.transform.Find("Img_SkillIcon").gameObject;
            this.Text_SkillItemNum = gameObject.transform.Find("Text_SkillItemNum").gameObject;
            this.Img_SkillCD = gameObject.transform.Find("Img_SkillCD").gameObject;
            this.Text_SkillCD = gameObject.transform.Find("Text_SkillCD").gameObject;
            this.Img_PublicSkillCD = gameObject.transform.Find("Img_PublicSkillCD").gameObject;
            this.Img_Mask = gameObject.transform.Find("Img_Mask").gameObject;
            this.BackIcon = gameObject.transform.Find("BackIcon").gameObject;

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
            Log.Debug("OnPointerOnCancel");
        }

        public static void ResetUI(this UISkillGridComponent self)
        {
            self.Text_SkillCD.SetActive(false);
            self.Img_SkillCD.SetActive(false);
        }

        public static int GetSkillId(this UISkillGridComponent self)
        {
            return self.SkillBaseConfig != null ? self.SkillBaseConfig.Id : 0;
        }

        public static void OnUpdate(this UISkillGridComponent self, long leftCDTime, long publicCDTime)
        {
            long nowTime = TimeHelper.ClientNow();
            
            if (leftCDTime <= 0)
            {
                self.Text_SkillCD.SetActive(false);
                self.Img_SkillCD.SetActive(false);
            }
            else
            {
                //显示冷却CD
                int showCostTime = (int)(leftCDTime / 1000) + 1;
                self.Text_SkillCD.GetComponent<Text>().text = showCostTime.ToString();
                float proValue = (float)leftCDTime / (self.SkillBaseConfig.SkillCD * 1000f);
                //Log.Info("proValue = " + proValue + "costTime = " + costTime + "cd：" + SkillConfig.SkillCD);
                self.Img_SkillCD.GetComponent<Image>().fillAmount = proValue;
                self.Text_SkillCD.SetActive(true);
                self.Img_SkillCD.SetActive(true);
            }
            //显示公共CD
            if (nowTime < publicCDTime)
            {
                long costTime = publicCDTime - nowTime;
                float proValue = (float)costTime / (1 * 1000f);     //1秒公共CD
                self.Img_PublicSkillCD.GetComponent<Image>().fillAmount = proValue;
                self.Img_PublicSkillCD.SetActive(true);
            }
            else
            {
                self.Img_PublicSkillCD.SetActive(false);
            }
        }

        public static void Draging(this UISkillGridComponent self, PointerEventData eventData)
        {
            if (self.IfShowSkillZhishi() == false)
            {
                return;
            }
            self.ZoneScene().CurrentScene().GetComponent<SkillIndicatorComponent>().OnMouseDrag(eventData.delta);
        }

        public static void SetSkillCancelHandler(this UISkillGridComponent self, Action<bool> action)
        {
            self.SkillCancelHandler = action;
        }

        public static void EndDrag(this UISkillGridComponent self, PointerEventData eventData)
        {
            self.SkillCancelHandler(false);
            if (!self.UseSkill)
                return;
            if (self.IfShowSkillZhishi() == false)
                return;

            self.UseSkill = false;
            self.SendUseSkill(self.GetTargetAngle(), self.GetTargetDistance());
            self.ZoneScene().CurrentScene().GetComponent<SkillIndicatorComponent>().ClearnsShow();
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
                return;
            long targetId = self.DomainScene().CurrentScene().GetComponent<LockTargetComponent>().LastLockId;
            if (self.SkillWuqiConfig.SkillTargetType == (int)SkillTargetType.TargetOnly)
            {
                Unit nearest = null;
                Unit myUnit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
                if (targetId != 0)
                {
                    UnitComponent unitComponent = self.DomainScene().CurrentScene().GetComponent<UnitComponent>();
                    nearest = unitComponent.Get(targetId);
                    if (PositionHelper.Distance2D(nearest, myUnit) >= self.SkillWuqiConfig.SkillRangeSize)
                    {
                        FloatTipManager.Instance.ShowFloatTip("距离过远!");
                        return;
                    }
                }
                if (targetId == 0)
                {
                    nearest = MapHelper.GetNearestUnit(myUnit);
                    if (nearest == null)
                    {
                        FloatTipManager.Instance.ShowFloatTip("请选中施法目标");
                        return;
                    }
                    if (nearest != null && PositionHelper.Distance2D(nearest, myUnit) >= self.SkillWuqiConfig.SkillRangeSize)
                    {
                        FloatTipManager.Instance.ShowFloatTip("请选中施法目标");
                        return;
                    }
                    targetId = nearest.Id;
                }
            }

            UI uimain = UIHelper.GetUI(self.ZoneScene(), UIType.UIMain);
            uimain.GetComponent<UIMainComponent>().OnSpellStart();
            if (self.skillPro.SkillSetType == (int)SkillSetEnum.Skill)
            {
                MapHelper.SendUseSkill(self.DomainScene(), self.SkillBaseConfig.Id, 0, angle,  targetId, distance).Coroutine();
            }
            else
            {
                BagInfo bagInfo = self.ZoneScene().GetComponent<BagComponent>().GetBagInfo(self.skillPro.SkillID);
                if (bagInfo == null)
                {
                    return;
                }
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(self.skillPro.SkillID);
                MapHelper.SendUseSkill(self.DomainScene(), int.Parse(itemConfig.ItemUsePar), self.skillPro.SkillID, angle, targetId, distance).Coroutine();
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
            self.ZoneScene().CurrentScene().GetComponent<SkillIndicatorComponent>().ClearnsShow();
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
                self.ZoneScene().CurrentScene().GetComponent<SkillIndicatorComponent>().ClearnsShow();
                return;
            }
            
            self.UseSkill = true;
            self.SkillCancelHandler(true);
            Scene curscene = self.ZoneScene().CurrentScene();
            curscene.GetComponent<SkillIndicatorComponent>().ShowSkillIndicator(self.SkillWuqiConfig);
            curscene.GetComponent<SkillIndicatorComponent>().OnMouseDown(curscene.GetComponent<LockTargetComponent>().LastLockId);
        }

        public static int GetTargetAngle(this UISkillGridComponent self)
        {
            return self.ZoneScene().CurrentScene().GetComponent<SkillIndicatorComponent>().GetIndicatorAngle();
        }

        //X100
        public static float GetTargetDistance(this UISkillGridComponent self)
        {
            return self.ZoneScene().CurrentScene().GetComponent<SkillIndicatorComponent>().GetIndicatorDistance();
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
                self.Img_PublicSkillCD.SetActive(false);
                self.Img_SkillIcon.SetActive(false);
                self.BackIcon.SetActive(false);
                self.Img_Mask.SetActive(false);
                return;
            }
            if (skillpro.SkillSetType == (int)SkillSetEnum.Skill)
            {
                BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
                SkillConfig skillConfig = SkillConfigCategory.Instance.Get(SkillHelp.GetWeaponSkillID(skillpro.SkillID, bagComponent.GetEquipType()));
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
            UICommonHelper.SetParent(self.Img_SkillIcon, self.Img_Mask);
            self.Img_SkillIcon.SetActive(true);
            self.BackIcon.SetActive(true);
            self.Img_Mask.SetActive(true);
        }
    }
}
