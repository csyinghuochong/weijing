using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

namespace ET
{
    [Timer(TimerType.UIMainTimer)]
    public class UIMainTimer : ATimer<UIMainComponent>
    {
        public override void Run(UIMainComponent self)
        {
            try
            {
                self.OnCheckFuntionButton();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    [Timer(TimerType.UIMainFPSTimer)]
    public class UIMainFPSTimer : ATimer<UIMainComponent>
    {
        public override void Run(UIMainComponent self)
        {
            try
            {
                self.UpdatePing();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    public class UIMainComponent : Entity, IAwake, IDestroy
    {

        public GameObject Button_Solo;
        public GameObject Button_Donation;
        public GameObject Btn_Auction;
        public GameObject Button_JiaYuan;
        public GameObject DoMoveLeft;
        public GameObject DoMoveRight;
        public GameObject DoMoveBottom;
        public GameObject Button_NewYear;
        public GameObject Button_FenXiang;
        public GameObject FunctionSetBtn;
        public GameObject Button_Horse;
        public GameObject Button_CityHorse;
        public GameObject Button_WorldLv;
        public GameObject Button_ZhenYing;
        public GameObject Button_HongBao;
        public GameObject Btn_PetFormation;
        public GameObject Btn_GM;
        public GameObject Btn_Task;
        public Text TextPing;
        public GameObject MailHintTip;
        public GameObject UIStall;
        public GameObject Btn_Friend;
        public GameObject TeamDungeonBtn;
        public GameObject Fps;
        public GameObject Button_Energy;
        public GameObject JoystickMove;
        public GameObject JoystickFixed;
        public GameObject LeftBottomBtns;
        public GameObject Btn_PaiMaiHang;
        public GameObject Btn_EveryTask;
        public GameObject bagButton;
        public GameObject HomeButton;
        public GameObject UIMainSkill;
        public GameObject buttonReturn;
        public GameObject chengjiuButton;
        public GameObject adventureBtn;
        public GameObject duihuaButton;
        public GameObject petButton;
        public GameObject roleSkillBtn;
        public GameObject miniMapButton;
        public GameObject LevelGuideMini;
        public GameObject Obj_Img_ExpPro;
        public GameObject Obj_Lab_ExpValue;
        public GameObject Obj_Btn_ShouSuo;
        public GameObject Btn_Battle;
        public GameObject Btn_TopRight_2;
        public GameObject Btn_TopRight_1;
        public GameObject Button_Recharge;
        public GameObject Btn_Rank;

        public UI UILevelGuideMini;
        public UI UIMailHintTip;

        public UIMainChatComponent UIMainChat;
        public UIMainTaskComponent UIMainTask;
        public UIMapMiniComponent UIMapMini;
        public UIRoleHeadComponent UIRoleHead;
        public UIMainHpBarComponent UIMainHpBar;
        public UIMainTeamComponent UIMainTeam;
        public UIPageButtonComponent UIPageButtonComponent;
        public UIMainBuffComponent UIMainBuffComponent;
        public UIJoystickComponent UIJoystickComponent;
        public UIJoystickMoveComponent UIJoystickMoveComponent;
        public UIMainSkillComponent UIMainSkillComponent;
        public UIOpenBoxComponent UIOpenBoxComponent;
        public UISingingComponent UISingingComponent;
        public UIDigTreasureComponent UIDigTreasureComponent;
        public UIMainButtonPositionComponent UIMainButtonPositionComponent;

        public LockTargetComponent LockTargetComponent;
        public SkillIndicatorComponent SkillIndicatorComponent;

        public List<KeyValuePair> FunctionButtons = new List<KeyValuePair>();

        public GameObject TianQiEffectObj;
        public string TianQiEffectPath;
        public long TimerFunctiuon;
        public long TimerPing;

        public Unit MainUnit;
    }


    public class UIMainComponentAwakeSystem : AwakeSystem<UIMainComponent>
    {

        public override void Awake(UIMainComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            Transform transform = self.GetParent<UI>().GameObject.transform;
            self.DoMoveLeft = transform.Find("DoMoveLeft").gameObject;
            self.DoMoveRight = transform.Find("DoMoveRight").gameObject;
            self.DoMoveBottom = transform.Find("DoMoveBottom").gameObject;

            self.Button_Donation = rc.Get<GameObject>("Button_Donation");
            self.Button_Donation.SetActive(  GMHelp.GmAccount.Contains( self.ZoneScene().GetComponent<AccountInfoComponent>().Account ) );
            self.Button_Donation.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Create(self.ZoneScene(), UIType.UIDonation).Coroutine(); });

            self.Btn_PetFormation = rc.Get<GameObject>("Btn_PetFormation");
            ButtonHelp.AddListenerEx(self.Btn_PetFormation, () => { UIHelper.Create(self.ZoneScene(), UIType.UIPetChallenge).Coroutine(); });

            self.Button_Solo = rc.Get<GameObject>("Button_Solo");
            self.Button_Solo.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Create(self.ZoneScene(), UIType.UISolo).Coroutine(); });

            self.Btn_Auction = rc.Get<GameObject>("Btn_Auction");
            ButtonHelp.AddListenerEx(self.Btn_Auction, () => { UIHelper.Create(self.ZoneScene(), UIType.UIPaiMaiAuction).Coroutine(); });
            self.Btn_Auction.SetActive(false);
            self.Btn_GM = rc.Get<GameObject>("Btn_GM");
            self.Btn_GM.SetActive(GlobalHelp.IsBanHaoMode);
            ButtonHelp.AddListenerEx(self.Btn_GM, () => { UIHelper.Create(self.ZoneScene(), UIType.UICommand).Coroutine(); });

            self.Btn_Task = rc.Get<GameObject>("Btn_Task");
            ButtonHelp.AddListenerEx(self.Btn_Task, () => { self.OnOpenTask(); });

            self.UIStall = rc.Get<GameObject>("UIStall");
            GameObject buttonStallOpen = rc.Get<GameObject>("ButtonStallOpen");
            ButtonHelp.AddListenerEx(buttonStallOpen, () => { self.OnButtonStallOpen().Coroutine(); });

            GameObject buttonStallCancel = rc.Get<GameObject>("ButtonStallCancel");
            ButtonHelp.AddListenerEx(buttonStallCancel, () => { self.OnButtonStallCancel(); });

            self.Btn_Friend = rc.Get<GameObject>("Btn_Friend");
            ButtonHelp.AddListenerEx(self.Btn_Friend, () => { self.OnBtn_Friend(); });

            self.Button_HongBao = rc.Get<GameObject>("Button_HongBao");
            ButtonHelp.AddListenerEx(self.Button_HongBao, () => { self.OnButton_HongBao(); });
            self.Button_HongBao.SetActive(false);

            self.Button_JiaYuan = rc.Get<GameObject>("Btn_JiaYuan");
            ButtonHelp.AddListenerEx(self.Button_JiaYuan, () => { self.OnButton_JiaYuan(); });

            self.Button_ZhenYing = rc.Get<GameObject>("Button_ZhenYing");
            ButtonHelp.AddListenerEx(self.Button_ZhenYing, () => { self.OnButton_ZhenYing(); });

            self.Button_WorldLv = rc.Get<GameObject>("Button_WorldLv");
            ButtonHelp.AddListenerEx(self.Button_WorldLv, () => { self.OnButton_WorldLv(); });

            self.Button_Horse = rc.Get<GameObject>("Button_Horse");
            self.Button_CityHorse = rc.Get<GameObject>("Button_CityHorse");
            ButtonHelp.AddListenerEx(self.Button_Horse, () => { self.OnButton_Horse(); });
            ButtonHelp.AddListenerEx(self.Button_CityHorse, () => { self.OnButton_Horse(); });

            self.Button_FenXiang = rc.Get<GameObject>("Button_FenXiang");
            ButtonHelp.AddListenerEx(self.Button_FenXiang, () => { self.OnButton_FenXiang(); });

            self.Button_NewYear = rc.Get<GameObject>("Button_NewYear");
            ButtonHelp.AddListenerEx(self.Button_NewYear, () => { self.OnButton_NewYear(); });

            self.MailHintTip = rc.Get<GameObject>("MailHintTip");
            ButtonHelp.AddListenerEx(self.MailHintTip, () => { self.OnMailHintTip(); });
            UI mailHintTipUI = self.AddChild<UI, string, GameObject>("MailHintTip", self.MailHintTip);
            self.UIMailHintTip = mailHintTipUI;

            self.Btn_Battle = rc.Get<GameObject>("Btn_Battle");
            ButtonHelp.AddListenerEx(self.Btn_Battle, self.OnBtn_Battle);

            self.Fps = rc.Get<GameObject>("Fps");
            self.Fps.SetActive(false);

            //获取相关组件
            self.Obj_Img_ExpPro = rc.Get<GameObject>("Img_ExpPro");
            self.Obj_Lab_ExpValue = rc.Get<GameObject>("Lab_ExpValue");
            self.bagButton = rc.Get<GameObject>("Btn_RoseEquip");
            //self.bagButton.GetComponent<Button>().onClick.AddListener(() => { self.OnOpenBag(); });
            ButtonHelp.AddListenerEx(self.bagButton, () => { self.OnOpenBag(); });

            self.TextPing = rc.Get<GameObject>("TextPing").GetComponent<Text>();

            self.buttonReturn = rc.Get<GameObject>("Btn_RerurnBuilding");
            //self.buttonReturn.GetComponent<Button>().onClick.AddListener(() => { self.OnClickReturnButton(); });
            ButtonHelp.AddListenerEx(self.buttonReturn, () => { self.OnClickReturnButton(); });

            self.chengjiuButton = rc.Get<GameObject>("Btn_ChengJiu");
            //self.chengjiuButton.GetComponent<Button>().onClick.AddListener(() => { self.OnOpenChengjiu(); });
            ButtonHelp.AddListenerEx(self.chengjiuButton, () => { self.OnOpenChengjiu(); });
            self.adventureBtn = rc.Get<GameObject>("AdventureBtn");
            //self.adventureBtn.GetComponent<Button>().onClick.AddListener();
            ButtonHelp.AddListenerEx(self.adventureBtn, () => { self.OnEnterChapter().Coroutine(); });

            self.duihuaButton = rc.Get<GameObject>("Btn_NpcDuiHua");
            //self.duihuaButton.GetComponent<Button>().onClick.AddListener(() => { self.MoveToNpcDialog(); });
            ButtonHelp.AddListenerEx(self.duihuaButton, () => { DuiHuaHelper.MoveToNpcDialog(self.ZoneScene()); });

            //ButtonHelp.AddListenerEx(self.shiquButton, () => { self.OnShiquItem(); });

            self.petButton = rc.Get<GameObject>("Btn_Pet");
            //self.petButton.GetComponent<Button>().onClick.AddListener(() => { self.OnClickPetButton(); });
            self.petButton.GetComponent<Button>().onClick.AddListener(() => { self.OnClickPetButton(); });

            self.roleSkillBtn = rc.Get<GameObject>("Btn_RoseSkill");
            //self.roleSkillBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnClickSkillButton(); });
            ButtonHelp.AddListenerEx(self.roleSkillBtn, () => { self.OnClickSkillButton(); });

            self.miniMapButton = rc.Get<GameObject>("MiniMapButton");
            //self.miniMap.GetComponent<Button>().onClick.AddListener(() => { self.OnOpenMap(); });
            ButtonHelp.AddListenerEx(self.miniMapButton, () => { self.OnOpenMap(); });

            self.Obj_Btn_ShouSuo = rc.Get<GameObject>("Btn_ShouSuo");
            self.Obj_Btn_ShouSuo.GetComponent<Button>().onClick.AddListener(() => { self.OnOpenShouSuo(); });
            //ButtonHelp.AddListenerEx(self.Obj_Btn_ShouSuo, () => { self.OnOpenShouSuo(); });

            self.Btn_EveryTask = rc.Get<GameObject>("Btn_EveryTask");
            //self.Btn_EveryTask.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_EveryTask(); });
            ButtonHelp.AddListenerEx(self.Btn_EveryTask, () => { self.OnBtn_EveryTask(); });

            self.Btn_PaiMaiHang = rc.Get<GameObject>("Btn_PaiMaiHang");
            //self.Btn_PaiMaiHang.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_PaiMaiHang(); });
            ButtonHelp.AddListenerEx(self.Btn_PaiMaiHang, () => { self.OnBtn_PaiMaiHang(); });

            self.Button_Energy = rc.Get<GameObject>("Button_Energy");
            //self.Button_Energy.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_Energy(); });
            ButtonHelp.AddListenerEx(self.Button_Energy, () => { self.OnButton_Energy(); });

            self.TeamDungeonBtn = rc.Get<GameObject>("TeamDungeonBtn");
            ButtonHelp.AddListenerEx(self.TeamDungeonBtn, () => { self.OnTeamDungeonBtn(); });

            GameObject Btn_HuoDong = rc.Get<GameObject>("Btn_HuoDong");
            ButtonHelp.AddListenerEx(Btn_HuoDong, () => { self.OnBtn_HuoDong(); });

            GameObject Button_ZhanQu = rc.Get<GameObject>("Button_ZhanQu");
            ButtonHelp.AddListenerEx(Button_ZhanQu, () => { self.OnButton_ZhanQu(); });

            self.Button_Recharge = rc.Get<GameObject>("Button_Recharge");
            ButtonHelp.AddListenerEx(self.Button_Recharge, () => { self.OnButton_Recharge(); });

            self.Btn_Rank = rc.Get<GameObject>("Btn_Rank");
            ButtonHelp.AddListenerEx(self.Btn_Rank, () => { self.OnBtn_Rank(); });


            self.LeftBottomBtns = rc.Get<GameObject>("LeftBottomBtns");
            GameObject ShrinkBtn = rc.Get<GameObject>("ShrinkBtn");
            //ShrinkBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnShrinkBtn(); });
            ButtonHelp.AddListenerEx(ShrinkBtn, () => { self.OnShrinkBtn(); });

            self.HomeButton = rc.Get<GameObject>("HomeButton");
            self.UIMainSkill = rc.Get<GameObject>("UIMainSkill");
            self.Btn_TopRight_1 = rc.Get<GameObject>("Btn_TopRight_1");
            self.Btn_TopRight_2 = rc.Get<GameObject>("Btn_TopRight_2");

            self.LockTargetComponent = self.ZoneScene().GetComponent<LockTargetComponent>();
            self.SkillIndicatorComponent = self.ZoneScene().GetComponent<SkillIndicatorComponent>();

            //初始化子UI
            self.initSubUI();

            //初始化基础属性
            self.InitShow();

            self.OnSettingUpdate();

            self.RegisterReddot();

            self.InitFunctionButton();

            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            if (userInfo.Lv == 1)
            {
                int guideid = PlayerPrefsHelp.GetInt($"{PlayerPrefsHelp.LastGuide}_{userInfo.UserId}");
                guideid = guideid == 0 ? 10001 : guideid++;
                self.ZoneScene().GetComponent<GuideComponent>().SetGuideId(guideid);
            }

            self.GetParent<UI>().OnShowUI = self.OnShowUIHandler;

            DataUpdateComponent.Instance.AddListener(DataType.SkillSetting, self);
            DataUpdateComponent.Instance.AddListener(DataType.SkillReset, self);
            DataUpdateComponent.Instance.AddListener(DataType.EquipWear, self);
            DataUpdateComponent.Instance.AddListener(DataType.TaskUpdate, self);
            DataUpdateComponent.Instance.AddListener(DataType.TaskTrace, self);
            DataUpdateComponent.Instance.AddListener(DataType.TaskGet, self);
            DataUpdateComponent.Instance.AddListener(DataType.TaskLoopGet, self);
            DataUpdateComponent.Instance.AddListener(DataType.TaskComplete, self);
            DataUpdateComponent.Instance.AddListener(DataType.OnRecvChat, self);
            DataUpdateComponent.Instance.AddListener(DataType.HorseNotice, self);
            DataUpdateComponent.Instance.AddListener(DataType.OnPetFightSet, self);
            DataUpdateComponent.Instance.AddListener(DataType.UpdateRoleData, self);
            DataUpdateComponent.Instance.AddListener(DataType.BagItemUpdate, self);
            DataUpdateComponent.Instance.AddListener(DataType.SettingUpdate, self);
            DataUpdateComponent.Instance.AddListener(DataType.BagItemAdd, self);
            DataUpdateComponent.Instance.AddListener(DataType.TaskGiveUp, self);
            DataUpdateComponent.Instance.AddListener(DataType.TeamUpdate, self);
            DataUpdateComponent.Instance.AddListener(DataType.OnActiveTianFu, self);
            DataUpdateComponent.Instance.AddListener(DataType.MainHeroMove, self);
            DataUpdateComponent.Instance.AddListener(DataType.BeforeMove, self);
        }
    }

    //通用提示事件
    [Event]
    public class CommonHintEvent : AEventClass<EventType.CommonHint>
    {
        protected override void Run(object cls)
        {
            EventType.CommonHint args = cls as EventType.CommonHint;
            FloatTipManager.Instance.ShowFloatTipDi(args.HintText);
        }
    }

    //通用提示事件
    [Event]
    public class CommonHintErrorEvent : AEventClass<EventType.CommonHintError>
    {
        protected override void Run(object cls)
        {
            EventType.CommonHintError args = cls as EventType.CommonHintError;
            ErrorHelp.Instance.ErrorHint(args.errorValue);
        }
    }



    public class UIMainComponentDestroySystem : DestroySystem<UIMainComponent>
    {
        public override void Destroy(UIMainComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.SkillSetting, self);
            DataUpdateComponent.Instance.RemoveListener(DataType.SkillReset, self);
            DataUpdateComponent.Instance.RemoveListener(DataType.EquipWear, self);
            DataUpdateComponent.Instance.RemoveListener(DataType.TaskUpdate, self);
            DataUpdateComponent.Instance.RemoveListener(DataType.TaskTrace, self);
            DataUpdateComponent.Instance.RemoveListener(DataType.TaskGet, self);
            DataUpdateComponent.Instance.RemoveListener(DataType.TaskLoopGet, self);
            DataUpdateComponent.Instance.RemoveListener(DataType.TaskComplete, self);
            DataUpdateComponent.Instance.RemoveListener(DataType.OnRecvChat, self);
            DataUpdateComponent.Instance.RemoveListener(DataType.HorseNotice, self);
            DataUpdateComponent.Instance.RemoveListener(DataType.OnPetFightSet, self);
            DataUpdateComponent.Instance.RemoveListener(DataType.UpdateRoleData, self);
            DataUpdateComponent.Instance.RemoveListener(DataType.BagItemUpdate, self);
            DataUpdateComponent.Instance.RemoveListener(DataType.SettingUpdate, self);
            DataUpdateComponent.Instance.RemoveListener(DataType.BagItemAdd, self);
            DataUpdateComponent.Instance.RemoveListener(DataType.TaskGiveUp, self);
            DataUpdateComponent.Instance.RemoveListener(DataType.TeamUpdate, self);
            DataUpdateComponent.Instance.RemoveListener(DataType.OnActiveTianFu, self);
            DataUpdateComponent.Instance.RemoveListener(DataType.MainHeroMove, self);
            DataUpdateComponent.Instance.RemoveListener(DataType.BeforeMove, self);
            
            if (self.TianQiEffectObj != null)
            {
                GameObjectPoolComponent.Instance.RecoverGameObject(self.TianQiEffectPath, self.TianQiEffectObj);
                self.TianQiEffectObj = null;
            }

            TimerComponent.Instance?.Remove(ref self.TimerFunctiuon);
            TimerComponent.Instance?.Remove(ref self.TimerPing);
            self.UnRegisterRedot();
        }
    }

