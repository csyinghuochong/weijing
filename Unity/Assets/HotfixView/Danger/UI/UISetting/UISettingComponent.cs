using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace ET
{

    public class UISettingComponent : Entity, IAwake
    {
        public GameObject ButtonPhone;
        public GameObject LastLoginTime;
        public GameObject TextVersion;
        public GameObject Image_YinYing;
        public GameObject Btn_YinYing;
        public GameObject Image_Click;
        public GameObject Btn_Click;
        public Toggle ScreenToggle0;
        public Toggle ScreenToggle1;
        public GameObject HideDi;
        public GameObject Image_fps;
        public GameObject Btn_Fps;
        public GameObject SliderSound;
        public GameObject SliderMusic;
        public GameObject Image_Fixed;
        public GameObject Image_Move;
        public GameObject Btn_Fixed;
        public GameObject Btn_Move;
        public GameObject Btn_Close;
        public GameObject TextZhangHaoID;
        public GameObject Btn_CloseGame;
        public GameObject Btn_ReturnDengLu;
        public GameObject Image_Sound;
        public GameObject Image_yinyu;
        public GameObject Btn_Sound;
        public GameObject Btn_YinYue;
        public GameObject Btn_ChengHao;
        public GameObject ButtonRname;
        public GameObject InputFieldCName;
        public GameObject Authentication;
        public GameObject GameSetting;

        public UserInfoComponent userInfoComponent;
        public List<KeyValuePair> gameSettingInfos = new List<KeyValuePair>();
    }

    [ObjectSystem]
    public class UISettingComponentAwakeSystem : AwakeSystem<UISettingComponent>
    {
        public override void Awake(UISettingComponent self)
        {
            self.gameSettingInfos.Clear();

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.Btn_Close = rc.Get<GameObject>("Btn_Close");
            self.TextVersion = rc.Get<GameObject>("TextVersion");
            self.Image_Click = rc.Get<GameObject>("Image_Click");
            self.Btn_Click  = rc.Get<GameObject>("Btn_Click");
            self.LastLoginTime = rc.Get<GameObject>("LastLoginTime");
            self.Btn_Click.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_Click(); });

            self.Image_YinYing = rc.Get<GameObject>("Image_YinYing");
            self.Btn_YinYing = rc.Get<GameObject>("Btn_YinYing");
            self.Btn_YinYing.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_Shadow(); });

            self.HideDi = rc.Get<GameObject>("HideDi");
            self.SliderSound = rc.Get<GameObject>("SliderSound");
            self.SliderMusic = rc.Get<GameObject>("SliderMusic");
            self.SliderSound.GetComponent<Slider>().onValueChanged.AddListener((float value) => { self.OnSliderSoundChange(value);  });
            self.SliderMusic.GetComponent<Slider>().onValueChanged.AddListener((float value) => { self.OnSliderMusicChange(value); });

            self.Image_fps = rc.Get<GameObject>("Image_fps");
            self.Btn_Fps = rc.Get<GameObject>("Btn_Fps");
            self.Btn_Fps.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_Fps(); });

            UI uimain = UIHelper.GetUI(self.DomainScene(), UIType.UIMain);
            GameObject fps = uimain.GetComponent<UIMainComponent>().Fps;
            self.Image_fps.SetActive(fps.activeSelf);

            self.TextZhangHaoID = rc.Get<GameObject>("TextZhangHaoID");
            self.Btn_CloseGame = rc.Get<GameObject>("Btn_CloseGame");
            self.Btn_ReturnDengLu = rc.Get<GameObject>("Btn_ReturnDengLu");
            self.Image_Sound = rc.Get<GameObject>("Image_Sound");
            self.Image_yinyu = rc.Get<GameObject>("Image_yinyu");
            self.Btn_Sound = rc.Get<GameObject>("Btn_Sound");
            self.Btn_YinYue = rc.Get<GameObject>("Btn_YinYue");
            self.ButtonRname = rc.Get<GameObject>("ButtonRname");

            self.InputFieldCName = rc.Get<GameObject>("InputFieldCName");
            self.InputFieldCName.GetComponent<InputField>().onValueChanged.AddListener( (string text)=>{ self.CheckSensitiveWords(); } );
            
            self.Authentication = rc.Get<GameObject>("Authentication");
            self.GameSetting = rc.Get<GameObject>("GameSetting");

            //IOS适配
            IPHoneHelper.SetPosition(rc.Get<GameObject>("FunctionSetBtn"), new Vector2(300f, 316f));

            self.Btn_Close.GetComponent<Button>().onClick.AddListener(() => { self.OnBeforeClose(); });
            self.Btn_CloseGame.GetComponent<Button>().onClick.AddListener(() => { self.OnCloseGame(); });
            self.Btn_ReturnDengLu.GetComponent<Button>().onClick.AddListener(() => { self.OnReturnLogin(); });

            self.Btn_Sound.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_Sound(); });
            self.Btn_YinYue.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_YinYue(); });
            self.ButtonRname.GetComponent<Button>().onClick.AddListener(() => { self.OnButtonRname().Coroutine(); });

            self.ButtonPhone = rc.Get<GameObject>("ButtonPhone");
            ButtonHelp.AddListenerEx(self.ButtonPhone, self.OnButtonPhone);
            AccountInfoComponent accountInfoComponent = self.ZoneScene().GetComponent<AccountInfoComponent>();
            self.ButtonPhone.SetActive(GMHelp.GmAccount.Contains(accountInfoComponent.Account));

            self.Image_Fixed = rc.Get<GameObject>("Image_Fixed");
            self.Image_Move = rc.Get<GameObject>("Image_Move");
            self.Btn_Fixed = rc.Get<GameObject>("Btn_Fixed");
            self.Btn_Move = rc.Get<GameObject>("Btn_Move");
            self.Btn_Fixed.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_Fixed(); });
            self.Btn_Move.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_Move(); });

            self.ScreenToggle0 = rc.Get<GameObject>("ScreenToggle0").GetComponent<Toggle>();
            self.ScreenToggle1 = rc.Get<GameObject>("ScreenToggle1").GetComponent<Toggle>();
            self.ScreenToggle0.onValueChanged.AddListener((bool ison) => { self.OnScreenToggle0_Ex(ison); });
            self.ScreenToggle1.onValueChanged.AddListener((bool ison) => { self.OnScreenToggle1_Ex(ison); });

            self.userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            self.InitUI();
        }
    }

    public static class UISettingComponentSystem
    {
        public static void OnScreenToggle0_Ex(this UISettingComponent self, bool value)
        {
            if (value)
            {
                self.SaveSettings(GameSettingEnum.FenBianlLv, "1");
                UIHelper.GetUI(self.ZoneScene(), UIType.UIMain).GetComponent<UIMainComponent>().SetFenBianLv1();
            }
        }

        public static void OnScreenToggle1_Ex(this UISettingComponent self, bool value)
        {
            if (value)
            {
                self.SaveSettings(GameSettingEnum.FenBianlLv, "2");
                UIHelper.GetUI(self.ZoneScene(), UIType.UIMain).GetComponent<UIMainComponent>().SetFenBianLv2();
            }
        }

        public static void OnSliderSoundChange(this UISettingComponent self, float value)
        {
            self.SaveSettings(GameSettingEnum.SoundVolume, value.ToString());
            Game.Scene.GetComponent<SoundComponent>().ChangeMusicVolume ( value);

        }

        public static void OnSliderMusicChange(this UISettingComponent self, float value)
        {
            self.SaveSettings(GameSettingEnum.MusicVolume, value.ToString());
            Game.Scene.GetComponent<SoundComponent>().ChangeMusicVolume( value );
        }

        public static void OnBtn_Click(this UISettingComponent self)
        {
            string value = self.userInfoComponent.GetGameSettingValue(GameSettingEnum.Click);
            self.Image_Click.SetActive(value == "0");
            self.SaveSettings(GameSettingEnum.Click, value == "0"? "1" : "0");
            self.ZoneScene().CurrentScene().GetComponent<OperaComponent>().UpdateClickMode();
        }

        public static void OnBtn_Shadow(this UISettingComponent self)
        {
            string value = self.userInfoComponent.GetGameSettingValue(GameSettingEnum.Shadow);
            self.Image_YinYing.SetActive(value == "0");
            self.SaveSettings(GameSettingEnum.Shadow, value == "0" ? "1" : "0");
            UI uimain = UIHelper.GetUI(self.ZoneScene(), UIType.UIMain);
            uimain.GetComponent<UIMainComponent>().UpdateShadow(value == "0" ? "1" : "0");
        }

        public static void UpdateShadow(this UISettingComponent self)
        {
            UI uimain = UIHelper.GetUI(self.ZoneScene(), UIType.UIMain);
            uimain.GetComponent<UIMainComponent>().UpdateShadow ();
        }

        public static void InitUI(this UISettingComponent self)
        {
            self.Image_yinyu.SetActive(self.userInfoComponent.GetGameSettingValue(GameSettingEnum.Music) == "1");
            self.Image_Sound.SetActive(self.userInfoComponent.GetGameSettingValue(GameSettingEnum.Sound) == "1");
            self.Image_YinYing.SetActive(self.userInfoComponent.GetGameSettingValue(GameSettingEnum.Shadow) == "1");

            self.SliderSound.GetComponent<Slider>().value = float.Parse(self.userInfoComponent.GetGameSettingValue(GameSettingEnum.SoundVolume));
            self.SliderMusic.GetComponent<Slider>().value = float.Parse(self.userInfoComponent.GetGameSettingValue(GameSettingEnum.MusicVolume));

            self.ScreenToggle0.isOn = self.userInfoComponent.GetGameSettingValue(GameSettingEnum.FenBianlLv) == "1";
            self.ScreenToggle1.isOn = self.userInfoComponent.GetGameSettingValue(GameSettingEnum.FenBianlLv) == "2";
            self.Image_Click.SetActive(self.userInfoComponent.GetGameSettingValue(GameSettingEnum.Click) == "1");

            self.UpdateYaoGan();
            self.UpdateShadow();
            self.TextVersion.GetComponent<Text>().text = GlobalHelp.GetVersion().ToString();
            self.InputFieldCName.GetComponent<InputField>().text = self.userInfoComponent.UserInfo.Name;
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            long lastTime = unit.GetComponent<NumericComponent>().GetAsLong(NumericType.LastGameTime);
            self.LastLoginTime.GetComponent<Text>().text = TimeInfo.Instance.ToDateTime(lastTime).ToString();
        }

        public static void OnBeforeClose(this UISettingComponent self)
        {
            self.SendGameSetting().Coroutine();
        }

        public static void OnBtn_Fps(this UISettingComponent self)
        {
            UI uimain = UIHelper.GetUI(self.DomainScene(), UIType.UIMain);
            GameObject fps = uimain.GetComponent<UIMainComponent>().Fps;
            fps.SetActive(!fps.activeSelf);
            self.Image_fps.SetActive(fps.activeSelf);
            if (fps.activeSelf)
            {
                uimain.GetComponent<UIMainComponent>().ShowPing().Coroutine();
            }
        }

        public static async ETTask SendGameSetting(this UISettingComponent self)
        {
            if (self.gameSettingInfos.Count > 0)
            {
                self.ZoneScene().GetComponent<UserInfoComponent>().UpdateGameSetting(self.gameSettingInfos);
                HintHelp.GetInstance().DataUpdate(DataType.SettingUpdate);
                C2M_GameSettingRequest c2M_GameSettingRequest = new C2M_GameSettingRequest() { GameSettingInfos = self.gameSettingInfos };
                M2C_GameSettingResponse r2c_roleEquip = (M2C_GameSettingResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_GameSettingRequest);
            }
        }

        public static void OnCloseGame(this UISettingComponent self)
        {
            Application.Quit();
        }

        public static void OnReturnLogin(this UISettingComponent self)
        {
            self.HideDi.SetActive(true);
            //加载登录场景
            EventType.ReturnLogin.Instance.ZoneScene = self.DomainScene();
            Game.EventSystem.PublishClass(EventType.ReturnLogin.Instance);
        }

        public static void SaveSettings(this UISettingComponent self, GameSettingEnum gameSettingEnum, string value)
        {
            bool exit = false;
            for (int i = 0; i < self.gameSettingInfos.Count; i++)
            {
                if (self.gameSettingInfos[i].KeyId == (int)gameSettingEnum)
                {
                    self.gameSettingInfos[i].Value = value;
                    exit = true;
                    break;
                }
            }
            if (!exit)
            {
                self.gameSettingInfos.Add(new KeyValuePair() { KeyId = (int)gameSettingEnum, Value = value });
            }
            self.ZoneScene().GetComponent<UserInfoComponent>().UpdateGameSetting(self.gameSettingInfos);
        }

        public static void OnBtn_Sound(this UISettingComponent self)
        {
            self.Image_Sound.SetActive(!self.Image_Sound.activeSelf);
            self.SaveSettings(GameSettingEnum.Sound, self.Image_Sound.activeSelf ? "1" : "0");
        }

        public static void OnBtn_YinYue(this UISettingComponent self)
        {
            self.Image_yinyu.SetActive(!self.Image_yinyu.activeSelf);
            self.SaveSettings(GameSettingEnum.Music, self.Image_yinyu.activeSelf ? "1" : "0");
        }

        public static void OnBtn_Fixed(this UISettingComponent self)
        {
            self.SaveSettings(GameSettingEnum.YanGan, "2");
            self.UpdateYaoGan();
        }

        public static void UpdateYaoGan(this UISettingComponent self)
        {
            self.Image_Fixed.SetActive(self.userInfoComponent.GetGameSettingValue(GameSettingEnum.YanGan) == "2");
            self.Image_Move.SetActive(self.userInfoComponent.GetGameSettingValue(GameSettingEnum.YanGan) == "1");
        }

        public static void OnBtn_Move(this UISettingComponent self)
        {
            self.SaveSettings(GameSettingEnum.YanGan, "1");
            self.UpdateYaoGan();
        }

        public static void CheckSensitiveWords(this UISettingComponent self)
        {
            string text_new = "";
            string text_old = self.InputFieldCName.GetComponent<InputField>().text;
            MaskWordHelper.Instance.IsContainSensitiveWords(ref text_old, out text_new);
            self.InputFieldCName.GetComponent<InputField>().text = text_old;
        }

        public static  void OnButtonPhone(this UISettingComponent self)
        {
            UIHelper.Create( self.ZoneScene(), UIType.UIPhoneCode ).Coroutine();
        }

        public static async ETTask OnButtonRname(this UISettingComponent self)
        {
            string text = self.InputFieldCName.GetComponent<InputField>().text;
            if (text.Contains("*") || !StringHelper.IsSpecialChar(text))
            {
                FloatTipManager.Instance.ShowFloatTip("名字不合法，请重新输入！");
                return;
            }
            GlobalValueConfig globalValueConfig = GlobalValueConfigCategory.Instance.Get(70);
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            if (!bagComponent.CheckNeedItem(globalValueConfig.Value))
            {
                string needItem = UICommonHelper.GetNeedItemDesc(globalValueConfig.Value);
                FloatTipManager.Instance.ShowFloatTip($"需要 {needItem}");
                return;
            }

            C2M_ModifyNameRequest c2M_GameSettingRequest = new C2M_ModifyNameRequest() { NewName = text };
            M2C_ModifyNameResponse r2c_roleEquip = (M2C_ModifyNameResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_GameSettingRequest);

            if (r2c_roleEquip.Error == ErrorCore.ERR_Success)
            {
                FloatTipManager.Instance.ShowFloatTip("修改名称成功！");
            }
        }
    }

}
