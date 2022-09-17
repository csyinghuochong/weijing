using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using ILRuntime.Reflection;
using ILRuntime.CLR.Utils;

namespace ILRuntime.Runtime.Generated
{
    unsafe class MyCamera_1_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(global::MyCamera_1);
            args = new Type[]{};
            method = type.GetMethod("OnUpdate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnUpdate_0);

            field = type.GetField("Target", flag);
            app.RegisterCLRFieldGetter(field, get_Target_0);
            app.RegisterCLRFieldSetter(field, set_Target_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Target_0, AssignFromStack_Target_0);


        }


        static StackObject* OnUpdate_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::MyCamera_1 instance_of_this_method = (global::MyCamera_1)typeof(global::MyCamera_1).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnUpdate();

            return __ret;
        }


        static object get_Target_0(ref object o)
        {
            return ((global::MyCamera_1)o).Target;
        }

        static StackObject* CopyToStack_Target_0(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::MyCamera_1)o).Target;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Target_0(ref object o, object v)
        {
            ((global::MyCamera_1)o).Target = (UnityEngine.Transform)v;
        }

        static StackObject* AssignFromStack_Target_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Transform @Target = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((global::MyCamera_1)o).Target = @Target;
            return ptr_of_this_method;
        }



    }
}
