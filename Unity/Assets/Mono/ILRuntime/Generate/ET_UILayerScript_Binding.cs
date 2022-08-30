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
    unsafe class ET_UILayerScript_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(ET.UILayerScript);

            field = type.GetField("ShowHuoBi", flag);
            app.RegisterCLRFieldGetter(field, get_ShowHuoBi_0);
            app.RegisterCLRFieldSetter(field, set_ShowHuoBi_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_ShowHuoBi_0, AssignFromStack_ShowHuoBi_0);
            field = type.GetField("HideMainUI", flag);
            app.RegisterCLRFieldGetter(field, get_HideMainUI_1);
            app.RegisterCLRFieldSetter(field, set_HideMainUI_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_HideMainUI_1, AssignFromStack_HideMainUI_1);
            field = type.GetField("UILayer", flag);
            app.RegisterCLRFieldGetter(field, get_UILayer_2);
            app.RegisterCLRFieldSetter(field, set_UILayer_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_UILayer_2, AssignFromStack_UILayer_2);
            field = type.GetField("UIType", flag);
            app.RegisterCLRFieldGetter(field, get_UIType_3);
            app.RegisterCLRFieldSetter(field, set_UIType_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_UIType_3, AssignFromStack_UIType_3);


        }



        static object get_ShowHuoBi_0(ref object o)
        {
            return ((ET.UILayerScript)o).ShowHuoBi;
        }

        static StackObject* CopyToStack_ShowHuoBi_0(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((ET.UILayerScript)o).ShowHuoBi;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_ShowHuoBi_0(ref object o, object v)
        {
            ((ET.UILayerScript)o).ShowHuoBi = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_ShowHuoBi_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @ShowHuoBi = ptr_of_this_method->Value == 1;
            ((ET.UILayerScript)o).ShowHuoBi = @ShowHuoBi;
            return ptr_of_this_method;
        }

        static object get_HideMainUI_1(ref object o)
        {
            return ((ET.UILayerScript)o).HideMainUI;
        }

        static StackObject* CopyToStack_HideMainUI_1(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((ET.UILayerScript)o).HideMainUI;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_HideMainUI_1(ref object o, object v)
        {
            ((ET.UILayerScript)o).HideMainUI = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_HideMainUI_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @HideMainUI = ptr_of_this_method->Value == 1;
            ((ET.UILayerScript)o).HideMainUI = @HideMainUI;
            return ptr_of_this_method;
        }

        static object get_UILayer_2(ref object o)
        {
            return ((ET.UILayerScript)o).UILayer;
        }

        static StackObject* CopyToStack_UILayer_2(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((ET.UILayerScript)o).UILayer;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_UILayer_2(ref object o, object v)
        {
            ((ET.UILayerScript)o).UILayer = (ET.UILayer)v;
        }

        static StackObject* AssignFromStack_UILayer_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            ET.UILayer @UILayer = (ET.UILayer)typeof(ET.UILayer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((ET.UILayerScript)o).UILayer = @UILayer;
            return ptr_of_this_method;
        }

        static object get_UIType_3(ref object o)
        {
            return ((ET.UILayerScript)o).UIType;
        }

        static StackObject* CopyToStack_UIType_3(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((ET.UILayerScript)o).UIType;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_UIType_3(ref object o, object v)
        {
            ((ET.UILayerScript)o).UIType = (ET.UIEnum)v;
        }

        static StackObject* AssignFromStack_UIType_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            ET.UIEnum @UIType = (ET.UIEnum)typeof(ET.UIEnum).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((ET.UILayerScript)o).UIType = @UIType;
            return ptr_of_this_method;
        }



    }
}
