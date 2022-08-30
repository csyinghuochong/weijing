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
    unsafe class UISizeFangDa_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(global::UISizeFangDa);

            field = type.GetField("Obj_Img", flag);
            app.RegisterCLRFieldGetter(field, get_Obj_Img_0);
            app.RegisterCLRFieldSetter(field, set_Obj_Img_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Obj_Img_0, AssignFromStack_Obj_Img_0);


        }



        static object get_Obj_Img_0(ref object o)
        {
            return ((global::UISizeFangDa)o).Obj_Img;
        }

        static StackObject* CopyToStack_Obj_Img_0(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::UISizeFangDa)o).Obj_Img;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Obj_Img_0(ref object o, object v)
        {
            ((global::UISizeFangDa)o).Obj_Img = (UnityEngine.GameObject)v;
        }

        static StackObject* AssignFromStack_Obj_Img_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.GameObject @Obj_Img = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((global::UISizeFangDa)o).Obj_Img = @Obj_Img;
            return ptr_of_this_method;
        }



    }
}
