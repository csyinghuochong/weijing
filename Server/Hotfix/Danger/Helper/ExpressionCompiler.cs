using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Emit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Linq;

namespace ET
{
    public static class ExpressionCompiler
    {
        public static Func<double, double> Compile(string expression)
        {
            const string className = "Expressions";
            const string methodName = "Func";
            //C#代码字符串
            string sourceString = $"using System;using static System.Math;public class {className}" +
                $"{{public static double {methodName}(double x)=>{expression};}}";

            Assembly assembly = null;
            SyntaxTree syntaxTree = CSharpSyntaxTree.ParseText(sourceString);
            SyntaxTree[] syntaxTreeList = new SyntaxTree[1] { syntaxTree };

            string assemblyName = "ass";

            CSharpCompilation compilation = CSharpCompilation.Create(
                assemblyName,
                syntaxTrees: syntaxTreeList,
                references: metadataReferenceList,
                options: new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));
            using (var ms = new MemoryStream())
            {
                EmitResult result = compilation.Emit(ms);
                if (!result.Success)
                {
                    IEnumerable<Diagnostic> failures = result.Diagnostics.Where(diagnostic => diagnostic.IsWarningAsError || diagnostic.Severity == DiagnosticSeverity.Error);
                    StringBuilder sb = new StringBuilder();
                    foreach (Diagnostic diagnostic in failures)
                    {
                        /* Process failures */
                        sb.AppendLine(diagnostic.GetMessage());
                    }
                    throw new ArgumentException(sb.ToString());
                }
                else
                {
                    ms.Seek(0, SeekOrigin.Begin);
                    assembly = Assembly.Load(ms.ToArray());
                }
            }
            /*//构造一个CSharp代码生成器
            var provider = new Microsoft.CodeDom.Providers.DotNetCompilerPlatform.CSharpCodeProvider();
            //var provider = new Microsoft.CSharp.CSharpCodeProvider();
            //构造一个编译器参数设置
            CompilerParameters para = new CompilerParameters
            {
                GenerateInMemory = true,
                GenerateExecutable = false
            };
            //para可以需要按照实际要求进行设置，比如添加程序集引用，如下
            //para.ReferencedAssemblies.Add("System.dll");
            //编译到程序集,有重载，也可以从文件加载，传入参数为文件路径字符串数组
            CompilerResults rst = provider.CompileAssemblyFromSource(para, txt);
            //判断是否有编译错误
            if (rst.Errors.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                foreach (CompilerError item in rst.Errors)
                {
                    sb.AppendLine(item.Line + ":" + item.ErrorText);
                }
                throw new ArgumentException(sb.ToString());
            }
            //获取程序集
            Assembly assemble = rst.CompiledAssembly;*/
            //通过反射获取类类型
            Type t = assembly.GetType(className);
            //通过反射获取类型方法
            MethodInfo method = t.GetMethod(methodName);
            return method.CreateDelegate<Func<double, double>>();
        }

        static readonly List<MetadataReference> metadataReferenceList;

        static ExpressionCompiler()
        {
            Assembly[] assemblyArray = AppDomain.CurrentDomain.GetAssemblies();
            if (metadataReferenceList != null) return;
            metadataReferenceList = new List<MetadataReference>();
            foreach (Assembly domainAssembly in assemblyArray)
            {
                try
                {
                    AssemblyMetadata assemblyMetadata = AssemblyMetadata.CreateFromFile(domainAssembly.Location);
                    MetadataReference metadataReference = assemblyMetadata.GetReference();
                    metadataReferenceList.Add(metadataReference);
                }
                catch (Exception e)
                {
                    Log.Error(e.ToString());
                }
            }
        }
    }
}
