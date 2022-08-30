using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;



namespace cn.SMSSDK.Unity
{
    #if UNITY_IPHONE || UNITY_IOS
    public class SMSSDKIOSImpl: ISMSSDK
    {   
        private string _callbackObjectName = "Default ID";
        
        [DllImport("__Internal")]
        private static extern void __iosGetversion (string observer);
        [DllImport("__Internal")]
        private static extern void __iosGetsupportedcountrycode (string observer);
        [DllImport("__Internal")]
        private static extern void __iosGetmobileauthtoken (string observer);
        [DllImport("__Internal")]
        private static extern void __iosVerifymobilewithphone (string phoneNumber, string observer);
        [DllImport("__Internal")]
        private static extern void __iosGetcode (CodeType method, string phoneNumber, string zone, string tmpCode, string observer);
        [DllImport("__Internal")]
        private static extern void __iosCommitcode (string phoneNumber, string zone, string code, string observer);
        [DllImport("__Internal")]
        private static extern void __iosSubmitpolicygrantresult (bool isAgree, string observer);

        /// <summary>
        /// 默认初始化方法，用来传递Gameobject
        /// <summary>
        /// <param name="go">游戏对象</param>
        public SMSSDKIOSImpl (GameObject go)
        {
            try{
    			_callbackObjectName = go.name;
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
            __iosGetversion (_callbackObjectName);
        }
    
        ///<summary>
        /// 获取区号
        ///</summary>
        ///
        ///<returns>void</returns>
        public override void getSupportedCountryCode () {
            __iosGetsupportedcountrycode (_callbackObjectName);
        }
    
        ///<summary>
        /// 请求本机号码认证Token
        ///</summary>
        ///
        ///<returns>void</returns>
        public override void getMobileAuthToken () {
            __iosGetmobileauthtoken (_callbackObjectName);
        }
    
        ///<summary>
        /// 验证手机号
        ///</summary>
        ///<param name=phoneNUmber>待验证手机号</param>
		///<param name=model>号码认证Token</param>
        ///<returns>void</returns>
        public override void verifyMobileWithPhone (string phoneNumber) {
            __iosVerifymobilewithphone (phoneNumber, _callbackObjectName);
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
            __iosGetcode (method, phoneNumber, zone, tmpCode, _callbackObjectName);
        }
    
        ///<summary>
        /// 提交验证码
        ///</summary>
        ///<param name=code>验证码</param>
		///<param name=phoneNumber>电话号码</param>
		///<param name=zone>区域号</param>
        ///<returns>void</returns>
        public override void commitCode (string phoneNumber, string zone, string code) {
            __iosCommitcode (phoneNumber, zone, code, _callbackObjectName);
        }
    
        ///<summary>
        /// 上传隐私协议状态
        ///</summary>
        ///<param name=isAgree>是否同意隐私协议 布尔类型</param>
        ///<returns>void</returns>
        public override void submitPolicyGrantResult (bool isAgree) {
            __iosSubmitpolicygrantresult (isAgree, _callbackObjectName);
        }
    
    }
    #endif
}
    