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
    unsafe class libx_Assets_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(libx.Assets);
            args = new Type[]{typeof(System.String), typeof(System.Type)};
            method = type.GetMethod("LoadAsset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LoadAsset_0);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("UnloadAsset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, UnloadAsset_1);
            args = new Type[]{typeof(System.String), typeof(System.Boolean)};
            method = type.GetMethod("LoadSceneAsync", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LoadSceneAsync_2);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("UnloadScene", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, UnloadScene_3);
            args = new Type[]{};
            method = type.GetMethod("RemoveUnUseScene", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveUnUseScene_4);
            args = new Type[]{typeof(System.String), typeof(System.Type)};
            method = type.GetMethod("LoadAssetAsync", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LoadAssetAsync_5);

            field = type.GetField("MAX_BUNDLES_PERFRAME", flag);
            app.RegisterCLRFieldGetter(field, get_MAX_BUNDLES_PERFRAME_0);
            app.RegisterCLRFieldSetter(field, set_MAX_BUNDLES_PERFRAME_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_MAX_BUNDLES_PERFRAME_0, AssignFromStack_MAX_BUNDLES_PERFRAME_0);


        }


        static StackObject* LoadAsset_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Type @type = (System.Type)typeof(System.Type).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @path = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = libx.Assets.LoadAsset(@path, @type);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* UnloadAsset_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @asset = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            libx.Assets.UnloadAsset(@asset);

            return __ret;
        }

        static StackObject* LoadSceneAsync_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @additive = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @path = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = libx.Assets.LoadSceneAsync(@path, @additive);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* UnloadScene_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @scene = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            libx.Assets.UnloadScene(@scene);

            return __ret;
        }

        static StackObject* RemoveUnUseScene_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            libx.Assets.RemoveUnUseScene();

            return __ret;
        }

        static StackObject* LoadAssetAsync_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Type @type = (System.Type)typeof(System.Type).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @path = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = libx.Assets.LoadAssetAsync(@path, @type);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object get_MAX_BUNDLES_PERFRAME_0(ref object o)
        {
            return libx.Assets.MAX_BUNDLES_PERFRAME;
        }

        static StackObject* CopyToStack_MAX_BUNDLES_PERFRAME_0(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = libx.Assets.MAX_BUNDLES_PERFRAME;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_MAX_BUNDLES_PERFRAME_0(ref object o, object v)
        {
            libx.Assets.MAX_BUNDLES_PERFRAME = (System.Int32)v;
        }

        static StackObject* AssignFromStack_MAX_BUNDLES_PERFRAME_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @MAX_BUNDLES_PERFRAME = ptr_of_this_method->Value;
            libx.Assets.MAX_BUNDLES_PERFRAME = @MAX_BUNDLES_PERFRAME;
            return ptr_of_this_method;
        }



    }
}
