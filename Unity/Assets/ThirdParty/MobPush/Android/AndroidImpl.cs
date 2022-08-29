using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.mob.mobpush
{
#if UNITY_ANDROID
	public class AndroidImpl : MobPushImpl {
		private AndroidJavaObject javaObj;

		public AndroidImpl (GameObject go) {
			Debug.Log("AndroidImpl  ===>>>  AndroidImpl" );
			try{
				javaObj = new AndroidJavaObject("com.mob.unity3d.MobPushUtils", go.name, "_MobPushCallback", "_MobPushDemoCallback", "_MobPushRegIdCallback", "_MobPushBindPhoneNumCallback");
			} catch(Exception e) {
				Console.WriteLine("{0} Exception caught.", e);
			}
		}

		public override void initPushSDK (string appKey, string appScrect){
			Debug.Log("AndroidImpl  ===>>>  InitPushSDK === appKey:" + appKey + "   AppSecrect:" + appScrect);
			if(javaObj != null){
				javaObj.Call ("initPushSDK", appKey, appScrect);
			}
		}

		//推送监听接口
		//添加推送监听，可监听接收到的自定义消息(透传消息)、通知消息、通知栏点击事件、别名和标签变更操作。
		public override void addPushReceiver (){
			Debug.Log("AndroidImpl  ===>>>  addPushReceiver === ");
			if(javaObj != null){
				javaObj.Call ("addPushReceiver");
			}
		}

		//停止推送服务
		public override void stopPush (){
			Debug.Log("AndroidImpl  ===>>>  stopPush === ");
			if(javaObj != null){
				javaObj.Call ("stopPush");
			}
		}

		//重启推送服务
		public override void restartPush (){
			Debug.Log("AndroidImpl  ===>>>  restartPush === ");
			if(javaObj != null){
				javaObj.Call ("restartPush");
			}
		}

		//推送服务是否开启
		public override bool isPushStopped (){
			Debug.Log("AndroidImpl  ===>>>  isPushStopped === ");
			if(javaObj != null){
				return javaObj.Call <bool>("isPushStopped");
			}
			return false;
		}

		//点击通知是否启动主页
		public override void setClickNotificationToLaunchPage (bool isOpen){
			Debug.Log("AndroidImpl  ===>>>  setClickNotificationToLaunchPage === ");
			if(javaObj != null){
				javaObj.Call ("setClickNotificationToLaunchMainActivity", isOpen);
			}
		}

		//获取注册Id (getRegistrationId)
		//描述：获取注册id。RegistrationId是MobPush针对不同用户生成的唯一标识符，可通过RegistrationId向用户推送消息。
		public override void getRegistrationId (){
			Debug.Log("AndroidImpl  ===>>>  getRegistrationId === ");
			if(javaObj != null){
				javaObj.Call ("getRegistrationId");
			}
		}

		//添加标签 (addTags)
		public override void addTags (string[] tags){
			Debug.Log("AndroidImpl  ===>>>  addTags === ");
			if(javaObj != null){
				string stringTags = String.Join (",", tags);
				javaObj.Call ("addTags", stringTags);
			}
		}

		//获取标签 
		public override void getTags (){
			Debug.Log("AndroidImpl  ===>>>  getTags === ");
			if(javaObj != null){
				javaObj.Call ("getTags");
			}
		}

		//删除标签 
		public override void deleteTags (string[] tags){
			Debug.Log("AndroidImpl  ===>>>  deleteTags === ");
			if(javaObj != null){
				string stringTags = String.Join (",", tags);
				javaObj.Call ("deleteTags", stringTags);
			}
		}

		public override void cleanAllTags (){
			Debug.Log("AndroidImpl  ===>>>  cleanAllTags === ");
			if(javaObj != null){
				javaObj.Call ("cleanAllTags");
			}
		}

		//设置别名 (setAlias)
		//描述：设置别名。别名是唯一的，与RegistrationId为一对一关系。如多次调用，会以最后一次设置为准，进行覆盖；
		//是否设置成功，会在addPushReceiver()->MobPushReceiver-> onAliasCallback(Context context, String alias, int operation, int errorCode)中进行回调返回。当operation为0时，表示获取别名操作；当operation为1时，表示设置别名操作；当operation为2时，表示删除别名操作。当errorCode为0时，表示操作成功；当errorCode非0时，表示操作失败。
		//别名支持：字母（区分大小写）、数字、下划线、汉字、特殊字符@!#$&*+=.|。
		public override void addAlias (string alias){
			Debug.Log("AndroidImpl  ===>>>  addAlias === ");
			if(javaObj != null){
				javaObj.Call ("setAlias", alias);
			}
		}


		//描述：获取别名。
		//是否获取成功，会在addPushReceiver()->MobPushReceiver-> onAliasCallback(Context context, String alias, int operation, int errorCode)中进行回调返回。
		//当operation为0时，表示获取别名操作；当operation为1时，表示设置别名操作；当operation为2时，表示删除别名操作。当errorCode为0时，表示操作成功；当errorCode非0时，表示操作失败。
		public override void getAlias (){
			Debug.Log("AndroidImpl  ===>>>  getAlias === ");
			if(javaObj != null){
				javaObj.Call ("getAlias");
			}
		}

		public override void cleanAllAlias (){
			Debug.Log("AndroidImpl  ===>>>  cleanAllAlias === ");
			if(javaObj != null){
				javaObj.Call ("cleanAllAlias");
			}
		}

		public override void setMobPushLocalNotification (LocalNotifyStyle style){
			String reqJson = style.getStyleParamsStr ();
			Debug.Log("AndroidImpl  ===>>>  setMobPushLocalNotification === " + reqJson);
			if(javaObj != null){
				javaObj.Call ("setMobPushLocalNotification", reqJson);
			}
		}

		public override void setCustomNotification (CustomNotifyStyle style){
			String reqJson = style.getStyleParamsStr ();
			Debug.Log("AndroidImpl  ===>>>  setCustomNotification === " + reqJson);
			if(javaObj != null){
				javaObj.Call ("setCustomNotification", reqJson);
			}
		}

		//设置通知图标 
		public override void setNotifyIcon (string resIcon){
			Debug.Log("AndroidImpl  ===>>>  setNotifyIcon === ");
			if(javaObj != null){
				javaObj.Call ("setNotifyIcon", resIcon);
			}
		}

        public override void setAppForegroundHiddenNotification (bool hidden){
			Debug.Log("AndroidImpl  ===>>>  setAppForegroundHiddenNotification === ");
			if(javaObj != null){
				javaObj.Call ("setAppForegroundHiddenNotification", hidden);
			}
		}

        public override void bindPhoneNum (string phoneNum){
			Debug.Log("AndroidImpl  ===>>>  bindPhoneNum === "+phoneNum);
			if(javaObj != null){
				javaObj.Call ("bindPhoneNum", phoneNum);
			}
		}

		//设置是否显示角标
		public override void setShowBadge (bool show){
			Debug.Log("AndroidImpl  ===>>>  setShowBadge === "+show);
			if(javaObj != null){
				javaObj.Call ("setShowBadge", show);
			}
		}

		public override void req (int type, string content, int space, string extras){
			Debug.Log("AndroidImpl  ===>>>  req === ");
			if(javaObj != null){
				javaObj.Call ("req", type, content, space, extras);
			}
		}

        public override void updatePrivacyPermissionStatus (bool agree){
			Debug.Log("AndroidImpl  ===>>>  updatePrivacyPermissionStatus  ==="+agree);
			if(javaObj != null){
				javaObj.Call ("updatePrivacyPermissionStatus", agree);
			}
		}


      public override void deleteLocalNotification(string[] ids){
			Debug.Log("AndroidImpl  ===>>>  deleteLocalNotification === ");
			if(javaObj != null){
                string stringIds = String.Join (",", ids);
				javaObj.Call ("deleteLocalNotification",stringIds);
			}
		}
	}
#endif
}