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
    unsafe class ScrollCircle_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(global::ScrollCircle);

            field = type.GetField("BeginDragAction", flag);
            app.RegisterCLRFieldGetter(field, get_BeginDragAction_0);
            app.RegisterCLRFieldSetter(field, set_BeginDragAction_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_BeginDragAction_0, AssignFromStack_BeginDragAction_0);
            field = type.GetField("EndDragAction", flag);
            app.RegisterCLRFieldGetter(field, get_EndDragAction_1);
            app.RegisterCLRFieldSetter(field, set_EndDragAction_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_EndDragAction_1, AssignFromStack_EndDragAction_1);
            field = type.GetField("DragingAction", flag);
            app.RegisterCLRFieldGetter(field, get_DragingAction_2);
            app.RegisterCLRFieldSetter(field, set_DragingAction_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_DragingAction_2, AssignFromStack_DragingAction_2);


        }



        static object get_BeginDragAction_0(ref object o)
        {
            return ((global::ScrollCircle)o).BeginDragAction;
        }

        static StackObject* CopyToStack_BeginDragAction_0(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::ScrollCircle)o).BeginDragAction;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_BeginDragAction_0(ref object o, object v)
        {
            ((global::ScrollCircle)o).BeginDragAction = (System.Action)v;
        }

        static StackObject* AssignFromStack_BeginDragAction_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action @BeginDragAction = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((global::ScrollCircle)o).BeginDragAction = @BeginDragAction;
            return ptr_of_this_method;
        }

        static object get_EndDragAction_1(ref object o)
        {
            return ((global::ScrollCircle)o).EndDragAction;
        }

        static StackObject* CopyToStack_EndDragAction_1(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::ScrollCircle)o).EndDragAction;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_EndDragAction_1(ref object o, object v)
        {
            ((global::ScrollCircle)o).EndDragAction = (System.Action)v;
        }

        static StackObject* AssignFromStack_EndDragAction_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action @EndDragAction = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((global::ScrollCircle)o).EndDragAction = @EndDragAction;
            return ptr_of_this_method;
        }

        static object get_DragingAction_2(ref object o)
        {
            return ((global::ScrollCircle)o).DragingAction;
        }

        static StackObject* CopyToStack_DragingAction_2(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::ScrollCircle)o).DragingAction;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_DragingAction_2(ref object o, object v)
        {
            ((global::ScrollCircle)o).DragingAction = (System.Action<UnityEngine.EventSystems.PointerEventData>)v;
        }

        static StackObject* AssignFromStack_DragingAction_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action<UnityEngine.EventSystems.PointerEventData> @DragingAction = (System.Action<UnityEngine.EventSystems.PointerEventData>)typeof(System.Action<UnityEngine.EventSystems.PointerEventData>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((global::ScrollCircle)o).DragingAction = @DragingAction;
            return ptr_of_this_method;
        }



    }
}