    public static class UIMainComponentSystem
    {

        public static void OnShowUIHandler(this UIMainComponent self)
        {
            self.ZoneScene().GetComponent<GuideComponent>().OnTrigger(GuideTriggerType.OpenUI, UIType.UIMain);

#if UNITY_ANDROID
            Unit unit = UnitHelper.GetMyUnitFromZoneScene( self.ZoneScene() );
            int rechargenumber = unit.GetComponent<NumericComponent>().GetAsInt( NumericType.RechargeNumber );

            AccountInfoComponent accountInfoComponent = self.ZoneScene().GetComponent<AccountInfoComponent>();
            string serverName = ServerHelper.GetGetServerItem(!GlobalHelp.IsOutNetMode, accountInfoComponent.ServerId).ServerName;

            //UploadUserData
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            TapSDKHelper.InitUserData(userInfo.UserId, userInfo.Name, userInfo.Lv, userInfo.Combat, rechargenumber, serverName);
#endif
        }

        public static void OnMainHeroMove(this UIMainComponent self)
        {
            self.UIMapMini.OnMainHeroMove();
            self.LockTargetComponent.OnMainHeroMove();
            self.SkillIndicatorComponent.OnMainHeroMove();

            if (self.TianQiEffectObj != null)
            {
                self.TianQiEffectObj.transform.localPosition = self.MainUnit.Position;
            }
        }

