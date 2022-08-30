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
    unsafe class HeadBarUI_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(global::HeadBarUI);

            field = type.GetField("HeadPos", flag);
            app.RegisterCLRFieldGetter(field, get_HeadPos_0);
            app.RegisterCLRFieldSetter(field, set_HeadPos_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_HeadPos_0, AssignFromStack_HeadPos_0);
            field = type.GetField("HeadBar", flag);
            app.RegisterCLRFieldGetter(field, get_HeadBar_1);
            app.RegisterCLRFieldSetter(field, set_HeadBar_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_HeadBar_1, AssignFromStack_HeadBar_1);


        }



        static object get_HeadPos_0(ref object o)
        {
            return ((global::HeadBarUI)o).HeadPos;
        }

        static StackObject* CopyToStack_HeadPos_0(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::HeadBarUI)o).HeadPos;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_HeadPos_0(ref object o, object v)
        {
            ((global::HeadBarUI)o).HeadPos = (UnityEngine.Transform)v;
        }

        static StackObject* AssignFromStack_HeadPos_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Transform @HeadPos = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((global::HeadBarUI)o).HeadPos = @HeadPos;
            return ptr_of_this_method;
        }

        static object get_HeadBar_1(ref object o)
        {
            return ((global::HeadBarUI)o).HeadBar;
        }

        static StackObject* CopyToStack_HeadBar_1(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::HeadBarUI)o).HeadBar;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_HeadBar_1(ref object o, object v)
        {
            ((global::HeadBarUI)o).HeadBar = (UnityEngine.GameObject)v;
        }

        static StackObject* AssignFromStack_HeadBar_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.GameObject @HeadBar = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((global::HeadBarUI)o).HeadBar = @HeadBar;
            return ptr_of_this_method;
        }



    }
}
