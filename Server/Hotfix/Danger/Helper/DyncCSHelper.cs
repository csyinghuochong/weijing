using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CSharp;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Reflection;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Diagnostics;
using System.Globalization;
using System.Runtime;
using System.IO;
using Microsoft.CodeAnalysis.Emit;

namespace ET
{
    public static class DyncCSHelper
    {
        const string programText =
@"using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(""Hello, World!"");
        }
    }
}";

        public static void Test()
        {
            //var options = new CompilerParameters();
            SyntaxTree tree = CSharpSyntaxTree.ParseText(programText);
            CompilationUnitSyntax root = tree.GetCompilationUnitRoot();
        }

        public static void Test_2(string script)
        {
            string strCSFilePath = @$"../{script}.cs";
            string strCsDir = System.IO.Path.GetDirectoryName(strCSFilePath);
            string strTempDir = System.IO.Path.Combine(strCsDir, "temp");//编译生成类库文件目录
            if (!System.IO.Directory.Exists(strTempDir))
                System.IO.Directory.CreateDirectory(strTempDir);
            string strOutput = System.IO.Path.GetRandomFileName();//随机文件名
            string strCompiledFile = System.IO.Path.Combine(strTempDir, strOutput + ".compiled");
            string strPdbFile = System.IO.Path.Combine(strTempDir, strOutput + ".pdb");

            StringBuilder asmInfo = new StringBuilder();

            //生成版本信息
            asmInfo.AppendLine("using System.Reflection;");
            asmInfo.AppendLine($"[assembly: AssemblyTitle(\"{strOutput}\")]");
            asmInfo.AppendLine("[assembly: AssemblyVersion(\"1.0.0.0\")]");
            asmInfo.AppendLine("[assembly: AssemblyFileVersion(\"1.0.0.0\")]");
            // Product Info
            asmInfo.AppendLine($"[assembly: AssemblyProduct(\"{strOutput}\")]");
            asmInfo.AppendLine("[assembly: AssemblyInformationalVersion(\"1.0.0.0\")]");

            var VerInfoSyntaxTree = CSharpSyntaxTree.ParseText(asmInfo.ToString(), CSharpParseOptions.Default.WithLanguageVersion(LanguageVersion.CSharp8));

            string strCode = File.ReadAllText(strCSFilePath);
            //LanguageVersion 需要一致
            var parsedSyntaxTree = CSharpSyntaxTree.ParseText(strCode, CSharpParseOptions.Default.WithLanguageVersion(LanguageVersion.CSharp8), strCSFilePath, Encoding.UTF8);//调试源码path需指定encoding
            CSharpCompilationOptions defaultCompilationOptions = new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary).WithOptimizationLevel(OptimizationLevel.Release).WithPlatform(Platform.AnyCpu);
            if (System.Diagnostics.Debugger.IsAttached)
            {
                //生成调试信息
                defaultCompilationOptions = new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary).WithOptimizationLevel(OptimizationLevel.Debug).WithPlatform(Platform.AnyCpu);
            }
       
            var assemblyPath = Path.GetDirectoryName(typeof(object).Assembly.Location);
            //dll引用,动态库需要就引入，不需要的可以省略
            IEnumerable<MetadataReference> DefaultReferences =
                new[]
                {
                    MetadataReference.CreateFromFile(typeof(object).Assembly.Location),//mscorlib.dll
                    MetadataReference.CreateFromFile(typeof(Uri).Assembly.Location),//System.dll
                    MetadataReference.CreateFromFile(typeof(Enumerable).Assembly.Location),//System.Core.dll
                      MetadataReference.CreateFromFile( "./Server.Model.dll"),
                                        MetadataReference.CreateFromFile( "./Server.Hotfix.dll"),
                    MetadataReference.CreateFromFile(Path.Combine(assemblyPath, "System.Collections.dll")),
                    MetadataReference.CreateFromFile(Path.Combine(assemblyPath, "System.Data.dll")),
                    MetadataReference.CreateFromFile(Path.Combine(assemblyPath, "System.Linq.dll")),
                    MetadataReference.CreateFromFile(Path.Combine(assemblyPath, "System.XML.dll")),
                    MetadataReference.CreateFromFile(Path.Combine(assemblyPath, "System.IO.dll")),
                    MetadataReference.CreateFromFile(Path.Combine(assemblyPath, "Microsoft.CSharp.dll")),
                    MetadataReference.CreateFromFile(Path.Combine(assemblyPath, "System.Runtime.dll")),
                    MetadataReference.CreateFromFile(Path.Combine(assemblyPath, "System.Runtime.Serialization.dll")),
                    MetadataReference.CreateFromFile(Path.Combine(assemblyPath, "System.Dynamic.Runtime.dll")),
                    MetadataReference.CreateFromFile(Path.Combine(assemblyPath, "System.Reflection.dll"))
                };

            var compilation = CSharpCompilation.Create(strOutput, new SyntaxTree[] { VerInfoSyntaxTree, parsedSyntaxTree }, DefaultReferences, defaultCompilationOptions);
            var dllms = new System.IO.MemoryStream();
          
            MemoryStream pdbms = null;//pdb文件
            EmitOptions emitOptions = null;
            if (System.Diagnostics.Debugger.IsAttached)
            {
                pdbms = new System.IO.MemoryStream();
                emitOptions = new EmitOptions(debugInformationFormat: DebugInformationFormat.PortablePdb, pdbFilePath: strPdbFile);
            }

            var EmitRet = compilation.Emit(dllms, pdbStream: pdbms, options: emitOptions);

            if (EmitRet.Success)
            {
                //输出类库
                using (var file = new System.IO.FileStream(strCompiledFile, System.IO.FileMode.Create))
                {
                    dllms.Seek(0, System.IO.SeekOrigin.Begin);
                    dllms.WriteTo(file);
                    file.Close();
                }
                //pdb文件
                if (pdbms != null)
                {
                    using (var filePdb = new System.IO.FileStream(strPdbFile, System.IO.FileMode.Create))
                    {
                        pdbms.Seek(0, System.IO.SeekOrigin.Begin);
                        pdbms.WriteTo(filePdb);
                        filePdb.Close();
                    }
                }

                //内存中的类库调用
                var ourAssembly = Assembly.Load(dllms.ToArray());
                Type tp = ourAssembly.GetType($"ET.{script}");
                object instanceDll = Activator.CreateInstance(tp);
                if (instanceDll == null)
                    return;//出错了
                var method = tp.GetMethod("dllAdd");
                if (method == null)
                    return;//出错了
                double dbResult = (double)method.Invoke(instanceDll, new object[] { 5.68, 4.2 });
                Console.WriteLine("tree1111:   " +  dbResult.ToString("F4"));//类库中的函数调用结果
                
                method = tp.GetMethod("Admin");
                if (method == null)
                    return;//出错了

                string admin = (string)method.Invoke(instanceDll, new object[] { });
                Console.WriteLine("tree222:   " + admin);

                ComHelp.TTTT = 2; 
            }
        }
    }

}

   