using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UITrialHurtDataComponent : Entity, IAwake, IDestroy
    {

        public GameObject ButtonClose;
        public GameObject Text_TotalHurt;
        public GameObject Text_TotalTime;
        public GameObject RankListNode;
        public GameObject UITrialHurtDataItem;
    }

    public class UITrialHurtDataComponentAwake : AwakeSystem<UITrialHurtDataComponent>
    {
        public override void Awake(UITrialHurtDataComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            Transform transform = self.GetParent<UI>().GameObject.transform;
            self.Text_TotalHurt = rc.Get<GameObject>("Text_TotalHurt");
            self.Text_TotalTime = rc.Get<GameObject>("Text_TotalTime");
            self.RankListNode = rc.Get<GameObject>("RankListNode");
            self.UITrialHurtDataItem = rc.Get<GameObject>("UITrialHurtDataItem");
            self.UITrialHurtDataItem.SetActive(false);

            self.ButtonClose = rc.Get<GameObject>("ButtonClose");
            self.ButtonClose.GetComponent<Button>().onClick.AddListener(() =>
            {
                UIHelper.Remove( self.ZoneScene(), UIType.UITrialHurtData );
            });
        }
    }

    public class UITrialHurtDataComponentDestroy : DestroySystem<UITrialHurtDataComponent>
    {
        public override void Destroy(UITrialHurtDataComponent self)
        {

        }
    }

    public static class UITrialHurtDataComponentSystem
    {

        public static string GetUnitType(this UITrialHurtData self)
        {
            switch (self.UnitType)
            {
                case UnitType.Pet:
                    return GameSettingLanguge.LoadLocalization("宠物");
                case UnitType.Monster:
                    return GameSettingLanguge.LoadLocalization("召唤物");
                case UnitType.Player:
                    return GameSettingLanguge.LoadLocalization("技能");
            }
            return "";
        }

        public static string GetUnitName(this UITrialHurtData self)
        {
            switch (self.UnitType)
            {
                case UnitType.Player:
                    return  SkillConfigCategory.Instance.Get(self.SkillId).GetSkillName();
                case UnitType.Pet:
                    return PetConfigCategory.Instance.Get(self.ConfigId).GetPetName();
                case UnitType.Monster:
                    return MonsterConfigCategory.Instance.Get(self.ConfigId).GetMonsterName();
            }
            return string.Empty;
        }

        public static string GetIconPath (this UITrialHurtData self)
        {
            switch (self.UnitType)
            {
                case UnitType.Pet:
                    PetConfig petConfig = PetConfigCategory.Instance.Get(self.ConfigId);
                    return ABPathHelper.GetAtlasPath_2(ABAtlasTypes.PetHeadIcon, petConfig.HeadIcon);
                case UnitType.Monster:
                    MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(self.ConfigId);
                    return ABPathHelper.GetAtlasPath_2(ABAtlasTypes.MonsterIcon, monsterConfig.MonsterHeadIcon);
                case UnitType.Player:
                    SkillConfig skillConfig = SkillConfigCategory.Instance.Get(self.SkillId);
                    return ABPathHelper.GetAtlasPath_2(ABAtlasTypes.RoleSkillIcon, skillConfig.SkillIcon);
            }
            return "";
        }

        public static void OnUpdateUI(this UITrialHurtDataComponent self, List<UITrialHurtData> uITrialHurts, long totalhurtvalue, long fighttime)
        {
            self.Text_TotalHurt.GetComponent<Text>().text = totalhurtvalue.ToString();
            self.Text_TotalTime.GetComponent<Text>().text = fighttime.ToString() + GameSettingLanguge.LoadLocalization("秒");

            uITrialHurts = uITrialHurts.OrderByDescending(p => p.UnitType)
                     .ToList();

            for (int i = 0; i < uITrialHurts.Count; i++)
            {
                UITrialHurtData uITrialHurtData = uITrialHurts[i];

                GameObject uirankShowItem = UnityEngine.Object.Instantiate(self.UITrialHurtDataItem);
                uirankShowItem.SetActive(true);

                int hurtrate = 0;
                if (totalhurtvalue > 0)
                {
                    hurtrate = (int)(uITrialHurtData.TotalHurt * 100f / totalhurtvalue);
                }

                Transform transform = uirankShowItem.transform;
                transform.Find("Text_HurtRate").GetComponent<Text>().text = $"{hurtrate}%";
                transform.Find("Text_TotalHurt").GetComponent<Text>().text = uITrialHurtData.TotalHurt.ToString();
                transform.Find("Text_UseNumber").GetComponent<Text>().text = uITrialHurtData.UseNumber.ToString();
                transform.Find("Text_Type").GetComponent<Text>().text = uITrialHurtData.GetUnitType();
                transform.Find("Text_Name").GetComponent<Text>().text = uITrialHurtData.GetUnitName();
                transform.Find("ImageBg2").gameObject.SetActive(i % 2 == 0);

                Image image =  transform.Find("ImageHeadIcon").GetComponent<Image>();

                var path = uITrialHurtData.GetIconPath();
                if (ComHelp.IfNull(path) || path.Contains("/0.png"))
                {
                    image.gameObject.SetActive(false);
                }
                else
                {
                    image.gameObject.SetActive(true);
                    Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
                    image.sprite = sp;
                }

                UICommonHelper.SetParent( uirankShowItem, self.RankListNode );
            }

        }
    }
}