        public static void OnUpdateCombat(this UIMainComponent self)
        {
            self.UIRoleHead.OnUpdateCombat();
        }

        public static void UpdatePing(this UIMainComponent self)
        {
            SessionComponent sessionComponent = self.ZoneScene().GetComponent<SessionComponent>();
            if (sessionComponent == null || sessionComponent.Session == null)
            {
                return;
            }
            long ping = sessionComponent.Session.GetComponent<PingComponent>().Ping;
            self.TextPing.text= $"延迟: {ping}";
            if (ping <= 200)
            {
                self.TextPing.color = Color.green;
                return;
            }
            if (ping <= 500)
            {
                self.TextPing.color = Color.yellow;
                return;
            }
            self.TextPing.color = Color.red;
        }

        public static void  ShowPing(this UIMainComponent self)
        {
            if (self.Fps.activeSelf)
            {
                return;
            }
            self.Fps.SetActive(true);
            TimerComponent.Instance?.Remove(ref self.TimerPing);
            self.TimerPing = TimerComponent.Instance.NewRepeatedTimer(5000, TimerType.UIMainFPSTimer, self);
        }

        public static void OnBagItemAdd(this UIMainComponent self, string dataPaams)
        {
            if (UIHelper.GetUI(self.ZoneScene(), UIType.UITreasureOpen) != null)
            {
                return;
            }

            string[] iteminfo = dataPaams.Split('_');
            int itemId = int.Parse(iteminfo[0]);
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(itemId);
            FloatTipManager.Instance.ShowFloatTip($"获得物品 {itemConfig.ItemName} x{iteminfo[1]}");
        }

        public static void OnUpdateHP(this UIMainComponent self, Unit unit, int sceneType)
        {
            int unitType = unit.Type;
            if (sceneType == SceneTypeEnum.TeamDungeon && unitType == UnitType.Player)
            {
                self.UIMainTeam.OnUpdateHP(unit);
            }
            if (unitType == UnitType.Monster)
            {
                self.UIMainHpBar.OnUpdateHP(unit);
            }
            if (unitType == UnitType.Pet)
            {
                self.UIRoleHead.OnUpdatePetHP(unit);
            }
        }

        public static void OnTeamUpdate(this UIMainComponent self)
        {
            self.UIMainTeam.OnUpdateUI();
        }

