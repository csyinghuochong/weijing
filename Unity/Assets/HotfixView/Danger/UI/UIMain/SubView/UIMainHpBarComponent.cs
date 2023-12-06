using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    [Timer(TimerType.MonsterSingingTimer)]
    public class MonsterSingingTimer : ATimer<UIMainHpBarComponent>
    {
        public override void Run(UIMainHpBarComponent self)
        {
            try
            {
                self.OnSinging();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    public class UIMainHpBarComponent : Entity, IAwake<GameObject>, IDestroy
    {

        public Text Lab_Deve;
        public Text HurtTextPet;
        public Text HurtTextPlayer;
        public GameObject HurtTextNode;
        public GameObject SingNode;
        public Image Img_SingValue;
        public GameObject Img_SingDi;
        public GameObject GameObject;
        public GameObject Lab_MonsterLv;
        public GameObject Lab_MonsterName;
        public GameObject Img_MonsterHp;
        public GameObject RawImage;
        public GameObject Lab_BossLv;
        public GameObject Lab_BossName;
        public GameObject Img_BossHp;
        public GameObject MonsterNode;
        public GameObject BossNode;
        public Text Lab_Owner;

        public int BossConfiId;
        public long LockBossId;
        public Vector3 Vector3 =  new Vector3(1, 1, 1);
        public RenderTexture RenderTexture;
        public UIModelDynamicComponent UIModelShowComponent;

        public UIMainBuffComponent UIMainBuffComponent;
        public LockTargetComponent LockTargetComponent;

        public long SingTimer;
        public long SingEndTime;
        public long SingTotalTime;

        public long PlayerHurt;
        public long PetHurt;

        public string DefaultString = "0";

        public long MyUnitId = 0;
    }


    public class UIMainHpBarComponentAwakeSystem : AwakeSystem<UIMainHpBarComponent, GameObject>
    {
        public override void Awake(UIMainHpBarComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.Img_SingValue = rc.Get<GameObject>("Img_SingValue").GetComponent<Image>();
            self.Img_SingDi = rc.Get<GameObject>("Img_SingDi");
            self.Lab_MonsterLv = rc.Get<GameObject>("Lab_MonsterLv");
            self.Lab_MonsterName = rc.Get<GameObject>("Lab_MonsterName");
            self.Img_MonsterHp = rc.Get<GameObject>("Img_MonsterHp");
            self.RawImage = rc.Get<GameObject>("Img_BossIcon");
            self.Lab_BossLv = rc.Get<GameObject>("Lab_BossLv");
            self.Lab_BossName = rc.Get<GameObject>("Lab_BossName");
            self.Img_BossHp = rc.Get<GameObject>("Img_BossHp");
            self.MonsterNode = rc.Get<GameObject>("MonsterNode");
            self.BossNode = rc.Get<GameObject>("BossNode");
            self.Lab_Owner = rc.Get<GameObject>("Lab_Owner").GetComponent<Text>();
            self.Lab_Owner.text = string.Empty;

            self.MonsterNode.SetActive(false);
            self.BossNode.SetActive(false);
            self.RenderTexture = new RenderTexture(256, 256, 16, RenderTextureFormat.ARGB32);
            self.RenderTexture.Create();
            self.RawImage.GetComponent<RawImage>().texture = self.RenderTexture;
            ButtonHelp.AddListenerEx(self.RawImage, () => { self.OnImg_BossIcon().Coroutine();  });

            self.HurtTextPet = rc.Get<GameObject>("HurtTextPet").GetComponent<Text>();
            self.HurtTextPlayer = rc.Get<GameObject>("HurtTextPlayer").GetComponent<Text>();
            self.Lab_Deve = rc.Get<GameObject>("Lab_Deve").GetComponent<Text>();
            self.Lab_Deve.gameObject.SetActive(true);

            self.HurtTextNode = rc.Get<GameObject>("HurtTextNode");
            self.SingNode = rc.Get<GameObject>("SingNode");
            self.SingNode.SetActive(false);
            self.HurtTextNode.SetActive(false);
            self.UpdateHurtText();

            GameObject UIMainBuff = rc.Get<GameObject>("UIMainBuff");
            self.UIMainBuffComponent = self.AddChild<UIMainBuffComponent, GameObject>(UIMainBuff);

            //模型展示界面
            var path = ABPathHelper.GetUGUIPath("Common/UIModelDynamic");
            GameObject bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject showMode = UnityEngine.Object.Instantiate(bundleGameObject);
            self.UIModelShowComponent = self.AddChild<UIModelDynamicComponent, GameObject>(showMode);
            self.UIModelShowComponent.OnInitUI(self.RawImage, self.RenderTexture);
            //配置摄像机位置[0,115,257]
            showMode.transform.Find("Camera").localPosition = new Vector3(0f, 200, 378f);

            self.LockTargetComponent = self.ZoneScene().GetComponent<LockTargetComponent>();

            DataUpdateComponent.Instance.AddListener(DataType.UpdateSing, self);
        }
    }


    public class UIMainHpBarComponentDestroy : DestroySystem<UIMainHpBarComponent>
    {
        public override void Destroy(UIMainHpBarComponent self)
        {
            self.UIModelShowComponent.ReleaseRenderTexture();
            self.RenderTexture.Release();
            GameObject.Destroy(self.RenderTexture);
            self.RenderTexture = null;

            TimerComponent.Instance?.Remove( ref self.SingTimer);
            DataUpdateComponent.Instance.RemoveListener(DataType.UpdateSing, self);
        }
    }

    public static class UIMainHpBarComponentSystem
    {

        public static async ETTask OnImg_BossIcon(this UIMainHpBarComponent self)
        {
            self.BossConfiId = 70001011;
            if (self.BossConfiId == 0)
            {
                return;
            }

            KeyValuePairInt keyValuePair = FirstWinConfigCategory.Instance.GetBossChapter(self.BossConfiId);
            if(keyValuePair == null)
            {
                return;    
            }

            //70001011 野猪王
            long instanceid = self.InstanceId;
            UI uI = await UIHelper.Create( self.ZoneScene(), UIType.UIZhanQu );
            if(instanceid != self.InstanceId)
            {
                return;
            }
            self.ZoneScene().GetComponent<BattleMessageComponent>().FirstWinBossId = self.BossConfiId;
            uI.GetComponent<UIZhanQuComponent>().OnClickGoToFirstWin(self.BossConfiId);
        }

        public static void BeginEnterScene(this UIMainHpBarComponent self)
        {
            self.MonsterNode.SetActive(false);
            self.Lab_Owner.text = string.Empty;
            self.PetHurt = 0;
            self.PlayerHurt = 0;
            self.MyUnitId = UnitHelper.GetMyUnitId(self.ZoneScene());
            self.UpdateHurtText();
            self.BossNode.SetActive(false);
        }

        public static void OnUpdateBelongID(this UIMainHpBarComponent self, long bossid, long belongid)
        {
            self.Lab_Owner.text = string.Empty;

            Unit unitmain = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            Unit unitboss = unitmain.GetParent<UnitComponent>().Get(bossid);
            MapComponent mapComponent = self.ZoneScene().GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum == SceneTypeEnum.LocalDungeon)
            {
                int killNumber = self.ZoneScene().GetComponent<UserInfoComponent>().GetMonsterKillNumber(unitboss.ConfigId);
                int chpaterid = DungeonConfigCategory.Instance.GetChapterByDungeon(mapComponent.SceneId);
                BossDevelopment bossDevelopment = ConfigHelper.GetBossDevelopmentByKill(chpaterid, killNumber);
                self.Lab_Deve.text = bossDevelopment.Name;
            }
            else
            {
                self.Lab_Deve.text = string.Empty;
            }

            Unit unitbelong = unitmain.GetParent<UnitComponent>().Get(belongid);
            if (unitbelong == null)
            {
                self.Lab_Owner.text = string.Empty;
                return;
            }

            if (unitbelong.Id == unitmain.Id)
            {
                self.Lab_Owner.color = new Color(148f/255f,1,0);      //绿色
            }
            else 
            {
                self.Lab_Owner.color = new Color(255f / 255f, 99f / 255f, 66f / 255f);      //红色
            }
            self.Lab_Owner.text = $"掉落归属:{unitbelong.GetComponent<UnitInfoComponent>().UnitName}";
        }

        public static void OnLockUnit(this UIMainHpBarComponent self, Unit unit)
        {
            int configid = unit.ConfigId;
            MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(configid);
            if (monsterConfig.MonsterType == (int)MonsterTypeEnum.Boss)
            {
                return;
            }

            self.MonsterNode.SetActive(true);
            self.Lab_MonsterName.GetComponent<Text>().text = monsterConfig.MonsterName;
            MapComponent mapComponent = self.ZoneScene().GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum == (int)SceneTypeEnum.Tower)
            {
                UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
                self.Lab_MonsterLv.GetComponent<Text>().text = userInfoComponent.UserInfo.Lv.ToString();
            }
            else
            {
                self.Lab_MonsterLv.GetComponent<Text>().text = monsterConfig.Lv.ToString();
            }
            self.OnUpdateHP(unit);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="self"></param>
        /// <param name="defend"></param>
        /// <param name="attack"></param>
        /// <param name="hurtvalue"></param>
        public static void OnUpdateHP(this UIMainHpBarComponent self, Unit defend, Unit attack, long hurtvalue)
        {
            if (defend.Id != self.LockBossId)
            {
                return;
            }
            if (hurtvalue > 0 || attack == null)
            {
                return;
            }
            hurtvalue *= -1;

            if (attack.MainHero)
            {
                //玩家伤害
                self.PlayerHurt += hurtvalue;
                self.UpdateHurtText();
            }
            else if (attack.GetMasterId() == self.MyUnitId)
            { 
                self.PetHurt += hurtvalue;
                self.UpdateHurtText();
            }
        }

        public static string ShowHurtString(this UIMainHpBarComponent self, long hurt)
        {
            if (hurt == 0)
            {
                return self.DefaultString;
            }
            if (hurt <= 10000)
            { 
                return hurt.ToString(); 
            }
            float value = hurt / 10000f;
            return value.ToString("0.#") + "万";
        }

        public static void UpdateHurtText(this UIMainHpBarComponent self)
        {
            if (self.PlayerHurt == 0 && self.PetHurt == 0)
            {
                self.HurtTextNode.SetActive(false);
            }
            else
            {
                self.HurtTextNode.SetActive(true);
                self.HurtTextPlayer.text = "玩家: " + self.ShowHurtString(self.PlayerHurt);
                self.HurtTextPet.text = "宠物: " + self.ShowHurtString(self.PetHurt);
            }
        }

        public static void OnSinging(this UIMainHpBarComponent self)
        {
            long leftTime = self.SingEndTime - TimeHelper.ClientNow();
            float rage = Math.Max(0f, (1f* leftTime / self.SingTotalTime));
            self.Img_SingValue.fillAmount = rage;
        }

        public static void OnUpdateSing(this UIMainHpBarComponent self, string paramsinfo)
        {
            string[] infolist  = paramsinfo.Split('_'); 
            long unitid = long.Parse(infolist[0]);
            if (unitid != self.LockBossId)
            {
                return;
            }

            int operate = int.Parse(infolist[1]);
            int paramid = int.Parse(infolist[2]);
            if (operate == 1)
            {
                self.SingNode.SetActive(true);
                self.HurtTextNode.SetActive(false);
                self.Img_SingValue.fillAmount = 1f;
                TimerComponent.Instance?.Remove(ref self.SingTimer);
                SkillConfig skillConfig = SkillConfigCategory.Instance.Get(paramid);
                self.SingTimer = TimerComponent.Instance.NewRepeatedTimer(100, TimerType.MonsterSingingTimer, self );
                self.SingTotalTime = (long)(skillConfig.SkillFrontSingTime * 1000);
                self.SingEndTime = self.SingTotalTime + TimeHelper.ClientNow();
            }
            if (operate == 2)
            {
                self.SingNode.SetActive(false);
                self.HurtTextNode.SetActive(true); 
                TimerComponent.Instance?.Remove(ref self.SingTimer);
            }
        }

        public static void OnUpdateHP(this UIMainHpBarComponent self, Unit unit)
        {
            if (self.LockTargetComponent.LastLockId != unit.Id
              && self.LockBossId != unit.Id)
            {
                return;
            }
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            float curhp = numericComponent.GetAsLong(NumericType.Now_Hp);
            float maxHp = numericComponent.GetAsLong(NumericType.Now_MaxHp);
            if (maxHp == 0)
            {
                return;
            }
            float blood = curhp / numericComponent.GetAsLong(NumericType.Now_MaxHp);
            if (blood < 0) {
                blood = 0;
            }

            self.Vector3.x = blood;
            if (self.LockTargetComponent.LastLockId == unit.Id)
            {
                //更新怪物血条
                self.Img_MonsterHp.transform.localScale = self.Vector3;
            }
            if (self.LockBossId == unit.Id)
            {
                //更新Boss血条
                self.Img_BossHp.transform.localScale = self.Vector3;
            }
        }

        public static void OnUnitDead(this UIMainHpBarComponent self, long unitid)
        {
            if (self.LockTargetComponent.LastLockId == unitid)
            {
                self.MonsterNode.SetActive(false);
            }
            if (self.LockBossId == unitid)
            {
                self.PetHurt = 0;
                self.PlayerHurt = 0;
                self.UpdateHurtText();
                self.BossNode.SetActive(false);
                self.Lab_Owner.text = string.Empty;
            }
        }

        public static void OnCancelLock(this UIMainHpBarComponent self)
        {
            self.MonsterNode.SetActive(false);
        }

        public static void  UpdateModelShowView(this UIMainHpBarComponent self, int monsterId)
        {
            MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(monsterId);
            self.UIModelShowComponent.ShowModel("Monster/" + monsterConfig.MonsterModelID.ToString()).Coroutine();
        }

        public static void ShowBossHPBar(this UIMainHpBarComponent self, Unit unit)
        {
            if (self.BossNode.activeSelf && unit != null)
            {
                return;
            }
            if (!self.BossNode.activeSelf && unit == null)
            {
                return;
            }
            if (unit == null)
            {
                self.LockBossId = 0;
                self.BossConfiId = 0;
                self.PetHurt = 0;
                self.PlayerHurt = 0;
                self.UpdateHurtText();
                self.BossNode.SetActive(false);
                self.Lab_Owner.text = string.Empty;
                self.UIModelShowComponent.RemoveModel();
            }
            else
            {
                int configid = unit.ConfigId;
                MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(configid);
                self.LockBossId = unit.Id;
                self.BossConfiId = unit.ConfigId;
                self.BossNode.SetActive(true);
                self.Lab_BossLv.GetComponent<Text>().text = monsterConfig.Lv.ToString();
                self.Lab_BossName.GetComponent<Text>().text = monsterConfig.MonsterName;
                self.UpdateModelShowView(configid);
                self.OnUpdateHP(unit);
                self.OnUpdateBelongID(unit.Id, unit.GetComponent<NumericComponent>().GetAsLong(NumericType.BossBelongID));

                //掉落类型为3,名字上移
                if (monsterConfig.DropType == 3)
                {
                    self.Lab_BossName.transform.localPosition = new Vector3(self.Lab_BossName.transform.localPosition.x, 385, self.Lab_BossName.transform.localPosition.z);
                    self.Lab_Owner.gameObject.SetActive(true);
                }
                else {
                    self.Lab_Owner.text = "";
                    self.Lab_Owner.gameObject.SetActive(false);
                }

                self.UIMainBuffComponent.ResetUI();
            }
        }

    }

}
