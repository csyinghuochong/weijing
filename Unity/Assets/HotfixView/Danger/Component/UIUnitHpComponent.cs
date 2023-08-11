using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    [Timer(TimerType.UIUnitReviveTime)]
    public class UIUnitReviveTime : ATimer<UIUnitHpComponent>
    {
        public override void Run(UIUnitHpComponent self)
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

    public class UIUnitHpComponentAwakeSystem : AwakeSystem<UIUnitHpComponent>
    {
        public override void Awake(UIUnitHpComponent self)
        {
            self.Awake();
        }
    }

    public class UIUnitHpComponentDestroySystem : DestroySystem<UIUnitHpComponent>
    {
        public override void Destroy(UIUnitHpComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
            self.RecoverGameObject(self.GameObject);
        }
    }

    /// <summary>
    /// 头部血条组件，负责血条的密度以及血条与人物的同步
    /// </summary>
    public class UIUnitHpComponent: Entity, IAwake, IDestroy
    {

        public GameObject Lal_Name;
        public GameObject Img_HpValue;
        public GameObject GameObject;
        public GameObject UIPlayerHpText;
        public GameObject BuffShieldValue;
        public GameObject Img_ChengHao;
        public GameObject Img_AngleValue;
        public GameObject Img_AngleValueDi;
        public Transform UIPosition;
        public string HeadBarPath;
        public Vector2 LastPositon;
        public GameObject Lal_ShopName;
        public GameObject ShopShowSet;
        public GameObject PlayerNameSet;
        public GameObject Lal_JiaZuName;
        public UIXuLieZhenComponent UIXuLieZhenComponent;
        public float LastTime;
        public long Timer;

        public void  Awake( )
        {
            this.GameObject = null;
            this.Img_HpValue = null;
            this.Img_AngleValue = null;
            this.Img_AngleValueDi = null;   
            this.HeadBarPath = "";
            this.LastTime = 0f;
            switch (this.GetParent<Unit>().Type)
            {
                case UnitType.Player:
                    this.HeadBarPath = ABPathHelper.GetUGUIPath("Blood/UIUnitHp");
                    break;
                case UnitType.Monster:
                    this.HeadBarPath = ABPathHelper.GetUGUIPath("Blood/UIMonsterHp");
                    break;
                case UnitType.Pet:
                case UnitType.JingLing:
                    this.HeadBarPath = ABPathHelper.GetUGUIPath("Blood/UIUnitHp");
                    break;
            }
            GameObjectPoolComponent.Instance.AddLoadQueue(HeadBarPath, this.InstanceId, this.OnLoadGameObject);
        }

        public void ShowHearBar(bool show)
        {
            this.GameObject.SetActive(show);
        }

        public void OnLoadGameObject(GameObject gameObject, long formId)
        {
            if (this.IsDisposed)
            {
                this.RecoverGameObject(gameObject);
                return;
            }
            this.GameObject = gameObject;
            Unit unit = this.GetParent<Unit>();
            ReferenceCollector rc = this.GameObject.GetComponent<ReferenceCollector>();

            Unit mainUnit = UnitHelper.GetMyUnitFromZoneScene(this.ZoneScene());
            bool canAttack = mainUnit.IsCanAttackUnit(unit);
            this.Img_HpValue = rc.Get<GameObject>("Img_HpValue");
            switch (unit.Type)
            {
                case UnitType.Monster:
                    string imageHp = canAttack ? StringBuilderHelper.UI_pro_4_2 : StringBuilderHelper.UI_pro_3_2;
                    Sprite sp = rc.Get<GameObject>(imageHp).GetComponent<Image>().sprite;
                    rc.Get<GameObject>("Img_HpValue").SetActive(true);
                    this.Img_HpValue.GetComponent<Image>().sprite = sp;
                    rc.Get<GameObject>("Alive").SetActive(true);
                    rc.Get<GameObject>("Dead").SetActive(false);
                    rc.Get<GameObject>("ReviveTime").SetActive(false);
                    break;
                case UnitType.Player:
                    imageHp = canAttack ? StringBuilderHelper.UI_pro_4_2: StringBuilderHelper.UI_pro_3_2;
                    sp = rc.Get<GameObject>(imageHp).GetComponent<Image>().sprite;
                    this.PlayerNameSet = rc.Get<GameObject>("PlayerNameSet");
                    this.Img_HpValue.GetComponent<Image>().sprite = sp;
                    this.BuffShieldValue = rc.Get<GameObject>("BuffShieldValue");
                    this.Img_ChengHao = rc.Get<GameObject>("Img_ChengHao");
                    this.Img_ChengHao.SetActive(true);
                    this.PlayerNameSet.SetActive(true);
                    this.Lal_ShopName = rc.Get<GameObject>("Lal_ShopName");
                    this.ShopShowSet = rc.Get<GameObject>("ShopShowSet");
                    this.Img_AngleValue = rc.Get<GameObject>("Img_AngleValue");
                    this.Img_AngleValue.SetActive(false);
                    this.Img_AngleValueDi = rc.Get<GameObject>("Img_AngleValueDi");
                    this.Img_AngleValueDi.SetActive(false);
                    this.UIXuLieZhenComponent = this.AddChild<UIXuLieZhenComponent, GameObject>(this.Img_ChengHao);
                    break;
                case UnitType.Pet:
                case UnitType.JingLing:
                    imageHp = canAttack ? StringBuilderHelper.UI_pro_4_2: StringBuilderHelper.UI_pro_3_4;
                    sp = rc.Get<GameObject>(imageHp).GetComponent<Image>().sprite;
                    this.PlayerNameSet = rc.Get<GameObject>("PlayerNameSet");
                    this.Img_HpValue.GetComponent<Image>().sprite = sp;
                    this.Img_ChengHao = rc.Get<GameObject>("Img_ChengHao");
                    this.Img_ChengHao.SetActive(false);
                    this.PlayerNameSet.SetActive(unit.Type == UnitType.Pet);
                    this.Img_AngleValue = rc.Get<GameObject>("Img_AngleValue");
                    this.Img_AngleValue.SetActive(false);
                    this.Img_AngleValueDi = rc.Get<GameObject>("Img_AngleValueDi");
                    this.Img_AngleValueDi.SetActive(false);
                    break;
                default:
                    break;
            }

            this.Lal_Name = rc.Get<GameObject>("Lal_Name");
            this.Lal_JiaZuName = rc.Get<GameObject>("Lal_JiaZuName");
            this.UIPosition = unit.GetComponent<HeroTransformComponent>().GetTranform(PosType.Head);
            GameObject bloodparent = unit.Type == UnitType.Monster ? UIEventComponent.Instance.BloodMonster :  UIEventComponent.Instance.BloodPlayer ;
            this.GameObject.transform.SetParent(bloodparent.transform);
            this.GameObject.transform.localScale = Vector3.one;

            this.UIPlayerHpText = rc.Get<GameObject>("UIPlayerHpText");
            this.UIPlayerHpText.transform.SetParent(UIEventComponent.Instance.BloodText.transform);
            this.UIPlayerHpText.transform.localScale = Vector3.one;
            HeadBarUI HeadBarUI_1 = this.UIPlayerHpText.GetComponent<HeadBarUI>();
            HeadBarUI_1.enabled = !unit.MainHero;
            HeadBarUI_1.HeadPos = UIPosition;
            HeadBarUI_1.HeadBar = this.UIPlayerHpText;
            HeadBarUI_1.UiCamera = UIComponent.Instance.UICamera;
            HeadBarUI_1.MainCamera = UIComponent.Instance.MainCamera;
            HeadBarUI_1.UpdatePostion();

            HeadBarUI HeadBarUI_2 = this.GameObject.GetComponent<HeadBarUI>();
            HeadBarUI_2.enabled =  !unit.MainHero;
            HeadBarUI_2.HeadPos = UIPosition;
            HeadBarUI_2.HeadBar = GameObject;
            HeadBarUI_2.UiCamera = UIComponent.Instance.UICamera;
            HeadBarUI_2.MainCamera = UIComponent.Instance.MainCamera;
            HeadBarUI_2.UpdatePostion();

            if (unit.MainHero)
            {
                OnUpdateHorse();
                this.GameObject.transform.SetAsLastSibling();
            }
            else
            {
                this.GameObject.transform.SetAsFirstSibling();
            }
            this.GameObject.SetActive(SettingHelper.ShowBlood);

            //初始化当前血条
            UpdateBlood();
            //更新显示
            UpdateShow();

            ShowJueXingAnger();
        }

        public void OnUpdateHorse(  )
        {
            if (this.GameObject == null)
            {
                return;
            }

            Unit unit = this.GetParent<Unit>();
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            int horseRide = numericComponent.GetAsInt(NumericType.HorseRide);
            this.GameObject.transform.localPosition = horseRide > 0 ? new Vector3(0f, 180f, 0f): new Vector3(0f, 120f, 0f);

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
                    tilteid = unit.MainHero ? tilteid : 0;
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
                TextMeshProUGUI textMeshProUGUI = this.Lal_Name.GetComponent<TextMeshProUGUI>();
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
                        this.Lal_Name.GetComponent<TextMeshProUGUI>().text = $"深渊召唤:{colorstr}{monsterCof.MonsterName}</color>";
                    }
                    else
                    {
                        this.Lal_Name.GetComponent<TextMeshProUGUI>().text = $"{colorstr}{monsterCof.MonsterName}</color>";
                    }
                }
                else
                {
                    this.Lal_Name.GetComponent<TextMeshProUGUI>().text = $"{colorstr}{monsterCof.MonsterName}</color>";
                }

                //怪物等级显示
                ReferenceCollector rc = this.GameObject.GetComponent<ReferenceCollector>();
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
                this.Lal_Name.GetComponent<TextMeshProUGUI>().text = unitInfoComponent.UnitName;
                this.Lal_JiaZuName.GetComponent<TextMeshProUGUI>().text = $"{unitInfoComponent.MasterName }的宠物";
            }
            if (this.GetParent<Unit>().Type == UnitType.JingLing)
            {
                UnitInfoComponent unitInfoComponent = this.GetParent<Unit>().GetComponent<UnitInfoComponent>();
                this.Lal_Name.GetComponent<TextMeshProUGUI>().text = unitInfoComponent.UnitName;
                this.Lal_JiaZuName.GetComponent<TextMeshProUGUI>().text = $"{unitInfoComponent.MasterName }的精灵";
            }
        }

        public void OnRevive()
        {
            if (this.GameObject == null)
            {
                return;
            }
            TimerComponent.Instance.Remove(ref this.Timer);
            if (this.GetParent<Unit>().Type == UnitType.Monster)
            {
                ReferenceCollector rc = this.GameObject.GetComponent<ReferenceCollector>();
                rc.Get<GameObject>("Alive").SetActive(true);
                rc.Get<GameObject>("Dead").SetActive(false);
                rc.Get<GameObject>("ReviveTime").SetActive(false);
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
                ReferenceCollector rc = this.GameObject.GetComponent<ReferenceCollector>();
                rc.Get<GameObject>("Alive").SetActive(false);
                rc.Get<GameObject>("Dead").SetActive(true);
                rc.Get<GameObject>("ReviveTime").SetActive(true);

                TimerComponent.Instance.Remove(ref this.Timer);
                this.Timer = TimerComponent.Instance.NewRepeatedTimer(1000, TimerType.UIUnitReviveTime, this);
            }
        }

        public void UpdateAI()
        {
            if (this.Lal_Name != null)
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
            if (Img_HpValue == null)
            {
                return;
            }
            int unitType = this.GetParent<Unit>().Type;
            switch (unitType)
            {
                case UnitType.Player:
                    this.Img_HpValue.GetComponent<Image>().fillAmount = blood;
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
                    this.Img_HpValue.GetComponent<Image>().fillAmount = blood;
                    break;
                default:
                    this.Img_HpValue.GetComponent<Image>().fillAmount = blood;
                    break;
            }
        }

        public void OnTimer()
        {
            MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(this.GetParent<Unit>().ConfigId);
            long leftTime = this.Parent.GetComponent<NumericComponent>().GetAsLong(NumericType.ReviveTime) - TimeHelper.ClientNow();
            leftTime = leftTime / 1000;
            ReferenceCollector rc = this.GameObject.GetComponent<ReferenceCollector>();
            GameObject reviveTime = rc.Get<GameObject>("ReviveTime");
            int hour = (int) leftTime / 3600;
            int min = (int)((leftTime - (hour * 3600))/60);
            int sec = (int)(leftTime - (hour * 3600) - (min * 60));
            string showStr = hour + "时" + min + "分" + sec + "秒";
            reviveTime.GetComponent<Text>().text = $"{monsterConfig.MonsterName} 刷新剩余时间:{showStr}";
        }

        public  void ShowJueXingAnger()
        {
            Unit unit = this.GetParent<Unit>();
            if (!unit.MainHero)
            {
                if (this.Img_AngleValue != null)
                {
                    this.Img_AngleValue.SetActive(false);
                    this.Img_AngleValueDi.SetActive(false);
                }
                return;
            }
            UserInfoComponent userInfoComponent = this.ZoneScene().GetComponent<UserInfoComponent>();
            if (userInfoComponent == null || userInfoComponent.UserInfo == null)
            {
                return;

            }

            int occTwo = userInfoComponent.UserInfo.OccTwo;
            if (occTwo == 0)
            {
                return;
            }
            SkillSetComponent skillSetComponent = this.ZoneScene().GetComponent<SkillSetComponent>();
            OccupationTwoConfig occupationConfigCategory = OccupationTwoConfigCategory.Instance.Get(occTwo);
            this.Img_AngleValue.SetActive(skillSetComponent.GetSkillPro(occupationConfigCategory.JueXingSkill[7]) != null);
            this.Img_AngleValueDi.SetActive(skillSetComponent.GetSkillPro(occupationConfigCategory.JueXingSkill[7]) != null);
        }


        public void RecoverGameObject(GameObject gameobject)
        {
            if (gameobject != null)
            {
                gameobject.GetComponent<HeadBarUI>().enabled = false;
                if (this.UIPlayerHpText != null)
                {
                    this.UIPlayerHpText.GetComponent<HeadBarUI>().enabled = false;
                    this.UIPlayerHpText.transform.SetParent(gameobject.transform);
                }
               
                GameObjectPoolComponent.Instance.RecoverGameObject(this.HeadBarPath, gameobject);
                this.GameObject = null;
            }
        }
    }

    public static class UIUnitHpComponentSystem
    {
        public static void UpdateStallName(this UIUnitHpComponent self, string stallName)
        {
            self.Lal_ShopName.GetComponent<TextMeshProUGUI>().text = stallName;
        }

        public static void UpdateShield(this UIUnitHpComponent self)
        { 
            
        }

        public static void UptateJueXingAnger(this UIUnitHpComponent self)
        {
            if (self.Img_AngleValue == null)
            {
                return;
            }
            Unit unit = self.GetParent<Unit>();
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            float value = numericComponent.GetAsInt(NumericType.JueXingAnger) * 1f/ 500;
            self.Img_AngleValue.GetComponent<Image>().fillAmount = Math.Min( value, 1f );
        }

        public static void OnUnitStallUpdate(this UIUnitHpComponent self, int stallType)
        {
            UnitInfoComponent infoComponent = self.GetParent<Unit>().GetComponent<UnitInfoComponent>();

            //显示玩家名称
            if (stallType == 0)
            {
                self.Lal_Name.GetComponent<TextMeshProUGUI>().text = infoComponent.UnitName;
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