        public static void OnUpdateRoleData(this UIMainComponent self, string updateType)
        {
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            UserDataType userDataType = (UserDataType)int.Parse(updateType.Split('_')[0]);

            string updateValue = updateType.Split('_')[1];

            switch (userDataType)
            {
                case UserDataType.Exp:
                    self.UpdateShowRoleExp();
                    break;
                case UserDataType.Lv:
                    FunctionEffect.GetInstance().PlaySelfEffect(self.MainUnit, 60000002);
                    FloatTipManager.Instance.ShowFloatTipDi(GameSettingLanguge.LoadLocalization("恭喜你!等级提升至:") + userInfo.Lv);

                    self.UpdateShowRoleExp();

                    self.UIRoleHead.UpdateShowRoleExp();
                    break;
                case UserDataType.Name:
                    self.UIRoleHead.UpdateShowRoleName();
                    break;

                case UserDataType.PiLao:
                    self.UIRoleHead.UpdateShowRolePiLao();
                    break;

                case UserDataType.Vitality:
                    self.UIRoleHead.UpdateShowRoleHuoLi();
                    break;

                case UserDataType.Gold:
                    if (UIHelper.GetUI(self.ZoneScene(), UIType.UITreasureOpen) != null)
                    {
                        return;
                    }
                    if (int.Parse(updateValue) > 0)
                    {
                        FloatTipManager.Instance.ShowFloatTip($"获得{ updateValue} 金币");
                    }
                    if (int.Parse(updateValue) < 0)
                    {
                        FloatTipManager.Instance.ShowFloatTip($"消耗{ int.Parse(updateValue) * -1} 金币");
                    }
                    break;

                case UserDataType.RongYu:
                    if (int.Parse(updateValue) > 0)
                    {
                        FloatTipManager.Instance.ShowFloatTip($"获得{ updateValue} 荣誉");
                    }
                    if (int.Parse(updateValue) < 0)
                    {
                        FloatTipManager.Instance.ShowFloatTip($"消耗{ int.Parse(updateValue) * -1} 荣誉");
                    }
                    break;
                case UserDataType.JiaYuanFund:
                    if (int.Parse(updateValue) > 0)
                    {
                        FloatTipManager.Instance.ShowFloatTip($"获得{ updateValue} 家园资金");
                    }
                    break;
                case UserDataType.BaoShiDu:
                    if (int.Parse(updateValue) > 0)
                    {
                        FloatTipManager.Instance.ShowFloatTip($"获得{ updateValue} 饱食度");
                    }
                    break;

                case UserDataType.Combat:
                    self.OnUpdateCombat();

                    UI ui = UIHelper.GetUI(self.ZoneScene(), UIType.UIRole);
                    if (ui != null)
                    {
                        ui.GetComponent<UIRoleComponent>().UpdateShowComBat();
                    }
                    break;
                case UserDataType.Message:
                    PopupTipHelp.OpenPopupTip_2(self.ZoneScene(), "系统消息", updateValue, null).Coroutine();
                    break;
            }
        }

        public static void OnRechageSucess(this UIMainComponent self, int addNumber)
        {
            FloatTipManager.Instance.ShowFloatTipDi($"充值{addNumber}元成功");

            self.ZoneScene().GetComponent<AccountInfoComponent>().PlayerInfo.RechargeInfos.Add(new RechargeInfo()
            {
                Amount = addNumber,
                Time = TimeHelper.ClientNow(),
                UserId = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.UserId
            });
        }

        public static void OnSettingUpdate(this UIMainComponent self)
        {
            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            self.JoystickMove.SetActive(userInfoComponent.GetGameSettingValue(GameSettingEnum.YanGan) == "1");
            self.JoystickFixed.SetActive(userInfoComponent.GetGameSettingValue(GameSettingEnum.YanGan) == "2");
        }

        public static void ShowMainUI(this UIMainComponent self, bool show)
        {
            //self.GetParent<UI>().GameObject.SetActive(show);
            self.DoMoveLeft.SetActive(show);
            self.DoMoveRight.SetActive(show);
            self.DoMoveBottom.SetActive(show);
            if (show)
            {
                self.UIMainChat.UpdatePosition().Coroutine();
            }
            else
            {
                self.ZoneScene().GetComponent<SkillIndicatorComponent>()?.RecoveryEffect();
                //self.UIJoystickMoveComponent.ResetUI(); //防止打开其他界面摇杆接受不到ui事件
            }
        }

        public static void OnBagItemUpdate(this UIMainComponent self)
        {
            self.UIMainSkillComponent.OnBagItemUpdate();
        }

        public static void OnEquipWear(this UIMainComponent self, string DataParams)
        {
            //装备武器
            self.OnSkillSetUpdate();
        }

        public static void OnTaskGet(this UIMainComponent self, string taskid)
        {
            self.ZoneScene().GetComponent<GuideComponent>().OnTrigger(GuideTriggerType.AcceptTask, taskid);
        }

        public static async ETTask OnCompleteTask(this UIMainComponent self, string taskid)
        {
            await TimerComponent.Instance.WaitAsync(1000);
            self.ZoneScene().GetComponent<GuideComponent>().OnTrigger(GuideTriggerType.CommitTask, taskid);
        }

        public static void OnRecvTaskUpdate(this UIMainComponent self)
        {
            self.UIMainTask.OnUpdateUI();

            self.UpdateNpcTaskUI();
        }

        public static void UpdateNpcTaskUI(this UIMainComponent self)
        {
            List<Unit> allunit = self.DomainScene().CurrentScene().GetComponent<UnitComponent>().GetAll();
            for (int i = 0; i < allunit.Count; i++)
            {
                Unit unit = allunit[i];
                if (unit.InstanceId == 0 || unit.IsDisposed)
                {
                    continue;
                }
                if (unit.Type != UnitType.Npc)
                {
                    continue;
                }
                if (unit.GetComponent<NpcHeadBarComponent>() != null)
                {
                    unit.GetComponent<NpcHeadBarComponent>().OnRecvTaskUpdate();
                }
            }
        }

        public static void OnTaskGiveUp(this UIMainComponent self)
        {
            self.UIMainTask.OnUpdateUI();
        }

        public static void OnRecvTaskTrace(this UIMainComponent self)
        {
            self.UIMainTask.OnUpdateUI();
        }

        public static void OnSkillSetUpdate(this UIMainComponent self)
        {
            self.UIMainSkillComponent.OnSkillSetUpdate();
        }

        public static async ETTask OnStopServer(this UIMainComponent self)
        {
            PopupTipHelp.OpenPopupTip_2(self.ZoneScene(), "停服维护", "十分钟后停服维护，请暂时退出游戏！",
               () =>
               {
               }).Coroutine();

            long instanceId = self.InstanceId;
            await TimerComponent.Instance.WaitAsync(10 * 60000);
            if (instanceId != self.InstanceId)
            {
                return;
            }
            EventType.ReturnLogin.Instance.ZoneScene = self.DomainScene();
            Game.EventSystem.PublishClass(EventType.ReturnLogin.Instance);


#if UNITY_ANDROID
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            int rechargenumber = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.RechargeNumber);

            AccountInfoComponent accountInfoComponent = self.ZoneScene().GetComponent<AccountInfoComponent>();
            string serverName = ServerHelper.GetGetServerItem(!GlobalHelp.IsOutNetMode, accountInfoComponent.ServerId).ServerName;

            //UploadUserData
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            TapSDKHelper.UploadUserData(userInfo.Name, userInfo.Lv, userInfo.Combat, rechargenumber, serverName);
#endif
        }

        public static  void OnTianQiChange(this UIMainComponent self, string tianqivalue)
        {
            if (tianqivalue == "0" && self.TianQiEffectObj!=null)
            {
                GameObjectPoolComponent.Instance.RecoverGameObject(self.TianQiEffectPath, self.TianQiEffectObj);
                self.TianQiEffectObj = null;
            }
            if (tianqivalue == "1" && tianqivalue == "2")
            {
                self.TianQiEffectPath = ABPathHelper.GetEffetPath($"ScenceEffect/Effect_Rain_{tianqivalue}");
                GameObjectPoolComponent.Instance.AddLoadQueue(self.TianQiEffectPath, self.InstanceId, self.OnLoadTianQiGameObject);
            }
            self.UIMapMini.UpdateTianQi(tianqivalue);
        }

        public static void OnLoadTianQiGameObject(this UIMainComponent self, GameObject gameObject, long instanceId)
        {
            UICommonHelper.SetParent(gameObject, GlobalComponent.Instance.Unit.gameObject);
            gameObject.SetActive(true);
            self.TianQiEffectObj = gameObject;
        }

        public static void OnUnionRace(this UIMainComponent self)
        {
            PopupTipHelp.OpenPopupTip(self.ZoneScene(), "家族争霸赛", "是否参与家族争霸赛?", () =>
           {
               EnterFubenHelp.RequestTransfer(self.ZoneScene(), SceneTypeEnum.UnionRace, 2000008).Coroutine();
           }, null).Coroutine();
        }

        public static  void OnHorseNotice(this UIMainComponent self)
        {
            M2C_HorseNoticeInfo m2C_HorseNoticeInfo = self.ZoneScene().GetComponent<ChatComponent>().HorseNoticeInfo;
            switch (m2C_HorseNoticeInfo.NoticeType)
            {
                case NoticeType.UnionRace:
                    self.OnUnionRace();
                    break;
                case NoticeType.StopSever:
                    self.OnStopServer().Coroutine();
                    break;
                case NoticeType.TianQiChange:
                    self.OnTianQiChange(m2C_HorseNoticeInfo.NoticeText);
                    break;
                case NoticeType.PaiMaiAuction:
                    UI uI = UIHelper.GetUI(self.DomainScene(), UIType.UIPaiMaiAuction);
                    if (uI == null)
                    {
                        return;
                    }
                    uI.GetComponent<UIPaiMaiAuctionComponent>()?.OnRecvHorseNotice(m2C_HorseNoticeInfo.NoticeText);
                    break;
                default:
                    uI = UIHelper.GetUI(self.DomainScene(), UIType.UIHorseNotice);
                    if (uI == null)
                    {
                        return;
                    }
                    uI.GetComponent<UIHorseNoticeComponent>()?.OnRecvHorseNotice(m2C_HorseNoticeInfo);
                    break;
            }
        }

