using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEngine;
using System.Linq;
using System.Runtime.Serialization;
using System.Net.Http;

namespace ET
{
	public class CodeLoader: IDisposable
	{
		public static CodeLoader Instance = new CodeLoader();
		public Action Update;
		public Action LateUpdate;
		public Action OnApplicationQuit;

		private Assembly assembly;

		public CodeMode CodeMode { get; set; }
		
		// 所有mono的类型
		private readonly Dictionary<string, Type> monoTypes = new Dictionary<string, Type>();
		
		// 热更层的类型
		private readonly Dictionary<string, Type> hotfixTypes = new Dictionary<string, Type>();
		private ILRuntime.Runtime.Enviorment.AppDomain appDomain;


		[IgnoreDataMemberAttribute]
		private int ttt;

		public MultiMap<long, long> timers = new MultiMap<long, long>();
		public MultiMap<long, object> timers2 = new MultiMap<long, object>();
		public MultiMap<int, object> timers3 = new MultiMap<int, object>();
		public Dictionary<int, object> timers4 = new Dictionary<int, object>();

		public HttpClient httpClient;

		private CodeLoader()
		{
			Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
			foreach (Assembly ass in assemblies)
			{
				foreach (Type type in ass.GetTypes())
				{
					this.monoTypes[type.FullName] = type;
					this.monoTypes[type.AssemblyQualifiedName] = type;
				}
			}
			timers = new MultiMap<long, long>();
			timers2 = new MultiMap<long, object>();
			timers2.ToArray();
			timers3.ToArray();
			timers4.ToArray();
			NoRun().Coroutine();
		}

		public static async ETTask NoRun()
		{
			await ETTask.CompletedTask;
			await ETTask<int>.Create();
			await ETTask<float>.Create();
			await ETTask<double>.Create();
			await ETTask<object>.Create();
		}

		public Type GetMonoType(string fullName)
		{
			this.monoTypes.TryGetValue(fullName, out Type type);
			return type;
		}
		
		public Type GetHotfixType(string fullName)
		{
			this.hotfixTypes.TryGetValue(fullName, out Type type);
			return type;
		}

		public void Dispose()
		{
			this.appDomain?.Dispose();
		}
		
