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

namespace ET
{

    public static class TestCS
    {
        public static void Test()
        {
            //var options = new CompilerParameters();
        }
    }

    /// <summary>
    /// 本类用来将字符串转为可执行文本并执行
    /// 从别处复制，勿随意更改！
    /// </summary>
    //public class Evaluator
    //{
    //    #region 构造函数
    //    /// <summary>
    //    /// 可执行串的构造函数
    //    /// </summary>
    //    /// <param name="items">
    //    /// 可执行字符串数组
    //    /// </param>
    //    public Evaluator(EvaluatorItem[] items, Dictionary<string, string> listAssemblies = null)
    //    {
    //        ConstructEvaluator(items, listAssemblies);      //调用解析字符串构造函数进行解析
    //    }
    //    /// <summary>
    //    /// 可执行串的构造函数
    //    /// </summary>
    //    /// <param name="returnType">返回值类型</param>
    //    /// <param name="expression">执行表达式</param>
    //    /// <param name="name">执行字符串名称</param>
    //    public Evaluator(Type returnType, string expression, string name, Dictionary<string, string> listAssemblies = null)
    //    {
    //        //创建可执行字符串数组
    //        EvaluatorItem[] items = { new EvaluatorItem(returnType, expression, name) };
    //        ConstructEvaluator(items, listAssemblies);      //调用解析字符串构造函数进行解析
    //    }
    //    public Evaluator(string allCode, string _namespace, string _class, List<string> listAssemblies = null)
    //    {
    //        ConstructEvaluatorByAllCode(allCode, _namespace, _class, listAssemblies);      //调用解析字符串构造函数进行解析
    //    }
    //    /// <summary>
    //    /// 可执行串的构造函数
    //    /// </summary>
    //    /// <param name="item">可执行字符串项</param>
    //    public Evaluator(EvaluatorItem item, Dictionary<string, string> listAssemblies = null)
    //    {
    //        EvaluatorItem[] items = { item };//将可执行字符串项转为可执行字符串项数组
    //        ConstructEvaluator(items, listAssemblies);      //调用解析字符串构造函数进行解析
    //    }
    //    /// <summary>
    //    /// 解析字符串构造函数
    //    /// </summary>
    //    /// <param name="items">待解析字符串数组</param>
    //    private void ConstructEvaluator(EvaluatorItem[] items, Dictionary<string, string> listAssemblies = null)
    //    {
    //        //创建C#编译器实例
    //        ICodeCompiler comp = (new CSharpCodeProvider().CreateCompiler());
    //        //编译器的传入参数
    //        CompilerParameters cp = new CompilerParameters();
    //        cp.ReferencedAssemblies.Add("system.dll");              //添加程序集 system.dll 的引用
    //        cp.ReferencedAssemblies.Add("system.data.dll");         //添加程序集 system.data.dll 的引用
    //        cp.ReferencedAssemblies.Add("system.xml.dll");          //添加程序集 system.xml.dll 的引用
    //        cp.ReferencedAssemblies.Add("System.Windows.Forms.dll");          //添加程序集 system.xml.dll 的引用
    //        cp.GenerateExecutable = false;                          //不生成可执行文件
    //        cp.GenerateInMemory = true;                             //在内存中运行
    //        StringBuilder code = new StringBuilder();               //创建代码串
    //        if (listAssemblies != null)
    //        {
    //            foreach (var item in listAssemblies)
    //            {
    //                cp.ReferencedAssemblies.Add(item.Key);              //添加程序集 引用
    //                code.Append("using " + item.Value + "; \n");
    //            }
    //        }
    //        /*
    //         * 添加常见且必须的引用字符串
    //         */
    //        code.Append("using System; \n");
    //        code.Append("using System.Data; \n");
    //        code.Append("using System.Data.SqlClient; \n");
    //        code.Append("using System.Data.OleDb; \n");
    //        code.Append("using System.Xml; \n");
    //        code.Append("using System.Windows.Forms; \n");
    //        code.Append("namespace EvalGuy { \n");                  //生成代码的命名空间为EvalGuy，和本代码一样
    //        code.Append(" public class _Evaluator { \n");          //产生 _Evaluator 类，所有可执行代码均在此类中运行
    //        foreach (EvaluatorItem item in items)               //遍历每一个可执行字符串项
    //        {
    //            code.AppendFormat("    public {0} {1}() ",          //添加定义公共函数代码
    //                            item.ReturnType == null ? "void" : item.ReturnType.Name,             //函数返回值为可执行字符串项中定义的返回值类型
    //                              item.Name);                       //函数名称为可执行字符串项中定义的执行字符串名称
    //            code.Append("{ ");                                  //添加函数开始括号
    //            if (item.ReturnType != null)
    //                code.AppendFormat("return ({0});", item.Expression);//添加函数体，返回可执行字符串项中定义的表达式的值
    //            else
    //            {
    //                code.Append(item.Expression);//添加函数体，返回可执行字符串项中定义的表达式的值
    //            }
    //            code.Append("}\n");                                 //添加函数结束括号
    //        }
    //        code.Append("} }");                                 //添加类结束和命名空间结束括号
    //        //得到编译器实例的返回结果
    //        CompilerResults cr = comp.CompileAssemblyFromSource(cp, code.ToString());
    //        if (cr.Errors.HasErrors)                            //如果有错误
    //        {
    //            StringBuilder error = new StringBuilder();          //创建错误信息字符串
    //            error.Append("编译有错误的表达式: ");                //添加错误文本
    //            foreach (CompilerError err in cr.Errors)            //遍历每一个出现的编译错误
    //            {
    //                error.AppendFormat("{0}\n", err.ErrorText);     //添加进错误文本，每个错误后换行
    //            }
    //            throw new Exception("编译错误: " + error.ToString());//抛出异常
    //        }
    //        Assembly a = cr.CompiledAssembly;                       //获取编译器实例的程序集
    //        _Compiled = a.CreateInstance("EvalGuy._Evaluator");     //通过程序集查找并声明 EvalGuy._Evaluator 的实例
    //    }
    //    private void ConstructEvaluatorByAllCode(string allcode, string _namespace, string _class, List<string> listAssemblies)
    //    {
    //        if (listAssemblies == null)
    //        {
    //            listAssemblies = new List<string>();
    //        }
    //        //创建C#编译器实例
    //        ICodeCompiler comp = (new CSharpCodeProvider().CreateCompiler());
    //        //编译器的传入参数
    //        CompilerParameters cp = new CompilerParameters();
    //        if (!listAssemblies.Contains("system.dll"))
    //        {
    //            listAssemblies.Add("system.dll");
    //            listAssemblies.Add("system.data.dll");
    //            listAssemblies.Add("system.xml.dll");
    //        }
    //        foreach (var item in listAssemblies)
    //        {
    //            cp.ReferencedAssemblies.Add(item);
    //        }
    //        cp.GenerateExecutable = false;                          //不生成可执行文件
    //        cp.GenerateInMemory = true;                             //在内存中运行
    //        //得到编译器实例的返回结果
    //        CompilerResults cr = comp.CompileAssemblyFromSource(cp, allcode);
    //        if (cr.Errors.HasErrors)                            //如果有错误
    //        {
    //            StringBuilder error = new StringBuilder();          //创建错误信息字符串
    //            error.Append("编译有错误的表达式: ");                //添加错误文本
    //            foreach (CompilerError err in cr.Errors)            //遍历每一个出现的编译错误
    //            {
    //                error.AppendFormat("{0}\n", err.ErrorText);     //添加进错误文本，每个错误后换行
    //            }
    //            throw new Exception("编译错误: " + error.ToString());//抛出异常
    //        }
    //        Assembly a = cr.CompiledAssembly;                       //获取编译器实例的程序集
    //        _Compiled = a.CreateInstance($"{_namespace}.{_class}");     //通过程序集查找并声明 EvalGuy._Evaluator 的实例
    //    }
    //    #endregion