        public static void OnRecvChat(this UIMainComponent self)
        {
            self.UIMainChat.OnRecvChat(self.ZoneScene().GetComponent<ChatComponent>().LastChatInfo);
        }

        public static void OnPetFightSet(this UIMainComponent self)
        {
            self.UIRoleHead.OnPetFightSet();
        }

        public static void OnUpdateRoleName(this UIMainComponent self)
        {
            self.UIRoleHead.UpdateShowRoleName();
        }

        public static void OnClickPageButton(this UIMainComponent self, int page)
        {
            self.UIMainTask.GameObject.SetActive(page == 0);
            self.UIMainTeam.GameObject.SetActive(page == 1);
            //if (self.Obj_Btn_ShouSuo.transform.localScale.x > 0.9f)
            //{
            //    self.UIMainTask.GameObject.SetActive(page == 0);
            //    self.UIMainTeam.GameObject.SetActive(page == 1);
            //}
            //else
            //{
            //    self.UIMainTask.GameObject.SetActive(false);
            //    self.UIMainTeam.GameObject.SetActive(false);
            //}
        }

        public static void OnOpenShouSuo(this UIMainComponent self)
        {
            //if (self.Obj_Btn_ShouSuo.transform.localScale.x > 0.9f)
            //{
            //    self.Obj_Btn_ShouSuo.transform.localScale = new Vector3(-1, 1, 1);
            //    self.UIMainTask.GameObject.SetActive(false);
            //    self.UIMainTeam.GameObject.SetActive(false);
            //}
            //else
            //{
            //    self.Obj_Btn_ShouSuo.transform.localScale = new Vector3(1, 1, 1);
            //    int page = self.UIPageButtonComponent.CurrentIndex;
            //    self.UIMainTask.GameObject.SetActive(page == 0);
            //    self.UIMainTeam.GameObject.SetActive(page == 1);
            //}
        }

        public static void OnRelinkUpdate(this UIMainComponent self)
        {
            self.UIRoleHead.UpdateShowRolePiLao();
        }

        public static void initSubUI(this UIMainComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            //技能
            GameObject mainSkill = rc.Get<GameObject>("UIMainSkill");
            UI uiskill = self.AddChild<UI, string, GameObject>("SubMainSkill", mainSkill);
            self.UIMainSkillComponent = uiskill.AddComponent<UIMainSkillComponent>();

            //摇杆
            self.JoystickMove = rc.Get<GameObject>("JoystickMove");
            UI uiJoystick = self.AddChild<UI, string, GameObject>("NewJoystick1", self.JoystickMove);
            self.UIJoystickMoveComponent = uiJoystick.AddComponent<UIJoystickMoveComponent>();

            self.JoystickFixed = rc.Get<GameObject>("JoystickFixed");
            UI fixedJoystickUI = self.AddChild<UI, string, GameObject>("NewJoystick2", self.JoystickFixed);
            self.UIJoystickComponent = fixedJoystickUI.AddComponent<UIJoystickComponent>();

            GameObject UIMainBuff = rc.Get<GameObject>("UIMainBuff");
            self.UIMainBuffComponent = self.AddChild<UIMainBuffComponent, GameObject>(UIMainBuff);

            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            List<ABuffHandler> aBuffs = unit.GetComponent<BuffManagerComponent>().m_Buffs;
            for (int i = 0; i < aBuffs.Count; i++)
            {
                ABuffHandler buffHandler = aBuffs[i];
                self.UIMainBuffComponent.OnAddBuff(buffHandler);
            }

            GameObject UIOpenBox = rc.Get<GameObject>("UIOpenBox");
            UI uiopenbox = self.AddChild<UI, string, GameObject>("UIMainBuff", UIOpenBox);
            self.UIOpenBoxComponent = uiopenbox.AddComponent<UIOpenBoxComponent>();

            GameObject uisinging = rc.Get<GameObject>("UISinging");
            self.UISingingComponent = self.AddChild<UISingingComponent, GameObject>(uisinging);

            //任务
            GameObject taskShowSet = rc.Get<GameObject>("UIMainTask");
            self.UIMainTask = self.AddChild<UIMainTaskComponent, GameObject>(taskShowSet);

            //组队
            GameObject mainTeamSet = rc.Get<GameObject>("UIMainTeam");
            self.UIMainTeam = self.AddChild<UIMainTeamComponent, GameObject>( mainTeamSet);

            //关卡小地图
            self.LevelGuideMini = rc.Get<GameObject>("LevelGuideMini");
            self.UILevelGuideMini = self.AddChild<UI, string, GameObject>("LevelGuideMini", self.LevelGuideMini);
            self.UILevelGuideMini.AddComponent<UICellDungeonCellMiniComponent>();

            GameObject UIMapMini = rc.Get<GameObject>("UIMapMini");
            self.UIMapMini = self.AddChild<UIMapMiniComponent, GameObject>(UIMapMini);

            //聊天
            GameObject MainChat = rc.Get<GameObject>("UIMainChat");
            self.UIMainChat = self.AddChild<UIMainChatComponent, GameObject>(MainChat);

            GameObject DigTreasure = rc.Get<GameObject>("UIDigTreasure");
            self.UIDigTreasureComponent = self.AddChild<UIDigTreasureComponent, GameObject>(DigTreasure);
            self.UIDigTreasureComponent.GameObject.SetActive(false);

            //左上角头像
            GameObject RoleHead = rc.Get<GameObject>("UIRoleHead");
            self.UIRoleHead = self.AddChild<UIRoleHeadComponent, GameObject>(RoleHead);

            GameObject UIMainHpBar = rc.Get<GameObject>("UIMainHpBar");
            self.UIMainHpBar = self.AddChild<UIMainHpBarComponent, GameObject>(UIMainHpBar);

            self.FunctionSetBtn = rc.Get<GameObject>("FunctionSetBtn");
            UI buttonSet = self.AddChild<UI, string, GameObject>("FunctionBtnSet", self.FunctionSetBtn);
            UIPageButtonComponent uIPageViewComponent = buttonSet.AddComponent<UIPageButtonComponent>();
            uIPageViewComponent.SetClickHandler((int page) =>
            {
                self.OnClickPageButton(page);
            });
            uIPageViewComponent.OnSelectIndex(0);
            self.UIPageButtonComponent = uIPageViewComponent;

            GameObject ButtonPositionSet = rc.Get<GameObject>("ButtonPositionSet");
            self.UIMainButtonPositionComponent = self.AddChild<UIMainButtonPositionComponent, GameObject>(ButtonPositionSet);
            self.UIMainButtonPositionComponent.InitButtons( self.GetParent<UI>().GameObject );
            self.UIMainButtonPositionComponent.GameObject.SetActive(false);

            //IOS适配
            GameObject PhoneLeft = rc.Get<GameObject>("PhoneLeft");
            IPHoneHelper.SetPosition(PhoneLeft, new Vector2(120f, 0f));
            IPHoneHelper.SetPosition(mainSkill, new Vector2(-120f, 0f));
            //IPHoneHelper.SetPosition(self.duihuaButton, new Vector2(-120f, 0f));

            UIHelper.Create(self.DomainScene(), UIType.UIHorseNotice).Coroutine();

            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            if (userInfoComponent.GetGameSettingValue(GameSettingEnum.FenBianlLv) == "1")
            {
                self.SetFenBianLv1();
            }
            if (userInfoComponent.GetGameSettingValue(GameSettingEnum.FenBianlLv) == "2")
            {
                self.SetFenBianLv2();
            }
            string oldValue = userInfoComponent.GetGameSettingValue(GameSettingEnum.Smooth);
            Application.targetFrameRate = oldValue == "1" ? 60 : 30;
        }

        public static void OnZeroClockUpdate(this UIMainComponent self)
        {
            self.InitFunctionButton();
        }

