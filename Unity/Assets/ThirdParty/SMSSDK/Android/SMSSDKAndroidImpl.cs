using System;
using UnityEngine;


       namespace cn.SMSSDK.Unity
       {
           #if UNITY_ANDROID
           public class SMSSDKAndroidImpl: ISMSSDK
           {   
               private AndroidJavaObject sdk;

               /// <summary>
               /// 默认初始化方法，用来传递Gameobject
               /// <summary>
               /// <param name="go">游戏对象</param>
               public SMSSDKAndroidImpl (GameObject go)
               {
                   try{
                       sdk = new AndroidJavaObject("cn.smssdk.unity3d.SMSSDKUtils", go.name, "_callBack");
           		} catch(Exception e) {
           			Console.WriteLine("{0} Exception caught.", e);
           		}
               }

               
        ///<summary>
        /// SDK版本号
        ///</summary>
        ///
        ///<returns>void</returns>
        public override void getVersion () {
            if (sdk != null) {
                sdk.Call ("getVersion");
            }
        }
    
        ///<summary>
        /// 获取区号
        ///</summary>
        ///
        ///<returns>void</returns>
        public override void getSupportedCountryCode () {
            if (sdk != null) {
                sdk.Call ("getSupportedCountryCode");
            }
        }
    
        ///<summary>
        /// 请求本机号码认证Token
        ///</summary>
        ///
        ///<returns>void</returns>
        public override void getMobileAuthToken () {
            if (sdk != null) {
                sdk.Call ("getMobileAuthToken");
            }
        }
    
        ///<summary>
        /// 验证手机号
        ///</summary>
        ///<param name=phoneNUmber>待验证手机号</param>
		///<param name=model>号码认证Token</param>
        ///<returns>void</returns>
        public override void verifyMobileWithPhone (string phoneNumber) {
            if (sdk != null) {
                sdk.Call ("verifyMobileWithPhone" ,phoneNumber);
            }
        }
    
        ///<summary>
        /// 获取验证码
        ///</summary>
        ///<param name=method>获取验证码的方法</param>
		///<param name=phoneNumber>电话号码</param>
		///<param name=zone>区域号</param>
		///<param name=tmpCode>模板id</param>
        ///<returns>void</returns>
        public override void getCode (CodeType method, string phoneNumber, string zone, string tmpCode) {
            if (sdk != null) {
                sdk.Call ("getCode" ,Convert.ToInt32(method), phoneNumber, zone, tmpCode);
            }
        }
    
        ///<summary>
        /// 提交验证码
        ///</summary>
        ///<param name=code>验证码</param>
		///<param name=phoneNumber>电话号码</param>
		///<param name=zone>区域号</param>
        ///<returns>void</returns>
        public override void commitCode (string phoneNumber, string zone, string code) {
            if (sdk != null) {
                sdk.Call ("commitCode" ,phoneNumber, zone, code);
            }
        }
    
        ///<summary>
        /// 上传隐私协议状态
        ///</summary>
        ///<param name=isAgree>是否同意隐私协议 布尔类型</param>
        ///<returns>void</returns>
        public override void submitPolicyGrantResult (bool isAgree) {
            if (sdk != null) {
                sdk.Call ("submitPolicyGrantResult" ,isAgree);
            }
        }
    
           }
       #endif
   }
   