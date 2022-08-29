using System;
using System.Collections.Generic;
using System.Net;

namespace ET
{
    public static class Entry
	{
		public static void Start()
		{
			try
			{
                //LoadMetadataForAOTAssembly();

                CodeLoader.Instance.Update += Game.Update;
				CodeLoader.Instance.LateUpdate += Game.LateUpdate;
				CodeLoader.Instance.OnApplicationQuit += Game.Close;
                Game.EventSystem.Add(CodeLoader.Instance.GetHotfixTypes());
				Game.EventSystem.Publish(new EventType.AppStart());
			}
			catch (Exception e)
			{
				Log.Error(e);
			}
		}


        /// <summary>
        /// 为aot assembly加载原始metadata， 这个代码放aot或者热更新都行。
        /// 一旦加载后，如果AOT泛型函数对应native实现不存在，则自动替换为解释模式执行
        /// </summary>
        public static unsafe void LoadMetadataForAOTAssembly()
        {
            // 可以加载任意aot assembly的对应的dll。但要求dll必须与unity build过程中生成的裁剪后的dll一致，而不能直接使用
            // 原始dll。
            // 这些dll可以在目录 Temp\StagingArea\Il2Cpp\Managed 下找到。
            // 对于Win Standalone，也可以在 build目录的 {Project}/Managed目录下找到。
            // 对于Android及其他target, 导出工程中并没有这些dll，因此还是得去 Temp\StagingArea\Il2Cpp\Managed 获取。
            //
            // 这里以最常用的mscorlib.dll举例
            //
            // 加载打包时 unity在build目录下生成的 裁剪过的 mscorlib，注意，不能为原始mscorlib
            //
            //string mscorelib = @$"{Application.dataPath}/../Temp/StagingArea/Il2Cpp/Managed/mscorlib.dll";

            /// 注意，补充元数据是给AOT dll补充元数据，而不是给热更新dll补充元数据。
            /// 热更新dll不缺元数据，不需要补充，如果调用LoadMetadataForAOTAssembly会返回错误
            List<string> aotDllList = new List<string>
            {
                "mscorlib.dll",
                "System.dll",
                "System.Core.dll", // 如果使用了Linq，需要这个
                "Unity.Mono.dll",
                "Unity.ThirdParty.dll",
               // "Code.dll",
                // "Newtonsoft.Json.dll",
                // "protobuf-net.dll",
                // "Google.Protobuf.dll",
                // "MongoDB.Bson.dll",
                // "DOTween.Modules.dll",
                // "UniTask.dll",
            };

            //AssetBundle dllAB = LoadDll.AssemblyAssetBundle;
            //foreach (var aotDllName in aotDllList)
            //{
            //    byte[] dllBytes = LoadHelper.LoadCodeBytes(aotDllName);

            //    Log.ILog.Debug($"LoadMetadataForAOTAssembly1:{aotDllName}. ret:{dllBytes.Length}");
            //    fixed (byte* ptr = dllBytes)
            //    {
            //        // 加载assembly对应的dll，会自动为它hook。一旦aot泛型函数的native函数不存在，用解释器版本代码
            //        int err = HuaTuo.RuntimeApi.LoadMetadataForAOTAssembly((IntPtr)ptr, dllBytes.Length);
            //        Log.ILog.Debug($"LoadMetadataForAOTAssembly2:{dllBytes}. ret:{err}");
            //    }
            //}

            IPAddress[] xxc = Dns.GetHostEntry("mengjing.weijinggame.com").AddressList;
            //{
            //    byte[] dllBytes = LoadHelper.LoadCodeBytes("Code.dll");
            //    fixed (byte* ptr = dllBytes)
            //    {
            //        // 加载assembly对应的dll，会自动为它hook。一旦aot泛型函数的native函数不存在，用解释器版本代码
            //        int err = Huatuo.HuatuoApi.LoadMetadataForAOTAssembly((IntPtr)ptr, dllBytes.Length);
            //        Log.ILog.Debug($"LoadMetadataForAOTAssembly2:{dllBytes}. ret:{err}");
            //    }
            //}
            {
                //byte[] dllBytes = LoadHelper.LoadCodeBytes("Code.pdb");
                //fixed (byte* ptr = dllBytes)
                //{
                //    // 加载assembly对应的dll，会自动为它hook。一旦aot泛型函数的native函数不存在，用解释器版本代码
                //    int err = Huatuo.HuatuoApi.LoadMetadataForAOTAssembly((IntPtr)ptr, dllBytes.Length);
                //    Log.ILog.Debug($"LoadMetadataForAOTAssembly2:{dllBytes}. ret:{err}");
                //}
            }

        }


    }
}