        public static void OnHongBao(this UIMainComponent self, int value)
        {
            if (value == 1)
            {
                self.Button_HongBao.SetActive(false);
            }
        }

        public static void InitFunctionButton(this UIMainComponent self)
        {
            long serverTime = TimeHelper.ServerNow();
            DateTime dateTime = TimeInfo.Instance.ToDateTime(serverTime);
            long curTime = (dateTime.Hour * 60 + dateTime.Minute ) * 60 + dateTime.Second;
            self.MainUnit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
 
            List<int> functonIds = new List<int>() { 1023, 1025, 1031, 1040, 1045 };
            for (int i= 0; i < functonIds.Count; i++)
            {
                long startTime = FunctionHelp.GetOpenTime(functonIds[i]) + 10;
                long endTime = FunctionHelp.GetCloseTime(functonIds[i]);
                //战场按钮延长30分钟消失
                if (functonIds[i] == 1025)
                {
                    endTime += (30 * 60);
                }

                if (curTime < startTime)
                {
                    long sTime = serverTime + (startTime - curTime) * 1000;
                    self.FunctionButtons.Add(new KeyValuePair() { KeyId = functonIds[i], Value = "1", Value2 = sTime.ToString() });
                }
                if (curTime < endTime)
                {
                    long sTime = serverTime + (endTime - curTime) * 1000;
                    self.FunctionButtons.Add(new KeyValuePair() { KeyId = functonIds[i], Value = "0", Value2 = sTime.ToString() });
                }
                bool inTime = curTime >= startTime && curTime <= endTime;
                switch (functonIds[i])
                {
                    case 1023:
                        self.Button_HongBao.SetActive(inTime && self.MainUnit.GetComponent<NumericComponent>().GetAsInt(NumericType.HongBao) == 0);
                        break;
                    case 1025:
                        self.Btn_Battle.SetActive(inTime);
                        break;
                    case 1031:
                        if (inTime)
                        {
                            ActivityTipHelper.OnActiviyTip(self.ZoneScene(), functonIds[i]);
                        }
                        break;
                    case 1040:
                        self.Btn_Auction.SetActive(inTime);
                        break;
                    case 1045:
                        self.Button_Solo.SetActive(inTime && GMHelp.GmAccount.Contains( self.ZoneScene().GetComponent<AccountInfoComponent>().Account ));
                        break;
                    default:
                        break;
                }
            }
            
            TimerComponent.Instance.Remove(ref self.TimerFunctiuon);
            if (self.FunctionButtons.Count > 0)
            {
                self.FunctionButtons.Sort(delegate (KeyValuePair a, KeyValuePair b)
                {
                    long endTime_1 = long.Parse(a.Value2);
                    long endTime_2 = long.Parse(b.Value2);
                    return (int)(endTime_1 - endTime_2);     
                });

                self.TimerFunctiuon = TimerComponent.Instance.NewOnceTimer(long.Parse(self.FunctionButtons[0].Value2), TimerType.UIMainTimer, self);
            }
        }

        public static void OnCheckFuntionButton(this UIMainComponent self)
        {
            if (self.MainUnit.IsDisposed)
            {
                return;
            }

            long serverTime = TimeHelper.ServerNow();
            for (int i = self.FunctionButtons.Count - 1; i >= 0; i--)
            {
                int functionId = self.FunctionButtons[i].KeyId;
                long sTime = long.Parse(self.FunctionButtons[i].Value2);
                if (serverTime >= sTime)
                {
                    switch (functionId)
                    {
                        case 1023:
                            self.Button_HongBao.SetActive(self.FunctionButtons[i].Value == "1"
                            && self.MainUnit.GetComponent<NumericComponent>().GetAsInt(NumericType.HongBao) == 0);
                            break;
                        case 1025:
                            self.Btn_Battle.SetActive(self.FunctionButtons[i].Value == "1");
                            break;
                        case 1031:
                            if (self.FunctionButtons[i].Value == "1")
                            {
                                ActivityTipHelper.OnActiviyTip(self.ZoneScene(), functionId);
                            }
                            break;
                        case 1040:
                            self.Btn_Auction.SetActive(self.FunctionButtons[i].Value == "1");
                            break;
                        case 1045:
                            self.Button_Solo.SetActive(self.FunctionButtons[i].Value == "1" && GMHelp.GmAccount.Contains(self.ZoneScene().GetComponent<AccountInfoComponent>().Account));
                            break;
                        default:
                            break;
                    }
                    self.FunctionButtons.RemoveAt(i);
                }
            }
            TimerComponent.Instance.Remove(ref self.TimerFunctiuon);
            if (self.FunctionButtons.Count > 0)
            {
                self.TimerFunctiuon = TimerComponent.Instance.NewOnceTimer(long.Parse(self.FunctionButtons[0].Value2) + 30000, TimerType.UIMainTimer, self);
            }
        }

        public static void SetFenBianLv1(this UIMainComponent self)
        {
            //AccountInfoComponent accountInfoComponent = self.ZoneScene().GetComponent<AccountInfoComponent>();
            //float dishu = GMHelp.IsTestPlayer(accountInfoComponent.Account) ? 0.8f : 1f;
            Screen.SetResolution((int)(UIComponent.Instance.ResolutionWidth ), (int)(UIComponent.Instance.ResolutionHeight), true);
        }

        public static void SetFenBianLv2(this UIMainComponent self)
        {
            //AccountInfoComponent accountInfoComponent = self.ZoneScene().GetComponent<AccountInfoComponent>();
            //float dishu = GMHelp.IsTestPlayer(accountInfoComponent.Account) ? 0.8f : 1f;
            Screen.SetResolution((int)(UIComponent.Instance.ResolutionWidth * 0.8f), (int)(UIComponent.Instance.ResolutionHeight * 0.8f), true);
        }

        public static void RegisterReddot(this UIMainComponent self)
        {
            ReddotViewComponent redPointComponent = self.ZoneScene().GetComponent<ReddotViewComponent>();
            redPointComponent.RegisterReddot(ReddotType.Friend, self.Reddot_Frined);
            redPointComponent.RegisterReddot(ReddotType.Team, self.Reddot_Team);
            redPointComponent.RegisterReddot(ReddotType.Email, self.Reddot_Email);

            FriendComponent friendComponent = self.ZoneScene().GetComponent<FriendComponent>();
            ReddotComponent reddotComponent = self.ZoneScene().GetComponent<ReddotComponent>();
            if (friendComponent.ApplyList.Count > 0)
            {
                reddotComponent.AddReddont(ReddotType.FriendApply);
            }
            if (reddotComponent.GetReddot(ReddotType.UnionApply) > 0)
            {
                reddotComponent.AddReddont(ReddotType.UnionApply);
            }
            if (reddotComponent.GetReddot(ReddotType.Email) > 0)
            {
                reddotComponent.AddReddont(ReddotType.Email);
            }
        }

        public static void BeginWaterMove(this UIMainComponent self)
        {
            GameObject water = GameObject.Find("zhucheng_dimianshuimian/zhucheng_shui");
            Material material = water.GetComponent<MeshRenderer>().materials[0];
            material.SetTextureOffset("_MainTex", new Vector2(1, 1));
        }

        public static void UnRegisterRedot(this UIMainComponent self)
        {
            ReddotViewComponent redPointComponent = self.DomainScene().GetComponent<ReddotViewComponent>();
            redPointComponent.UnRegisterReddot(ReddotType.Friend, self.Reddot_Frined);
        }

        public static void Reddot_Frined(this UIMainComponent self, int num)
        {
            self.Btn_Friend.transform.Find("Reddot").gameObject.SetActive(num > 0);
        }

        public static void Reddot_Team(this UIMainComponent self, int num)
        {
            self.UIPageButtonComponent.SetButtonReddot(1, num > 0);
        }

