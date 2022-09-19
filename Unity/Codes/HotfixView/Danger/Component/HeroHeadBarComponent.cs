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
            self.Awake().Coroutine();
        }
    }

    [ObjectSystem]
    public class HeroHeadBarComponentDestroySystem : DestroySystem<HeroHeadBarComponent>
    {
        public override void Destroy(HeroHeadBarComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
            self.Destroy();
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
        public Transform UIPosition;
        public string HeadBarPath;
        public Vector2 LastPositon;
        public GameObject Obj_Lal_ShopName;
        public GameObject Obj_ShopShowSet;
        public GameObject Obj_PlayerNameSet;
        public GameObject Lal_NameOwner;
        public GameObject JiaZuShowSet;
        public GameObject Lal_JiaZuName;
        public bool mainHero;
        public float LastTime;
        public long Timer;
        public HeadBarUI HeadBarUI;

        public async ETTask Awake( )
        {
            HeadBar = null;
            HeadBarUI = null;
            ObjHp = null;
            HeadBarPath = "";
            LastTime = 0f;
            Unit m_Hero = GetParent<Unit>();
            mainHero = m_Hero.MainHero;
            UiCamera = GameObject.Find("Global/UI/UICamera").GetComponent<Camera>();
            MainCamera = GameObject.Find("Global/Main Camera").GetComponent<Camera>();
            if (m_Hero.GetComponent<UnitInfoComponent>().Type == UnitType.Player)
            {
                HeadBarPath = ABPathHelper.GetUGUIPath("Battle/UIPlayerHp");
            }
            if (m_Hero.GetComponent<UnitInfoComponent>().Type == UnitType.Monster)
            {
                HeadBarPath = ABPathHelper.GetUGUIPath("Battle/UIMonsterHp");
            }
            if (m_Hero.GetComponent<UnitInfoComponent>().Type == UnitType.Pet)
            {
                HeadBarPath = ABPathHelper.GetUGUIPath("Battle/UIPetHp");
            }
            long instanceid = this.InstanceId;
            HeadBar = await GameObjectPoolComponent.Instance.GetExternal(HeadBarPath);
            HeadBar.SetActive(true);
            if (instanceid != this.InstanceId)
            {
                return;
            }

            ReferenceCollector rc = HeadBar.GetComponent<ReferenceCollector>();
            ObjName = rc.Get<GameObject>("Lal_Name");
            ObjHp = rc.Get<GameObject>("Img_HpValue");
            Obj_Lal_ShopName = rc.Get<GameObject>("Lal_ShopName");
            Obj_ShopShowSet = rc.Get<GameObject>("ShopShowSet");
            Obj_PlayerNameSet = rc.Get<GameObject>("PlayerNameSet");
            JiaZuShowSet = rc.Get<GameObject>("JiaZuShowSet");
            Lal_JiaZuName = rc.Get<GameObject>("Lal_JiaZuName");
            UIPosition = m_Hero.GetComponent<HeroTransformComponent>().GetTranform(PosType.Head);

            HeadBar.transform.SetParent(UIEventComponent.Instance.UILayers[(int)UILayer.Blood]);
            HeadBar.transform.localScale = Vector3.one;
            if (m_Hero.GetComponent<UnitInfoComponent>().Type == UnitType.Monster)
            {
                rc.Get<GameObject>("Alive").SetActive(true);
                rc.Get<GameObject>("Dead").SetActive(false);
            }
            if (m_Hero.GetComponent<UnitInfoComponent>().Type == UnitType.Pet)
            {
                this.Lal_NameOwner = rc.Get<GameObject>("Lal_NameOwner");
            }
            //初始化当前血条
            UpdateBlood();
            //更新显示
            UpdateShow( );

            if (HeadBar.GetComponent<HeadBarUI>() == null)
            {
                HeadBar.AddComponent<HeadBarUI>();
            }
            HeadBarUI = HeadBar.GetComponent<HeadBarUI>();
            HeadBarUI.enabled = !mainHero;
            HeadBarUI.HeadPos = UIPosition;
            HeadBarUI.HeadBar = HeadBar;
            if (mainHero)
            {
                HeadBar.transform.localPosition = new Vector3(0f, 120f, 0f);
            }
        }

        //更新显示
        public void UpdateShow()
        {
            UnitInfoComponent infoComponent = this.Parent.GetComponent<UnitInfoComponent>();

            //显示玩家名称
            if (infoComponent.Type == UnitType.Player)
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
            if (infoComponent.Type == UnitType.Monster)
            {
                MonsterConfig monsterCof = MonsterConfigCategory.Instance.Get(this.Parent.GetComponent<UnitInfoComponent>().UnitCondigID);
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
                if (mapComponent.SceneTypeEnum == (int)SceneTypeEnum.Tower)
                {
                    UserInfoComponent userInfoComponent = this.ZoneScene().GetComponent<UserInfoComponent>();
                    rc.Get<GameObject>("Lal_Lv").GetComponent<TextMeshProUGUI>().text = userInfoComponent.UserInfo.Lv.ToString();
                }
                else
                {
                    rc.Get<GameObject>("Lal_Lv").GetComponent<TextMeshProUGUI>().text = monsterCof.Lv.ToString();
                }
            }
            if (infoComponent.Type == UnitType.Pet) 
            {
                ObjName.GetComponent<TextMeshProUGUI>().text = PetConfigCategory.Instance.Get(infoComponent.UnitCondigID).PetName;
                //ReferenceCollector rc = ObjSave.GetComponent<ReferenceCollector>();
                //rc.Get<GameObject>("Lal_Lv").GetComponent<TextMeshProUGUI>().text = hero.GetComponent<UserInfoComponent>().UserInfo.Lv.ToString();
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
            if (infoComponent.Type == UnitType.Monster)
            {
                ReferenceCollector rc = this.HeadBar.GetComponent<ReferenceCollector>();
                rc.Get<GameObject>("Alive").SetActive(true);
                rc.Get<GameObject>("Dead").SetActive(false);
            } 
            UpdateBlood();
        }

        public void OnDead()
        {
            if (this.Parent.GetComponent<UnitInfoComponent>().Type != UnitType.Monster)
            {
                return;
            }
            MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(this.Parent.GetComponent<UnitInfoComponent>().UnitCondigID);
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
            float curhp = this.Parent.GetComponent<NumericComponent>().GetAsLong(NumericType.Now_Hp); // + value;
            float blood = curhp / this.Parent.GetComponent<NumericComponent>().GetAsLong(NumericType.Now_MaxHp);
            blood = Mathf.Max(blood, 0f);
            if (ObjHp != null)
            {
                if (this.Parent.GetComponent<UnitInfoComponent>().Type == UnitType.Player|| this.Parent.GetComponent<UnitInfoComponent>().Type == UnitType.Pet)
                {
                    ObjHp.GetComponent<Slider>().value = blood;
                }
                else {
                    ObjHp.GetComponent<Image>().fillAmount = blood;
                }
            }
        }

        public void OnTimer()
        {
            ReferenceCollector rc = this.HeadBar.GetComponent<ReferenceCollector>();
           
            MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(this.Parent.GetComponent<UnitInfoComponent>().UnitCondigID);
            long leftTime = this.Parent.GetComponent<NumericComponent>().GetAsLong(NumericType.ReviveTime) - TimeHelper.ClientNow();
            leftTime = leftTime / 1000;
            GameObject reviveTime = rc.Get<GameObject>("Dead").transform.Find("ReviveTime").gameObject;
            int hour = (int) leftTime / 3600;
            int min = (int)((leftTime - (hour * 3600))/60);
            int sec = (int)(leftTime - (hour * 3600) - (min * 60));
            string showStr = hour + "时" + min + "分" + sec + "秒";
            reviveTime.GetComponent<Text>().text = $"{monsterConfig.MonsterName} 刷新剩余时间:{showStr}";
        }

        public void Destroy()
        {
            if (HeadBar != null)
            {
                HeadBar.SetActive(false);
                GameObjectPoolComponent.Instance.InternalPut(HeadBarPath, HeadBar);
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
            self.Obj_Lal_ShopName.GetComponent<TextMeshProUGUI>().text = stallName;
        }

        public static void OnUnitStallUpdate(this HeroHeadBarComponent self, int stallType)
        {
            UnitInfoComponent infoComponent = self.GetParent<Unit>().GetComponent<UnitInfoComponent>();

            //显示玩家名称
            if (stallType == 0)
            {
                self.ObjName.GetComponent<TextMeshProUGUI>().text = infoComponent.PlayerName;
                self.Obj_ShopShowSet.SetActive(false);
                self.Obj_PlayerNameSet.SetActive(true);
            }
            else
            {
                self.Obj_Lal_ShopName.GetComponent<TextMeshProUGUI>().text = infoComponent.StallName;
                self.Obj_ShopShowSet.SetActive(true);
                self.Obj_PlayerNameSet.SetActive(false);
            }
        }
    }
}