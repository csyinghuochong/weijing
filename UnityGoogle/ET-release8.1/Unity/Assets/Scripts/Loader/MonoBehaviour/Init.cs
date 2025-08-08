using System;
using CommandLine;
using UnityEngine;
using GooglePlayGames;
using Google;
using System.Collections.Generic;
using System.Threading.Tasks;

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
		
		private GoogleSignInConfiguration configuration;

		public void InitGoogleSignInConfiguration()
		{
			if (configuration == null)
			{
				Debug.Log("InitGoogleSignInConfiguration");
				
				configuration = new GoogleSignInConfiguration
				{
					WebClientId = "180577064002-g3nucon81omrr7j7m9ic7e5kpepj2nmf.apps.googleusercontent.com",
					RequestIdToken = true
				};
			}
		}
		
		public void OnSignIn()
		{
			this.InitGoogleSignInConfiguration();
			
			GoogleSignIn.Configuration = configuration;
			GoogleSignIn.Configuration.UseGameSignIn = false;
			GoogleSignIn.Configuration.RequestIdToken = true;

			Debug.Log("Calling SignIn");
			
			GoogleSignIn.DefaultInstance.SignIn().ContinueWith(OnAuthenticationFinished);
		}
		
		public void OnSignOut()
		{
			this.InitGoogleSignInConfiguration();
			
			Debug.Log("Calling SignOut");
			
			GoogleSignIn.DefaultInstance.SignOut();
		}
		
		public void OnDisconnect()
		{
			this.InitGoogleSignInConfiguration();
			
			Debug.Log("Calling Disconnect");
			
			GoogleSignIn.DefaultInstance.Disconnect();
		}
		
		void OnAuthenticationFinished(Task<GoogleSignInUser> task)
		{
			if (task.IsFaulted)
			{
				using (IEnumerator<System.Exception> enumerator = task.Exception.InnerExceptions.GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						GoogleSignIn.SignInException error = (GoogleSignIn.SignInException)enumerator.Current;
						Debug.Log("Got Error: " + error.Status + " " + error.Message);
					}
					else
					{
						Debug.Log("Got Unexpected Exception?!?" + task.Exception);
					}
				}
			}
			else if (task.IsCanceled)
			{
				Debug.Log("Canceled");
			}
			else
			{
				Debug.Log("Google 登录成功");
				Debug.Log($"Id: {task.Result.UserId}");
				Debug.Log($"Name: {task.Result.DisplayName}");
			}
		}
		
		public void OnSignInSilently()
		{
			this.InitGoogleSignInConfiguration();
			
			GoogleSignIn.Configuration = configuration;
			GoogleSignIn.Configuration.UseGameSignIn = false;
			GoogleSignIn.Configuration.RequestIdToken = true;
		
			Debug.Log("Calling SignInSilently");
			
			GoogleSignIn.DefaultInstance.SignInSilently().ContinueWith(OnAuthenticationFinished);
		}
		
		
		public void OnGamesSignIn()
		{
			this.InitGoogleSignInConfiguration();
			
			GoogleSignIn.Configuration = configuration;
			GoogleSignIn.Configuration.UseGameSignIn = true;
			GoogleSignIn.Configuration.RequestIdToken = false;
		
			Debug.Log("Calling GamesSignIn");
			
			GoogleSignIn.DefaultInstance.SignIn().ContinueWith(OnAuthenticationFinished);
		}
	}
}