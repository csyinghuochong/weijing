using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    [ObjectSystem]
	public class UILoginComponentAwakeSystem : AwakeSystem<UILoginComponent>
	{
		public override void Awake(UILoginComponent self)
		{
			try
			{
				string path = "beta";
				if (GlobalHelp.IsBanHaoMode)
				{
					path = "banhao";
				}
				self.DownloadUrl = $"http://39.96.194.143/weijing1/apk/{path}/weijing.apk";
				int version = GameObject.Find("Global").GetComponent<Init>().BigVersion;
				if (version < self.BigVersion)
				{
					self.OpenDownLoadUI($"old:{version}_new:{self.BigVersion}");
					return;
				}

				Application.targetFrameRate = 30;
				Application.runInBackground = true;
				libx.Assets.MAX_BUNDLES_PERFRAME = 16;
				self.ZoneScene().GetComponent<MapComponent>().SetMapInfo((int)SceneTypeEnum.LoginScene, 0, 0);
				self.LastLoginTime = 0;
				ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
                self.ZhuCe = rc.Get<GameObject>("ZhuCe");
				self.ZhuCe.SetActive(false);
				self.Btn_Return = rc.Get<GameObject>("Btn_Return");
				self.Btn_Return.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_Return(); });

				ButtonHelp.AddListenerEx(self.ZhuCe.transform.Find("Btn_QQ").gameObject, () => { self.OnBtn_QQLogin(); });
                ButtonHelp.AddListenerEx(self.ZhuCe.transform.Find("Btn_WeChat").gameObject, () => { self.OnBtn_WeChatLogin(); });
				ButtonHelp.AddListenerEx(self.ZhuCe.transform.Find("Btn_ZhuCe").gameObject, () => { self.OnBtn_ZhuCe(); });
				ButtonHelp.AddListenerEx(self.ZhuCe.transform.Find("Btn_iPhone").gameObject, () => { self.OnBtn_iPhone(); });

				self.AccountText = rc.Get<GameObject>("AccountText");
				self.AccountText.GetComponent<Text>().text = GlobalHelp.IsBanHaoMode ? "注册账号" : "切换账号";
				self.YanZheng = rc.Get<GameObject>("YanZheng");
				self.SendYanzheng = rc.Get<GameObject>("SendYanzheng");
				self.IPhone = rc.Get<GameObject>("IPhone");
				self.YanZheng.SetActive(false);
				self.SendYanzheng.SetActive(false);
				self.IPhone.SetActive(false);
				self.ButtonCommitCode = rc.Get<GameObject>("ButtonCommitCode");
				self.ButtonGetCode = rc.Get<GameObject>("ButtonGetCode");
				self.TextPhoneCode = rc.Get<GameObject>("TextPhoneCode");
				self.PhoneNumber = rc.Get<GameObject>("PhoneNumber");
				ButtonHelp.AddListenerEx(self.ButtonCommitCode, () => { self.OnButtonCommitCode(); });
				ButtonHelp.AddListenerEx(self.ButtonGetCode, () => { self.OnButtonGetCode(); });

				self.BanHanNode = rc.Get<GameObject>("BanHanNode");
				self.HideNode = rc.Get<GameObject>("HideNode");

				self.ButtonOtherLogin = rc.Get<GameObject>("ButtonOtherLogin");
				self.ButtonYiJianLogin = rc.Get<GameObject>("ButtonYiJianLogin");
				self.TextPhoneNumber = rc.Get<GameObject>("TextPhoneNumber");
				self.ThirdLoginBg = rc.Get<GameObject>("ThirdLoginBg");
				self.YiJianDengLu = rc.Get<GameObject>("YiJianDengLu");
				self.YiJianDengLu.SetActive(false);
				//切换替他登录方式 });
				ButtonHelp.AddListenerEx(self.ButtonOtherLogin, () => { self.OnButtonOtherLogin(); });
				ButtonHelp.AddListenerEx(self.ButtonYiJianLogin, () => { self.OnButtonYiJianLogin(); });

				GameObject.Find("Global").GetComponent<SMSSDemo>().CommitCodeSucessHandler = (string text) => { self.OnCommitCodeHandler(text); };
				GameObject.Find("Global").GetComponent<Init>().OnShareHandler = (bool value) => { self.OnShareHandler(value); };
				GameObject.Find("Global").GetComponent<Init>().OnAuthorizeHandler = (string text) => { self.OnAuthorize(text); };
				GameObject.Find("Global").GetComponent<Init>().OnGetUserInfoHandler = (string text) => { self.OnGetUserInfo(text); };
				GameObject.Find("Global").GetComponent<Init>().OnGetPhoneNumHandler = (string text) => { self.OnGetPhoneNum(text); };

				self.RealNameButton = rc.Get<GameObject>("RealNameButton");
				self.RealNameButton.GetComponent<Button>().onClick.AddListener(() => { self.OnRealNameButton(); });

				self.loginBtn = rc.Get<GameObject>("LoginBtn");
				//self.loginBtn.GetComponent<Button>().onClick.AddListener();
				ButtonHelp.AddListenerEx(self.loginBtn, () => { self.OnLogin(); });
				self.registerBtn = rc.Get<GameObject>("CreateAccountBtn");
				self.registerBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnRegister(); });
				self.Account = rc.Get<GameObject>("Account");
				self.Password = rc.Get<GameObject>("Password");

				self.ObjNoticeBtn = rc.Get<GameObject>("NoticeBtn");
				self.ObjSelectBtn = rc.Get<GameObject>("SelectBtn");
				self.SelectServerName = rc.Get<GameObject>("SelectServerName");

				self.ObjNoticeBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnNotice(); });
				self.ObjSelectBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnSelectServerList(); });

				self.YongHuXieYiClose = rc.Get<GameObject>("YongHuXieYiClose");
				self.YongHuXieYi = rc.Get<GameObject>("YongHuXieYi");
				self.YinSiXieYi = rc.Get<GameObject>("YinSiXieYi");
				self.YinSiXieYiClose = rc.Get<GameObject>("YinSiXieYiClose");
				self.YinSiToggle = rc.Get<GameObject>("YinSiToggle");
				self.TextButton_2 = rc.Get<GameObject>("TextButton_2");
				self.TextButton_1 = rc.Get<GameObject>("TextButton_1");
				self.YongHuXieYi.SetActive(false);
				self.YinSiXieYi.SetActive(false);

				self.TextButton_2_2 = rc.Get<GameObject>("TextButton_2_2");
				self.TextButton_2_1 = rc.Get<GameObject>("TextButton_2_1");
				self.YinSiToggle2 = rc.Get<GameObject>("YinSiToggle2");
				
				self.TextButton_2.GetComponent<Button>().onClick.AddListener(() => { self.YongHuXieYi.SetActive(true); });
				self.TextButton_1.GetComponent<Button>().onClick.AddListener(() => { self.YinSiXieYi.SetActive(true); });
				self.TextButton_2_2.GetComponent<Button>().onClick.AddListener(() => { self.YongHuXieYi.SetActive(true); });
				self.TextButton_2_1.GetComponent<Button>().onClick.AddListener(() => { self.YinSiXieYi.SetActive(true); });
				self.YongHuXieYiClose.GetComponent<Button>().onClick.AddListener(() => { self.YongHuXieYi.SetActive(false); });
				self.YinSiXieYiClose.GetComponent<Button>().onClick.AddListener(() => { self.YinSiXieYi.SetActive(false); });

				self.Loading = rc.Get<GameObject>("Loading");
				UI uirotate = self.AddChild<UI, string, GameObject>("RightPositionSet", rc.Get<GameObject>("Img_Loading"));
				uirotate.AddComponent<UIRotateComponent>();
				self.UIRotateComponent = uirotate;
				self.Loading.SetActive(false);
				int id = PlayerPrefsHelp.GetInt(PlayerPrefsHelp.MyServerID);
				self.RequestAllServer().Coroutine();
				GameSettingLanguge.Instance.InitRandomName().Coroutine();
				self.PlayerComponent = self.DomainScene().GetComponent<AccountInfoComponent>();
				Game.Scene.GetComponent<SceneManagerComponent>().PlayBgmSound(self.ZoneScene(), (int)SceneTypeEnum.LoginScene);
				self.InitLoginType();
				self.UpdateLoginType();
			}
			catch (Exception E)
			{
				Log.Error(E.ToString());
			}
		}
	}
	
	public static class UILoginComponentSystem
	{

		public static void OnBtn_Return(this UILoginComponent self)
		{
			if (self.ZhuCe.activeSelf)
			{
				self.ZhuCe.SetActive(false);
				self.ThirdLoginBg.SetActive(false);
				self.HideNode.SetActive(true);
			}
			else
			{
				self.ZhuCe.SetActive(true);
				self.YiJianDengLu.SetActive(false);
				self.IPhone.SetActive(false);
			}
		}

		public static void InitLoginType(this UILoginComponent self)
		{
			string lastloginType = PlayerPrefsHelp.GetString(PlayerPrefsHelp.LastLoginType);
			if (string.IsNullOrEmpty(lastloginType))
			{
				self.LoginType =  LoginTypeEnum.PhoneNumLogin.ToString();    //默认手机号一键登录
			}
			else
			{
				self.LoginType = lastloginType;
			}
			self.LoginType = GlobalHelp.IsBanHaoMode ? LoginTypeEnum.RegisterLogin.ToString() : self.LoginType;

			self.Account.GetComponent<InputField>().text = PlayerPrefsHelp.GetString(PlayerPrefsHelp.LastAccount(self.LoginType));
			self.Password.GetComponent<InputField>().text = PlayerPrefsHelp.GetString(PlayerPrefsHelp.LastPassword(self.LoginType));

			Log.ILog.Debug($"LoginTest2222  {self.LoginType} {self.Account.GetComponent<InputField>().text}");
		}

		//public const int RegisterLogin = 0;     //注册账号登录
		//public const int WeixLogin = 1;         //微信登录
		//public const int QQLogin = 2;           //QQ登录
		//public const int SMSSLogin = 3;         //短信验证吗登录
		//public const int PhoneLogin = 4;        //手机号登录
		public static void UpdateLoginType(this UILoginComponent self)
		{
			self.ThirdLoginBg.SetActive(true);
			self.YiJianDengLu.SetActive(int.Parse(self.LoginType) == LoginTypeEnum.PhoneNumLogin);
			string lastAccount = PlayerPrefsHelp.GetString(PlayerPrefsHelp.LastAccount(self.LoginType));

			bool uppos = GlobalHelp.IsBanHaoMode || LoginTypeEnum.RegisterLogin.ToString() == self.LoginType;
			self.BanHanNode.transform.localPosition = uppos ? new Vector3(0f, -20f, 0f) : new Vector3(0f,160f,0f);

			Log.ILog.Debug($"LoginTest {self.LoginType} {lastAccount}");

			switch (int.Parse(self.LoginType))
			{
				case LoginTypeEnum.RegisterLogin:
					self.ZhuCe.SetActive(false);
					self.ThirdLoginBg.SetActive(false);
					self.Account.SetActive(true);
					self.Password.SetActive(true);
					self.HideNode.SetActive(true);
					break;
				case LoginTypeEnum.WeixLogin:
				case LoginTypeEnum.QQLogin:
					if (string.IsNullOrEmpty(lastAccount))
					{
						Log.ILog.Debug($"LoginTest IsNullOrEmpty {lastAccount} {self.LoginType}");
						GlobalHelp.GetUserInfo(self.LoginType);
					}
					else
					{
						Log.ILog.Debug($"LoginTest  Valided {lastAccount}");
						self.OnGetUserInfo($"{lastAccount}");
					}
					break;
				case LoginTypeEnum.PhoneCodeLogin:
					if (string.IsNullOrEmpty(lastAccount))
					{
						self.ZhuCe.SetActive(false);
						self.IPhone.SetActive(true);
						self.HideNode.SetActive(false);
						self.SendYanzheng.SetActive(true);
					}
					else
					{
						self.OnCommitCodeHandler(lastAccount);
					}
					break;
				case LoginTypeEnum.PhoneNumLogin:
					if (string.IsNullOrEmpty(lastAccount))
					{
						GlobalHelp.OnButtonGetPhoneNum();
					}
					else
					{
						self.OnGetPhoneNum(lastAccount);
						self.OnButtonYiJianLogin();
					}
					break;
			}
		}

		public static void OnGetPhoneNum(this UILoginComponent self, string phoneNum)
		{
			self.TextPhoneNumber.GetComponent<Text>().text = phoneNum;
		}

		public static string GetPhoneZone(this UILoginComponent self)
		{
			return "86";
		}

		public static void OnButtonOtherLogin(this UILoginComponent self)
		{
			self.ThirdLoginBg.SetActive(true);
			self.YiJianDengLu.SetActive(false);
			self.ZhuCe.SetActive(true);
			self.HideNode.SetActive(false);
		}

		public static void OnButtonYiJianLogin(this UILoginComponent self)
		{
			string phoneNum = self.TextPhoneNumber.GetComponent<Text>().text;
			if (string.IsNullOrEmpty(phoneNum))
			{
				FloatTipManager.Instance.ShowFloatTip("请选择其他登录方式！");
				return;
			}
			self.Account.GetComponent<InputField>().text = phoneNum;
			self.Password.GetComponent<InputField>().text = self.LoginType;
			self.ZhuCe.SetActive(false);
			self.YiJianDengLu.SetActive(false);
			self.ThirdLoginBg.SetActive(false);
			self.Account.SetActive(false);
			self.Password.SetActive(false);
		}

		public static void OpenDownLoadUI(this UILoginComponent self, string version)
		{
			PopupTipHelp.OpenPopupTip_2(self.ZoneScene(), "重新下载", $"应用版本过低，请重新下载{version}", () =>
			{
				Application.OpenURL(self.DownloadUrl);
			}).Coroutine();
		}

		public static async ETTask RequestAllServer(this UILoginComponent self)
		{
			//请求服务器列表信息s
			try
			{
				int erroCode = ErrorCore.ERR_Success;
				if (GlobalHelp.IsOutNetMode)
				{
					erroCode = await LoginHelper.OnServerListAsyncRelease(self.DomainScene(), GlobalHelp.VersionMode);
				}
				else
				{
					erroCode = await LoginHelper.OnServerListAsyncDebug(self.DomainScene(), GlobalHelp.VersionMode);
				}
				if (erroCode != ErrorCore.ERR_Success)
				{
					return;
				}
				ServerItem serverItem = self.PlayerComponent.AllServerList[self.PlayerComponent.AllServerList.Count - 1];
				List<int> myids = new List<int>();
				int myserver = PlayerPrefsHelp.GetInt(PlayerPrefsHelp.MyServerID);

				for (int i = 0; i < self.PlayerComponent.AllServerList.Count; i++)
				{
					if (self.PlayerComponent.AllServerList[i].ServerId == myserver)
					{
						serverItem = self.PlayerComponent.AllServerList[i];
						myids.Add(serverItem.ServerId);
						break;
					}
				}
				self.PlayerComponent.MyServerList = myids;
				self.OnSelectServer(serverItem);
			}
			catch (Exception ex)
			{
				Log.Debug(ex.ToString());
				FloatTipManager.Instance.ShowFloatTip("请检查网络！: ");
			}
		}

		public static void OnRealNameButton(this UILoginComponent self)
		{
			UIHelper.Create( self.DomainScene(), UIType.UIRealName ).Coroutine();
		}

		public static void OnBtn_QQLogin(this UILoginComponent self)
		{
			if (!self.YinSiToggle2.GetComponent<Toggle>().isOn)
			{
				FloatTipManager.Instance.ShowFloatTip("请选勾选用户隐私协议！");
				return;
			}

			self.LoginType = LoginTypeEnum.QQLogin.ToString();
			self.UpdateLoginType();
		}

		public static void OnBtn_WeChatLogin(this UILoginComponent self)
		{
			if (!self.YinSiToggle2.GetComponent<Toggle>().isOn)
			{
				FloatTipManager.Instance.ShowFloatTip("请选勾选用户隐私协议！");
				return;
			}
			self.LoginType = LoginTypeEnum.WeixLogin.ToString();
			self.UpdateLoginType();
		}

		public static void OnBtn_ZhuCe(this UILoginComponent self)
		{
			if (!self.YinSiToggle2.GetComponent<Toggle>().isOn)
			{
				FloatTipManager.Instance.ShowFloatTip("请选勾选用户隐私协议！");
				return;
			}
			self.LoginType = LoginTypeEnum.RegisterLogin.ToString();
			UIHelper.Create(self.DomainScene(), UIType.UIRegister).Coroutine();
			self.UpdateLoginType();
		}

		public static void OnBtn_iPhone(this UILoginComponent self)
		{
			if (!self.YinSiToggle2.GetComponent<Toggle>().isOn)
			{
				FloatTipManager.Instance.ShowFloatTip("请选勾选用户隐私协议！");
				return;
			}
			self.LoginType = LoginTypeEnum.PhoneCodeLogin.ToString();
			self.UpdateLoginType();
		}

		public static void OnShareHandler(this UILoginComponent self, bool share)
		{ 
			
		}

		//QQ/WeiXin Login
		public static void OnGetUserInfo(this UILoginComponent self, string openId)
		{
			Log.ILog.Debug($"LoginTestOnGetUserInfo  {openId}  {self.LoginType}");

			if (openId == "fail" || string.IsNullOrEmpty(openId) )
			{
				GlobalHelp.Authorize(self.LoginType);
				return;
			}
			//self.RequestLogin(msg[1], self.LoginType, self.LoginType).Coroutine();
			self.Account.GetComponent<InputField>().text = openId;
			self.Password.GetComponent<InputField>().text = self.LoginType;
			self.ZhuCe.SetActive(false);
			self.YiJianDengLu.SetActive(false);
			self.ThirdLoginBg.SetActive(false);
			self.Account.SetActive(false);
			self.Password.SetActive(false);
			self.HideNode.SetActive(true);
		}

		public static void OnAuthorize(this UILoginComponent self, string openId)
		{
			string[] msg = openId.Split('_');
			if (msg.Length < 2 || msg[0] == "fail")
			{
				return;
			}
			self.RequestLogin(msg[1], self.LoginType,self.LoginType).Coroutine();
		}

		public static void OnQQShare(this UILoginComponent self)
		{
			//QQ空间
			GlobalHelp.FenXiang("2");
		}

		public static void OnWeiXinShare(this UILoginComponent self)
		{
			//微信朋友圈
			GlobalHelp.FenXiang("1");	
		}

		public static void OnWeChatMoments(this UILoginComponent self)
		{
			//微信好友
			GlobalHelp.FenXiang("4");		
		}

		public static void OnQQZone(this UILoginComponent self)
		{
			//QQ好友
			GlobalHelp.FenXiang("5");
		}

		public static void OnButtonCommitCode(this UILoginComponent self)
		{
			GlobalHelp.OnButtonCommbitCode(self.TextPhoneCode.GetComponent<InputField>().text);
		}
		public static void OnButtonGetCode(this UILoginComponent self)
		{
			GlobalHelp.OnButtonGetCode(self.PhoneNumber.GetComponent<InputField>().text);
			self.SendYanzheng.SetActive(false);
			self.YanZheng.SetActive(true);
		}

		public static void OnCommitCodeHandler(this UILoginComponent self, string phone)
		{
			self.LoginType = LoginTypeEnum.PhoneCodeLogin.ToString();
			self.Account.GetComponent<InputField>().text = phone;
			self.Password.GetComponent<InputField>().text = self.LoginType;
			self.IPhone.SetActive(false);
			self.ThirdLoginBg.SetActive(false);
			self.ZhuCe.SetActive(false);
			self.HideNode.SetActive(true);
		}

		public static void  OnLogin(this UILoginComponent self)
		{
			if (!self.YinSiToggle.GetComponent<Toggle>().isOn)
			{
				FloatTipManager.Instance.ShowFloatTip("请选勾选用户隐私协议！");
				return;
			}

			string account = self.Account.GetComponent<InputField>().text;
			string password = self.Password.GetComponent<InputField>().text;

			Log.ILog.Debug($"LoginTest OnLogin:  {account}");
			self.RequestLogin(account, password, self.LoginType).Coroutine();
		}

		public static void OnReLogin(this UILoginComponent self)
		{
			string account = self.PlayerComponent.Account;
			string password = self.PlayerComponent.Password;
			self.RequestLogin(account, password, self.PlayerComponent.LoginType).Coroutine();
		}

		public static async ETTask RequestLogin(this UILoginComponent self, string account ,string password, string loginType)
		{
			if (self.ServerInfo == null)
			{
				self.RequestAllServer().Coroutine();
				return;
			}
			if (string.IsNullOrEmpty(account) || string.IsNullOrEmpty(password))
			{
				FloatTipManager.Instance.ShowFloatTip("请选择登录方式");
				return;
			}
			if (TimeHelper.ClientNow() - self.LastLoginTime < 3000)
			{
				return;
			}

			self.Loading.SetActive(true);
			account = account.Replace(" ", "");
			password = password.Replace(" ", "");
			self.LastLoginTime = TimeHelper.ClientNow();
			self.PlayerComponent.CurrentServerId = self.ServerInfo.ServerId;
			self.PlayerComponent.ServerIp = self.ServerInfo.ServerIp;
			self.PlayerComponent.Account = account;
			self.PlayerComponent.Password = password;
			self.PlayerComponent.LoginType = loginType;
			self.UIRotateComponent.GameObject.SetActive(true);
			self.UIRotateComponent.GetComponent<UIRotateComponent>().StartRotate(true);

			PlayerPrefsHelp.SetInt(PlayerPrefsHelp.MyServerID, self.ServerInfo.ServerId);
			PlayerPrefsHelp.SetString(PlayerPrefsHelp.LastLoginType, self.LoginType);
			PlayerPrefsHelp.SetString(PlayerPrefsHelp.LastAccount(self.LoginType), account);
			PlayerPrefsHelp.SetString(PlayerPrefsHelp.LastPassword(self.LoginType), password);

			int login = await LoginHelper.Login(
				self.DomainScene(),
				self.ServerInfo.ServerIp,
				account,
				password,
				false, 
				"",
				self.LoginType);
			if (login != ErrorCore.ERR_Success)
			{
				self.UIRotateComponent.GameObject.SetActive(false);
				self.Loading.SetActive(false);
				self.UIRotateComponent.GetComponent<UIRotateComponent>().StartRotate(false);
			}
		}

		public static void OnRegister(this UILoginComponent self)
		{
			if (GlobalHelp.IsBanHaoMode)
			{
				UIHelper.Create(self.ZoneScene(), UIType.UIRegister).Coroutine();
			}
			else
			{
				self.ThirdLoginBg.SetActive(true);
				self.ZhuCe.SetActive(true);
				self.YiJianDengLu.SetActive(false);
				self.Account.SetActive(false);
				self.Password.SetActive(false);
				self.HideNode.SetActive(false);
			}
			PlayerPrefsHelp.SetString(PlayerPrefsHelp.LastLoginType, "");
			self.ResetPlayerPrefs(LoginTypeEnum.RegisterLogin.ToString());
			self.ResetPlayerPrefs(LoginTypeEnum.WeixLogin.ToString());
			self.ResetPlayerPrefs(LoginTypeEnum.QQLogin.ToString());
			self.ResetPlayerPrefs(LoginTypeEnum.PhoneCodeLogin.ToString());
			self.ResetPlayerPrefs(LoginTypeEnum.PhoneNumLogin.ToString());
			self.InitLoginType();
		}

		public static void ResetPlayerPrefs(this UILoginComponent self, string loingType)
		{
			PlayerPrefsHelp.SetString(PlayerPrefsHelp.LastAccount(loingType), "");
			PlayerPrefsHelp.SetString(PlayerPrefsHelp.LastPassword(loingType), "");
		}

		public static void OnSelectServer(this UILoginComponent self, ServerItem serverId)
		{
			self.ServerInfo = serverId;
			self.SelectServerName.GetComponent<Text>().text = serverId.ServerName;
		}

		public static async void OnNotice(this UILoginComponent self)
		{
			if (self.PlayerComponent.NoticeStr == null)
			{
				await LoginHelper.OnNoticeAsync(self.DomainScene(), self.ServerInfo.ServerIp);
			}

			if (self.PlayerComponent.NoticeStr != null)
			{
				PopupTipHelp.OpenPopupTip(self.DomainScene(), GameSettingLanguge.LoadLocalization("游戏公告"), self.PlayerComponent.NoticeStr,
				null,
				null
				).Coroutine();
			}
		}

		public static void OnSelectServerList(this UILoginComponent self)
		{
			Log.Info("点击显示服务器列表...");
			//LoginHelper.OnNoticeAsync(self.DomainScene(), ConstValue.LoginAddress).Coroutine();
			UIHelper.Create(self.DomainScene(), UIType.UISelectServer).Coroutine();
		}

	}
}
