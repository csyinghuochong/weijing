using System;
using System.Collections.Generic;
using ET;
using HybridCLR;
using UnityEngine;

public static class InitHybridCLR
{

    public static void Init()
    {
        //if (GameObject.Find("Global").GetComponent<Init>().CodeMode == CodeMode.HuaTuo)
        //{
            
        //}
        LoadMetadataForAOTAssembly();
    }


    /// <summary>
    /// 为aot assembly加载原始metadata， 这个代码放aot或者热更新都行。
    /// 一旦加载后，如果AOT泛型函数对应native实现不存在，则自动替换为解释模式执行
    /// </summary>
    public static unsafe void LoadMetadataForAOTAssembly()
    {
        // 可以加载任意aot assembly的对应的dll。但要求dll必须与unity build过程中生成的裁剪后的dll一致，而不能直接使用原始dll。
        // 我们在Huatuo_BuildProcessor_xxx里添加了处理代码，这些裁剪后的dll在打包时自动被复制到 {项目目录}/HuatuoData/AssembliesPostIl2CppStrip/{Target} 目录。

        // 注意，补充元数据是给AOT dll补充元数据，而不是给热更新dll补充元数据。
        // 热更新dll不缺元数据，不需要补充，如果调用LoadMetadataForAOTAssembly会返回错误
        List<string> aotDllList = new List<string>
                {
                    "mscorlib.dll",
                    "System.dll",
                    "System.Core.dll", // 如果使用了Linq，需要这个
                    //"FromHotFix.dll",
                    "Unity.Mono.dll",
                    "Unity.ThirdParty.dll",
                    // "Newtonsoft.Json.dll",
                    // "protobuf-net.dll",
                    // "Google.Protobuf.dll",
                    // "MongoDB.Bson.dll",
                    // "DOTween.Modules.dll",
                    // "UniTask.dll",
                };

        foreach (var aotDllName in aotDllList)
        {
            byte[] dllBytes = LoadHelper.LoadCode($"{aotDllName}").bytes;

            Log.ILog.Debug($"{ aotDllName} {dllBytes!=null}");
            //AssetComponent.Load<TextAsset>($"Assets/Bundles/Code/.bytes").bytes;

            fixed (byte* ptr = dllBytes)
            {
                // 加载assembly对应的dll，会自动为它hook。一旦aot泛型函数的native函数不存在，用解释器版本代码
                int err = RuntimeApi.LoadMetadataForAOTAssembly((IntPtr)ptr, dllBytes.Length);
                Debug.Log($"LoadMetadataForAOTAssembly:{aotDllName}. ret:{err}");
            }
        }
    }
}