        public static void Reddot_Email(this UIMainComponent self, int num)
        {
            self.MailHintTip.SetActive(num > 0);
            //if (num > 0)
            //{
            //    self.UIMailHintTip.RemoveComponent<UIFadeComponent>();
            //    self.UIMailHintTip.AddComponent<UIFadeComponent>();
            //}
            //else
            //{
            //    self.UIMailHintTip.RemoveComponent<UIFadeComponent>();
            //}
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="self"></param>
        public static void BeginEnterScene(this UIMainComponent self, int lastScene)
        {
            self.UIMainTeam.ResetUI();
            self.UIMainSkillComponent.ResetUI();
            self.UIMainBuffComponent.ResetUI();
            self.UIJoystickMoveComponent.ResetUI();

            self.UIMapMini.BeginChangeScene(lastScene);
            self.UISingingComponent.GameObject.SetActive(false);
            self.ZoneScene().GetComponent<SkillIndicatorComponent>().BeginEnterScene();
            self.ZoneScene().GetComponent<LockTargetComponent>().BeginEnterScene();
        }
       
        /// <summary>
        /// 场景加载完成
        /// </summary>
        /// <param name="self"></param>
        /// <param name="sceneTypeEnum"></param>
        public static void AfterEnterScene(this UIMainComponent self, int sceneTypeEnum)
        {
            self.MainUnit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            self.Btn_TopRight_1.SetActive(SceneConfigHelper.ShowRightTopButton(sceneTypeEnum));
            self.Btn_TopRight_2.SetActive(SceneConfigHelper.ShowRightTopButton(sceneTypeEnum));
            self.buttonReturn.SetActive(sceneTypeEnum != SceneTypeEnum.MainCityScene && sceneTypeEnum != SceneTypeEnum.JiaYuan);
            self.LevelGuideMini.SetActive(sceneTypeEnum == SceneTypeEnum.CellDungeon);
            self.duihuaButton.SetActive(sceneTypeEnum == SceneTypeEnum.MainCityScene);
            self.UIJoystickMoveComponent.AfterEnterScene();
            if(!SceneConfigHelper.ShowLeftButton(sceneTypeEnum))
            {
                self.FunctionSetBtn.SetActive(false);
                self.OnClickPageButton(-1);
            }
            else
            {
                self.FunctionSetBtn.SetActive(true);
                self.UIPageButtonComponent.OnSelectIndex(sceneTypeEnum == SceneTypeEnum.TeamDungeon ? 1 : 0);
            }

            switch (sceneTypeEnum)
            {
                case SceneTypeEnum.CellDungeon:
                    self.UILevelGuideMini.GetComponent<UICellDungeonCellMiniComponent>().OnUpdateUI();
                    break;
                case SceneTypeEnum.MainCityScene:
                    self.UIMainHpBar.MonsterNode.SetActive(false);
                    self.UIMainHpBar.BossNode.SetActive(false);
                    self.HomeButton.SetActive(true);
                    self.UIMainSkill.SetActive(false);
                    break;
                case SceneTypeEnum.JiaYuan:
                    self.HomeButton.SetActive(false);
                    self.UIMainSkill.SetActive(false);
                    break;
                default:
                    self.HomeButton.SetActive(false);
                    self.UIMainSkill.SetActive(true);
                    break;
            }

            self.OnHorseRide();
            self.UpdateShadow();
            self.UpdateNpcTaskUI();
            self.UIMapMini.OnEnterScene();
            self.UIMainSkillComponent.OnEnterScene(self.MainUnit, sceneTypeEnum);
            self.UIMainSkillComponent.OnSkillSetUpdate();
            self.ZoneScene().GetComponent<RelinkComponent>().OnApplicationFocusHandler(true);

            if (sceneTypeEnum == SceneTypeEnum.LocalDungeon)
            {
                int sceneid = self.ZoneScene().GetComponent<MapComponent>().SceneId;
                self.ZoneScene().GetComponent<GuideComponent>().OnTrigger(GuideTriggerType.EnterFuben, sceneid.ToString());
            }
        }

        public static void OnOpenTask(this UIMainComponent self)
        {
            UIHelper.Create(self.DomainScene(), UIType.UITask).Coroutine();
        }

        public static async ETTask OnButtonStallOpen(this UIMainComponent self)
        {
            UI uI = await UIHelper.Create(self.DomainScene(), UIType.UIPaiMaiStall);
            uI.GetComponent<UIPaiMaiStallComponent>().OnUpdateUI(UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene()));
        }

        public static void OnButtonStallCancel(this UIMainComponent self)
        {
            PopupTipHelp.OpenPopupTip(self.DomainScene(), "摊位提示", "是否收起自己的摊位?",
                       () =>
                       {
                           NetHelper.PaiMaiStallRequest(self.DomainScene(), 0).Coroutine();
                           //界面存在就销毁界面
                           UIHelper.Remove(self.DomainScene(), UIType.UIPaiMaiStall);
                           //弹出提示
                           FloatTipManager.Instance.ShowFloatTipDi("摊位已收起!");
                       }).Coroutine();
        }

        public static void OnMailHintTip(this UIMainComponent self)
        {
            MapComponent mapComponent = self.ZoneScene().GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum != (int)SceneTypeEnum.MainCityScene)
            {
                FloatTipManager.Instance.ShowFloatTipDi("请前往主城!");
                return;
            }
            self.ZoneScene().CurrentScene().GetComponent<OperaComponent>().OnClickNpc(1000008);
        }

        public static void OnBtn_Battle(this UIMainComponent self)
        {
            UIHelper.Create(self.DomainScene(), UIType.UIBattle).Coroutine();
        }

        public static void OnBtn_Friend(this UIMainComponent self)
        {
            UIHelper.Create(self.DomainScene(), UIType.UIFriend).Coroutine();
        }

        public static void OnButton_HongBao(this UIMainComponent self)
        {
            UIHelper.Create(self.DomainScene(), UIType.UIHongBao).Coroutine();
        }

        public static void OnButton_Tower(this UIMainComponent self)
        {
            UIHelper.Create(self.DomainScene(), UIType.UIRandomTower).Coroutine();
        }

        public static void OnButton_JiaYuan(this UIMainComponent self)
        {
            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            self.ZoneScene().GetComponent<JiaYuanComponent>().MasterId = userInfoComponent.UserInfo.UserId;
            EnterFubenHelp.RequestTransfer(self.ZoneScene(), SceneTypeEnum.JiaYuan, 102, 1, userInfoComponent.UserInfo.UserId.ToString()).Coroutine();
        }

        public static void OnButton_ZhenYing(this UIMainComponent self)
        {
            UIHelper.Create(self.DomainScene(), UIType.UICamp).Coroutine();
        }

        public static void OnButton_WorldLv(this UIMainComponent self)
        {
            UIHelper.Create(self.DomainScene(), UIType.UIWorldLv).Coroutine();
        }

