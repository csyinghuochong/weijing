using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UISettingSkillComponent: Entity, IAwake, IDestroy
    {
        public GameObject ResetBtn;
        public GameObject SkillIconItem;
        public GameObject SkillIPositionSetRight;
        public GameObject SkillIPositionSetLeft;
        public GameObject CloseBtn;

        public List<KeyValuePair> GameSettingInfos = new List<KeyValuePair>();
        public List<int> SkillSet = new List<int>();
        public List<GameObject> SkillSetIconLeftList = new List<GameObject>();
        public List<GameObject> SkillSetIconRightList = new List<GameObject>();
        public List<string> AssetPath = new List<string>();
        public Action CloseAction;
    }

    public class UISettingSkillComponentAwakeSystem: AwakeSystem<UISettingSkillComponent>
    {
        public override void Awake(UISettingSkillComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ResetBtn = rc.Get<GameObject>("ResetBtn");
            self.SkillIconItem = rc.Get<GameObject>("SkillIconItem");
            self.SkillIPositionSetRight = rc.Get<GameObject>("SkillIPositionSetRight");
            self.SkillIPositionSetLeft = rc.Get<GameObject>("SkillIPositionSetLeft");
            self.CloseBtn = rc.Get<GameObject>("CloseBtn");

            self.SkillIconItem.SetActive(false);
            self.CloseBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnCloseBtn().Coroutine(); });
            self.ResetBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnResetBtn(); });

            self.Init();
            self.UpdataSkillLeft();
            self.UpdataSkillSetRight();
        }
    }

    public class UISettingSkillComponentDestroy: DestroySystem<UISettingSkillComponent>
    {
        public override void Destroy(UISettingSkillComponent self)
        {
            for (int i = 0; i < self.AssetPath.Count; i++)
            {
                if (!string.IsNullOrEmpty(self.AssetPath[i]))
                {
                    ResourcesComponent.Instance.UnLoadAsset(self.AssetPath[i]);
                }
            }

            self.AssetPath = null;
        }
    }

    public static class UISettingSkillComponentSystem
    {
        public static void Init(this UISettingSkillComponent self)
        {
            int childCount = self.SkillIPositionSetLeft.transform.childCount;
            for (int i = 0; i < childCount; i++)
            {
                GameObject go = UnityEngine.Object.Instantiate(self.SkillIconItem);
                go.SetActive(false);
                UICommonHelper.SetParent(go, self.SkillIPositionSetLeft.transform.GetChild(i).gameObject);
                self.SkillSetIconLeftList.Add(go);
            }

            int childCount1 = self.SkillIPositionSetRight.transform.childCount;
            for (int i = 0; i < childCount1; i++)
            {
                GameObject go = UnityEngine.Object.Instantiate(self.SkillIconItem);
                go.SetActive(false);
                UICommonHelper.SetParent(go, self.SkillIPositionSetRight.transform.GetChild(i).gameObject);
                self.SkillSetIconRightList.Add(go);
            }

            string[] skillIndexs = self.ZoneScene().GetComponent<UserInfoComponent>().GetGameSettingValue(GameSettingEnum.GuaJiAutoUseSkill)
                    .Split('@');
            if (skillIndexs.Length > 0)
            {
                foreach (string skill in skillIndexs)
                {
                    if (skill == "")
                    {
                        continue;
                    }

                    self.SkillSet.Add(int.Parse(skill));
                }
            }
        }

        public static void UpdataSkillLeft(this UISettingSkillComponent self)
        {
            SkillSetComponent skillSetComponent = self.ZoneScene().GetComponent<SkillSetComponent>();
            for (int i = 0; i < self.SkillSetIconLeftList.Count; i++)
            {
                GameObject itemgo = self.SkillSetIconLeftList[i];
                GameObject addImage = itemgo.transform.parent.GetChild(0).gameObject;
                SkillPro skillPro = skillSetComponent.GetByPosition(i + 1);

                if (skillPro == null)
                {
                    addImage.GetComponent<Image>().fillAmount = 1;
                    itemgo.SetActive(false);
                    continue;
                }

                addImage.GetComponent<Image>().fillAmount = 0;
                itemgo.SetActive(true);
                if (skillPro.SkillSetType == SkillSetEnum.Skill)
                {
                    SkillConfig skillConfig = SkillConfigCategory.Instance.Get(SkillHelp.GetWeaponSkill(skillPro.SkillID,
                        UnitHelper.GetEquipType(self.ZoneScene()), skillSetComponent.SkillList));
                    string path = ABPathHelper.GetAtlasPath_2(ABAtlasTypes.RoleSkillIcon, skillConfig.SkillIcon);
                    Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
                    if (!self.AssetPath.Contains(path))
                    {
                        self.AssetPath.Add(path);
                    }

                    itemgo.transform.Find("Img_Mask/Img_SkillIcon").GetComponent<Image>().sprite = sp;

                    int i1 = i;
                    itemgo.GetComponentInChildren<Button>().onClick.AddListener(() => { self.OnClick(i1); });
                }
            }
        }

        public static void UpdataSkillSetRight(this UISettingSkillComponent self)
        {
            SkillSetComponent skillSetComponent = self.ZoneScene().GetComponent<SkillSetComponent>();
            for (int i = 0; i < self.SkillSetIconRightList.Count; i++)
            {
                GameObject itemgo = self.SkillSetIconRightList[i];
                GameObject addImage = itemgo.transform.parent.GetChild(0).gameObject;

                itemgo.SetActive(false);
                addImage.GetComponent<Image>().fillAmount = 1;

                if (i >= self.SkillSet.Count)
                {
                    continue;
                }

                SkillPro skillPro = skillSetComponent.GetByPosition(self.SkillSet[i] + 1);

                if (skillPro == null)
                {
                    addImage.GetComponent<Image>().fillAmount = 1;
                    itemgo.SetActive(false);
                    continue;
                }

                addImage.GetComponent<Image>().fillAmount = 0;
                itemgo.SetActive(true);
                if (skillPro.SkillSetType == SkillSetEnum.Skill)
                {
                    SkillConfig skillConfig = SkillConfigCategory.Instance.Get(SkillHelp.GetWeaponSkill(skillPro.SkillID,
                        UnitHelper.GetEquipType(self.ZoneScene()), skillSetComponent.SkillList));
                    string path = ABPathHelper.GetAtlasPath_2(ABAtlasTypes.RoleSkillIcon, skillConfig.SkillIcon);
                    Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
                    if (!self.AssetPath.Contains(path))
                    {
                        self.AssetPath.Add(path);
                    }

                    itemgo.transform.Find("Img_Mask/Img_SkillIcon").GetComponent<Image>().sprite = sp;
                }
            }
        }

        public static void OnClick(this UISettingSkillComponent self, int index)
        {
            Log.Debug($"点击技能{index}");
            if (self.SkillSet.Contains(index))
            {
                FloatTipManager.Instance.ShowFloatTip("已放置该技能！");
                return;
            }

            self.SkillSet.Add(index);
            self.UpdataSkillSetRight();
        }

        public static async ETTask OnCloseBtn(this UISettingSkillComponent self)
        {
            string skillSet = string.Empty;
            if (self.SkillSet.Count > 0)
            {
                foreach (int i in self.SkillSet)
                {
                    skillSet += i + "@";
                }

                skillSet = skillSet.Substring(0, skillSet.Length - 1);
            }

            self.GameSettingInfos.Add(new KeyValuePair() { KeyId = (int)GameSettingEnum.GuaJiAutoUseSkill, Value = skillSet });
            self.ZoneScene().GetComponent<UserInfoComponent>().UpdateGameSetting(self.GameSettingInfos);
            HintHelp.GetInstance().DataUpdate(DataType.SettingUpdate);
            C2M_GameSettingRequest c2M_GameSettingRequest = new C2M_GameSettingRequest() { GameSettingInfos = self.GameSettingInfos };
            M2C_GameSettingResponse r2c_roleEquip =
                    (M2C_GameSettingResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_GameSettingRequest);
            // 更新主界面
            self.CloseAction?.Invoke();
            UIHelper.Remove(self.ZoneScene(), UIType.UISettingSkill);
        }

        public static void OnResetBtn(this UISettingSkillComponent self)
        {
            self.SkillSet.Clear();
            self.UpdataSkillSetRight();
        }
    }
}