using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using com.mob.mobpush;

public class MobPushDemo : MonoBehaviour
{

	public GUISkin demoSkin;
	public MobPush mobPush;

	void Start()
	{
		mobPush = gameObject.GetComponent<MobPush>();
		mobPush.onNotifyCallback = OnNitifyHandler;
		mobPush.onTagsCallback = OnTagsHandler;
		mobPush.onAliasCallback = OnAliasHandler;
		mobPush.onDemoReqCallback = OnDemoReqHandler;
		mobPush.onRegIdCallback = OnRegIdHandler;
		mobPush.onBindPhoneNumCallback = OnBindPhoneNumHandler;
		mobPush.onPrivacyPolicyCallback = OnPrivacyPolicyHandler;

		// IPHONE 要想收到 APNs 和本地通知，必须先要 setCustom (only ios)
#if UNITY_IPHONE
			//isPro 参数：推送环境，上线/生产环境为 true，开发环境为/真机调试 false，默认为 false
			//接口要在 Start 中调用
			mobPush.setAPNsForProduction(false);

			//设置推送
			CustomNotifyStyle style = new CustomNotifyStyle ();
		    style.setType(CustomNotifyStyle.TYPE_BADGE | CustomNotifyStyle.TYPE_SOUND | CustomNotifyStyle.TYPE_ALERT);
			// 设置推送的角标，声音，横幅
			Debug.Log("=======TYPE OR:" + (CustomNotifyStyle.TYPE_BADGE | CustomNotifyStyle.TYPE_SOUND | CustomNotifyStyle.TYPE_ALERT));
			mobPush.setCustomNotification(style);
#endif
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Application.Quit();
		}
	}

	void OnGUI()
	{
	}

	void OnGUI_1111()
	{
		GUI.skin = demoSkin;

		float scale = 1.0f;

		if (Application.platform == RuntimePlatform.IPhonePlayer)
		{
			scale = Screen.width / 320;
		}

		//float btnWidth = 165 * scale;
		float btnWidth = Screen.width / 5 * 2;
		float btnHeight = Screen.height / 25;
		float btnTop = 30 * scale;
		float btnGap = 20 * scale;
		GUI.skin.button.fontSize = Convert.ToInt32(13 * scale);

		if (GUI.Button(new Rect((Screen.width - btnGap) / 2 - btnWidth, btnTop, btnWidth, btnHeight), "Send Notify"))
		{
			Hashtable extras = new Hashtable();
			extras.Add("key1", "value1");
			extras.Add("key2", "value2");
			extras.Add("key3", "value3");
			mobPush.req(1, "content-Send Notify", 0, extras);
		}

		if (GUI.Button(new Rect((Screen.width - btnGap) / 2 + btnGap, btnTop, btnWidth, btnHeight), "Send App Notify"))
		{
			mobPush.req(2, "App Notify", 0, null);
		}

		btnTop += btnHeight + 20 * scale;
		if (GUI.Button(new Rect((Screen.width - btnGap) / 2 - btnWidth, btnTop, btnWidth, btnHeight), "Send Delayed Notify"))
		{
			mobPush.req(3, "Delayed Notify", 1, null);
		}

		if (GUI.Button(new Rect((Screen.width - btnGap) / 2 + btnGap, btnTop, btnWidth, btnHeight), "Send Locat Notify"))
		{
			LocalNotifyStyle style = new LocalNotifyStyle();
			style.setContent("Text");
			style.setTitle("title");
			Hashtable extras = new Hashtable();
			extras["key1"] = "value1";
			extras["key2"] = "value1";
			style.setExtras(extras);
			mobPush.setMobPushLocalNotification(style);
		}

		btnTop += btnHeight + 20 * scale;
		if (GUI.Button(new Rect((Screen.width - btnGap) / 2 - btnWidth, btnTop, btnWidth, btnHeight), "CustomNotify"))
		{
			CustomNotifyStyle style = new CustomNotifyStyle();

#if UNITY_IPHONE

			style.setType(CustomNotifyStyle.TYPE_BADGE | CustomNotifyStyle.TYPE_SOUND | CustomNotifyStyle.TYPE_ALERT);

#elif UNITY_ANDROID

			style.setContent("Content");
			style.setTitle("Title");
			style.setTickerText("TickerText");

#endif

			mobPush.setCustomNotification(style);
		}

		if (GUI.Button(new Rect((Screen.width - btnGap) / 2 + btnGap, btnTop, btnWidth, btnHeight), "getRegistrationId"))
		{
			mobPush.getRegistrationId();
		}

		//Test Code
		btnTop += btnHeight + 20 * scale;
		if (GUI.Button(new Rect((Screen.width - btnGap) / 2 - btnWidth, btnTop, btnWidth, btnHeight), "addTags"))
		{
			String[] tags = { "tags1", "tags2", "tags3" };
			mobPush.addTags(tags);
		}

		if (GUI.Button(new Rect((Screen.width - btnGap) / 2 + btnGap, btnTop, btnWidth, btnHeight), "getTags"))
		{
			mobPush.getTags();
		}


		btnTop += btnHeight + 20 * scale;
		if (GUI.Button(new Rect((Screen.width - btnGap) / 2 - btnWidth, btnTop, btnWidth, btnHeight), "deleteTags"))
		{
			String[] tags = { "tags1", "tags2", "tags3" };
			mobPush.deleteTags(tags);
		}

		if (GUI.Button(new Rect((Screen.width - btnGap) / 2 + btnGap, btnTop, btnWidth, btnHeight), "cleanAllTags"))
		{
			mobPush.cleanAllTags();
		}


		btnTop += btnHeight + 20 * scale;
		if (GUI.Button(new Rect((Screen.width - btnGap) / 2 - btnWidth, btnTop, btnWidth, btnHeight), "addAlias"))
		{
			mobPush.addAlias("alias");
		}

		if (GUI.Button(new Rect((Screen.width - btnGap) / 2 + btnGap, btnTop, btnWidth, btnHeight), "getAlias"))
		{
			mobPush.getAlias();
		}


		btnTop += btnHeight + 20 * scale;
		if (GUI.Button(new Rect((Screen.width - btnGap) / 2 - btnWidth, btnTop, btnWidth, btnHeight), "cleanAllAlias"))
		{
			mobPush.cleanAllAlias();
		}

		if (GUI.Button(new Rect((Screen.width - btnGap) / 2 + btnGap, btnTop, btnWidth, btnHeight), "bindPhoneNum"))
		{
			mobPush.bindPhoneNum("12345678988");
		}

		btnTop += btnHeight + 20 * scale;
		if (GUI.Button(new Rect((Screen.width - btnGap) / 2 - btnWidth, btnTop, btnWidth, btnHeight), "查询隐私协议(URL)"))
		{
			mobPush.getPrivacyPolicy("1", "");
		}

		if (GUI.Button(new Rect((Screen.width - btnGap) / 2 + btnGap, btnTop, btnWidth, btnHeight), "查询隐私协议(富文本)"))
		{
			mobPush.getPrivacyPolicy("2", "");
		}

		btnTop += btnHeight + 20 * scale;
		if (GUI.Button(new Rect((Screen.width - btnGap) / 2 - btnWidth, btnTop, btnWidth, btnHeight), "上报隐私授权"))
		{
			mobPush.updatePrivacyPermissionStatus(true);
		}

#if UNITY_ANDROID

		btnTop += btnHeight + 20 * scale;
		if (GUI.Button(new Rect((Screen.width - btnGap) / 2 - btnWidth, btnTop, btnWidth, btnHeight), "stopPush"))
		{
			mobPush.stopPush();
		}


		if (GUI.Button(new Rect((Screen.width - btnGap) / 2 + btnGap, btnTop, btnWidth, btnHeight), "restartPush"))
		{
			mobPush.restartPush();
		}
		btnTop += btnHeight + 20 * scale;
		if (GUI.Button(new Rect((Screen.width - btnGap) / 2 - btnWidth, btnTop, btnWidth, btnHeight), "isPushStop"))
		{
			mobPush.isPushStopped();
		}

		if (GUI.Button(new Rect((Screen.width - btnGap) / 2 + btnGap, btnTop, btnWidth, btnHeight), "setClickNotificationToLaunchPage"))
		{
			mobPush.setClickNotificationToLaunchPage(false);
		}


		btnTop += btnHeight + 20 * scale;
		if (GUI.Button(new Rect((Screen.width - btnGap) / 2 - btnWidth, btnTop, btnWidth, btnHeight), "setShowBadge"))
		{
			mobPush.setShowBadge(true);
		}

#endif
	}

	/// <summary>
	/// 设置推送可在任何地方设置，但是想要收到推送之前，必须要设置。回调配置
	/// mobPush.onNotifyCallback = OnNitifyHandler;
	/// </summary>
	/// <param name="action"></param>
	/// <param name="resulte"></param>
	void OnNitifyHandler(int action, Hashtable resulte)
	{
		Debug.Log("MobPush_OnNitifyHandler");
		if (action == ResponseState.CoutomMessage)
		{
			// 自定义消息
			Debug.Log("MobPush_CoutomMessage:" + MiniJSON.jsonEncode(resulte));
		}
		else if (action == ResponseState.MessageRecvice)
		{
			// 收到消息
			Debug.Log("MobPush_MessageRecvice:" + MiniJSON.jsonEncode(resulte));
		}
		else if (action == ResponseState.MessageOpened)
		{
			// 点击通知
			Debug.Log("MobPush_MessageOpened:" + MiniJSON.jsonEncode(resulte));
		}
	}

	/// <summary>
	/// mobPush.onTagsCallback = OnTagsHandler; 设置标签 回调
	/// action = 3 开发者可以忽略  tag 数组
	/// operation：0 获取，1 设置，2 删除，3 清空
	/// 错误码，errorCode = 0 成功，其余失败
	/// </summary>
	/// <param name="action"></param>
	/// <param name="tags"></param>
	/// <param name="operation"></param>
	/// <param name="errorCode"></param>
	void OnTagsHandler(int action, string[] tags, int operation, int errorCode)
	{
		Debug.Log("MobPush_OnTagsHandler  action:" + action + " tags:" + String.Join(",", tags) + " operation:" + operation + "errorCode:" + errorCode);
	}

	/// <summary>
	/// 获取别名  回调
	/// mobPush.onAliasCallback = OnAliasHandler;
	/// </summary>
	/// <param name="action">action = 4 开发者可以忽略</param>
	/// <param name="alias">别名</param>
	/// <param name="operation">0 获取，1 设置，2 删除</param>
	/// <param name="errorCode">errorCode = 0 成功，其余失败</param>
	void OnAliasHandler(int action, string alias, int operation, int errorCode)
	{
		Debug.Log("MobPush_OnAliasHandler action:" + action + " alias:" + alias + " operation:" + operation + "errorCode:" + errorCode);
	}

	/// <summary>
	///  获取 regId getRegistrationId 回调
	///  mobPush.onRegIdCallback = OnRegIdHandler;
	/// </summary>
	/// <param name="regId"></param>
	void OnRegIdHandler(string regId)
	{
		Debug.Log("MobPush_OnRegIdHandler-regId:" + regId);
	}

	void OnBindPhoneNumHandler(bool isSuccess)
	{
		Debug.Log("MobPush_OnBindPhoneNumHandler-result:" + isSuccess);
	}

	void OnPrivacyPolicyHandler(string content, int errorCode)
	{
		Debug.Log("MobPush_OnPrivacyPolicyHandler  content:" + content + " errorCode:" + errorCode);
	}

	void OnDemoReqHandler(bool isSuccess)
	{
		Debug.Log("MobPush_OnDemoReqHandler:" + isSuccess);
	}
}
