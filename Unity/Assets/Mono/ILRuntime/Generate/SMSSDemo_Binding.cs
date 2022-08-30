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
    unsafe class SMSSDemo_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(global::SMSSDemo);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("OnButtonGetCode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnButtonGetCode_0);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("OnButtonCommbitCode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnButtonCommbitCode_1);

            field = type.GetField("CommitCodeSucessHandler", flag);
            app.RegisterCLRFieldGetter(field, get_CommitCodeSucessHandler_0);
            app.RegisterCLRFieldSetter(field, set_CommitCodeSucessHandler_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_CommitCodeSucessHandler_0, AssignFromStack_CommitCodeSucessHandler_0);


        }


        static StackObject* OnButtonGetCode_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @phoneNumber = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::SMSSDemo instance_of_this_method = (global::SMSSDemo)typeof(global::SMSSDemo).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnButtonGetCode(@phoneNumber);

            return __ret;
        }

        static StackObject* OnButtonCommbitCode_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @code = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::SMSSDemo instance_of_this_method = (global::SMSSDemo)typeof(global::SMSSDemo).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnButtonCommbitCode(@code);

            return __ret;
        }


        static object get_CommitCodeSucessHandler_0(ref object o)
        {
            return ((global::SMSSDemo)o).CommitCodeSucessHandler;
        }

        static StackObject* CopyToStack_CommitCodeSucessHandler_0(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::SMSSDemo)o).CommitCodeSucessHandler;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_CommitCodeSucessHandler_0(ref object o, object v)
        {
            ((global::SMSSDemo)o).CommitCodeSucessHandler = (System.Action<System.String>)v;
        }

        static StackObject* AssignFromStack_CommitCodeSucessHandler_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action<System.String> @CommitCodeSucessHandler = (System.Action<System.String>)typeof(System.Action<System.String>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((global::SMSSDemo)o).CommitCodeSucessHandler = @CommitCodeSucessHandler;
            return ptr_of_this_method;
        }



    }
}
