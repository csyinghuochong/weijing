
using System;
using UnityEngine;

namespace Douyin.Game
{
  internal class AndroidJNISafe
  {
    public class AndroidJavaException : Exception
    {
      private string mJavaStackTrace;

      internal AndroidJavaException(string message, string javaStackTrace)
        : base(message)
      {
        this.mJavaStackTrace = javaStackTrace;
      }

      public override string StackTrace => this.mJavaStackTrace + base.StackTrace;
    }
    public static void CheckException()
    {
      IntPtr localref = AndroidJNI.ExceptionOccurred();
      if (!(localref != IntPtr.Zero))
        return;
      AndroidJNI.ExceptionClear();
      IntPtr num1 = AndroidJNI.FindClass("java/lang/Throwable");
      IntPtr num2 = AndroidJNI.FindClass("android/util/Log");
      try
      {
        IntPtr methodId = AndroidJNI.GetMethodID(num1, "toString", "()Ljava/lang/String;");
        IntPtr staticMethodId = AndroidJNI.GetStaticMethodID(num2, "getStackTraceString", "(Ljava/lang/Throwable;)Ljava/lang/String;");
        string message = AndroidJNI.CallStringMethod(localref, methodId, new jvalue[0]);
        jvalue[] args = new jvalue[1];
        args[0].l = localref;
        string javaStackTrace = AndroidJNI.CallStaticStringMethod(num2, staticMethodId, args);
        throw new AndroidJavaException(message, javaStackTrace);
      }
      finally
      {
        AndroidJNISafe.DeleteLocalRef(localref);
        AndroidJNISafe.DeleteLocalRef(num1);
        AndroidJNISafe.DeleteLocalRef(num2);
      }
    }

    public static void DeleteGlobalRef(IntPtr globalref)
    {
      if (!(globalref != IntPtr.Zero))
        return;
      AndroidJNI.DeleteGlobalRef(globalref);
    }

    public static void DeleteLocalRef(IntPtr localref)
    {
      if (!(localref != IntPtr.Zero))
        return;
      AndroidJNI.DeleteLocalRef(localref);
    }

