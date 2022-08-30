using System;
using System.Reflection;

namespace ET
{
    public class MonoStaticMethod : IStaticMethod
    {
        private readonly MethodInfo methodInfo;

        private readonly object[] param;

        private MonoStaticMethod(MethodInfo methodInfo, object[] param)
        {
            this.methodInfo = methodInfo;
            this.param = param;
        }

        public MonoStaticMethod(Assembly assembly, string typeName, string methodName)
        {
            this.methodInfo = assembly.GetType(typeName).GetMethod(methodName);
            this.param = new object[this.methodInfo.GetParameters().Length];
        }

        public static MonoStaticMethod Create(Assembly assembly, string typeName, string methodName)
        {
            Type type = assembly?.GetType(typeName);
            MethodInfo methodInfo = type?.GetMethod(methodName);
            int len = methodInfo?.GetParameters()?.Length ?? 0;
            object[] param = new object[len];
            return methodInfo != null ? new MonoStaticMethod(methodInfo, param) : null;
        }

        public override void Run()
        {
            this.methodInfo.Invoke(null, param);
        }

        public override void Run(object a)
        {
            this.param[0] = a;
            this.methodInfo.Invoke(null, param);
        }

        public override void Run(object a, object b)
        {
            this.param[0] = a;
            this.param[1] = b;
            this.methodInfo.Invoke(null, param);
        }

        public override void Run(object a, object b, object c)
        {
            this.param[0] = a;
            this.param[1] = b;
            this.param[2] = c;
            this.methodInfo.Invoke(null, param);
        }
    }
}

