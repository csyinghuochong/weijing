using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cn.sharesdk.unity3d;
using System.Threading;
using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

namespace ET
{
    public static class ShareSdkHelper
    {
		public static void FenXiang(FenXiangContent fenxiangConent)
		{
			ShareSDK ssdk = GameObject.Find("Global").GetComponent<Init>().GetComponent<ShareSDK>();

			//auth和getuser接口都可以实现授权登录功能，可以任意调用一个
			//授权（每次都会跳转到第三方平台进行授权）进行授权
			//ssdk.Authorize(PlatformType.WeChat);
			//ssdk.GetUserInfo(PlatformType.WeChat);
			//设置分享
			ShareContent content = new ShareContent();
			//title标题，印象笔记、邮箱、信息、微信、人人网、QQ和QQ空间使用
			content.SetTitle(fenxiangConent.FenXiang_Title);
			//分享文本
			content.SetText(fenxiangConent.FenXiang_Text);
			//分享网络图片，新浪微博分享网络图片需要通过审核后申请高级写入接口，否则请注释掉测试新浪微博
			content.SetImageUrl(fenxiangConent.FenXiang_ImageUrl);
			// titleUrl是标题的网络链接，仅在Linked-in,QQ和QQ空间使用
			content.SetTitleUrl(fenxiangConent.FenXiang_ClickUrl);
			// imagePath是图片的本地路径，Linked-In以外的平台都支持此参数
			//content.SetImagePath("/sdcard/test.jpg");//确保SDcard下面存在此张图片
			// url仅在微信（包括好友和朋友圈）中使用
			content.SetUrl(fenxiangConent.FenXiang_ClickUrl);
			// site是分享此内容的网站名称，仅在QQ空间使用
			content.SetSite(fenxiangConent.FenXiang_Title);
			// siteUrl是分享此内容的网站地址，仅在QQ空间使用
			content.SetSiteUrl(fenxiangConent.FenXiang_ClickUrl);
			//设置分享类型
			content.SetShareType(ContentType.Webpage);
			//content.SetShareType(ContentType.Text);

			GameObject.Find("Global").GetComponent<Init>().FenXiangShareContent(content, fenxiangConent.Fenxiangtype);
		}

	}
}