    //    #region 公有成员
    //    /// <summary>
    //    /// 执行字符串并返回整型值
    //    /// </summary>
    //    /// <param name="name">执行字符串名称</param>
    //    /// <returns>执行结果</returns>
    //    public int EvaluateInt(string name)
    //    {
    //        return (int)Evaluate(name);
    //    }
    //    /// <summary>
    //    /// 执行字符串并返回字符串型值
    //    /// </summary>
    //    /// <param name="name">执行字符串名称</param>
    //    /// <returns>执行结果</returns>
    //    public string EvaluateString(string name)
    //    {
    //        return (string)Evaluate(name);
    //    }
    //    /// <summary>
    //    /// 执行字符串并返回布尔型值
    //    /// </summary>
    //    /// <param name="name">执行字符串名称</param>
    //    /// <returns>执行结果</returns>
    //    public bool EvaluateBool(string name)
    //    {
    //        return (bool)Evaluate(name);
    //    }
    //    /// <summary>
    //    /// 执行字符串并返 object 型值
    //    /// </summary>
    //    /// <param name="name">执行字符串名称</param>
    //    /// <returns>执行结果</returns>
    //    public object Evaluate(string name)
    //    {
    //        MethodInfo mi = _Compiled.GetType().GetMethod(name);//获取 _Compiled 所属类型中名称为 name 的方法的引用
    //        return mi.Invoke(_Compiled, null);                  //执行 mi 所引用的方法
    //    }
    //    #endregion
    //    #region 静态成员
    //    /// <summary>
    //    /// 执行表达式并返回整型值
    //    /// </summary>
    //    /// <param name="code">要执行的表达式</param>
    //    /// <param name="listAssemblies">需要引用到类库，key:dll名称，value:命名空间名称</param>
    //    /// <returns>运算结果</returns>
    //    static public int EvaluateToInteger(string code, Dictionary<string, string> listAssemblies = null)
    //    {
    //        Evaluator eval = new Evaluator(typeof(int), code, staticMethodName, listAssemblies);//生成 Evaluator 类的对像
    //        return (int)eval.Evaluate(staticMethodName);                        //执行并返回整型数据
    //    }
    //    /// <summary>
    //    /// 执行表达式并返回字符串型值
    //    /// </summary>
    //    /// <param name="code">要执行的表达式</param>
    //    /// <param name="listAssemblies">需要引用到类库，key:dll名称，value:命名空间名称</param>
    //    /// <returns>运算结果</returns>
    //    static public string EvaluateToString(string code, Dictionary<string, string> listAssemblies = null)
    //    {
    //        Evaluator eval = new Evaluator(typeof(string), code, staticMethodName, listAssemblies);//生成 Evaluator 类的对像
    //        return (string)eval.Evaluate(staticMethodName);                     //执行并返回字符串型数据
    //    }
    //    /// <summary>
    //    /// 执行表达式并返回布尔型值
    //    /// </summary>
    //    /// <param name="code">要执行的表达式</param>
    //    /// <param name="listAssemblies">需要引用到类库，key:dll名称，value:命名空间名称</param>
    //    /// <returns>运算结果</returns>
    //    static public bool EvaluateToBool(string code, Dictionary<string, string> listAssemblies = null)
    //    {
    //        Evaluator eval = new Evaluator(typeof(bool), code, staticMethodName, listAssemblies);//生成 Evaluator 类的对像
    //        return (bool)eval.Evaluate(staticMethodName);                       //执行并返回布尔型数据
    //    }
    //    /// <summary>
    //    /// 执行表达式并返回 object 型值
    //    /// </summary>
    //    /// <param name="code">要执行的表达式</param>
    //    /// <param name="listAssemblies">需要引用到类库，key:dll名称，value:命名空间名称</param>
    //    /// <returns>运算结果</returns>
    //    static public object EvaluateToObject(string code, Dictionary<string, string> listAssemblies = null)
    //    {
    //        Evaluator eval = new Evaluator(typeof(object), code, staticMethodName, listAssemblies);//生成 Evaluator 类的对像
    //        return eval.Evaluate(staticMethodName);                             //执行并返回 object 型数据
    //    }
    //    /// <summary>
    //    /// 执行一个无返回式的代码
    //    /// </summary>
    //    /// <param name="code"></param>
    //    /// <param name="listAssemblies">需要引用到类库，key:dll名称，value:命名空间名称</param>
    //    static public void EvaluateToVoid(string code, Dictionary<string, string> listAssemblies = null)
    //    {
    //        Evaluator eval = new Evaluator(null, code, staticMethodName, listAssemblies);//生成 Evaluator 类的对像
    //        eval.Evaluate(staticMethodName);                             //执行并返回 object 型数据
    //    }
    //    /// <summary>
    //    /// 执行一个全代码
    //    /// </summary>
    //    /// <param name="code">全代码，包含命名空间引用，命名空间声明，类声明，函数声明等</param>
    //    /// <param name="_namespace"></param>
    //    /// <param name="_class"></param>
    //    /// <param name="methodName">函数</param>
    //    /// <param name="listAssemblies">需要引用到类库</param>
    //    public static void EvaluateByAllCode(string code, string _namespace, string _class, string methodName, List<string> listAssemblies = null)
    //    {
    //        Evaluator eval = new Evaluator(code, _namespace, _class, listAssemblies);//生成 Evaluator 类的对像
    //        eval.Evaluate(methodName);
    //    }
    //    #endregion
    //    #region 私有成员
    //    /// <summary>
    //    /// 静态方法的执行字符串名称
    //    /// </summary>
    //    private const string staticMethodName = "__foo";
    //    /// <summary>
    //    /// 用于动态引用生成的类，执行其内部包含的可执行字符串
    //    /// </summary>
    //    object _Compiled = null;
    //    #endregion
    //}
    /// <summary>
    /// 可执行字符串项（即一条可执行字符串）
    /// </summary>
    public class EvaluatorItem
    {
        /// <summary>
        /// 返回值类型
        /// </summary>
        public Type ReturnType;
        /// <summary>
        /// 执行表达式
        /// </summary>
        public string Expression;
        /// <summary>
        /// 执行字符串名称
        /// </summary>
        public string Name;
        /// <summary>
        /// 可执行字符串项构造函数
        /// </summary>
        /// <param name="returnType">返回值类型</param>
        /// <param name="expression">执行表达式</param>
        /// <param name="name">执行字符串名称</param>
        public EvaluatorItem(Type returnType, string expression, string name)
        {
            ReturnType = returnType;
            Expression = expression;
            Name = name;
        }
    }

    public static class DyncCSHelper
{

    public static string str = @"using System;
namespace ET
{ 
    public class bb
    {
        public  void cc()
        {
            Console.WriteLine(1);
        }
    }
}";

    public static void GenerateDyncCS(string content)
    {
        //Proto2CS("ET", "../Proto/InnerMessage.proto", serverMessagePath, "InnerOpcode", OpcodeRangeDefine.InnerMinOpcode);


    }

}

}

   