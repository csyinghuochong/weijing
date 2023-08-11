using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIBattleRecruitItemComponent: Entity, IAwake<GameObject>
    {
        public GameObject GameObject;
        public GameObject NameText;
        public GameObject PropertiesText;
        public GameObject MonsterNumberText;
        public GameObject CurrentNumberText;
        public GameObject CostText;
        public GameObject FilledImage;
        public GameObject BuyButton;

        public long SummonTime;
        public int CostGold;
        public BattleSummonConfig BattleSummonConfig;
        public Action<int, int> OnRecruitAction;
    }

    public class UIBattltRecruitItemComponentAwakeSystem: AwakeSystem<UIBattleRecruitItemComponent, GameObject>
    {
        public override void Awake(UIBattleRecruitItemComponent self, GameObject gameObject)
        {
            self.Awake(gameObject);
        }
    }

    public static class UIBattltRecruitItemComponentSystem
    {
        public static void Awake(this UIBattleRecruitItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.NameText = rc.Get<GameObject>("NameText");
            self.PropertiesText = rc.Get<GameObject>("PropertiesText");
            self.MonsterNumberText = rc.Get<GameObject>("MonsterNumberText");
            self.CurrentNumberText = rc.Get<GameObject>("CurrentNumberText");
            self.CostText = rc.Get<GameObject>("CostText");
            self.FilledImage = rc.Get<GameObject>("FilledImage");
            self.BuyButton = rc.Get<GameObject>("BuyButton");

            self.BuyButton.GetComponent<Button>().onClick.AddListener(() =>
            {
                self.OnRecruitAction?.Invoke(self.BattleSummonConfig.Id, self.CostGold);
            });
        }

        public static void InitUI(this UIBattleRecruitItemComponent self, BattleSummonConfig battleSummonConfig)
        {
            self.BattleSummonConfig = battleSummonConfig;
            self.CostGold = battleSummonConfig.CostGold;

            self.NameText.GetComponent<Text>().text = battleSummonConfig.ItemName;

            string showStr = "";
            string[] properties = battleSummonConfig.AttributesKey.Split('@');
            for (int i = 0; i < properties.Length; i++)
            {
                string[] pro = properties[i].Split(';');
                string proName = ItemViewHelp.GetAttributeName(int.Parse(pro[0]));
                int showType = NumericHelp.GetNumericValueType(int.Parse(pro[0]));

                if (showType == 2)
                {
                    float value = float.Parse(pro[1]) / 100f;
                    showStr += proName + " + " + value.ToString("0.##") + "%\n";
                }
                else
                {
                    showStr += proName + " + " + int.Parse(pro[1]) + "%\n";
                }
            }
            self.PropertiesText.GetComponent<Text>().text = showStr;
            
            self.MonsterNumberText.GetComponent<Text>().text = $"所需人口:{battleSummonConfig.MonsterNumber}";
            self.CurrentNumberText.GetComponent<Text>().text = "当前数量:0";
            self.CostText.GetComponent<Text>().text = $"消耗金币:{self.CostGold}";
        }

        public static void UpdateUI(this UIBattleRecruitItemComponent self, long nowTime)
        {
            if (nowTime - self.SummonTime >= self.BattleSummonConfig.FreeResetTime * TimeHelper.Second)
            {
                self.CostGold = 0;
                self.CostText.GetComponent<Text>().text = $"消耗金币:{self.CostGold}";
                self.FilledImage.GetComponent<Image>().fillAmount = 0;
            }
            else
            {
                self.CostGold = self.BattleSummonConfig.CostGold;
                self.CostText.GetComponent<Text>().text = $"消耗金币:{self.CostGold}";
                self.FilledImage.GetComponent<Image>().fillAmount =
                        1f - (float)(nowTime - self.SummonTime) / (self.BattleSummonConfig.FreeResetTime * TimeHelper.Second);
            }
        }

        public static void UpdateUI(this UIBattleRecruitItemComponent self, BattleSummonInfo battleSummonInfo)
        {
            self.SummonTime = battleSummonInfo.SummonTime;
            self.CurrentNumberText.GetComponent<Text>().text = $"当前数量:{battleSummonInfo.SummonNumber}";
        }
    }
}