        public static void OnButton_Horse(this UIMainComponent self)
        {
            //C2G_ExitGameGate c2G_ExitGameGate = new C2G_ExitGameGate()
            //{
            //    Account = 1592206859811487766,
            //    RoleId = 1641218363831156736,
            //};
            //self.ZoneScene().GetComponent<SessionComponent>().Session.Call(c2G_ExitGameGate).Coroutine();
            C2M_HorseRideRequest request = new C2M_HorseRideRequest() {  };
            self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request).Coroutine();
        }

        public static void OnButton_FenXiang(this UIMainComponent self)
        {
            UIHelper.Create(self.ZoneScene(), UIType.UIFenXiang).Coroutine();
        }

        public static void OnButton_NewYear(this UIMainComponent self)
        {
            UIHelper.Create(self.ZoneScene(), UIType.UINewYear).Coroutine();
        }

        public static void OnOpenBag(this UIMainComponent self)
        {
            UIHelper.Create(self.DomainScene(), UIType.UIRole).Coroutine();
        }

        public static void OnOpenChengjiu(this UIMainComponent self)
        {
            UIHelper.Create(self.DomainScene(), UIType.UIChengJiu).Coroutine();
        }

        public static void OnClickReturnButton(this UIMainComponent self)
        {
            Scene zoneScene = self.ZoneScene();
            MapComponent mapComponent = zoneScene.GetComponent<MapComponent>();
            UI uI = UIHelper.GetUI(self.ZoneScene(), UIType.UITowerOpen);
            if (uI != null && uI.GetComponent<UITowerOpenComponent>().M2C_FubenSettlement == null)
            {
                uI.GetComponent<UITowerOpenComponent>().RequestTowerQuit();
                return;
            }

            string tipStr = "确定返回主城？";
            if (mapComponent.SceneTypeEnum == SceneTypeEnum.Battle)
            {
                tipStr = "现在离开战场,将不会获得战场胜利的奖励哦";
            }

            PopupTipHelp.OpenPopupTip(self.DomainScene(), "", GameSettingLanguge.LoadLocalization(tipStr),
                () =>
                {
                    EnterFubenHelp.RequestQuitFuben(self.ZoneScene());
                },
                null).Coroutine();
        }

        //初始化界面基础信息
        public static void InitShow(this UIMainComponent self)
        {
            self.UpdateShowRoleExp();

            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            self.UIStall.SetActive(unit.GetComponent<NumericComponent>().GetAsInt((int)NumericType.Now_Stall) == 1);

            int zone = self.ZoneScene().GetComponent<AccountInfoComponent>().ServerId;
            int openDay = ServerHelper.GetOpenServerDay(!GlobalHelp.IsOutNetMode, zone);
            int lastDay = WorldLvHelper.GetWorldLvLastDay();
            self.Button_WorldLv.SetActive(openDay <= lastDay + 1);

            self.OnTianQiChange(self.ZoneScene().GetComponent<AccountInfoComponent>().TianQiValue);
        }

        //角色经验更新
        public static void UpdateShowRoleExp(this UIMainComponent self)
        {
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            self.Obj_Lab_ExpValue.GetComponent<Text>().text = userInfo.Exp.ToString() + "/" + ExpConfigCategory.Instance.Get(userInfo.Lv).UpExp;
            self.Obj_Img_ExpPro.GetComponent<Image>().fillAmount = (float)userInfo.Exp / (float)ExpConfigCategory.Instance.Get(userInfo.Lv).UpExp;
        }


        public static void OnZhaoHuan(this UIMainComponent self)
        {
            MapHelper.SendZhaoHuan(self.DomainScene());
        }

        public static async ETTask OnEnterChapter(this UIMainComponent self)
        {
            self.adventureBtn.SetActive(false);
            UI uI = await UIHelper.Create(self.DomainScene(), UIType.UIDungeon);
            uI.GetComponent<UIDungeonComponent>().UpdateChapterList().Coroutine();
            self.adventureBtn.SetActive(true);
        }

        public static void OnHorseRide(this UIMainComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());

            int sceneTypeEnum = self.ZoneScene().GetComponent<MapComponent>().SceneTypeEnum;

            self.Button_Horse.SetActive(unit.GetComponent<NumericComponent>().GetAsInt(NumericType.HorseFightID) > 0);
            self.Button_CityHorse.SetActive(unit.GetComponent<NumericComponent>().GetAsInt(NumericType.HorseFightID) > 0);
        }

        public static void OnShowFubenIndex(this UIMainComponent self)
        {
            UIHelper.Create(self.DomainScene(), UIType.UICellDungeonCell).Coroutine();
        }

        public static void OnClickSkillButton(this UIMainComponent self)
        {
            UIHelper.Create(self.DomainScene(), UIType.UISkill).Coroutine();
        }

        public static void OnOpenBigMap(this UIMainComponent self)
        {
            UIHelper.Create(self.DomainScene(), UIType.UIMapBig).Coroutine();
        }

        public static void OnOpenMap(this UIMainComponent self)
        {
            int sceneType = self.ZoneScene().GetComponent<MapComponent>().SceneTypeEnum;
            int sceneId = self.ZoneScene().GetComponent<MapComponent>().SceneId;
            switch (sceneType)
            {
                case (int)SceneTypeEnum.MainCityScene:
                case (int)SceneTypeEnum.LocalDungeon:
                    self.OnOpenBigMap();        //打开主城
                    break;
                case (int)SceneTypeEnum.CellDungeon:
                    self.OnShowFubenIndex();        //打开副本小地图
                    break;
                default:
                    SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(sceneId);
                    if (sceneConfig.ifShowMinMap == 0)
                    {
                        FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("当前场景不支持查看小地图"));
                    }
                    else
                    {
                        self.OnOpenBigMap();        //打开主城
                    }
                    break;
            }
        }

        public static  void OnChapterOpen(this UIMainComponent self)
        {
            var BaseObj = ResourcesComponent.Instance.LoadAsset<GameObject>(ABPathHelper.GetUGUIPath("Chapter/UIChapterOpen"));
            UI uiskillButton = self.AddChild<UI, string, GameObject>("UIChapterOpen", GameObject.Instantiate(BaseObj));
            uiskillButton.AddComponent<UICellChapterOpenComponent>().OnUpdateUI();
            UICommonHelper.SetParent(uiskillButton.GameObject, UIEventComponent.Instance.UILayers[(int)UILayer.Mid].gameObject);

            self.UILevelGuideMini.GetComponent<UICellDungeonCellMiniComponent>().OnChapterOpen(true);
        }

        public static  void OnCellDungeonEnterShow(this UIMainComponent self, int chapterId)
        {
            if (chapterId == 0)
                return;

            var BaseObj = ResourcesComponent.Instance.LoadAsset<GameObject>(ABPathHelper.GetUGUIPath("CellDungeon/UICellDungeonEnterShow"));
            UI uiskillButton = self.AddChild<UI, string, GameObject>("ChapterEnterShow", GameObject.Instantiate(BaseObj));
            uiskillButton.AddComponent<UICellDungeonEnterShowComponent>().OnUpdateUI(chapterId);

            UICommonHelper.SetParent(uiskillButton.GameObject, UIEventComponent.Instance.UILayers[(int)UILayer.Mid].gameObject);
        }

        public static void OnBtn_Email(this UIMainComponent self)
        {
            UIHelper.Create(self.DomainScene(), UIType.UIMail).Coroutine();
        }

        public static void OnBtn_EveryTask(this UIMainComponent self)
        {
            UIHelper.Create(self.DomainScene(), UIType.UICountry).Coroutine();
        }

        public static void OnBtn_PaiMaiHang(this UIMainComponent self)
        {
            UIHelper.Create(self.DomainScene(), UIType.UIPaiMai).Coroutine();
        }

        public static void OnButton_Energy(this UIMainComponent self)
        {
            UIHelper.Create(self.DomainScene(), UIType.UIEnergy).Coroutine();
        }

        public static void OnTeamDungeonBtn(this UIMainComponent self)
        {
            UIHelper.Create(self.DomainScene(), UIType.UITeamDungeon).Coroutine();
        }

        public static void OnBtn_HuoDong(this UIMainComponent self)
        {
            UIHelper.Create(self.DomainScene(), UIType.UIActivity).Coroutine();
        }

        public static void OnButton_ZhanQu(this UIMainComponent self)
        {
            UIHelper.Create(self.DomainScene(), UIType.UIZhanQu).Coroutine();
        }

        public static void OnButton_Recharge(this UIMainComponent self)
        {
            UIHelper.Create(self.DomainScene(), UIType.UIRecharge).Coroutine();
        }

        public static void OnBtn_Rank(this UIMainComponent self)
        {
            UIHelper.Create(self.DomainScene(), UIType.UIRank).Coroutine();
        }

        public static void OnShrinkBtn(this UIMainComponent self)
        {
            self.LeftBottomBtns.SetActive(!self.LeftBottomBtns.activeSelf);
        }

        public static void OnClickPetButton(this UIMainComponent self)
        {
            UIHelper.Create(self.DomainScene(), UIType.UIPet).Coroutine();
        }

        public static void OnMoveStart(this UIMainComponent self)
        {
            if (self.UIOpenBoxComponent != null && self.UIOpenBoxComponent.BoxUnitId> 0)
            {
                self.UIOpenBoxComponent.OnOpenBox(null);
            }
            self.UIMainSkillComponent.UIAttackGrid.OnMoveStart();
        }

        public static void OnSpellStart(this UIMainComponent self)
        {
            if (self.UIOpenBoxComponent != null && self.UIOpenBoxComponent.BoxUnitId > 0)
            {
                self.UIOpenBoxComponent.OnOpenBox(null);
            }
        }

        public static void OnBeforeSkill(this UIMainComponent self)
        {
            self.UIJoystickMoveComponent.lastSendTime = 0f;
        }

        public static void OnStopAction(this UIMainComponent self)
        {
            self.UIJoystickMoveComponent.ResetUI();
            self.OnMoveStart();
        }

        public static void UpdateShadow(this UIMainComponent self, string usevalue = "")
        {
            GameObject gameObject = GameObject.Find("Directional Light");
            if (gameObject == null)
            {
                return;
            }
            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            string value = usevalue != "" ? usevalue :  userInfoComponent.GetGameSettingValue(GameSettingEnum.Shadow);
            Light light = gameObject.GetComponent<Light>();
            light.shadows = value == "0" ? LightShadows.None : LightShadows.Soft;
        }
    }
}
