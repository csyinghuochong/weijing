using System;
using CommandLine;
using UnityEngine;
using GooglePlayGames;

namespace ET
{
	public class Init: MonoBehaviour
	{
		private void Start()
		{
			this.StartAsync().Coroutine();
		}
		
		private async ETTask StartAsync()
		{
			DontDestroyOnLoad(gameObject);
			
			AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
			{
				Log.Error(e.ExceptionObject.ToString());
			};

			// 命令行参数
			string[] args = "".Split(" ");
			Parser.Default.ParseArguments<Options>(args)
				.WithNotParsed(error => throw new Exception($"命令行格式错误! {error}"))
				.WithParsed((o)=>World.Instance.AddSingleton(o));
			Options.Instance.StartConfig = $"StartConfig/Localhost";
			
			World.Instance.AddSingleton<Logger>().Log = new UnityLogger();
			ETTask.ExceptionHandler += Log.Error;
			
			World.Instance.AddSingleton<TimeInfo>();
			World.Instance.AddSingleton<FiberManager>();

			await World.Instance.AddSingleton<ResourcesComponent>().CreatePackageAsync("DefaultPackage", true);
			
			CodeLoader codeLoader = World.Instance.AddSingleton<CodeLoader>();
			await codeLoader.DownloadAsync();
			
			codeLoader.Start();
		}

		private void Update()
		{
			TimeInfo.Instance.Update();
			FiberManager.Instance.Update();
		}

		private void LateUpdate()
		{
			FiberManager.Instance.LateUpdate();
		}

		private void OnApplicationQuit()
		{
			World.Instance.Dispose();
		}

		public void GooglePlayGamesSignin()
		{
			Debug.Log("GooglePlayGamesSignin");
			// 配置登录选项，请求用户信息权限
			//PlayGamesPlatform.Instance.Authenticate(ProcessAuthentication);

			//PlayGamesPlatform.Activate();
			//Social.localUser.Authenticate(ProcessAuthentication_2);
			//this.GetComponent<GoogleLoginScript>().OnSignIn();

			//PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder().Build();
			//PlayGamesPlatform.InitializeInstance(config);
			
			PlayGamesPlatform.Activate();
			Social.localUser.Authenticate((bool success) =>
			{
				if (success)
				{
					Debug.Log("Google Play Games 登录成功");
					Debug.Log("PlayGamesPlatform.Instance.GetUserId xxxx: " + PlayGamesPlatform.Instance.GetUserId());
				}
				else
				{
					Debug.Log("Google Play Games 登录失败");
					Debug.Log("PlayGamesPlatform.Instance.GetUserId yyyy: " + PlayGamesPlatform.Instance.GetUserId());
				}
			});
		}
	}
}