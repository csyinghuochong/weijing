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
    unsafe class NpcLocal_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(global::NpcLocal);

            field = type.GetField("NpcId", flag);
            app.RegisterCLRFieldGetter(field, get_NpcId_0);
            app.RegisterCLRFieldSetter(field, set_NpcId_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_NpcId_0, AssignFromStack_NpcId_0);
            field = type.GetField("Target", flag);
            app.RegisterCLRFieldGetter(field, get_Target_1);
            app.RegisterCLRFieldSetter(field, set_Target_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Target_1, AssignFromStack_Target_1);
            field = type.GetField("NpcName", flag);
            app.RegisterCLRFieldGetter(field, get_NpcName_2);
            app.RegisterCLRFieldSetter(field, set_NpcName_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_NpcName_2, AssignFromStack_NpcName_2);
            field = type.GetField("NpcSpeak", flag);
            app.RegisterCLRFieldGetter(field, get_NpcSpeak_3);
            app.RegisterCLRFieldSetter(field, set_NpcSpeak_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_NpcSpeak_3, AssignFromStack_NpcSpeak_3);
            field = type.GetField("AssetBundle", flag);
            app.RegisterCLRFieldGetter(field, get_AssetBundle_4);
            app.RegisterCLRFieldSetter(field, set_AssetBundle_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_AssetBundle_4, AssignFromStack_AssetBundle_4);


        }



        static object get_NpcId_0(ref object o)
        {
            return ((global::NpcLocal)o).NpcId;
        }

        static StackObject* CopyToStack_NpcId_0(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::NpcLocal)o).NpcId;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_NpcId_0(ref object o, object v)
        {
            ((global::NpcLocal)o).NpcId = (System.Int32)v;
        }

        static StackObject* AssignFromStack_NpcId_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @NpcId = ptr_of_this_method->Value;
            ((global::NpcLocal)o).NpcId = @NpcId;
            return ptr_of_this_method;
        }

        static object get_Target_1(ref object o)
        {
            return ((global::NpcLocal)o).Target;
        }

        static StackObject* CopyToStack_Target_1(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::NpcLocal)o).Target;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Target_1(ref object o, object v)
        {
            ((global::NpcLocal)o).Target = (UnityEngine.Transform)v;
        }

        static StackObject* AssignFromStack_Target_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Transform @Target = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((global::NpcLocal)o).Target = @Target;
            return ptr_of_this_method;
        }

        static object get_NpcName_2(ref object o)
        {
            return ((global::NpcLocal)o).NpcName;
        }

        static StackObject* CopyToStack_NpcName_2(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::NpcLocal)o).NpcName;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_NpcName_2(ref object o, object v)
        {
            ((global::NpcLocal)o).NpcName = (System.String)v;
        }

        static StackObject* AssignFromStack_NpcName_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @NpcName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((global::NpcLocal)o).NpcName = @NpcName;
            return ptr_of_this_method;
        }

        static object get_NpcSpeak_3(ref object o)
        {
            return ((global::NpcLocal)o).NpcSpeak;
        }

        static StackObject* CopyToStack_NpcSpeak_3(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::NpcLocal)o).NpcSpeak;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_NpcSpeak_3(ref object o, object v)
        {
            ((global::NpcLocal)o).NpcSpeak = (System.String)v;
        }

        static StackObject* AssignFromStack_NpcSpeak_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @NpcSpeak = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((global::NpcLocal)o).NpcSpeak = @NpcSpeak;
            return ptr_of_this_method;
        }

        static object get_AssetBundle_4(ref object o)
        {
            return ((global::NpcLocal)o).AssetBundle;
        }

        static StackObject* CopyToStack_AssetBundle_4(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::NpcLocal)o).AssetBundle;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_AssetBundle_4(ref object o, object v)
        {
            ((global::NpcLocal)o).AssetBundle = (UnityEngine.GameObject)v;
        }

        static StackObject* AssignFromStack_AssetBundle_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.GameObject @AssetBundle = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((global::NpcLocal)o).AssetBundle = @AssetBundle;
            return ptr_of_this_method;
        }



    }
}
