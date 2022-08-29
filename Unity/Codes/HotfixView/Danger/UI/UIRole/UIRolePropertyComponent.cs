using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UIRolePropertyComponent : Entity, IAwake,IDestroy
    {

        public GameObject ButtonCloseAddPoint;
        public GameObject ButtonAddPointConfirm;
        public GameObject ButtonAddPoint;
        public GameObject RoleAddPoint;
        public GameObject AddPointNode;
        public GameObject AttributeNode;
        public GameObject Text_Exp;
        public GameObject ImageExp;
        public GameObject Text_PiLao;
        public GameObject ImagePiLao;
        public GameObject Text_Vitality;
        public GameObject PropertyListSet_2;
        public GameObject Btn_TeShuPro;
        public GameObject Btn_BasePro;
        public GameObject RoleProValueSetList;
        public GameObject PropertyListSet;

		//public GameObject Obj_ProBtnSet;
		public GameObject Obj_RoleProValueSetList;
		public GameObject Obj_ProListSet;
		public GameObject Obj_ProListSet_2;

		public GameObject Obj_Btn_KangXingPro;

        public GameObject RoleProValueSetList1;
        public GameObject RoleProValueSetList2;

        public List<ShowPropertyList> ShowPropertyList_Base = new List<ShowPropertyList>();
		public List<ShowPropertyList> ShowPropertyList_TeShu = new List<ShowPropertyList>();
		public List<ShowPropertyList> ShowPropertyList_KangXing = new List<ShowPropertyList>();

        public UserInfoComponent UserInfoComponent;
        public UIRoleAddPointComponent UIRoleAddPointComponent;
        public int MaxPiLao;
        public int NowShowType;
    }


    [ObjectSystem]
	public class UIRolePropertyComponentAwakeSystem : AwakeSystem<UIRolePropertyComponent>
	{
		public override void Awake(UIRolePropertyComponent self)
		{

            //清理数据
            self.ShowPropertyList_Base.Clear();
            self.ShowPropertyList_TeShu.Clear();
            self.ShowPropertyList_KangXing.Clear();

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.UserInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            GlobalValueConfig globalValueConfig = GlobalValueConfigCategory.Instance.Get(10);
            self.MaxPiLao = int.Parse(globalValueConfig.Value);

            self.Text_PiLao = rc.Get<GameObject>("Text_PiLao");
            self.ImagePiLao = rc.Get<GameObject>("ImagePiLao");
            self.Text_Vitality = rc.Get<GameObject>("Text_Vitality");

            self.ButtonCloseAddPoint = rc.Get<GameObject>("ButtonCloseAddPoint");
            self.ButtonCloseAddPoint.GetComponent<Button>().onClick.AddListener(() => 
            {
                self.AddPointNode.SetActive(false);
                self.AttributeNode.SetActive(true);
            });
            self.ButtonAddPoint = rc.Get<GameObject>("ButtonAddPoint");
            self.ButtonAddPoint.GetComponent<Button>().onClick.AddListener(() =>
            {
                self.AddPointNode.SetActive(true);
                self.AttributeNode.SetActive(false);
                self.UIRoleAddPointComponent.OnInitUI();
            });

            self.RoleAddPoint = rc.Get<GameObject>("RoleAddPoint");
            self.UIRoleAddPointComponent = self.AddChild<UIRoleAddPointComponent, GameObject>(self.RoleAddPoint);
            self.AddPointNode = rc.Get<GameObject>("AddPointNode");
            self.AttributeNode = rc.Get<GameObject>("AttributeNode");
            self.AddPointNode.SetActive(false);
            self.AttributeNode.SetActive(true);

            self.Text_Exp = rc.Get<GameObject>("Text_Exp");
            self.ImageExp = rc.Get<GameObject>("ImageExp");

            self.RoleProValueSetList1 = rc.Get<GameObject>("RoleProValueSetList1");
            self.RoleProValueSetList2 = rc.Get<GameObject>("RoleProValueSetList2");

            //self.ObjLabRoleLv = rc.Get<GameObject>("Lab_RoseLv");
            //self.ObjLabRoleName = rc.Get<GameObject>("Lab_RoseName");
            self.Obj_ProListSet = rc.Get<GameObject>("PropertyListSet");
            self.Obj_ProListSet_2 = rc.Get<GameObject>("PropertyListSet_2");
            self.Obj_RoleProValueSetList = rc.Get<GameObject>("RoleProValueSetList");

            //初始化属性列表
            self.InitShowPropertyList_Base();
            self.InitPropertyShow(0);
            self.UpdateShowRoleExp();

            self.GetParent<UI>().OnUpdateUI = () => { self.InitPropertyShow(self.NowShowType); };

            //添加监听事件
            DataUpdateComponent.Instance.AddListener(DataType.UpdateRoleFightData, self);
            ReddotViewComponent redPointComponent = self.DomainScene().GetComponent<ReddotViewComponent>();
            // redPointComponent.RegisterReddot(ReddotType.RolePoint, (int numer) => { self.Reddot_RolePoint(numer); });
            redPointComponent.RegisterReddot(ReddotType.RolePoint, self.Reddot_RolePoint);
        }
	}

    [ObjectSystem]
    public class UIRolePropertyComponentDestroySystem : DestroySystem<UIRolePropertyComponent>
    {
        public override void Destroy(UIRolePropertyComponent self)
        {
            //移除监听事件
            DataUpdateComponent.Instance.RemoveListener(DataType.UpdateRoleFightData, self);

            ReddotViewComponent redPointComponent = self.DomainScene().GetComponent<ReddotViewComponent>();
            redPointComponent.UnRegisterReddot(ReddotType.RolePoint, self.Reddot_RolePoint);
        }
    }

    public static class UIRolePropertyComponentSystem
	{

        public static void Reddot_RolePoint(this UIRolePropertyComponent self, int num)
        {
            self.ButtonAddPoint.transform.Find("Reddot").gameObject.SetActive(num > 0);
        }

        public static void UpdateShowRoleExp(this UIRolePropertyComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            int maxPiLao = self.UserInfoComponent.GetMaxPiLao(unit.GetComponent<NumericComponent>());
            self.ImagePiLao.GetComponent<Image>().fillAmount = (float)self.UserInfoComponent.UserInfo.PiLao / maxPiLao;
            self.Text_PiLao.GetComponent<Text>().text = self.UserInfoComponent.UserInfo.PiLao + "/" + maxPiLao;
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            self.Text_Exp.GetComponent<Text>().text = userInfo.Exp.ToString() + "/" + ExpConfigCategory.Instance.Get(userInfo.Lv).UpExp;
            self.ImageExp.GetComponent<Image>().fillAmount = (float)userInfo.Exp / (float)ExpConfigCategory.Instance.Get(userInfo.Lv).UpExp;
        }

        //添加初始话要显示的属性
        public static void InitShowPropertyList_Base(this UIRolePropertyComponent self)
		{

			//添加基础属性
			//self.ShowPropertyList_Base.Add(AddShowProperList(NumericType.Now_Power, "力量", "Pro_8", 1));
			//self.ShowPropertyList_Base.Add(AddShowProperList(NumericType.Now_Intellect, "智力", "Pro_7", 1));
			//self.ShowPropertyList_Base.Add(AddShowProperList(NumericType.Now_Stamina, "耐力", "Pro_1", 1));
			//self.ShowPropertyList_Base.Add(AddShowProperList(NumericType.Now_Constitution, "体质", "Pro_6", 1));
			//self.ShowPropertyList_Base.Add(AddShowProperList(NumericType.Now_Agility, "敏捷", "Pro_2", 1));
			self.ShowPropertyList_Base.Add(AddShowProperList(NumericType.Now_MaxHp, "生命", "Pro_4", 1));
			self.ShowPropertyList_Base.Add(AddShowProperList(NumericType.Now_MaxAct, "攻击", "Pro_5", 1));
			self.ShowPropertyList_Base.Add(AddShowProperList(NumericType.Now_MaxDef, "防御", "Pro_3", 1));
			self.ShowPropertyList_Base.Add(AddShowProperList(NumericType.Now_MaxAdf, "魔御", "Pro_9", 1));
            //

            //特殊属性

            self.ShowPropertyList_TeShu.Add(AddShowProperList(NumericType.Now_Cri, "暴击概率", "", 2));
            self.ShowPropertyList_TeShu.Add(AddShowProperList(NumericType.Now_Res, "韧性概率", "", 2));
            self.ShowPropertyList_TeShu.Add(AddShowProperList(NumericType.Now_Hit, "命中概率", "", 2));
            self.ShowPropertyList_TeShu.Add(AddShowProperList(NumericType.Now_Dodge, "闪避概率", "", 2));
            self.ShowPropertyList_TeShu.Add(AddShowProperList(NumericType.Now_DamgeAddPro, "伤害加成", "", 2));
            self.ShowPropertyList_TeShu.Add(AddShowProperList(NumericType.Now_DamgeSubPro, "伤害减免", "", 2));
            self.ShowPropertyList_TeShu.Add(AddShowProperList(NumericType.Now_Luck, "幸运值", "", 1));
            self.ShowPropertyList_TeShu.Add(AddShowProperList(NumericType.Now_Speed, "移动速度", "", 2));
            /*
            self.ShowPropertyList_TeShu.Add(AddShowProperList(NumericType.Now_CriLv, "暴击等级", "", 1));
			self.ShowPropertyList_TeShu.Add(AddShowProperList(NumericType.Now_ResLv, "韧性等级", "", 1));
			self.ShowPropertyList_TeShu.Add(AddShowProperList(NumericType.Now_HitLv, "命中等级", "", 1));
			self.ShowPropertyList_TeShu.Add(AddShowProperList(NumericType.Now_DodgeLv, "闪避等级", "", 1));



			self.ShowPropertyList_TeShu.Add(AddShowProperList(NumericType.Now_ActDamgeAddPro, "物理伤害加成", "", 2));
			self.ShowPropertyList_TeShu.Add(AddShowProperList(NumericType.Now_MageDamgeAddPro, "魔法伤害加成", "", 2));
			self.ShowPropertyList_TeShu.Add(AddShowProperList(NumericType.Now_ActDamgeSubPro, "物理伤害减免", "", 2));
			self.ShowPropertyList_TeShu.Add(AddShowProperList(NumericType.Now_MageDamgeSubPro, "魔法伤害减免", "", 2));

			self.ShowPropertyList_TeShu.Add(AddShowProperList(NumericType.Now_ZhongJiPro, "重击概率", "", 2));
			self.ShowPropertyList_TeShu.Add(AddShowProperList(NumericType.Now_ZhongJi, "重击附加伤害", "", 1));
			self.ShowPropertyList_TeShu.Add(AddShowProperList(NumericType.Now_HuShiActPro, "攻击穿透", "", 2));
			self.ShowPropertyList_TeShu.Add(AddShowProperList(NumericType.Now_HuShiMagePro, "魔法穿透", "", 2));
			self.ShowPropertyList_TeShu.Add(AddShowProperList(NumericType.Now_HuShiDef, "忽视目标防御", "", 2));
			self.ShowPropertyList_TeShu.Add(AddShowProperList(NumericType.Now_HuShiAdf, "忽视目标魔御", "", 2));
			self.ShowPropertyList_TeShu.Add(AddShowProperList(NumericType.Now_XiXuePro, "吸血概率", "", 2));
			self.ShowPropertyList_TeShu.Add(AddShowProperList(NumericType.Now_SkillCDTimeCostPro, "技能冷却缩减", "", 2));

			self.ShowPropertyList_TeShu.Add(AddShowProperList(NumericType.Now_GeDang, "格挡值", "", 1));
			self.ShowPropertyList_TeShu.Add(AddShowProperList(NumericType.Now_ZhenShi, "真实伤害", "", 1));

			//抗性属性
			self.ShowPropertyList_KangXing.Add(AddShowProperList(NumericType.Now_ActBossPro, "物攻领主加成", "", 2));
			self.ShowPropertyList_KangXing.Add(AddShowProperList(NumericType.Now_MageBossPro, "魔攻领主加成", "", 2));
			self.ShowPropertyList_KangXing.Add(AddShowProperList(NumericType.Now_ActBossSubPro, "领主物攻减免", "", 2));
			self.ShowPropertyList_KangXing.Add(AddShowProperList(NumericType.Now_MageBossSubPro, "领主魔攻减免", "", 2));

			self.ShowPropertyList_KangXing.Add(AddShowProperList(NumericType.Now_Resistance_Beast_Pro, "野兽抗性", "", 2));
			self.ShowPropertyList_KangXing.Add(AddShowProperList(NumericType.Now_Resistance_Hum_Pro, "人物抗性", "", 2));
			self.ShowPropertyList_KangXing.Add(AddShowProperList(NumericType.Now_Resistance_Demon_Pro, "恶魔抗性", "", 2));
			self.ShowPropertyList_KangXing.Add(AddShowProperList(NumericType.Now_Damge_Beast_Pro, "野兽伤害", "", 2));
			self.ShowPropertyList_KangXing.Add(AddShowProperList(NumericType.Now_Damge_Hum_Pro, "人物伤害", "", 2));
			self.ShowPropertyList_KangXing.Add(AddShowProperList(NumericType.Now_Damge_Demon_Pro, "恶魔伤害", "", 2));

			self.ShowPropertyList_KangXing.Add(AddShowProperList(NumericType.Now_Resistance_Shine_Pro, "神圣抗性", "", 2));
			self.ShowPropertyList_KangXing.Add(AddShowProperList(NumericType.Now_Resistance_Shadow_Pro, "暗影抗性", "", 2));
			self.ShowPropertyList_KangXing.Add(AddShowProperList(NumericType.Now_ResistIcece_Ice_Pro, "冰霜抗性", "", 2));
			self.ShowPropertyList_KangXing.Add(AddShowProperList(NumericType.Now_ResistFirece_Fire_Pro, "火焰抗性", "", 2));
			self.ShowPropertyList_KangXing.Add(AddShowProperList(NumericType.Now_ResistThunderce_Thunder_Pro, "闪电抗性", "", 2));
            */
		}

		public static ShowPropertyList AddShowProperList(int numericType, string name, string iconID, int type)
		{
			ShowPropertyList showList = new ShowPropertyList();
			showList.numericType = numericType;
			showList.name = name;
			showList.iconID = iconID;
			showList.Type = type;
			return showList;
		}

		//属性界面展示
		public static void InitPropertyShow(this UIRolePropertyComponent self, int type)
		{
            self.UpdateShowRoleExp();
            self.UIRoleAddPointComponent.OnInitUI();

            self.Text_Vitality.GetComponent<Text>().text = $"{self.UserInfoComponent.UserInfo.Vitality}/{GlobalValueConfigCategory.Instance.Get(10).Value}";

            NumericComponent numericComponent = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene()).GetComponent<NumericComponent>();

            //清理目标下的所有控件

            FunctionUI.GetInstance().DestoryTargetObj(self.RoleProValueSetList1);
            FunctionUI.GetInstance().DestoryTargetObj(self.RoleProValueSetList2);
            //self.Obj_RoleProValueSetList.transform.localPosition = new Vector3(self.Obj_RoleProValueSetList.transform.localPosition.x, -500, self.Obj_RoleProValueSetList.transform.localPosition.z);

            //显示基础属性列表
            for (int i = 0; i < self.ShowPropertyList_Base.Count; i++)
            {

                GameObject gameObject = UnityEngine.Object.Instantiate(self.Obj_ProListSet);
                gameObject.transform.SetParent(self.RoleProValueSetList1.transform);
                gameObject.transform.localScale = new Vector3(1, 1, 1);
                gameObject.transform.localPosition = new Vector3(0, 0, 0);
                gameObject.SetActive(true);

                ShowPropertyList showList = self.ShowPropertyList_Base[i];
                ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

                rc.Get<GameObject>("Lab_PropertyType").GetComponent<Text>().text = showList.name;
                if (showList.numericType == NumericType.Now_Speed)
                {
                    rc.Get<GameObject>("Lab_ProTypeValue").GetComponent<Text>().text = numericComponent.GetAsFloat(showList.numericType).ToString();
                }
                else
                {
                    if (showList.numericType == NumericType.Now_MaxAct)
                    {
                        rc.Get<GameObject>("Lab_ProTypeValue").GetComponent<Text>().text = numericComponent.GetAsLong(NumericType.Now_MinAct) + "-" + numericComponent.GetAsLong(NumericType.Now_MaxAct);
                        //rc.Get<GameObject>("Lab_ProTypeValue").GetComponent<Text>().text = numericComponent.GetAsLong(NumericType.Now_MaxAct).ToString();
                    }
                    else if (showList.numericType == NumericType.Now_MaxDef)
                    {
                        rc.Get<GameObject>("Lab_ProTypeValue").GetComponent<Text>().text = numericComponent.GetAsLong(NumericType.Now_MinDef) + "-" + numericComponent.GetAsLong(NumericType.Now_MaxDef);
                        //rc.Get<GameObject>("Lab_ProTypeValue").GetComponent<Text>().text = numericComponent.GetAsLong(NumericType.Now_MaxDef).ToString();
                    }
                    else if (showList.numericType == NumericType.Now_MaxAdf)
                    {
                        rc.Get<GameObject>("Lab_ProTypeValue").GetComponent<Text>().text = numericComponent.GetAsLong(NumericType.Now_MinAdf) + "-" + numericComponent.GetAsLong(NumericType.Now_MaxAdf);
                        //rc.Get<GameObject>("Lab_ProTypeValue").GetComponent<Text>().text = numericComponent.GetAsLong(NumericType.Now_MaxAdf).ToString();
                    }
                    else
                    {
                        rc.Get<GameObject>("Lab_ProTypeValue").GetComponent<Text>().text = numericComponent.GetAsLong(showList.numericType).ToString();
                    }
                }

                //显示图标
                if (showList.iconID != null && showList.iconID != "")
                {
                    rc.Get<GameObject>("Img_Icon").GetComponent<Image>().sprite = ABAtlasHelp.GetIconSprite(ABAtlasTypes.PropertyIcon, showList.iconID);
                }
            }

            //显示特殊属性列表
            for (int i = 0; i < self.ShowPropertyList_TeShu.Count; i++)
            {
                GameObject gameObject = UnityEngine.Object.Instantiate(self.Obj_ProListSet_2);
                gameObject.transform.SetParent(self.RoleProValueSetList2.transform);
                gameObject.transform.localScale = new Vector3(1, 1, 1);
                gameObject.transform.localPosition = new Vector3(0, 0, 0);
                gameObject.SetActive(true);

                ShowPropertyList showList = self.ShowPropertyList_TeShu[i];
                ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

                rc.Get<GameObject>("Lab_PropertyType").GetComponent<Text>().text = showList.name;

                //整数
                if (showList.Type == 1)
                {
                    rc.Get<GameObject>("Lab_ProTypeValue").GetComponent<Text>().text = numericComponent.GetAsLong(showList.numericType).ToString();
                }

                //浮点数
                if (showList.Type == 2)
                {
                    float value = numericComponent.GetAsFloat(showList.numericType) * 100.0f;
                    if (value.ToString().Contains("."))
                    {
                        rc.Get<GameObject>("Lab_ProTypeValue").GetComponent<Text>().text = value.ToString("F2") + "%";
                    }
                    else
                    {
                        rc.Get<GameObject>("Lab_ProTypeValue").GetComponent<Text>().text = value.ToString() + "%";
                    }
                }
            }

            if (type == 3)
            {
                //显示特殊属性列表
                for (int i = 0; i < self.ShowPropertyList_KangXing.Count; i++)
                {
                    GameObject gameObject = UnityEngine.Object.Instantiate(self.Obj_ProListSet_2);
                    gameObject.transform.SetParent(self.Obj_RoleProValueSetList.transform);
                    gameObject.transform.localScale = new Vector3(1, 1, 1);
                    gameObject.transform.localPosition = new Vector3(0, 0, 0);
                    gameObject.SetActive(true);

                    ShowPropertyList showList = self.ShowPropertyList_KangXing[i];
                    ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();
                    rc.Get<GameObject>("Lab_PropertyType").GetComponent<Text>().text = showList.name;
                    //浮点数
                    if (showList.Type == 2)
                    {
                        float value = numericComponent.GetAsFloat(showList.numericType) * 100.0f;
                        if (value.ToString().Contains("."))
                        {
                            rc.Get<GameObject>("Lab_ProTypeValue").GetComponent<Text>().text = value.ToString("F2") + "%";
                        }
                        else
                        {
                            rc.Get<GameObject>("Lab_ProTypeValue").GetComponent<Text>().text = value.ToString() + "%";
                        }
                    }
                }
            }

            self.NowShowType = type;

            //显示战斗力
            UI ui = UIHelper.GetUI(self.ZoneScene(), UIType.UIRole);
            ui.GetComponent<UIRoleComponent>().UpdateShowComBat();

        }

	}

}
