using System;
using UnityEngine;

namespace Douyin.Game
{
    public static class ReflectionInvoke
    {
        public static void Invoke(string typeName, string getPropertyName, string invokeMethodName,
            object[] parameters = null)
        {
            try
            {
                var type = Type.GetType(typeName);
                var instanceProperty = type?.BaseType?.GetProperty(getPropertyName);
                if (instanceProperty == null)
                {
                    instanceProperty = type?.GetProperty(getPropertyName);
                }

                var instance = instanceProperty?.GetValue(null);
                var methodInfo = type?.GetMethod(invokeMethodName);
                methodInfo?.Invoke(instance, parameters);
            }
            catch (Exception e)
            {
                Debug.LogError(e);
            }
        }
        
        public static object InvokeStaticMethod(string typeName, string invokeMethodName)
        {
            try
            {
                // 获得类型信息
                var type = Type.GetType(typeName);
                // 获得方法信息
                var methodInfo = type?.GetMethod(invokeMethodName);
                // 调用静态方法
                var obj = methodInfo?.Invoke(null, null);
                return obj;
            }
            catch (Exception e)
            {
                Debug.LogError(e);
            }
            return null;
        }
    }
}