using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    [Timer(TimerType.HeroHeadBarTimer)]
    public class HeroHeadBarTimer : ATimer<HeroHeadBarComponent>
    {
        public override void Run(HeroHeadBarComponent self)
        {
            try
            {
                self.OnTimer();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    [ObjectSystem]
    public class HeroHeadBarComponentAwakeSystem: AwakeSystem<HeroHeadBarComponent>
    {
        public override void Awake(HeroHeadBarComponent self)
        {
            self.Awake();
        }
    }

    [ObjectSystem]
    public class HeroHeadBarComponentDestroySystem : DestroySystem<HeroHeadBarComponent>
    {
        public override void Destroy(HeroHeadBarComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
            self.RecoverGameObject(self.HeadBar);
        }
    }

    /// <summary>
    /// 头部血条组件，负责血条的密度以及血条与人物的同步
    /// </summary>
    public class HeroHeadBarComponent: Entity, IAwake, IDestroy
    {
        public Camera UiCamera;
        public Camera MainCamera;
        public GameObject ObjName;
        public GameObject ObjHp;
        public GameObject HeadBar;
        public GameObject BuffShieldValue;
        public Transform UIPosition;
        public string HeadBarPath;
        public Vector2 LastPositon;
        public GameObject Lal_ShopName;
        public GameObject ShopShowSet;
        public GameObject PlayerNameSet;
        public GameObject Lal_NameOwner;
        public GameObject JiaZuShowSet;
        public GameObject Lal_JiaZuName;
        public HeadBarUI HeadBarUI;
        public float LastTime;
        public long Timer;

        public void  Awake( )
        {
            HeadBar = null;
            HeadBarUI = null;
            ObjHp = null;
            HeadBarPath = "";
            LastTime = 0f;
            Unit m_Hero = this.GetParent<Unit>();
            UiCamera = GameObject.Find("Global/UI/UICamera").GetComponent<Camera>();
            MainCamera = GameObject.Find("Global/Main Camera").GetComponent<Camera>();
            UnitInfoComponent unitInfoComponent1 = m_Hero.GetComponent<UnitInfoComponent>();
            if (m_Hero.Type == UnitType.Player)
            {
                HeadBarPath = ABPathHelper.GetUGUIPath("Battle/UIPlayerHp");
            }
            if (m_Hero.Type == UnitType.Monster)
            {
                HeadBarPath = ABPathHelper.GetUGUIPath("Battle/UIMonsterHp");
            }
            if (m_Hero.Type == UnitType.Pet)
            {
                HeadBarPath = ABPathHelper.GetUGUIPath("Battle/UIPetHp");
            }
            long instanceid = this.InstanceId;
            GameObjectPoolComponent.Instance.AddLoadQueue(HeadBarPath, this.InstanceId, this.OnLoadGameObject);
        }

        public void OnLoadGameObject(GameObject gameObject, long formId)
        {
            if (this.IsDisposed)
            {
                this.RecoverGameObject(gameObject);
                return;
            }
            HeadBar = gameObject;
            HeadBar.SetActive(true);
            Unit unit = this.GetParent<Unit>();
            UnitInfoComponent unitInfoComponent1 = unit.GetComponent<UnitInfoComponent>();
            ReferenceCollector rc = HeadBar.GetComponent<ReferenceCollector>();

            Unit mainUnit = UnitHelper.GetMyUnitFromZoneScene(this.ZoneScene());
            bool sameCamp = unit.GetBattleCamp() == mainUnit.GetBattleCamp();
            ObjHp = rc.Get<GameObject>("Img_HpValue");
            switch (unit.Type)
            {
                case UnitType.Monster:
                    string imageHp = sameCamp ? "UI_pro_3_2" : "UI_pro_4_2";
                    Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.OtherIcon, imageHp);
                    rc.Get<GameObject>("Img_HpValue").SetActive(true);
                    ObjHp.GetComponent<Image>().sprite = sp;
                    break;
                case UnitType.Player:
                    imageHp = sameCamp ? "UI_pro_3_2" : "UI_pro_4_2";
                    GameObject ImageHpFill = rc.Get<GameObject>("ImageHpFill");
                    sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.OtherIcon, imageHp);
                    ImageHpFill.GetComponent<Image>().sprite = sp;
                    this.BuffShieldValue = rc.Get<GameObject>("BuffShieldValue");
                    break;
                case UnitType.Pet:
                    imageHp = sameCamp ? "UI_pro_3_4" : "UI_pro_4_2";
                    ImageHpFill = rc.Get<GameObject>("ImageHpFill");
                    sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.OtherIcon, imageHp);
                    ImageHpFill.GetComponent<Image>().sprite = sp;
                    break;
                default:
                    break;
            }
            
            ObjName = rc.Get<GameObject>("Lal_Name");
            Lal_ShopName = rc.Get<GameObject>("Lal_ShopName");
            ShopShowSet = rc.Get<GameObject>("ShopShowSet");
            PlayerNameSet = rc.Get<GameObject>("PlayerNameSet");
            JiaZuShowSet = rc.Get<GameObject>("JiaZuShowSet");
            Lal_JiaZuName = rc.Get<GameObject>("Lal_JiaZuName");
            UIPosition = unit.GetComponent<HeroTransformComponent>().GetTranform(PosType.Head);

            HeadBar.transform.SetParent(UIEventComponent.Instance.UILayers[(int)UILayer.Blood]);
            HeadBar.transform.localScale = Vector3.one;
            if (unit.Type == UnitType.Monster)
            {
                rc.Get<GameObject>("Alive").SetActive(true);
                rc.Get<GameObject>("Dead").SetActive(false);
            }
            if (unit.Type == UnitType.Pet)
            {
                this.Lal_NameOwner = rc.Get<GameObject>("Lal_NameOwner");
            }
            //初始化当前血条
            UpdateBlood();
            //更新显示
            UpdateShow();
            if (HeadBar.GetComponent<HeadBarUI>() == null)
            {
                HeadBar.AddComponent<HeadBarUI>();
            }
            HeadBarUI = HeadBar.GetComponent<HeadBarUI>();
            HeadBarUI.enabled = !unit.MainHero;
            HeadBarUI.HeadPos = UIPosition;
            HeadBarUI.HeadBar = HeadBar;
            HeadBar.transform.localPosition = unit.MainHero ? new Vector3(0f, 120f, 0f) : HeadBar.transform.localPosition;
        }

        //更新显示
        public void UpdateShow()
        {
            Unit unit = this.GetParent<Unit>();
            UnitInfoComponent infoComponent = this.Parent.GetComponent<UnitInfoComponent>();
            //显示玩家名称
            if (unit.Type == UnitType.Player)
            {
                NumericComponent numericComponent = this.GetParent<Unit>().GetComponent<NumericComponent>();
                this.OnUnitStallUpdate(numericComponent.GetAsInt(NumericType.Now_Stall));
                //判断自身是否有家族进行显示
                if (infoComponent.UnionName.Length > 0)
                {
                    JiaZuShowSet.SetActive(true);
                    string text1 = numericComponent.GetAsInt(NumericType.UnionLeader) == 1 ? "家族组长" : "家族成员";
                    Lal_JiaZuName.GetComponent<TextMeshProUGUI>().text = infoComponent.UnionName + text1;
                }
                else
                {
                    JiaZuShowSet.SetActive(false);
                }
            }
            //显示怪物名称
            if (unit.Type == UnitType.Monster)
            {
                MonsterConfig monsterCof = MonsterConfigCategory.Instance.Get(this.GetParent<Unit>().ConfigId);
                bool isboos = monsterCof.MonsterType == (int)MonsterTypeEnum.Boss;
                if (isboos)
                {
                    this.ObjName.GetComponent<TextMeshProUGUI>().text = $"<color=#FF5FFF>{monsterCof.MonsterName}</color>";
                    this.ObjName.GetComponent<TextMeshProUGUI>().fontSize = 32;
                }
                else
                {
                    this.ObjName.GetComponent<TextMeshProUGUI>().text = $"<color=#FFFFFF>{monsterCof.MonsterName}</color>";
                }
                //this.ObjName.GetComponent<TextMeshProUGUI>().color = isboos ? new Color(255, 95, 255) : Color.white;
                //怪物等级显示
                ReferenceCollector rc = HeadBar.GetComponent<ReferenceCollector>();
                MapComponent mapComponent = this.ZoneScene().GetComponent<MapComponent>();
                int monsterLv = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Lv);
                if (mapComponent.SceneTypeEnum == (int)SceneTypeEnum.Tower)
                {
                    UserInfoComponent userInfoComponent = this.ZoneScene().GetComponent<UserInfoComponent>();
                    rc.Get<GameObject>("Lal_Lv").GetComponent<TextMeshProUGUI>().text = userInfoComponent.UserInfo.Lv.ToString();
                }
                else if (monsterLv > 0)
                {
                    rc.Get<GameObject>("Lal_Lv").GetComponent<TextMeshProUGUI>().text = monsterLv.ToString();
                }
                else
                {
                    rc.Get<GameObject>("Lal_Lv").GetComponent<TextMeshProUGUI>().text = monsterCof.Lv.ToString();
                }
            }
            if (this.GetParent<Unit>().Type == UnitType.Pet) 
            {
                ObjName.GetComponent<TextMeshProUGUI>().text = PetConfigCategory.Instance.Get(this.GetParent<Unit>().ConfigId).PetName;
                this.Lal_NameOwner.GetComponent<TextMeshProUGUI>().text = $"{this.GetParent<Unit>().GetComponent<UnitInfoComponent>().PlayerName }的宠物";
            }
        }

        public void OnRevive()
        {
            if (this.HeadBar == null)
            {
                return;
            }
            TimerComponent.Instance.Remove(ref this.Timer);
            UnitInfoComponent infoComponent = this.Parent.GetComponent<UnitInfoComponent>();
            if (this.GetParent<Unit>().Type == UnitType.Monster)
            {
                ReferenceCollector rc = this.HeadBar.GetComponent<ReferenceCollector>();
                rc.Get<GameObject>("Alive").SetActive(true);
                rc.Get<GameObject>("Dead").SetActive(false);
            } 
            UpdateBlood();
        }

        public void OnDead()
        {
            if (this.GetParent<Unit>().Type != UnitType.Monster)
            {
                return;
            }
            MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(this.GetParent<Unit>().ConfigId);
            if (monsterConfig.ReviveTime > 0)
            {
                ReferenceCollector rc = this.HeadBar.GetComponent<ReferenceCollector>();
                rc.Get<GameObject>("Alive").SetActive(false);
                rc.Get<GameObject>("Dead").SetActive(true);
                TimerComponent.Instance.Remove(ref this.Timer);
                this.Timer = TimerComponent.Instance.NewRepeatedTimer(1000, TimerType.HeroHeadBarTimer, this);
            }
        }

        public void UpdateBlood()
        {
            NumericComponent numericComponent = this.Parent.GetComponent<NumericComponent>();
            float curhp = numericComponent.GetAsLong(NumericType.Now_Hp); // + value;
            float blood = curhp / numericComponent.GetAsLong(NumericType.Now_MaxHp);
            blood = Mathf.Max(blood, 0f);
            if (ObjHp == null)
            {
                return;
            }
            int unitType = this.GetParent<Unit>().Type;
            switch (unitType)
            {
                case UnitType.Player:
                    ObjHp.GetComponent<Slider>().value = blood;
                    int shieldHp = numericComponent.GetAsInt(NumericType.Now_Shield_HP);
                    int shieldMax = numericComponent.GetAsInt(NumericType.Now_Shield_MaxHP);
                    if (shieldMax > 0)
                    {
                        this.BuffShieldValue.GetComponent<Image>().fillAmount = shieldHp * 1f / shieldMax;
                    }
                    else
                    {
                        this.BuffShieldValue.GetComponent<Image>().fillAmount = 0f;
                    }
                    break;
                case UnitType.Pet:
                    ObjHp.GetComponent<Slider>().value = blood;
                    break;
                default:
                    ObjHp.GetComponent<Image>().fillAmount = blood;
                    break;
            }
        }

        public void OnTimer()
        {
            ReferenceCollector rc = this.HeadBar.GetComponent<ReferenceCollector>();
           
            MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(this.GetParent<Unit>().ConfigId);
            long leftTime = this.Parent.GetComponent<NumericComponent>().GetAsLong(NumericType.ReviveTime) - TimeHelper.ClientNow();
            leftTime = leftTime / 1000;
            GameObject reviveTime = rc.Get<GameObject>("Dead").transform.Find("ReviveTime").gameObject;
            int hour = (int) leftTime / 3600;
            int min = (int)((leftTime - (hour * 3600))/60);
            int sec = (int)(leftTime - (hour * 3600) - (min * 60));
            string showStr = hour + "时" + min + "分" + sec + "秒";
            reviveTime.GetComponent<Text>().text = $"{monsterConfig.MonsterName} 刷新剩余时间:{showStr}";
        }

        public void RecoverGameObject(GameObject HeadBar)
        {
            if (HeadBar != null)
            {
                HeadBar.SetActive(false);
                GameObjectPoolComponent.Instance.RecoverGameObject(HeadBarPath, HeadBar);
                HeadBar = null;
            }
        }
    }

    public static class HeroHeadBarComponentSystem
    {
        public static void UpdatePlayerName(this HeroHeadBarComponent self, string playerName)
        { 
            
        }

        public static void UpdateStallName(this HeroHeadBarComponent self, string stallName)
        {
            self.Lal_ShopName.GetComponent<TextMeshProUGUI>().text = stallName;
        }

        public static void UpdateShield(this HeroHeadBarComponent self)
        { 
            
        }

        public static void OnUnitStallUpdate(this HeroHeadBarComponent self, int stallType)
        {
            UnitInfoComponent infoComponent = self.GetParent<Unit>().GetComponent<UnitInfoComponent>();

            //显示玩家名称
            if (stallType == 0)
            {
                self.ObjName.GetComponent<TextMeshProUGUI>().text = infoComponent.PlayerName;
                self.ShopShowSet.SetActive(false);
                self.PlayerNameSet.SetActive(true);
            }
            else
            {
                self.Lal_ShopName.GetComponent<TextMeshProUGUI>().text = infoComponent.StallName;
                self.ShopShowSet.SetActive(true);
                self.PlayerNameSet.SetActive(false);
            }
        }
    }
}