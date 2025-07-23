using System;
using UnityEngine;

namespace Douyin.Game
{
    public static class AndroidUnityBridge
    {
        private static readonly AndroidJavaObject GBUnityBridge =
            new AndroidJavaObject("com.bytedance.ttgame.tob.common.host.api.GBUnityBridge");

        private static readonly string CallMethodName = "callServiceMethod";

        private static IntPtr _bridgeRawClass;
        
        private static IntPtr _callMethodId;

        private static bool _isInit;

        private static void InitBridge()
        {
            try
            {
                var unityCallSignature = AndroidJNIHelper.GetSignature<AndroidJavaObject>(new object[]
                    { "", "", new AndroidJavaObject[1] });
                _bridgeRawClass = GBUnityBridge.GetRawClass();
                _callMethodId = AndroidJNIHelper.GetMethodID(_bridgeRawClass, CallMethodName, unityCallSignature, true);
                //Debug.Log("get method " + _callMethodId);

                _isInit = true;
            }
            catch (Exception e)
            {
                Debug.LogError(e);
                throw;
            }
        }

        public static AndroidJavaObject CallServiceMethod(string className, string methodName,  params AndroidJavaObject[] args)
        {
            try
            {
                if (args == null)
                {
                    args = new AndroidJavaObject[] { };
                }
                return GBUnityBridge.CallStatic<AndroidJavaObject>(CallMethodName,
                    className,
                    methodName, args);
            }
            catch (Exception e)
            {
                Debug.LogError(e);
                throw;
            }
        }
        