		public void Start()
		{
			switch (this.CodeMode)
			{
				case CodeMode.HuaTuo:
					{
						Log.ILog.Debug("hotupdate1   CodeMode.HuaTuo");

						byte[] assBytes = LoadHelper.LoadCode("Code.dll").bytes;
						byte[] pdbBytes = LoadHelper.LoadCode("Code.pdb").bytes;

						assembly = Assembly.Load(assBytes, pdbBytes);
						Type[] types = assembly.GetTypes();
						foreach (Type type in types)
						{
							this.hotfixTypes[type.FullName] = type;
						}

						Log.ILog.Debug($"huatuo2   CodeMode.HuaTuo {this.hotfixTypes.Count}");
						IStaticMethod start = MonoStaticMethod.Create(assembly, "ET.Entry", "Start");
						start.Run();

						break;
					}
				case CodeMode.Mono:
				{
						Log.ILog.Debug("hotupdate1   CodeMode.HuaTuo");
						byte[] assBytes = LoadHelper.LoadCode("Code.dll").bytes;
					byte[] pdbBytes = LoadHelper.LoadCode("Code.pdb").bytes;

					assembly = Assembly.Load(assBytes, pdbBytes);
					foreach (Type type in this.assembly.GetTypes())
					{
						this.monoTypes[type.FullName] = type;
						this.hotfixTypes[type.FullName] = type;
					}
					IStaticMethod start = new MonoStaticMethod(assembly, "ET.Entry", "Start");
					start.Run();
					break;
				}
                case CodeMode.ILRuntime:
                    {
						Log.ILog.Debug("hotupdate1   CodeMode.ILRuntime");
						byte[] assBytes = LoadHelper.LoadCode("Code.dll").bytes;
                        byte[] pdbBytes = LoadHelper.LoadCode("Code.pdb").bytes;

                        //byte[] assBytes = File.ReadAllBytes(Path.Combine("../Unity/", Define.BuildOutputDir, "Code.dll"));
                        //byte[] pdbBytes = File.ReadAllBytes(Path.Combine("../Unity/", Define.BuildOutputDir, "Code.pdb"));

                        appDomain = new ILRuntime.Runtime.Enviorment.AppDomain(ILRuntime.Runtime.ILRuntimeJITFlags.JITOnDemand);
#if DEBUG && (UNITY_EDITOR || UNITY_ANDROID || UNITY_IPHONE)
                        this.appDomain.UnityMainThreadID = System.Threading.Thread.CurrentThread.ManagedThreadId;
#endif
                        MemoryStream assStream = new MemoryStream(assBytes);
                        MemoryStream pdbStream = new MemoryStream(pdbBytes);
                        appDomain.LoadAssembly(assStream, pdbStream, new ILRuntime.Mono.Cecil.Pdb.PdbReaderProvider());

                        Type[] types = appDomain.LoadedTypes.Values.Select(x => x.ReflectionType).ToArray();
                        foreach (Type type in types)
                        {
                            this.hotfixTypes[type.FullName] = type;
                        }

						Log.ILog.Debug("InitILRuntime_111");
                        ILHelper.InitILRuntime(appDomain);
						Log.ILog.Debug("InitILRuntime_222");

						IStaticMethod start = new ILStaticMethod(appDomain, "ET.Entry", "Start", 0);
                        start.Run();
                        break;
                    }
                case CodeMode.Reload:
				{
					byte[] assBytes = File.ReadAllBytes(Path.Combine(Define.BuildOutputDir, "Data.dll"));
					byte[] pdbBytes = File.ReadAllBytes(Path.Combine(Define.BuildOutputDir, "Data.pdb"));
					
					assembly = Assembly.Load(assBytes, pdbBytes);
					this.LoadLogic();
					IStaticMethod start = new MonoStaticMethod(assembly, "ET.Entry", "Start");
					start.Run();
					break;
				}
			}
		}

		// 热重载调用下面三个方法
		// CodeLoader.Instance.LoadLogic();
		// Game.EventSystem.Add(CodeLoader.Instance.GetTypes());
		// Game.EventSystem.Load();
		public void LoadLogic()
		{
			if (this.CodeMode != CodeMode.Reload)
			{
				throw new Exception("CodeMode != Reload!");
			}
			
			// 傻屌Unity在这里搞了个傻逼优化，认为同一个路径的dll，返回的程序集就一样。所以这里每次编译都要随机名字
			string[] logicFiles = Directory.GetFiles(Define.BuildOutputDir, "Logic_*.dll");
			if (logicFiles.Length != 1)
			{
				throw new Exception("Logic dll count != 1");
			}

			string logicName = Path.GetFileNameWithoutExtension(logicFiles[0]);
			byte[] assBytes = File.ReadAllBytes(Path.Combine(Define.BuildOutputDir, $"{logicName}.dll"));
			byte[] pdbBytes = File.ReadAllBytes(Path.Combine(Define.BuildOutputDir, $"{logicName}.pdb"));

			Assembly hotfixAssembly = Assembly.Load(assBytes, pdbBytes);
			
			foreach (Type type in this.assembly.GetTypes())
			{
				this.monoTypes[type.FullName] = type;
				this.hotfixTypes[type.FullName] = type;
			}
			
			foreach (Type type in hotfixAssembly.GetTypes())
			{
				this.monoTypes[type.FullName] = type;
				this.hotfixTypes[type.FullName] = type;
			}
		}

		public Dictionary<string, Type> GetHotfixTypes()
		{
			return this.hotfixTypes;
		}
	}
}