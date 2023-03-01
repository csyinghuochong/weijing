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
        public GameObject Button_Tower;
        public GameObject Button_HongBao;
        public GameObject Btn_PetFormation;
        public GameObject Btn_GM;
        public GameObject Btn_Task;
        public Text TextPing;
        public GameObject MailHintTip;
        public GameObject Btn_Union;
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
        public GameObject zhaohuanButton;
        public GameObject chengjiuButton;
        public GameObject adventureBtn;
        public GameObject duihuaButton;
        public GameObject shiquButton;
        public GameObject petButton;
        public GameObject roleSkillBtn;
        public GameObject miniMapButton;
        public GameObject LevelGuideMini;
        public GameObject Obj_Img_ExpPro;
        public GameObject Obj_Lab_ExpValue;
        public GameObject Obj_Btn_ShouSuo;
        public GameObject Btn_Email;
        public GameObject Btn_MakeItem;
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

        public LockTargetComponent LockTargetComponent;
        public SkillIndicatorComponent SkillIndicatorComponent;

        public List<KeyValuePair> FunctionButtons = new List<KeyValuePair>();
        public Unit MainUnit;

        public long TimerFunctiuon;
        public long TimerPing;
    }

    [ObjectSystem]
    public class UIMainComponentAwakeSystem : AwakeSystem<UIMainComponent>
    {

        public override void Awake(UIMainComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            Transform transform = self.GetParent<UI>().GameObject.transform;
            self.DoMoveLeft = transform.Find("DoMoveLeft").gameObject;
            self.DoMoveRight = transform.Find("DoMoveRight").gameObject;
            self.DoMoveBottom = transform.Find("DoMoveBottom").gameObject;

            self.Btn_PetFormation = rc.Get<GameObject>("Btn_PetFormation");
            ButtonHelp.AddListenerEx(self.Btn_PetFormation, () => { UIHelper.Create(self.ZoneScene(), UIType.UIPetChallenge).Coroutine(); });

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

            self.Button_Tower = rc.Get<GameObject>("Button_Tower");
            ButtonHelp.AddListenerEx(self.Button_Tower, () => { self.OnButton_Tower(); });

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
            self.Button_FenXiang.SetActive(GMHelp.GmAccount.Contains(self.ZoneScene().GetComponent<AccountInfoComponent>().Account));

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
            self.Button_Horse.SetActive(GMHelp.GmAccount.Contains(self.ZoneScene().GetComponent<AccountInfoComponent>().Account));

            self.buttonReturn = rc.Get<GameObject>("Btn_RerurnBuilding");
            //self.buttonReturn.GetComponent<Button>().onClick.AddListener(() => { self.OnClickReturnButton(); });
            ButtonHelp.AddListenerEx(self.buttonReturn, () => { self.OnClickReturnButton(); });

            self.zhaohuanButton = rc.Get<GameObject>("Btn_ZhaoHuan");
            //self.zhaohuanButton.GetComponent<Button>().onClick.AddListener(() => { self.OnZhaoHuan(); });
            ButtonHelp.AddListenerEx(self.zhaohuanButton, () => { self.OnZhaoHuan(); });

            self.chengjiuButton = rc.Get<GameObject>("Btn_ChengJiu");
            //self.chengjiuButton.GetComponent<Button>().onClick.AddListener(() => { self.OnOpenChengjiu(); });
            ButtonHelp.AddListenerEx(self.chengjiuButton, () => { self.OnOpenChengjiu(); });
            self.adventureBtn = rc.Get<GameObject>("AdventureBtn");
            //self.adventureBtn.GetComponent<Button>().onClick.AddListener();
            ButtonHelp.AddListenerEx(self.adventureBtn, () => { self.OnEnterChapter().Coroutine(); });

            self.duihuaButton = rc.Get<GameObject>("Btn_NpcDuiHua");
            //self.duihuaButton.GetComponent<Button>().onClick.AddListener(() => { self.MoveToNpcDialog(); });
            ButtonHelp.AddListenerEx(self.duihuaButton, () => { self.MoveToNpcDialog(); });

            self.shiquButton = rc.Get<GameObject>("Btn_ShiQu");
            self.shiquButton.GetComponent<Button>().onClick.AddListener(() => { self.OnShiquItem(); });
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

            self.Btn_Email = rc.Get<GameObject>("Btn_Email");
            //self.Btn_Email.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_Email(); });
            ButtonHelp.AddListenerEx(self.Btn_Email, () => { self.OnBtn_Email(); });

            self.Btn_MakeItem = rc.Get<GameObject>("Btn_MakeItem");
            //self.Btn_MakeItem.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_Btn_MakeItem(); });

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

            self.ZoneScene().GetComponent<GuideComponent>().FirstEnter();

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


    [ObjectSystem]
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
            TimerComponent.Instance?.Remove(ref self.TimerFunctiuon);
            TimerComponent.Instance?.Remove(ref self.TimerPing);
            self.UnRegisterRedot();
        }
    }

    public static class UIMainComponentSystem
    {

        public static void OnMainHeroMove(this UIMainComponent self)
        {
            self.UIMapMini.OnMainHeroMove();
            self.LockTargetComponent.OnMainHeroMove();
            self.SkillIndicatorComponent.OnMainHeroMove();
        }

        public static bool IsHaveHongBao(this UIMainComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            return unit.GetComponent<NumericComponent>().GetAsInt(NumericType.HongBao) == 0;
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
            if (userDataType == UserDataType.Exp)
            {
                self.UpdateShowRoleExp();
            }
            //更新等级实例化特效
            if (userDataType == UserDataType.Lv)
            {
                FunctionEffect.GetInstance().PlaySelfEffect(UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene()), 60000002);
                FloatTipManager.Instance.ShowFloatTipDi(GameSettingLanguge.LoadLocalization("恭喜你!等级提升至:") + userInfo.Lv);

                self.UpdateShowRoleExp();

                self.UIRoleHead.UpdateShowRoleExp();

                self.ZoneScene().GetComponent<GuideComponent>().OnTrigger(GuideTriggerType.GuideTriggerLevel, userInfo.Lv);
            }
            if (userDataType == UserDataType.Name)
            {
                self.UIRoleHead.UpdateShowRoleName();
            }
            if (userDataType == UserDataType.PiLao)
            {
                self.UIRoleHead.UpdateShowRolePiLao();
            }
            if (userDataType == UserDataType.Vitality)
            {
                self.UIRoleHead.UpdateShowRoleHuoLi();
            }
            if (userDataType == UserDataType.Gold)
            {
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
            }
            if (userDataType == UserDataType.Diamond)
            {
                if (UIHelper.GetUI(self.ZoneScene(), UIType.UITreasureOpen) != null)
                {
                    return;
                }
                UI uIRechage = UIHelper.GetUI(self.ZoneScene(), UIType.UIRecharge);
                if (uIRechage != null)
                {
                    uIRechage.GetComponent<UIRechargeComponent>().OnRechageSucess();
                }
            }
            if (userDataType == UserDataType.RongYu)
            {
                if (int.Parse(updateValue) > 0)
                {
                    FloatTipManager.Instance.ShowFloatTip($"获得{ updateValue} 荣誉");
                }
                if (int.Parse(updateValue) < 0)
                {
                    FloatTipManager.Instance.ShowFloatTip($"消耗{ int.Parse(updateValue) * -1} 荣誉");
                }
            }
            if (userDataType == UserDataType.Combat)
            {
                self.OnUpdateCombat();

                UI ui = UIHelper.GetUI(self.ZoneScene(), UIType.UIRole);
                if (ui != null)
                {
                    ui.GetComponent<UIRoleComponent>().UpdateShowComBat();
                }
            }
            if (userDataType == UserDataType.Union)
            {
                long unionId = userInfo.UnionId;
                UI uifriend = UIHelper.GetUI(self.ZoneScene(), UIType.UIFriend);
                if (uifriend != null && unionId > 0)
                {
                    uifriend.GetComponent<UIFriendComponent>().OnCreateUnion();
                }
                if (uifriend != null && unionId == 0)
                {
                    uifriend.GetComponent<UIFriendComponent>().OnLeaveUnion();
                }
            }
            if (userDataType == UserDataType.Message)
            {
                PopupTipHelp.OpenPopupTip_2(self.ZoneScene(), "系统消息", updateValue, null).Coroutine();
            }
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
            PopupTipHelp.OpenPopupTip_2(self.ZoneScene(), "停服维护", "五分钟后停服维护，请暂时退出游戏！",
               () =>
               {
               }).Coroutine();

            long instanceId = self.InstanceId;
            await TimerComponent.Instance.WaitAsync(5 * 60000);
            if (instanceId != self.InstanceId)
            {
                return;
            }
            EventType.ReturnLogin.Instance.ZoneScene = self.DomainScene();
            Game.EventSystem.PublishClass(EventType.ReturnLogin.Instance);
        }

        public static  void OnHorseNotice(this UIMainComponent self)
        {
            M2C_HorseNoticeInfo m2C_HorseNoticeInfo = self.ZoneScene().GetComponent<ChatComponent>().HorseNoticeInfo;
            if (m2C_HorseNoticeInfo.NoticeType == NoticeType.StopSever)
            {
                self.OnStopServer().Coroutine();
                return;
            }
            UI uI = UIHelper.GetUI(self.DomainScene(), UIType.UIHorseNotice);
            if (uI == null)
            {
                return;
            }
            uI.GetComponent<UIHorseNoticeComponent>()?.OnRecvHorseNotice(m2C_HorseNoticeInfo);
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
            UI ui_mainbuff = self.AddChild<UI, string, GameObject>("UIMainBuff", UIMainBuff);
            self.UIMainBuffComponent = ui_mainbuff.AddComponent<UIMainBuffComponent>();
            UIMainBuff.SetActive(!GlobalHelp.IsBanHaoMode);

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
            DateTime dateTime = TimeHelper.DateTimeNow();
            int curTime = dateTime.Hour * 60 + dateTime.Minute;
            self.MainUnit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());

            List<int> functonIds = new List<int>() { 1023, 1025, 1031 };
            for (int i= 0; i < functonIds.Count; i++)
            {
                List<int> openTime =  FuntionConfigCategory.Instance.OpenTimeList[functonIds[i]];
                int openTime_1 = openTime[0];
                int openTime_2 = openTime[1];
                int closeTime_1 = openTime[2];
                int closeTime_2 = openTime[3];
                int startTime = openTime_1 * 60 + openTime_2;
                int endTime = closeTime_1 * 60 + closeTime_2;
                //战场按钮延长30分钟消失
                if (functonIds[i] == 1025)
                {
                    endTime += 30;
                }

                if (curTime < startTime)
                {
                    long sTime = serverTime + (startTime - curTime) * 60 * 1000;
                    self.FunctionButtons.Add(new KeyValuePair() { KeyId = functonIds[i], Value = "1", Value2 = sTime.ToString() });
                }
                if (curTime < endTime)
                {
                    long sTime = serverTime + (endTime - curTime) * 60 * 1000;
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
                    }
                    self.FunctionButtons.RemoveAt(i);
                }
            }
            TimerComponent.Instance.Remove(ref self.TimerFunctiuon);
            if (self.FunctionButtons.Count > 0)
            {
                self.TimerFunctiuon = TimerComponent.Instance.NewOnceTimer(long.Parse(self.FunctionButtons[0].Value2), TimerType.UIMainTimer, self);
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
            self.buttonReturn.SetActive(sceneTypeEnum != SceneTypeEnum.MainCityScene);
            self.LevelGuideMini.SetActive(sceneTypeEnum == SceneTypeEnum.CellDungeon);
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
                    self.duihuaButton.GetComponent<RectTransform>().anchoredPosition = new Vector2(-128f, 380f);
                    break;
                default:
                    self.HomeButton.SetActive(false);
                    self.UIMainSkill.SetActive(true);
                    self.duihuaButton.GetComponent<RectTransform>().anchoredPosition = new Vector2(-95.7f, 738f);
                    break;
            }

            self.OnHorseRide();
            self.UpdateShadow();
            self.UpdateNpcTaskUI();
            self.UIMapMini.OnEnterScene();
            self.UIMainSkillComponent.OnEnterScene(self.MainUnit);
            self.UIMainSkillComponent.OnSkillSetUpdate();
            self.ZoneScene().GetComponent<RelinkComponent>().OnApplicationFocusHandler(true);
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
            UIHelper.Create(self.DomainScene(), UIType.UIJiaYuan).Coroutine();
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
            int lastDay = ComHelp.GetWorldLvLastDay();
            self.Button_WorldLv.SetActive(openDay <= lastDay + 1);

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
            Log.Debug("OnEnterChapter_1");
            self.adventureBtn.SetActive(false);
            await UIHelper.Create(self.DomainScene(), UIType.UIDungeon);
            self.adventureBtn.SetActive(true);
        }

        public static void MoveToNpcDialog(this UIMainComponent self)
        {
            float distance = 20f;
            Unit npc = null;
            Unit main = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            List<Unit> units = self.ZoneScene().CurrentScene().GetComponent<UnitComponent>().GetAll();
            UnitInfoComponent unitInfoComponent;
            for (int i = 0; i < units.Count; i++)
            {
                unitInfoComponent = units[i].GetComponent<UnitInfoComponent>();
                if (units[i].Type != UnitType.Npc)
                {
                    continue;
                }

                float t_distance = PositionHelper.Distance2D(main, units[i] as Unit);
                if (t_distance < distance)
                {
                    distance = t_distance;
                    npc = units[i] as Unit;
                }
            }

            if (npc == null)
            {
                return;
            }
            self.ZoneScene().CurrentScene().GetComponent<OperaComponent>().OnClickNpc(npc.ConfigId);
        }

        public static void OnHorseRide(this UIMainComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());

            int sceneTypeEnum = self.ZoneScene().GetComponent<MapComponent>().SceneTypeEnum;

            self.Button_Horse.SetActive(unit.GetComponent<NumericComponent>().GetAsInt(NumericType.HorseFightID) > 0 && sceneTypeEnum != SceneTypeEnum.MainCityScene);
            self.Button_CityHorse.SetActive(unit.GetComponent<NumericComponent>().GetAsInt(NumericType.HorseFightID) > 0 && sceneTypeEnum == SceneTypeEnum.MainCityScene);
        }

        public static void OnShowFubenIndex(this UIMainComponent self)
        {
            UIHelper.Create(self.DomainScene(), UIType.UICellDungeonCell).Coroutine();
        }

        public static void OnShiquItem(this UIMainComponent self)
        {
            if (self.ZoneScene().GetComponent<BagComponent>().GetLeftSpace() == 0)
            {
                ErrorHelp.Instance.ErrorHint(ErrorCore.ERR_BagIsFull);
                return;
            }
            Unit main = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            if (main.GetComponent<SkillManagerComponent>().IsSkillMoveTime())
            {
                return;
            }
            List<DropInfo> ids = MapHelper.GetCanShiQu(self.ZoneScene());
            if (ids.Count > 0)
            {
                self.RequestShiQu(ids).Coroutine();
                return;
            }
            else
            {
                Unit unit = MapHelper.GetNearItem(self.ZoneScene());
                if (unit != null)
                {
                    Vector3 dir = (main.Position - unit.Position).normalized;
                    Vector3 tar = unit.Position + dir * 1f;
                    self.MoveToShiQu(tar).Coroutine();
                    return;
                }
            }

            long chestId = MapHelper.GetChestBox(self.ZoneScene());
            if (chestId != 0)
            {
                self.ZoneScene().CurrentScene().GetComponent<OperaComponent>().OnClickChest(chestId);
            }
        }

        public static async ETTask RequestShiQu(this UIMainComponent self, List<DropInfo> ids)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            if (!unit.GetComponent<MoveComponent>().IsArrived())
            {
                self.ZoneScene().GetComponent<SessionComponent>().Session.Send(new C2M_Stop());
            }
            
            unit.GetComponent<FsmComponent>().ChangeState(FsmStateEnum.FsmShiQuItem);
            MapHelper.SendShiquItem(self.ZoneScene(), ids).Coroutine();

            unit.GetComponent<StateComponent>().SetNetWaitEndTime(TimeHelper.ClientNow()+ 200);
            await TimerComponent.Instance.WaitAsync(200);
            unit.GetComponent<FsmComponent>().ChangeState(FsmStateEnum.FsmIdleState);
        }

        public static async ETTask MoveToShiQu(this UIMainComponent self, Vector3 position)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            int value = await unit.MoveToAsync2(position, true);
            List<DropInfo> ids = MapHelper.GetCanShiQu(self.ZoneScene());
            if (value == 0 && ids.Count > 0)
            {
                self.RequestShiQu(ids).Coroutine();
            }
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
                self.UIOpenBoxComponent.OnOpenBox(0);
            }
            self.UIMainSkillComponent.UIAttackGrid.OnMoveStart();
        }

        public static void OnSpellStart(this UIMainComponent self)
        {
            if (self.UIOpenBoxComponent != null && self.UIOpenBoxComponent.BoxUnitId > 0)
            {
                self.UIOpenBoxComponent.OnOpenBox(0);
            }
        }

        public static void OnBeforeSkill(this UIMainComponent self)
        {
            self.UIJoystickMoveComponent.lastSendTime = 0f;
        }

        public static void OnSelfDead(this UIMainComponent self)
        {
            self.UIJoystickMoveComponent.ResetUI();
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
