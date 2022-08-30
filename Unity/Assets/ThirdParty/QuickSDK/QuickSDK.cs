using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System;

namespace quicksdk
{
	public class QuickSDK
	{
		private static QuickSDK _instance;
		
		public static QuickSDK getInstance() {
			if( null == _instance ) {
				_instance = new QuickSDK();
            }
			return _instance;
		}

		public void setListener(QuickSDKListener listener)
		{
			QuickSDKImp.getInstance ().setListener (listener);
        }

		public void reInit()
		{
			QuickSDKImp.getInstance().init();
		}

		public void init()
        {
			QuickSDKImp.getInstance().init();
		}

		public void exit()
        {
			QuickSDKImp.getInstance ().exit();
        }

		public void login ()
		{
			QuickSDKImp.getInstance ().login();
        }
		public void logout ()
		{
			QuickSDKImp.getInstance ().logout();
        }

		public void pay (OrderInfo orderInfo, GameRoleInfo gameRoleInfo)
		{
			QuickSDKImp.getInstance ().pay(orderInfo, gameRoleInfo);
        }
		public string userId()//渠道uid
		{
			return QuickSDKImp.getInstance ().userId();            
		}
		public string getDeviceId()//设备DeviceId
		{
			return QuickSDKImp.getInstance().getDeviceId();
		}
		public void createRole(GameRoleInfo gameRoleInfo){
			QuickSDKImp.getInstance ().createRole (gameRoleInfo);//创建角色
		}
		public void enterGame(GameRoleInfo gameRoleInfo){
			QuickSDKImp.getInstance ().enterGame (gameRoleInfo);//开始游戏
		}
		public void updateRole(GameRoleInfo gameRoleInfo){
			QuickSDKImp.getInstance ().updateRole (gameRoleInfo);//角色升级
		}



		public void enterYunKeFuCenter(GameRoleInfo gameRoleInfo){
			QuickSDKImp.getInstance ().enterYunKeFuCenter (gameRoleInfo);//进入云客服
		}
		public void callSDKShare(ShareInfo shareInfo){
			QuickSDKImp.getInstance ().callSDKShare(shareInfo);//进入云客服
		}




		public int showToolBar(ToolbarPlace place)//1左上,2右上,3左中,4右中,5左下,6右下
		{
			return QuickSDKImp.getInstance ().showToolBar (place);
		}
		public int hideToolBar()
		{
			return QuickSDKImp.getInstance ().hideToolBar ();
		}
		public bool isFunctionSupported(FuncType type)
		{
			return QuickSDKImp.getInstance ().isFunctionSupported (type);
		}
		public void callFunction(FuncType type)
		{
			QuickSDKImp.getInstance ().callFunction (type);
		}
        public string channelName()          //获取渠道名称
		{
			return QuickSDKImp.getInstance ().channelName ();
		}
		public string channelVersion()       //获取渠道版本
		{
			return QuickSDKImp.getInstance ().channelVersion ();   
		}
		public int channelType()                 //获取渠道类别 渠道唯一标识
		{
			return QuickSDKImp.getInstance ().channelType ();
		}
		public string SDKVersion()      //QuickSDK版本
		{
			return QuickSDKImp.getInstance ().SDKVersion ();   
		}

		public string getConfigValue(string key)
		{
			return QuickSDKImp.getInstance ().getConfigValue (key);
		}

        public void exitGame()
        {
            QuickSDKImp.getInstance().exitGame();
        }

        public bool isChannelHasExitDialog()
        {
            return QuickSDKImp.getInstance().isChannelHasExitDialog();
        }

		//以下是v1.1的老接口，新接入用不到
		public void updateRoleInfoWith(GameRoleInfo gameRoleInfo, bool isCreateRole)
		{
			QuickSDKImp.getInstance ().updateRoleInfoWith (gameRoleInfo, isCreateRole);
		}

		public int enterUserCenter() //用户中心
		{
			return QuickSDKImp.getInstance ().enterUserCenter ();
		}


		

	}
}