        public static IntPtr CallServiceMethodEx(string className, string methodName, params object[] args)
        {
            if (args == null || args.Length == 0)
            {
                Debug.LogError("Unsupport argment is Null");
                return IntPtr.Zero;
            }
            IntPtr[] intPtrs = new IntPtr[args.Length];
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] == null)
                {
                    intPtrs[i] = IntPtr.Zero;
                    continue;
                }
                Type type = args[i].GetType();
                var argAndroidJavaObject = CreateAndroidJavaObject(type, args[i]);
                if (argAndroidJavaObject != null)
                {
                    intPtrs[i] = argAndroidJavaObject.GetRawObject();
                }
                else
                {
                    switch (args[i])
                    {
                        case AndroidJavaObject androidJavaObject:
                            intPtrs[i] = androidJavaObject.GetRawObject();
                            break;
                        case AndroidJavaProxy androidJavaProxy:
                            intPtrs[i] = AndroidJNIHelper.CreateJavaProxy(androidJavaProxy);
                            break;
                        default:
                            Debug.LogError("Unsupported argument: " + args[i]);
                            break;
                    }
                }
            }
            var argIntPtr = CreateArgArrayIntPtr(intPtrs);
            return CallServiceMethodInternal(className, methodName, argIntPtr);
        }

        public static TReturnType GetReturn<TReturnType>(AndroidJavaObject androidJavaObject)
        {
            if (androidJavaObject == null)
            {
                Debug.LogError("Return AndroidJavaObject Is Null");
                return default(TReturnType);
            }
            try
            {
                if (typeof(TReturnType) == typeof(string))
                {
                    return androidJavaObject.Call<TReturnType>("toString");
                }
                if (typeof(TReturnType) == typeof(bool))
                {
                    return androidJavaObject.Call<TReturnType>("booleanValue");
                }
                if (typeof(TReturnType) == typeof(long))
                {
                    return androidJavaObject.Call<TReturnType>("longValue");
                }
                if (typeof(TReturnType) == typeof(int))
                {
                    return androidJavaObject.Call<TReturnType>("intValue");
                }
                if (typeof(TReturnType) == typeof(char))
                {
                    return androidJavaObject.Call<TReturnType>("charValue");
                }
                if (typeof(TReturnType) == typeof(short))
                {
                    return androidJavaObject.Call<TReturnType>("shortValue");
                }
                if (typeof(TReturnType) == typeof(float))
                {
                    return androidJavaObject.Call<TReturnType>("floatValue");
                }
                if (typeof(TReturnType) == typeof(double))
                {
                    return androidJavaObject.Call<TReturnType>("doubleValue");
                }
                if (typeof(TReturnType) == typeof(byte))
                {
                    return androidJavaObject.Call<TReturnType>("byteValue");
                }
                
                Debug.LogError("Not Support Return Type");
                return default(TReturnType);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        public static TReturnType GetReturnEx<TReturnType>(IntPtr intPtr)
        {
            if (intPtr == IntPtr.Zero)
            {
                Debug.LogError("Return IntPtr Is Zero");
                return default(TReturnType);
            }
            try
            {
                var androidJavaObject = CreateAndroidJavaObject(typeof(TReturnType), intPtr);
                return GetReturn<TReturnType>(androidJavaObject);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        private static jvalue[] CreateJNIArgArray(jvalue[] jniArgArray, string className, string methodName, IntPtr arg)
        {
            try
            {
                jniArgArray[0].l = AndroidJNISafe.NewStringUTF(className);
                jniArgArray[1].l = AndroidJNISafe.NewStringUTF(methodName);
                jniArgArray[2].l = arg;
                return jniArgArray;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }

        private static IntPtr CreateArgArrayIntPtr(params IntPtr[] arg)
        {
            try
            {
                IntPtr[] array = new IntPtr[arg.Length];
                for (int i = 0; i < arg.Length; i++)
                {
                    array[i] = arg[i];
                }
                IntPtr argArray = AndroidJNISafe.ToObjectArray(array, AndroidJNISafe.FindClass("java/lang/Object"));

                return argArray;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }

        private static IntPtr CallServiceMethodInternal(string className, string methodName, IntPtr args)
        {
            if (!_isInit)
            {
                InitBridge();
            }
            jvalue[] jniArgArray = new jvalue[3];
            jniArgArray = CreateJNIArgArray(jniArgArray, className, methodName, args);
            try
            {
                IntPtr jobject = AndroidJNISafe.CallStaticObjectMethod(_bridgeRawClass, _callMethodId, jniArgArray);
                return jobject;
            }
            catch (Exception e)
            {
                Debug.LogError(e);
                throw;
            }
            finally
            {
                /* 源码 只有Array需要DeleteLocalRef
                 public static void DeleteJNIArgArray(object[] args, jvalue[] jniArgs)
                   {
                     int index = 0;
                     foreach (object obj in args)
                     {
                       int num;
                       switch (obj)
                       {
                         case string _:
                         case AndroidJavaRunnable _:
                         case AndroidJavaProxy _:
                           num = 1;
                           break;
                         default:
                           num = obj is Array ? 1 : 0;
                           break;
                       }
                       if (num != 0)
                         AndroidJNISafe.DeleteLocalRef(jniArgs[index].l);
                       ++index;
                     }
                     */
                AndroidJNISafe.DeleteLocalRef(jniArgArray[2].l);
            }
        }

        private static AndroidJavaObject CreateAndroidJavaObject(Type type, object value)
        {
            switch (Type.GetTypeCode(type))
            {
                case TypeCode.String:
                    return new AndroidJavaObject("java.lang.String", value);
                case TypeCode.Int32:
                    return new AndroidJavaObject("java.lang.Integer", value);
                case TypeCode.Boolean:
                    return new AndroidJavaObject("java.lang.Boolean", value);
                case TypeCode.Int64:
                    return new AndroidJavaObject("java.lang.Long", value);
                case TypeCode.Char:
                    return new AndroidJavaObject("java.lang.Character", value);
                case TypeCode.Int16:
                    return new AndroidJavaObject("java.lang.Short", value);
                case TypeCode.Single:
                    return new AndroidJavaObject("java.lang.Float", value);
                case TypeCode.Double:
                    return new AndroidJavaObject("java.lang.Double", value);
                case TypeCode.Byte:
                    return new AndroidJavaObject("java.lang.Byte", value);
            }
            return null;
        }
    }
}