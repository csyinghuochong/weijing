using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UICommonPropertyComponent: Entity, IAwake
    {
        public GameObject NameText;
        public GameObject LvText;
        public GameObject ImageButton;
        public GameObject ProItemSet;
        public GameObject PropertyListSet;
        public GameObject SkillListNode;

        public List<ShowPropertyList> ShowPropertyList = new List<ShowPropertyList>();
    }

    public class UICommonPropertyComponentAwakeSystem: AwakeSystem<UICommonPropertyComponent>
    {
        public override void Awake(UICommonPropertyComponent self)
        {
            self.Awake();
        }
    }

    public static class UICommonPropertyComponentSytstem
    {
        public static void Awake(this UICommonPropertyComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.NameText = rc.Get<GameObject>("NameText");
            self.LvText = rc.Get<GameObject>("LvText");
            self.ImageButton = rc.Get<GameObject>("ImageButton");
            self.ProItemSet = rc.Get<GameObject>("ProItemSet");
            self.PropertyListSet = rc.Get<GameObject>("PropertyListSet");
            self.SkillListNode = rc.Get<GameObject>("SkillListNode");

            self.PropertyListSet.SetActive(false);

            self.ImageButton.GetComponent<Button>().onClick.AddListener(() => UIHelper.Remove(self.ZoneScene(), UIType.UICommonProperty));

            self.InitShowPropertyList();
        }

        public static void ShowSkillList(this UICommonPropertyComponent self, Unit unit)
        {
            if (unit.Type != UnitType.Monster)
            {
                return;
            }
            List<int> skillids = new List<int>  ();

            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(unit.ConfigId);

            skillids.Add( monsterConfig.ActSkillID );
            if (monsterConfig.SkillID != null)
            {
                for (int i = 0; i < monsterConfig.SkillID.Length; i++)
                {
                    skillids.Add(monsterConfig.SkillID[i]);
                }
            }

            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonSkillItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            for (int i = 0; i < skillids.Count; i++)
            {
                if (skillids[i] == 0)
                {
                    continue;
                }
                SkillConfig skillConfig = SkillConfigCategory.Instance.Get(skillids[i]);
                if (string.IsNullOrEmpty(skillConfig.SkillIcon))
                {
                    return;
                }

                GameObject skillItem = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(skillItem, self.SkillListNode);
                skillItem.SetActive(true);
                skillItem.transform.localScale = Vector3.one * 1f;

                UICommonSkillItemComponent ui_item = self.AddChild<UICommonSkillItemComponent, GameObject>(skillItem);
                ui_item.OnUpdateUI(skillids[i]);
            }
        }

        public static void InitPropertyShow(this UICommonPropertyComponent self, Unit unit)
        {
            self.ShowSkillList(unit);

            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();

            self.NameText.GetComponent<Text>().text = MonsterConfigCategory.Instance.Get(unit.ConfigId).MonsterName;
            self.LvText.GetComponent<Text>().text = $"当前等级：{numericComponent.GetAsInt(NumericType.Now_Lv).ToString()}";

            for (int i = 0; i < self.ShowPropertyList.Count; i++)
            {
                GameObject go = UnityEngine.Object.Instantiate(self.PropertyListSet);
                go.transform.SetParent(self.ProItemSet.transform);
                go.transform.localScale = new Vector3(1, 1, 1);
                go.transform.localPosition = new Vector3(0, 0, 0);
                go.SetActive(true);

                ShowPropertyList showList = self.ShowPropertyList[i];
                ReferenceCollector rc = go.GetComponent<ReferenceCollector>();

                rc.Get<GameObject>("Lab_PropertyType").GetComponent<Text>().text = showList.name;

                if (self.ShowPropertyList[i].Type == 1)
                {
                    rc.Get<GameObject>("Lab_ProTypeValue").GetComponent<Text>().text = showList.numericType == NumericType.Now_Speed
                            ? numericComponent.GetAsFloat(showList.numericType).ToString()
                            : numericComponent.GetAsLong(showList.numericType).ToString();
                    //显示图标
                    if (!string.IsNullOrEmpty(showList.iconID))
                    {
                        rc.Get<GameObject>("Img_Icon").GetComponent<Image>().sprite =
                                ABAtlasHelp.GetIconSprite(ABAtlasTypes.PropertyIcon, showList.iconID);
                        rc.Get<GameObject>("Img_Icon").SetActive(true);
                    }
                }
                else
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

        public static void InitShowPropertyList(this UICommonPropertyComponent self)
        {
            self.ShowPropertyList.Add(AddShowProperList(NumericType.Now_MaxHp, "生命", "Pro_4", 1));
            self.ShowPropertyList.Add(AddShowProperList(NumericType.Now_MaxAct, "攻击", "Pro_5", 1));
            self.ShowPropertyList.Add(AddShowProperList(NumericType.Now_MaxDef, "防御", "Pro_3", 1));
            self.ShowPropertyList.Add(AddShowProperList(NumericType.Now_MaxAdf, "魔御", "Pro_9", 1));
            self.ShowPropertyList.Add(AddShowProperList(NumericType.Now_Hit, "命中概率", "", 2));
            self.ShowPropertyList.Add(AddShowProperList(NumericType.Now_Dodge, "闪避概率", "", 2));
            self.ShowPropertyList.Add(AddShowProperList(NumericType.Now_Cri, "暴击概率", "", 2));
            self.ShowPropertyList.Add(AddShowProperList(NumericType.Now_Res, "韧性概率", "", 2));
            self.ShowPropertyList.Add(AddShowProperList(NumericType.Now_Speed, "移动速度", "", 2));
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
    }
}