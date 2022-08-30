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
    unsafe class ET_Init_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(ET.Init);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("FenXiang", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, FenXiang_0);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("Authorize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Authorize_1);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetUserInfo", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetUserInfo_2);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("AliPay", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AliPay_3);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("WeChatPay", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WeChatPay_4);
            args = new Type[]{};
            method = type.GetMethod("OnGetPhoneNum", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnGetPhoneNum_5);
            args = new Type[]{typeof(System.Int64)};
            method = type.GetMethod("OpenBuglyAgent", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OpenBuglyAgent_6);

            field = type.GetField("OnApplicationFocusHandler", flag);
            app.RegisterCLRFieldGetter(field, get_OnApplicationFocusHandler_0);
            app.RegisterCLRFieldSetter(field, set_OnApplicationFocusHandler_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnApplicationFocusHandler_0, AssignFromStack_OnApplicationFocusHandler_0);
            field = type.GetField("EditorMode", flag);
            app.RegisterCLRFieldGetter(field, get_EditorMode_1);
            app.RegisterCLRFieldSetter(field, set_EditorMode_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_EditorMode_1, AssignFromStack_EditorMode_1);
            field = type.GetField("BanHaoMode", flag);
            app.RegisterCLRFieldGetter(field, get_BanHaoMode_2);
            app.RegisterCLRFieldSetter(field, set_BanHaoMode_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_BanHaoMode_2, AssignFromStack_BanHaoMode_2);
            field = type.GetField("OueNetMode", flag);
            app.RegisterCLRFieldGetter(field, get_OueNetMode_3);
            app.RegisterCLRFieldSetter(field, set_OueNetMode_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_OueNetMode_3, AssignFromStack_OueNetMode_3);
            field = type.GetField("CodeMode", flag);
            app.RegisterCLRFieldGetter(field, get_CodeMode_4);
            app.RegisterCLRFieldSetter(field, set_CodeMode_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_CodeMode_4, AssignFromStack_CodeMode_4);
            field = type.GetField("OnGetKeyHandler", flag);
            app.RegisterCLRFieldGetter(field, get_OnGetKeyHandler_5);
            app.RegisterCLRFieldSetter(field, set_OnGetKeyHandler_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnGetKeyHandler_5, AssignFromStack_OnGetKeyHandler_5);
            field = type.GetField("OnGetMouseButtonDown_0", flag);
            app.RegisterCLRFieldGetter(field, get_OnGetMouseButtonDown_0_6);
            app.RegisterCLRFieldSetter(field, set_OnGetMouseButtonDown_0_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnGetMouseButtonDown_0_6, AssignFromStack_OnGetMouseButtonDown_0_6);
            field = type.GetField("OnGetMouseButtonDown_1", flag);
            app.RegisterCLRFieldGetter(field, get_OnGetMouseButtonDown_1_7);
            app.RegisterCLRFieldSetter(field, set_OnGetMouseButtonDown_1_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnGetMouseButtonDown_1_7, AssignFromStack_OnGetMouseButtonDown_1_7);
            field = type.GetField("Updater", flag);
            app.RegisterCLRFieldGetter(field, get_Updater_8);
            app.RegisterCLRFieldSetter(field, set_Updater_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_Updater_8, AssignFromStack_Updater_8);
            field = type.GetField("BigVersion", flag);
            app.RegisterCLRFieldGetter(field, get_BigVersion_9);
            app.RegisterCLRFieldSetter(field, set_BigVersion_9);
            app.RegisterCLRFieldBinding(field, CopyToStack_BigVersion_9, AssignFromStack_BigVersion_9);
            field = type.GetField("OnShareHandler", flag);
            app.RegisterCLRFieldGetter(field, get_OnShareHandler_10);
            app.RegisterCLRFieldSetter(field, set_OnShareHandler_10);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnShareHandler_10, AssignFromStack_OnShareHandler_10);
            field = type.GetField("OnAuthorizeHandler", flag);
            app.RegisterCLRFieldGetter(field, get_OnAuthorizeHandler_11);
            app.RegisterCLRFieldSetter(field, set_OnAuthorizeHandler_11);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnAuthorizeHandler_11, AssignFromStack_OnAuthorizeHandler_11);
            field = type.GetField("OnGetUserInfoHandler", flag);
            app.RegisterCLRFieldGetter(field, get_OnGetUserInfoHandler_12);
            app.RegisterCLRFieldSetter(field, set_OnGetUserInfoHandler_12);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnGetUserInfoHandler_12, AssignFromStack_OnGetUserInfoHandler_12);
            field = type.GetField("OnGetPhoneNumHandler", flag);
            app.RegisterCLRFieldGetter(field, get_OnGetPhoneNumHandler_13);
            app.RegisterCLRFieldSetter(field, set_OnGetPhoneNumHandler_13);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnGetPhoneNumHandler_13, AssignFromStack_OnGetPhoneNumHandler_13);


        }


        static StackObject* FenXiang_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @fenxiangtype = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ET.Init instance_of_this_method = (ET.Init)typeof(ET.Init).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.FenXiang(@fenxiangtype);

            return __ret;
        }

        static StackObject* Authorize_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @fenxiangtype = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ET.Init instance_of_this_method = (ET.Init)typeof(ET.Init).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Authorize(@fenxiangtype);

            return __ret;
        }

        static StackObject* GetUserInfo_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @fenxiangtype = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ET.Init instance_of_this_method = (ET.Init)typeof(ET.Init).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.GetUserInfo(@fenxiangtype);

            return __ret;
        }

        static StackObject* AliPay_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @OrderInfo = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ET.Init instance_of_this_method = (ET.Init)typeof(ET.Init).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AliPay(@OrderInfo);

            return __ret;
        }

        static StackObject* WeChatPay_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @orderInfo = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ET.Init instance_of_this_method = (ET.Init)typeof(ET.Init).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.WeChatPay(@orderInfo);

            return __ret;
        }

        static StackObject* OnGetPhoneNum_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ET.Init instance_of_this_method = (ET.Init)typeof(ET.Init).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnGetPhoneNum();

            return __ret;
        }

        static StackObject* OpenBuglyAgent_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int64 @userId = *(long*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ET.Init instance_of_this_method = (ET.Init)typeof(ET.Init).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OpenBuglyAgent(@userId);

            return __ret;
        }


        static object get_OnApplicationFocusHandler_0(ref object o)
        {
            return ((ET.Init)o).OnApplicationFocusHandler;
        }

        static StackObject* CopyToStack_OnApplicationFocusHandler_0(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((ET.Init)o).OnApplicationFocusHandler;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnApplicationFocusHandler_0(ref object o, object v)
        {
            ((ET.Init)o).OnApplicationFocusHandler = (System.Action<System.Boolean>)v;
        }

        static StackObject* AssignFromStack_OnApplicationFocusHandler_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action<System.Boolean> @OnApplicationFocusHandler = (System.Action<System.Boolean>)typeof(System.Action<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((ET.Init)o).OnApplicationFocusHandler = @OnApplicationFocusHandler;
            return ptr_of_this_method;
        }

        static object get_EditorMode_1(ref object o)
        {
            return ((ET.Init)o).EditorMode;
        }

        static StackObject* CopyToStack_EditorMode_1(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((ET.Init)o).EditorMode;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_EditorMode_1(ref object o, object v)
        {
            ((ET.Init)o).EditorMode = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_EditorMode_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @EditorMode = ptr_of_this_method->Value == 1;
            ((ET.Init)o).EditorMode = @EditorMode;
            return ptr_of_this_method;
        }

        static object get_BanHaoMode_2(ref object o)
        {
            return ((ET.Init)o).BanHaoMode;
        }

        static StackObject* CopyToStack_BanHaoMode_2(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((ET.Init)o).BanHaoMode;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_BanHaoMode_2(ref object o, object v)
        {
            ((ET.Init)o).BanHaoMode = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_BanHaoMode_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @BanHaoMode = ptr_of_this_method->Value == 1;
            ((ET.Init)o).BanHaoMode = @BanHaoMode;
            return ptr_of_this_method;
        }

        static object get_OueNetMode_3(ref object o)
        {
            return ((ET.Init)o).OueNetMode;
        }

        static StackObject* CopyToStack_OueNetMode_3(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((ET.Init)o).OueNetMode;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_OueNetMode_3(ref object o, object v)
        {
            ((ET.Init)o).OueNetMode = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_OueNetMode_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @OueNetMode = ptr_of_this_method->Value == 1;
            ((ET.Init)o).OueNetMode = @OueNetMode;
            return ptr_of_this_method;
        }

        static object get_CodeMode_4(ref object o)
        {
            return ((ET.Init)o).CodeMode;
        }

        static StackObject* CopyToStack_CodeMode_4(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((ET.Init)o).CodeMode;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_CodeMode_4(ref object o, object v)
        {
            ((ET.Init)o).CodeMode = (ET.CodeMode)v;
        }

        static StackObject* AssignFromStack_CodeMode_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            ET.CodeMode @CodeMode = (ET.CodeMode)typeof(ET.CodeMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((ET.Init)o).CodeMode = @CodeMode;
            return ptr_of_this_method;
        }

        static object get_OnGetKeyHandler_5(ref object o)
        {
            return ((ET.Init)o).OnGetKeyHandler;
        }

        static StackObject* CopyToStack_OnGetKeyHandler_5(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((ET.Init)o).OnGetKeyHandler;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnGetKeyHandler_5(ref object o, object v)
        {
            ((ET.Init)o).OnGetKeyHandler = (System.Action<System.Int32>)v;
        }

        static StackObject* AssignFromStack_OnGetKeyHandler_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action<System.Int32> @OnGetKeyHandler = (System.Action<System.Int32>)typeof(System.Action<System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((ET.Init)o).OnGetKeyHandler = @OnGetKeyHandler;
            return ptr_of_this_method;
        }

        static object get_OnGetMouseButtonDown_0_6(ref object o)
        {
            return ((ET.Init)o).OnGetMouseButtonDown_0;
        }

        static StackObject* CopyToStack_OnGetMouseButtonDown_0_6(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((ET.Init)o).OnGetMouseButtonDown_0;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnGetMouseButtonDown_0_6(ref object o, object v)
        {
            ((ET.Init)o).OnGetMouseButtonDown_0 = (System.Action)v;
        }

        static StackObject* AssignFromStack_OnGetMouseButtonDown_0_6(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action @OnGetMouseButtonDown_0 = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((ET.Init)o).OnGetMouseButtonDown_0 = @OnGetMouseButtonDown_0;
            return ptr_of_this_method;
        }

        static object get_OnGetMouseButtonDown_1_7(ref object o)
        {
            return ((ET.Init)o).OnGetMouseButtonDown_1;
        }

        static StackObject* CopyToStack_OnGetMouseButtonDown_1_7(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((ET.Init)o).OnGetMouseButtonDown_1;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnGetMouseButtonDown_1_7(ref object o, object v)
        {
            ((ET.Init)o).OnGetMouseButtonDown_1 = (System.Action)v;
        }

        static StackObject* AssignFromStack_OnGetMouseButtonDown_1_7(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action @OnGetMouseButtonDown_1 = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((ET.Init)o).OnGetMouseButtonDown_1 = @OnGetMouseButtonDown_1;
            return ptr_of_this_method;
        }

        static object get_Updater_8(ref object o)
        {
            return ((ET.Init)o).Updater;
        }

        static StackObject* CopyToStack_Updater_8(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((ET.Init)o).Updater;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Updater_8(ref object o, object v)
        {
            ((ET.Init)o).Updater = (UnityEngine.GameObject)v;
        }

        static StackObject* AssignFromStack_Updater_8(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.GameObject @Updater = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((ET.Init)o).Updater = @Updater;
            return ptr_of_this_method;
        }

        static object get_BigVersion_9(ref object o)
        {
            return ((ET.Init)o).BigVersion;
        }

        static StackObject* CopyToStack_BigVersion_9(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((ET.Init)o).BigVersion;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_BigVersion_9(ref object o, object v)
        {
            ((ET.Init)o).BigVersion = (System.Int32)v;
        }

        static StackObject* AssignFromStack_BigVersion_9(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @BigVersion = ptr_of_this_method->Value;
            ((ET.Init)o).BigVersion = @BigVersion;
            return ptr_of_this_method;
        }

        static object get_OnShareHandler_10(ref object o)
        {
            return ((ET.Init)o).OnShareHandler;
        }

        static StackObject* CopyToStack_OnShareHandler_10(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((ET.Init)o).OnShareHandler;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnShareHandler_10(ref object o, object v)
        {
            ((ET.Init)o).OnShareHandler = (System.Action<System.Boolean>)v;
        }

        static StackObject* AssignFromStack_OnShareHandler_10(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action<System.Boolean> @OnShareHandler = (System.Action<System.Boolean>)typeof(System.Action<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((ET.Init)o).OnShareHandler = @OnShareHandler;
            return ptr_of_this_method;
        }

        static object get_OnAuthorizeHandler_11(ref object o)
        {
            return ((ET.Init)o).OnAuthorizeHandler;
        }

        static StackObject* CopyToStack_OnAuthorizeHandler_11(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((ET.Init)o).OnAuthorizeHandler;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnAuthorizeHandler_11(ref object o, object v)
        {
            ((ET.Init)o).OnAuthorizeHandler = (System.Action<System.String>)v;
        }

        static StackObject* AssignFromStack_OnAuthorizeHandler_11(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action<System.String> @OnAuthorizeHandler = (System.Action<System.String>)typeof(System.Action<System.String>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((ET.Init)o).OnAuthorizeHandler = @OnAuthorizeHandler;
            return ptr_of_this_method;
        }

        static object get_OnGetUserInfoHandler_12(ref object o)
        {
            return ((ET.Init)o).OnGetUserInfoHandler;
        }

        static StackObject* CopyToStack_OnGetUserInfoHandler_12(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((ET.Init)o).OnGetUserInfoHandler;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnGetUserInfoHandler_12(ref object o, object v)
        {
            ((ET.Init)o).OnGetUserInfoHandler = (System.Action<System.String>)v;
        }

        static StackObject* AssignFromStack_OnGetUserInfoHandler_12(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action<System.String> @OnGetUserInfoHandler = (System.Action<System.String>)typeof(System.Action<System.String>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((ET.Init)o).OnGetUserInfoHandler = @OnGetUserInfoHandler;
            return ptr_of_this_method;
        }

        static object get_OnGetPhoneNumHandler_13(ref object o)
        {
            return ((ET.Init)o).OnGetPhoneNumHandler;
        }

        static StackObject* CopyToStack_OnGetPhoneNumHandler_13(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((ET.Init)o).OnGetPhoneNumHandler;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnGetPhoneNumHandler_13(ref object o, object v)
        {
            ((ET.Init)o).OnGetPhoneNumHandler = (System.Action<System.String>)v;
        }

        static StackObject* AssignFromStack_OnGetPhoneNumHandler_13(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action<System.String> @OnGetPhoneNumHandler = (System.Action<System.String>)typeof(System.Action<System.String>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((ET.Init)o).OnGetPhoneNumHandler = @OnGetPhoneNumHandler;
            return ptr_of_this_method;
        }



    }
}
