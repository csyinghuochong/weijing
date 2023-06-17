using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    [Timer(TimerType.HeroHeadReviveTime)]
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

    public class HeroHeadBarComponentAwakeSystem: AwakeSystem<HeroHeadBarComponent>
    {
        public override void Awake(HeroHeadBarComponent self)
        {
            self.Awake();
        }
    }

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
        public GameObject UIPlayerHpText;
        public GameObject BuffShieldValue;
        public GameObject Img_ChengHao;
        public Transform UIPosition;
        public string HeadBarPath;
        public Vector2 LastPositon;
        public GameObject Lal_ShopName;
        public GameObject ShopShowSet;
        public GameObject PlayerNameSet;
        public GameObject Lal_NameOwner;
        public GameObject Lal_JiaZuName;
        public HeadBarUI HeadBarUI;
        public float LastTime;
        public long Timer;
        public UIXuLieZhenComponent UIXuLieZhenComponent;

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
            if (m_Hero.Type == UnitType.Pet || m_Hero.Type == UnitType.JingLing)
            {
                HeadBarPath = ABPathHelper.GetUGUIPath("Battle/UIPetHp");
            }
            long instanceid = this.InstanceId;
            GameObjectPoolComponent.Instance.AddLoadQueue(HeadBarPath, this.InstanceId, this.OnLoadGameObject);
        }

        public void ShowHearBar(bool show)
        {
            this.HeadBar.SetActive(show);
        }

        public void OnLoadGameObject(GameObject gameObject, long formId)
        {
            if (this.IsDisposed)
            {
                this.RecoverGameObject(gameObject);
                return;
            }
            this.HeadBar = gameObject;
            Unit unit = this.GetParent<Unit>();
            ReferenceCollector rc = this.HeadBar.GetComponent<ReferenceCollector>();

            Unit mainUnit = UnitHelper.GetMyUnitFromZoneScene(this.ZoneScene());
            bool canAttack = mainUnit.IsCanAttackUnit(unit);
            this.ObjHp = rc.Get<GameObject>("Img_HpValue");
            switch (unit.Type)
            {
                case UnitType.Monster:
                    string imageHp = canAttack ? StringBuilderHelper.UI_pro_4_2 : StringBuilderHelper.UI_pro_3_2;
                    Sprite sp = rc.Get<GameObject>(imageHp).GetComponent<Image>().sprite;
                    rc.Get<GameObject>("Img_HpValue").SetActive(true);
                    this.ObjHp.GetComponent<Image>().sprite = sp;
                    break;
                case UnitType.Player:
                    imageHp = canAttack ? StringBuilderHelper.UI_pro_4_2: StringBuilderHelper.UI_pro_3_2;
                    sp = rc.Get<GameObject>(imageHp).GetComponent<Image>().sprite;
                    this.ObjHp.GetComponent<Image>().sprite = sp;
                    this.BuffShieldValue = rc.Get<GameObject>("BuffShieldValue");
                    this.Img_ChengHao = rc.Get<GameObject>("Img_ChengHao");
                    this.UIXuLieZhenComponent = this.AddChild<UIXuLieZhenComponent, GameObject>(this.Img_ChengHao);
                    break;
                case UnitType.Pet:
                case UnitType.JingLing:
                    imageHp = canAttack ? StringBuilderHelper.UI_pro_4_2: StringBuilderHelper.UI_pro_3_4;
                    GameObject ImageHpFill = rc.Get<GameObject>("ImageHpFill");
                    sp = rc.Get<GameObject>(imageHp).GetComponent<Image>().sprite;
                    ImageHpFill.GetComponent<Image>().sprite = sp;
                    break;
                default:
                    break;
            }

            this.ObjName = rc.Get<GameObject>("Lal_Name");
            this.Lal_ShopName = rc.Get<GameObject>("Lal_ShopName");
            this.ShopShowSet = rc.Get<GameObject>("ShopShowSet");
            this.PlayerNameSet = rc.Get<GameObject>("PlayerNameSet");
            this.Lal_JiaZuName = rc.Get<GameObject>("Lal_JiaZuName");
            this.UIPosition = unit.GetComponent<HeroTransformComponent>().GetTranform(PosType.Head);
            if (unit.Type == UnitType.Monster)
            {
                rc.Get<GameObject>("Alive").SetActive(true);
                rc.Get<GameObject>("Dead").SetActive(false);
            }
            if (unit.Type == UnitType.Pet || unit.Type == UnitType.JingLing)
            {
                this.Lal_NameOwner = rc.Get<GameObject>("Lal_NameOwner");
            }
            if (unit.Type == UnitType.Player)
            {
                GameObject bloodparent =  UIEventComponent.Instance.BloodPlayer ;
                this.HeadBar.transform.SetParent(bloodparent.transform);
                this.HeadBar.transform.localScale = Vector3.one;

                this.UIPlayerHpText = this.HeadBar.transform.Find("UIPlayerHpText").gameObject;
                this.UIPlayerHpText.transform.SetParent(UIEventComponent.Instance.BloodText.transform);
                this.UIPlayerHpText.transform.localScale = Vector3.one;
                HeadBarUI HeadBarUI_1 = this.UIPlayerHpText.GetComponent<HeadBarUI>();
                HeadBarUI_1.enabled = !unit.MainHero;
                HeadBarUI_1.HeadPos = UIPosition;
                HeadBarUI_1.HeadBar = this.UIPlayerHpText;
            }
            else
            {
                GameObject bloodparent =  UIEventComponent.Instance.BloodMonster;
                this.HeadBar.transform.SetParent(bloodparent.transform);
                this.HeadBar.transform.localScale = Vector3.one;
            }

            if (HeadBar.GetComponent<HeadBarUI>() == null)
            {
                HeadBar.AddComponent<HeadBarUI>();
            }
            this.HeadBarUI = HeadBar.GetComponent<HeadBarUI>();
            this.HeadBarUI.enabled =  !unit.MainHero;
            this.HeadBarUI.HeadPos = UIPosition;
            this.HeadBarUI.HeadBar = HeadBar;
            if (unit.MainHero)
            {
                OnUpdateHorse();
                this.HeadBar.transform.SetAsLastSibling();
            }
            else
            {
                this.HeadBar.transform.SetAsFirstSibling();
            }
            this.HeadBar.SetActive(SettingHelper.ShowBlood);

            //初始化当前血条
            UpdateBlood();
            //更新显示
            UpdateShow();
        }

        public void OnUpdateHorse(  )
        {
            if (this.HeadBar == null)
            {
                return;
            }

            Unit unit = this.GetParent<Unit>();
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            int horseRide = numericComponent.GetAsInt(NumericType.HorseRide);
            this.HeadBar.transform.localPosition = horseRide > 0 ? new Vector3(0f, 180f, 0f): new Vector3(0f, 120f, 0f);

            if (unit.MainHero)
            {
                this.UIPlayerHpText.transform.localPosition = horseRide > 0 ? new Vector3(0f, 180f, 0f) : new Vector3(0f, 120f, 0f);
            }
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

                int tilteid = numericComponent.GetAsInt(NumericType.TitleID);
                if (!SettingHelper.ShowTitle ||  UnitHelper.GetUnitList(unit.DomainScene(), UnitType.Player).Count > SettingHelper.NoShowTitle)
                {
                    tilteid = 0;
                }
                this.UIXuLieZhenComponent.OnUpdateTitle(tilteid).Coroutine();

                this.OnUnitStallUpdate(numericComponent.GetAsInt(NumericType.Now_Stall));
                string unionname = string.Empty;
                Vector3 vector3_pos = Vector3.zero;
                //判断自身是否有家族进行显示
                if (infoComponent.UnionName.Length > 0)
                {
                    string text1 = numericComponent.GetAsInt(NumericType.UnionLeader) == 1 ? StringBuilderHelper.族长 : StringBuilderHelper.成员;
                    unionname = infoComponent.UnionName + text1;
                    vector3_pos = new Vector3(0f, 100f, 0f);
                }
                else
                {
                    unionname = String.Empty;
                    vector3_pos = new Vector3(0f, 75f, 0f);
                }
                if (numericComponent.GetAsInt(NumericType.UnionRaceWin) == 1 && !string.IsNullOrEmpty(unionname))
                {
                    unionname += "(争霸)";
                }

                this.Lal_JiaZuName.GetComponent<TextMeshProUGUI>().text = unionname;
                this.Img_ChengHao.transform.localPosition = vector3_pos;
            }
            //显示怪物名称
            if (unit.Type == UnitType.Monster)
            {
                MonsterConfig monsterCof = MonsterConfigCategory.Instance.Get(this.GetParent<Unit>().ConfigId);
                TextMeshProUGUI textMeshProUGUI = this.ObjName.GetComponent<TextMeshProUGUI>();
                bool isboos = monsterCof.MonsterType == (int)MonsterTypeEnum.Boss;
                textMeshProUGUI.fontSize = isboos ? 32 : 26;
                textMeshProUGUI.color = isboos ? new Color(255,95,255): Color.white;
                string colorstr = isboos ? "<color=#FF5FFF>" : "<color=#FFFFFF>";
                //NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
                //this.ObjName.GetComponent<TextMeshProUGUI>().text = $"{colorstr}{monsterCof.MonsterName}_{numericComponent.GetAsInt(NumericType.Now_AI)}</color>";
                MapComponent mapComponent = unit.ZoneScene().GetComponent<MapComponent>();    
                bool shenYuan = mapComponent.SceneTypeEnum == SceneTypeEnum.TeamDungeon && mapComponent.FubenDifficulty == TeamFubenType.ShenYuan;
                if (shenYuan)
                {
                    if (monsterCof.MonsterType == 3)
                    {
                        this.ObjName.GetComponent<TextMeshProUGUI>().text = $"深渊召唤:{colorstr}{monsterCof.MonsterName}</color>";
                    }
                    else
                    {
                        this.ObjName.GetComponent<TextMeshProUGUI>().text = $"{colorstr}{monsterCof.MonsterName}</color>";
                    }
                }
                else
                {
                    this.ObjName.GetComponent<TextMeshProUGUI>().text = $"{colorstr}{monsterCof.MonsterName}</color>";
                }

                //怪物等级显示
                ReferenceCollector rc = HeadBar.GetComponent<ReferenceCollector>();
                int monsterLv = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Lv);
                if (monsterLv > 0)
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
                UnitInfoComponent unitInfoComponent = this.GetParent<Unit>().GetComponent<UnitInfoComponent>();
                ObjName.GetComponent<TextMeshProUGUI>().text = unitInfoComponent.UnitName;
                this.Lal_NameOwner.GetComponent<TextMeshProUGUI>().text = $"{unitInfoComponent.MasterName }的宠物";
                this.ObjHp.SetActive(true);
                ReferenceCollector rc = this.HeadBar.GetComponent<ReferenceCollector>();
                rc.Get<GameObject>("Img_Di").SetActive(true);
            }
            if (this.GetParent<Unit>().Type == UnitType.JingLing)
            {
                UnitInfoComponent unitInfoComponent = this.GetParent<Unit>().GetComponent<UnitInfoComponent>();
                ObjName.GetComponent<TextMeshProUGUI>().text = unitInfoComponent.UnitName;
                this.Lal_NameOwner.GetComponent<TextMeshProUGUI>().text = $"{unitInfoComponent.MasterName }的精灵";
                this.ObjHp.SetActive(false);
                this.ObjName.SetActive(false);
                ReferenceCollector rc = this.HeadBar.GetComponent<ReferenceCollector>();
                rc.Get<GameObject>("Img_Di").SetActive(false);
            }
        }

        public void OnRevive()
        {
            if (this.HeadBar == null)
            {
                return;
            }
            TimerComponent.Instance.Remove(ref this.Timer);
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
                this.Timer = TimerComponent.Instance.NewRepeatedTimer(1000, TimerType.HeroHeadReviveTime, this);
            }
        }

        public void UpdateAI()
        {
            if (this.ObjName != null)
            {
                UpdateShow();
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
                    this.ObjHp.GetComponent<Image>().fillAmount = blood;
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
                    this.ObjHp.GetComponent<Image>().fillAmount = blood;
                    break;
                default:
                    this.ObjHp.GetComponent<Image>().fillAmount = blood;
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
                Unit unit = this.GetParent<Unit>();
                if (unit.Type == UnitType.Player)
                {
                    this.UIPlayerHpText.transform.SetParent(HeadBar.transform);
                }

                HeadBar.SetActive(false);
                GameObjectPoolComponent.Instance.RecoverGameObject(HeadBarPath, HeadBar);
                HeadBar = null;
            }
        }
    }

    public static class HeroHeadBarComponentSystem
    {
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
                self.ObjName.GetComponent<TextMeshProUGUI>().text = infoComponent.UnitName;
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