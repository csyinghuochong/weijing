using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIBattleRecruitItemComponent: Entity, IAwake<GameObject>, IDestroy
    {
        public GameObject GameObject;
        public GameObject NameText;
        public GameObject HeadImage;
        public GameObject PropertiesText_0; // 生命
        public GameObject PropertiesText_1; // 攻击
        public GameObject PropertiesText_2; // 速度
        public GameObject MonsterNumberText;
        public GameObject CostText;
        public GameObject RecruitItemBtn;
        public GameObject BtnText;
        public GameObject TimeText;

        public long SummonTime;
        public int CostGold;
        public BattleSummonConfig BattleSummonConfig;
        public Action<int, int> OnRecruitAction;

        public RenderTexture RenderTexture;
        public UIModelDynamicComponent UIModelShowComponent;
    }

    public class UIBattltRecruitItemComponentAwakeSystem: AwakeSystem<UIBattleRecruitItemComponent, GameObject>
    {
        public override void Awake(UIBattleRecruitItemComponent self, GameObject gameObject)
        {
            self.Awake(gameObject);
        }
    }

    public class UIBattltRecruitItemComponentDestroySystem: DestroySystem<UIBattleRecruitItemComponent>
    {
        public override void Destroy(UIBattleRecruitItemComponent self)
        {
            self.Destroy();
        }
    }

    public static class UIBattltRecruitItemComponentSystem
    {
        public static void Awake(this UIBattleRecruitItemComponent self, GameObject gameObject)
        {
            self.RenderTexture = null;
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.NameText = rc.Get<GameObject>("NameText");
            self.HeadImage = rc.Get<GameObject>("HeadImage");
            self.PropertiesText_0 = rc.Get<GameObject>("PropertiesText_0");
            self.PropertiesText_1 = rc.Get<GameObject>("PropertiesText_1");
            self.PropertiesText_2 = rc.Get<GameObject>("PropertiesText_2");
            self.MonsterNumberText = rc.Get<GameObject>("MonsterNumberText");
            self.CostText = rc.Get<GameObject>("CostText");
            self.RecruitItemBtn = rc.Get<GameObject>("RecruitItemBtn");
            self.BtnText = rc.Get<GameObject>("BtnText");
            self.TimeText = rc.Get<GameObject>("TimeText");
            
            self.PropertiesText_0.SetActive(false);
            self.PropertiesText_1.SetActive(false);
            self.PropertiesText_2.SetActive(false);

            var path = ABPathHelper.GetUGUIPath("Common/UIModelDynamic");
            GameObject bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject obj = UnityEngine.Object.Instantiate(bundleGameObject);
            self.UIModelShowComponent = self.AddChild<UIModelDynamicComponent, GameObject>(obj);

            self.RecruitItemBtn.GetComponent<Button>().onClick.AddListener(() =>
            {
                self.OnRecruitAction?.Invoke(self.BattleSummonConfig.Id, self.CostGold);
            });
        }

        public static void Destroy(this UIBattleRecruitItemComponent self)
        {
            self.UIModelShowComponent.ReleaseRenderTexture();
            self.RenderTexture.Release();
            GameObject.Destroy(self.RenderTexture);
            self.RenderTexture = null;
        }

        public static void InitUI(this UIBattleRecruitItemComponent self, BattleSummonConfig battleSummonConfig)
        {
            self.BattleSummonConfig = battleSummonConfig;
            self.CostGold = battleSummonConfig.CostGold;

            self.NameText.GetComponent<Text>().text = battleSummonConfig.ItemName;

            if (self.RenderTexture != null)
            {
                self.RenderTexture.Release();
                GameObject.Destroy(self.RenderTexture);
                self.RenderTexture = null;
            }

            MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(battleSummonConfig.MonsterIds[0]);
            if (self.RenderTexture == null)
            {
                self.RenderTexture = new RenderTexture(256, 256, 16, RenderTextureFormat.ARGB32);
                self.RenderTexture.Create();
                self.HeadImage.GetComponent<RawImage>().texture = self.RenderTexture;

                GameObject gameObject = self.UIModelShowComponent.GameObject;
                self.UIModelShowComponent.OnInitUI(self.HeadImage, self.RenderTexture);
                self.UIModelShowComponent.ShowModel("Monster/" + monsterConfig.MonsterModelID).Coroutine();
                gameObject.transform.Find("Camera").localPosition = new Vector3(0f, 100f, 450f);
                gameObject.transform.Find("Camera").GetComponent<Camera>().fieldOfView = 30;
                gameObject.transform.localPosition = new Vector2(1000 + 1000, 0);
                gameObject.transform.Find("Model").localRotation = Quaternion.Euler(0f, -45f, 0f);
            }

            //显示属性
            self.PropertiesText_0.SetActive(true);
            self.PropertiesText_0.GetComponent<Text>().text = monsterConfig.Hp.ToString();

            self.PropertiesText_1.SetActive(true);
            self.PropertiesText_1.GetComponent<Text>().text = monsterConfig.Act.ToString();

            self.PropertiesText_2.SetActive(true);
            self.PropertiesText_2.GetComponent<Text>().text = monsterConfig.Def.ToString();

            //显示人口
            self.MonsterNumberText.GetComponent<Text>().text = $"{battleSummonConfig.MonsterNumber}";
            self.CostText.GetComponent<Text>().text = $"{self.CostGold}金币";
        }

        public static void UpdateUI(this UIBattleRecruitItemComponent self, long nowTime)
        {
            if (nowTime - self.SummonTime >= self.BattleSummonConfig.FreeResetTime * TimeHelper.Second)
            {
                self.CostGold = 0;
                self.BtnText.GetComponent<Text>().text = "免费召唤";
                self.TimeText.GetComponent<Text>().text = "免费:0分0秒";
            }
            else
            {
                self.CostGold = self.BattleSummonConfig.CostGold;
                self.BtnText.GetComponent<Text>().text = "召唤魔物";
                long time = self.SummonTime + self.BattleSummonConfig.FreeResetTime * TimeHelper.Second - TimeHelper.ClientNow();
                time /= 1000;
                int hour = (int)time / 3600;
                int min = (int)((time - (hour * 3600)) / 60);
                int sec = (int)(time - (hour * 3600) - (min * 60));
                string showStr = min + "分" + sec + "秒";
                self.TimeText.GetComponent<Text>().text = $"免费:{showStr}";
            }
        }

        public static void UpdateDate(this UIBattleRecruitItemComponent self, long summonTime)
        {
            self.SummonTime = summonTime;
        }
    }
}