    public static IntPtr NewString(string chars)
    {
      try
      {
        return AndroidJNI.NewStringUTF(chars);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static IntPtr NewStringUTF(string bytes)
    {
      try
      {
        return AndroidJNI.NewStringUTF(bytes);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static string GetStringChars(IntPtr str)
    {
      try
      {
        return AndroidJNI.GetStringUTFChars(str);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static string GetStringUTFChars(IntPtr str)
    {
      try
      {
        return AndroidJNI.GetStringUTFChars(str);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static IntPtr GetObjectClass(IntPtr ptr)
    {
      try
      {
        return AndroidJNI.GetObjectClass(ptr);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig)
    {
      try
      {
        return AndroidJNI.GetStaticMethodID(clazz, name, sig);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static IntPtr GetMethodID(IntPtr obj, string name, string sig)
    {
      try
      {
        return AndroidJNI.GetMethodID(obj, name, sig);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static IntPtr GetFieldID(IntPtr clazz, string name, string sig)
    {
      try
      {
        return AndroidJNI.GetFieldID(clazz, name, sig);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static IntPtr GetStaticFieldID(IntPtr clazz, string name, string sig)
    {
      try
      {
        return AndroidJNI.GetStaticFieldID(clazz, name, sig);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static IntPtr FromReflectedMethod(IntPtr refMethod)
    {
      try
      {
        return AndroidJNI.FromReflectedMethod(refMethod);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static IntPtr FromReflectedField(IntPtr refField)
    {
      try
      {
        return AndroidJNI.FromReflectedField(refField);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static IntPtr FindClass(string name)
    {
      try
      {
        return AndroidJNI.FindClass(name);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, jvalue[] args)
    {
      try
      {
        return AndroidJNI.NewObject(clazz, methodID, args);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static void SetStaticObjectField(IntPtr clazz, IntPtr fieldID, IntPtr val)
    {
      try
      {
        AndroidJNI.SetStaticObjectField(clazz, fieldID, val);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static void SetStaticStringField(IntPtr clazz, IntPtr fieldID, string val)
    {
      try
      {
        AndroidJNI.SetStaticStringField(clazz, fieldID, val);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static void SetStaticCharField(IntPtr clazz, IntPtr fieldID, char val)
    {
      try
      {
        AndroidJNI.SetStaticCharField(clazz, fieldID, val);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static void SetStaticDoubleField(IntPtr clazz, IntPtr fieldID, double val)
    {
      try
      {
        AndroidJNI.SetStaticDoubleField(clazz, fieldID, val);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static void SetStaticFloatField(IntPtr clazz, IntPtr fieldID, float val)
    {
      try
      {
        AndroidJNI.SetStaticFloatField(clazz, fieldID, val);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static void SetStaticLongField(IntPtr clazz, IntPtr fieldID, long val)
    {
      try
      {
        AndroidJNI.SetStaticLongField(clazz, fieldID, val);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static void SetStaticShortField(IntPtr clazz, IntPtr fieldID, short val)
    {
      try
      {
        AndroidJNI.SetStaticShortField(clazz, fieldID, val);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static void SetStaticBooleanField(IntPtr clazz, IntPtr fieldID, bool val)
    {
      try
      {
        AndroidJNI.SetStaticBooleanField(clazz, fieldID, val);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static void SetStaticIntField(IntPtr clazz, IntPtr fieldID, int val)
    {
      try
      {
        AndroidJNI.SetStaticIntField(clazz, fieldID, val);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID)
    {
      try
      {
        return AndroidJNI.GetStaticObjectField(clazz, fieldID);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static string GetStaticStringField(IntPtr clazz, IntPtr fieldID)
    {
      try
      {
        return AndroidJNI.GetStaticStringField(clazz, fieldID);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static char GetStaticCharField(IntPtr clazz, IntPtr fieldID)
    {
      try
      {
        return AndroidJNI.GetStaticCharField(clazz, fieldID);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID)
    {
      try
      {
        return AndroidJNI.GetStaticDoubleField(clazz, fieldID);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static float GetStaticFloatField(IntPtr clazz, IntPtr fieldID)
    {
      try
      {
        return AndroidJNI.GetStaticFloatField(clazz, fieldID);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static long GetStaticLongField(IntPtr clazz, IntPtr fieldID)
    {
      try
      {
        return AndroidJNI.GetStaticLongField(clazz, fieldID);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static short GetStaticShortField(IntPtr clazz, IntPtr fieldID)
    {
      try
      {
        return AndroidJNI.GetStaticShortField(clazz, fieldID);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static bool GetStaticBooleanField(IntPtr clazz, IntPtr fieldID)
    {
      try
      {
        return AndroidJNI.GetStaticBooleanField(clazz, fieldID);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static int GetStaticIntField(IntPtr clazz, IntPtr fieldID)
    {
      try
      {
        return AndroidJNI.GetStaticIntField(clazz, fieldID);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
    {
      try
      {
        AndroidJNI.CallStaticVoidMethod(clazz, methodID, args);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
    {
      try
      {
        return AndroidJNI.CallStaticObjectMethod(clazz, methodID, args);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
    {
      try
      {
        return AndroidJNI.CallStaticStringMethod(clazz, methodID, args);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
    {
      try
      {
        return AndroidJNI.CallStaticCharMethod(clazz, methodID, args);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
    {
      try
      {
        return AndroidJNI.CallStaticDoubleMethod(clazz, methodID, args);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
    {
      try
      {
        return AndroidJNI.CallStaticFloatMethod(clazz, methodID, args);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
    {
      try
      {
        return AndroidJNI.CallStaticLongMethod(clazz, methodID, args);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
    {
      try
      {
        return AndroidJNI.CallStaticShortMethod(clazz, methodID, args);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
    {
      try
      {
        return AndroidJNI.CallStaticBooleanMethod(clazz, methodID, args);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
    {
      try
      {
        return AndroidJNI.CallStaticIntMethod(clazz, methodID, args);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static void SetObjectField(IntPtr obj, IntPtr fieldID, IntPtr val)
    {
      try
      {
        AndroidJNI.SetObjectField(obj, fieldID, val);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static void SetStringField(IntPtr obj, IntPtr fieldID, string val)
    {
      try
      {
        AndroidJNI.SetStringField(obj, fieldID, val);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static void SetCharField(IntPtr obj, IntPtr fieldID, char val)
    {
      try
      {
        AndroidJNI.SetCharField(obj, fieldID, val);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static void SetDoubleField(IntPtr obj, IntPtr fieldID, double val)
    {
      try
      {
        AndroidJNI.SetDoubleField(obj, fieldID, val);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static void SetFloatField(IntPtr obj, IntPtr fieldID, float val)
    {
      try
      {
        AndroidJNI.SetFloatField(obj, fieldID, val);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static void SetLongField(IntPtr obj, IntPtr fieldID, long val)
    {
      try
      {
        AndroidJNI.SetLongField(obj, fieldID, val);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static void SetShortField(IntPtr obj, IntPtr fieldID, short val)
    {
      try
      {
        AndroidJNI.SetShortField(obj, fieldID, val);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static void SetBooleanField(IntPtr obj, IntPtr fieldID, bool val)
    {
      try
      {
        AndroidJNI.SetBooleanField(obj, fieldID, val);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static void SetIntField(IntPtr obj, IntPtr fieldID, int val)
    {
      try
      {
        AndroidJNI.SetIntField(obj, fieldID, val);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static IntPtr GetObjectField(IntPtr obj, IntPtr fieldID)
    {
      try
      {
        return AndroidJNI.GetObjectField(obj, fieldID);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static string GetStringField(IntPtr obj, IntPtr fieldID)
    {
      try
      {
        return AndroidJNI.GetStringField(obj, fieldID);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static char GetCharField(IntPtr obj, IntPtr fieldID)
    {
      try
      {
        return AndroidJNI.GetCharField(obj, fieldID);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static double GetDoubleField(IntPtr obj, IntPtr fieldID)
    {
      try
      {
        return AndroidJNI.GetDoubleField(obj, fieldID);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static float GetFloatField(IntPtr obj, IntPtr fieldID)
    {
      try
      {
        return AndroidJNI.GetFloatField(obj, fieldID);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static long GetLongField(IntPtr obj, IntPtr fieldID)
    {
      try
      {
        return AndroidJNI.GetLongField(obj, fieldID);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static short GetShortField(IntPtr obj, IntPtr fieldID)
    {
      try
      {
        return AndroidJNI.GetShortField(obj, fieldID);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }
    

    public static bool GetBooleanField(IntPtr obj, IntPtr fieldID)
    {
      try
      {
        return AndroidJNI.GetBooleanField(obj, fieldID);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static int GetIntField(IntPtr obj, IntPtr fieldID)
    {
      try
      {
        return AndroidJNI.GetIntField(obj, fieldID);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static void CallVoidMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
    {
      try
      {
        AndroidJNI.CallVoidMethod(obj, methodID, args);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
    {
      try
      {
        return AndroidJNI.CallObjectMethod(obj, methodID, args);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
    {
      try
      {
        return AndroidJNI.CallStringMethod(obj, methodID, args);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static char CallCharMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
    {
      try
      {
        return AndroidJNI.CallCharMethod(obj, methodID, args);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
    {
      try
      {
        return AndroidJNI.CallDoubleMethod(obj, methodID, args);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static float CallFloatMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
    {
      try
      {
        return AndroidJNI.CallFloatMethod(obj, methodID, args);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static long CallLongMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
    {
      try
      {
        return AndroidJNI.CallLongMethod(obj, methodID, args);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static short CallShortMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
    {
      try
      {
        return AndroidJNI.CallShortMethod(obj, methodID, args);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
    {
      try
      {
        return AndroidJNI.CallBooleanMethod(obj, methodID, args);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static int CallIntMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
    {
      try
      {
        return AndroidJNI.CallIntMethod(obj, methodID, args);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static IntPtr[] FromObjectArray(IntPtr array)
    {
      try
      {
        return AndroidJNI.FromObjectArray(array);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static char[] FromCharArray(IntPtr array)
    {
      try
      {
        return AndroidJNI.FromCharArray(array);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static double[] FromDoubleArray(IntPtr array)
    {
      try
      {
        return AndroidJNI.FromDoubleArray(array);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static float[] FromFloatArray(IntPtr array)
    {
      try
      {
        return AndroidJNI.FromFloatArray(array);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static long[] FromLongArray(IntPtr array)
    {
      try
      {
        return AndroidJNI.FromLongArray(array);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static short[] FromShortArray(IntPtr array)
    {
      try
      {
        return AndroidJNI.FromShortArray(array);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    // public static byte[] FromByteArray(IntPtr array)//废弃接口减少warning
    // {
    //   try
    //   {
    //     return AndroidJNI.FromByteArray(array);
    //   }
    //   finally
    //   {
    //     AndroidJNISafe.CheckException();
    //   }
    // }

    public static bool[] FromBooleanArray(IntPtr array)
    {
      try
      {
        return AndroidJNI.FromBooleanArray(array);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static int[] FromIntArray(IntPtr array)
    {
      try
      {
        return AndroidJNI.FromIntArray(array);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static IntPtr ToObjectArray(IntPtr[] array)
    {
      try
      {
        return AndroidJNI.ToObjectArray(array);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static IntPtr ToObjectArray(IntPtr[] array, IntPtr type)
    {
      try
      {
        return AndroidJNI.ToObjectArray(array, type);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static IntPtr ToCharArray(char[] array)
    {
      try
      {
        return AndroidJNI.ToCharArray(array);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static IntPtr ToDoubleArray(double[] array)
    {
      try
      {
        return AndroidJNI.ToDoubleArray(array);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static IntPtr ToFloatArray(float[] array)
    {
      try
      {
        return AndroidJNI.ToFloatArray(array);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static IntPtr ToLongArray(long[] array)
    {
      try
      {
        return AndroidJNI.ToLongArray(array);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static IntPtr ToShortArray(short[] array)
    {
      try
      {
        return AndroidJNI.ToShortArray(array);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    // public static IntPtr ToByteArray(byte[] array) //废弃接口减少warning
    // {
    //   try
    //   {
    //     return AndroidJNI.ToByteArray(array);
    //   }
    //   finally
    //   {
    //     AndroidJNISafe.CheckException();
    //   }
    // }

    public static IntPtr ToBooleanArray(bool[] array)
    {
      try
      {
        return AndroidJNI.ToBooleanArray(array);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static IntPtr ToIntArray(int[] array)
    {
      try
      {
        return AndroidJNI.ToIntArray(array);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static IntPtr GetObjectArrayElement(IntPtr array, int index)
    {
      try
      {
        return AndroidJNI.GetObjectArrayElement(array, index);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }

    public static int GetArrayLength(IntPtr array)
    {
      try
      {
        return AndroidJNI.GetArrayLength(array);
      }
      finally
      {
        AndroidJNISafe.CheckException();
      }
    }
  }
}
