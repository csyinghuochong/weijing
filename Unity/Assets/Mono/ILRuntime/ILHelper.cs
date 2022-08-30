using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using ILRuntime.Runtime.Intepreter;
using ProtoBuf;
using UnityEngine;

namespace ET
{
    public static class ILHelper
    {
        public static List<Type> list = new List<Type>();

        public static void InitILRuntime(ILRuntime.Runtime.Enviorment.AppDomain appdomain)
        {
            list.Add(typeof(Dictionary<int, ILTypeInstance>));
            list.Add(typeof(Dictionary<long, ILTypeInstance>));
            list.Add(typeof(Dictionary<string, ILTypeInstance>));
            list.Add(typeof(Dictionary<int, int>));
            list.Add(typeof(Dictionary<object, object>));
            list.Add(typeof(Dictionary<int, object>));
            list.Add(typeof(Dictionary<long, object>));
            list.Add(typeof(Dictionary<long, int>));
            list.Add(typeof(Dictionary<int, long>));
            list.Add(typeof(Dictionary<string, long>));
            list.Add(typeof(Dictionary<string, int>));
            list.Add(typeof(Dictionary<string, object>));
            list.Add(typeof(List<ILTypeInstance>));
            list.Add(typeof(List<int>));
            list.Add(typeof(List<long>));
            list.Add(typeof(List<string>));
            list.Add(typeof(List<object>));
            list.Add(typeof(ETTask<int>));
            list.Add(typeof(ETTask<long>));
            list.Add(typeof(ETTask<string>));
            list.Add(typeof(ETTask<object>));
            list.Add(typeof(ETTask<AssetBundle>));
            list.Add(typeof(ETTask<UnityEngine.Object[]>));
            list.Add(typeof(ListComponent<ILTypeInstance>));
            list.Add(typeof(ListComponent<ETTask>));
            list.Add(typeof(ListComponent<Vector3>));
            
            // 注册重定向函数

            // 注册委托
            appdomain.DelegateManager.RegisterMethodDelegate<List<object>>();
            appdomain.DelegateManager.RegisterMethodDelegate<object>();
            appdomain.DelegateManager.RegisterMethodDelegate<bool>();
            appdomain.DelegateManager.RegisterMethodDelegate<string>();
            appdomain.DelegateManager.RegisterMethodDelegate<float>();
            appdomain.DelegateManager.RegisterMethodDelegate<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.Int32>();
            appdomain.DelegateManager.RegisterMethodDelegate<long, int>();
            appdomain.DelegateManager.RegisterMethodDelegate<long, MemoryStream>();
            appdomain.DelegateManager.RegisterMethodDelegate<long, IPEndPoint>();
            appdomain.DelegateManager.RegisterMethodDelegate<ILTypeInstance>();
            appdomain.DelegateManager.RegisterMethodDelegate<AsyncOperation>();
            appdomain.DelegateManager.RegisterMethodDelegate<libx.AssetRequest>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.Delegate>();
            appdomain.DelegateManager.RegisterMethodDelegate<List<System.Delegate>>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.Action>();
            appdomain.DelegateManager.RegisterMethodDelegate<List<System.Action>>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Vector2>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.EventSystems.BaseEventData>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.GameObject, UnityEngine.EventSystems.PointerEventData>();
            appdomain.DelegateManager.RegisterMethodDelegate<AChannel, System.Net.Sockets.SocketError>();
            appdomain.DelegateManager.RegisterMethodDelegate<byte[], int, int>();
            appdomain.DelegateManager.RegisterMethodDelegate<string, object>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.EventSystems.PointerEventData>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.Type, ILRuntime.Runtime.Intepreter.ILTypeInstance>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.Int64, ILRuntime.Runtime.Intepreter.ILTypeInstance>();
            
            
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Events.UnityAction>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Object, ET.ETTask>();
            appdomain.DelegateManager.RegisterFunctionDelegate<ILTypeInstance, bool>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Collections.Generic.KeyValuePair<System.String, System.Int32>, System.String>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Collections.Generic.KeyValuePair<System.String, System.Int32>, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<List<int>, int>();
            appdomain.DelegateManager.RegisterFunctionDelegate<List<int>, bool>();
            appdomain.DelegateManager.RegisterFunctionDelegate<int, bool>();//Linq
            appdomain.DelegateManager.RegisterFunctionDelegate<int, int, int>();//Linq
            appdomain.DelegateManager.RegisterFunctionDelegate<KeyValuePair<int, List<int>>, bool>();
            appdomain.DelegateManager.RegisterFunctionDelegate<KeyValuePair<int, int>, KeyValuePair<int, int>, int>();
            appdomain.DelegateManager.RegisterFunctionDelegate<ILRuntime.Runtime.Intepreter.ILTypeInstance, ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.Int64, System.Collections.Generic.List<System.Int64>>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.Int64, System.Collections.Generic.List<ILRuntime.Runtime.Intepreter.ILTypeInstance>>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Int64, System.Collections.Generic.List<System.Int64>, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Int64, System.Collections.Generic.List<ILRuntime.Runtime.Intepreter.ILTypeInstance>, System.Boolean>();

            appdomain.DelegateManager.RegisterMethodDelegate<ET.AService>();

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Events.UnityAction>((act) =>
            {
                return new UnityEngine.Events.UnityAction(() =>
                {
                    ((Action)act)();
                });
            });
            
            appdomain.DelegateManager.RegisterDelegateConvertor<Comparison<KeyValuePair<int, int>>>((act) =>
            {
                return new Comparison<KeyValuePair<int, int>>((x, y) =>
                {
                    return ((Func<KeyValuePair<int, int>, KeyValuePair<int, int>, int>)act)(x, y);
                });
            });
            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<ILRuntime.Runtime.Intepreter.ILTypeInstance>>((act) =>
            {
                return new System.Comparison<ILRuntime.Runtime.Intepreter.ILTypeInstance>((x, y) =>
                {
                    return ((Func<ILRuntime.Runtime.Intepreter.ILTypeInstance, ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>)act)(x, y);
                });
            });
            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Events.UnityAction<UnityEngine.Vector2>>((act) =>
            {
                return new UnityEngine.Events.UnityAction<UnityEngine.Vector2>((arg0) =>
                {
                    ((Action<UnityEngine.Vector2>)act)(arg0);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Events.UnityAction<UnityEngine.EventSystems.BaseEventData>>((act) =>
            {
                return new UnityEngine.Events.UnityAction<UnityEngine.EventSystems.BaseEventData>((arg0) =>
                {
                    ((Action<UnityEngine.EventSystems.BaseEventData>)act)(arg0);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Events.UnityAction>((act) =>
            {
                return new UnityEngine.Events.UnityAction(() =>
                {
                    ((Action)act)();
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Events.UnityAction<System.Boolean>>((act) =>
            {
                return new UnityEngine.Events.UnityAction<System.Boolean>((arg0) =>
                {
                    ((Action<System.Boolean>)act)(arg0);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Events.UnityAction<System.Single>>((act) =>
            {
                return new UnityEngine.Events.UnityAction<System.Single>((arg0) =>
                {
                    ((Action<System.Single>)act)(arg0);
                });
            });
            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Events.UnityAction<System.String>>((act) =>
            {
                return new UnityEngine.Events.UnityAction<System.String>((arg0) =>
                {
                    ((Action<System.String>)act)(arg0);
                });
            });
            // 注册适配器
            RegisterAdaptor(appdomain);
            
            //注册Json的CLR
            LitJson.JsonMapper.RegisterILRuntimeCLRRedirection(appdomain);
            //注册ProtoBuf的CLR
            PType.RegisterILRuntimeCLRRedirection(appdomain);
            //PType.RegisterILRuntime(appdomain, typeFullName => CodeLoader.Instance.GetHotfixType(typeFullName));

            ////////////////////////////////////
            // CLR绑定的注册，一定要记得将CLR绑定的注册写在CLR重定向的注册后面，因为同一个方法只能被重定向一次，只有先注册的那个才能生效
            ////////////////////////////////////
            Type t = Type.GetType("ILRuntime.Runtime.Generated.CLRBindings");
            if (t != null)
            {
                t.GetMethod("Initialize")?.Invoke(null, new object[] { appdomain });
            }
            //ILRuntime.Runtime.Generated.CLRBindings.Initialize(appdomain);
        }
        
        public static void RegisterAdaptor(ILRuntime.Runtime.Enviorment.AppDomain appdomain)
        {
            //注册自己写的适配器
            appdomain.RegisterCrossBindingAdaptor(new IAsyncStateMachineClassInheritanceAdaptor());
            appdomain.RegisterValueTypeBinder(typeof(Vector2), new Vector2Binder());
            appdomain.RegisterValueTypeBinder(typeof(Vector3), new Vector3Binder());
            appdomain.RegisterValueTypeBinder(typeof(Quaternion), new QuaternionBinder());
        }
    }
}