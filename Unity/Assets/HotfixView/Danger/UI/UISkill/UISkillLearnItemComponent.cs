using System;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UISkillLearnItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject ButtonUp;
        public GameObject ButtonLearn;
        public GameObject Text_Desc;
        public GameObject Img_XuanZhong;
        public GameObject Img_Button;
        public GameObject Text_LearnLv;
        public GameObject Node_1;
        public GameObject Lab_SkillLv;
        public GameObject Lab_SkillName;
        public GameObject Img_SkillIcon;
        public GameObject ButtonMax;
        public GameObject Lab_NeedSp;
        public GameObject GameObject;

        public SkillPro SkillPro;
        public Action<SkillPro> ClickHandler;
    }

    [ObjectSystem]
    public class UISkillLearnItemComponentAwakeSystem : AwakeSystem<UISkillLearnItemComponent, GameObject>
    {
        public override void Awake(UISkillLearnItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.Img_XuanZhong = rc.Get<GameObject>("Img_XuanZhong");
            self.Img_Button = rc.Get<GameObject>("Img_Button");
            self.Text_LearnLv = rc.Get<GameObject>("Text_LearnLv");
            self.Node_1 = rc.Get<GameObject>("Node_1");
            self.Lab_SkillLv = rc.Get<GameObject>("Lab_SkillLv");
            self.Lab_SkillName = rc.Get<GameObject>("Lab_SkillName");
            self.Img_SkillIcon = rc.Get<GameObject>("Img_SkillIcon");
            self.Text_Desc = rc.Get<GameObject>("Text_Desc");
            self.ButtonMax = rc.Get<GameObject>("ButtonMax");
            self.Lab_NeedSp = rc.Get<GameObject>("Lab_NeedSp");

            self.Img_Button.GetComponent<Button>().onClick.AddListener(() =>
            {
                self.OnImg_Button();
            });

            self.ButtonUp = rc.Get<GameObject>("ButtonUp");
            ButtonHelp.AddListenerEx(self.ButtonUp , () =>
            {
                self.OnButtonUp();
            });

            self.ButtonLearn = rc.Get<GameObject>("ButtonLearn");
            ButtonHelp.AddListenerEx(self.ButtonLearn , () =>
            {
                self.OnButtonLearn();
            });
        }
    }

    public static class UISkillLearnItemComponentSystem
    {
        public static void OnButtonUp(this UISkillLearnItemComponent self)
        {
            self.OnButtonLearn();
        }

        public static void OnButtonLearn(this UISkillLearnItemComponent self)
        {
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;

            SkillConfig skillConfig_base = SkillConfigCategory.Instance.Get(self.SkillPro.SkillID);

            int playerLv = userInfo.Lv;
            if (userInfo.Sp < skillConfig_base.CostSPValue)
            {
                FloatTipManager.Instance.ShowFloatTip("技能点不足！");
                return;
            }
            if (playerLv < skillConfig_base.LearnRoseLv)
            {
                FloatTipManager.Instance.ShowFloatTip("等级不足！");
                return;
            }
            if (userInfo.Gold < skillConfig_base.CostGoldValue)
            {
                FloatTipManager.Instance.ShowFloatTip("金币不足！");
                return;
            }
            if (skillConfig_base.NextSkillID == 0)
            {
                FloatTipManager.Instance.ShowFloatTip("已满级！");
                return;
            }

            self.ZoneScene().GetComponent<SkillSetComponent>().ActiveSkillID(self.SkillPro.SkillID).Coroutine();
        }

        public static void OnUpdateSkillInfo(this UISkillLearnItemComponent self)
        {
            //表现
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            int itemEquipType = bagComponent.GetEquipType();
            SkillConfig skillWuqiConfig = SkillConfigCategory.Instance.Get(SkillHelp.GetWeaponSkillID(self.SkillPro.SkillID, itemEquipType));

            //逻辑
            SkillConfig skillConfig_base = SkillConfigCategory.Instance.Get(self.SkillPro.SkillID);
            string[] skillDesc = Regex.Split(skillConfig_base.SkillDescribe, "\n\n", RegexOptions.IgnoreCase);

            if (skillDesc.Length == 1)
            {
                self.Text_Desc.GetComponent<Text>().text = skillDesc[0];
            }
            else
            {
                if (itemEquipType == ItemEquipType.Sword || itemEquipType == ItemEquipType.Wand)
                {
                    self.Text_Desc.GetComponent<Text>().text = skillDesc[0];
                }
                else
                {
                    self.Text_Desc.GetComponent<Text>().text = skillDesc[1];
                }
            }
            self.ButtonLearn.SetActive(false);
            self.ButtonUp.SetActive(false);
            self.ButtonMax.SetActive(false);
            if (skillConfig_base.SkillLv == 0)
            {
                self.ButtonLearn.SetActive(true);
            }
            else if (skillConfig_base.NextSkillID == 0)
            {
                self.ButtonMax.SetActive(true);
            }
            else
            {
                self.ButtonUp.SetActive(true);
            }
        }

        public static void OnSetSelected(this UISkillLearnItemComponent self, int SkillId)
        {
            self.Img_XuanZhong.SetActive(self.SkillPro.SkillID == SkillId);
        }

        public static void OnImg_Button(this UISkillLearnItemComponent self)
        {
            if (!self.Node_1.activeSelf)
            {
                return;
            }

            self.ClickHandler(self.SkillPro);
        }

        public static void SetClickHander(this UISkillLearnItemComponent self, Action<SkillPro> action)
        {
            self.ClickHandler = action;
        }

        public static void OnUpdateUI(this UISkillLearnItemComponent self, SkillPro skillPro)
        {
            self.SkillPro = skillPro;

            int playerLv = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Lv;
            SkillConfig skillBaseConfig = SkillConfigCategory.Instance.Get(skillPro.SkillID);

            self.Lab_NeedSp.GetComponent<Text>().text = $"需要技能点: {skillBaseConfig.CostSPValue}";
            self.Lab_SkillLv.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("等级 ") + skillBaseConfig.SkillLv.ToString();

            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            SkillConfig skillWeaponConfig = SkillConfigCategory.Instance.Get(SkillHelp.GetWeaponSkillID(self.SkillPro.SkillID, bagComponent.GetEquipType()));
            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.RoleSkillIcon, skillWeaponConfig.SkillIcon);
            self.Lab_SkillName.GetComponent<Text>().text = skillWeaponConfig.SkillName;
            self.Img_SkillIcon.GetComponent<Image>().sprite = sp;

            if (skillBaseConfig.SkillLv == 0)
            {
                self.Lab_SkillLv.GetComponent<Text>().text = string.Format("{0}级以后学习", skillBaseConfig.LearnRoseLv);
                UICommonHelper.SetImageGray(self.Img_SkillIcon, true);
            }
            else
            {
                UICommonHelper.SetImageGray(self.Img_SkillIcon, false);
            }


            self.OnUpdateSkillInfo();
        }
    }
}
