using System;
using System.Collections;

namespace cn.SMSSDK.Unity
{
	public abstract class ISMSSDK
	{
		/// <summary>
		/// SDK版本号
		/// <summary>
		public abstract void getVersion();

		/// <summary>
		/// 获取区号
		/// <summary>
		public abstract void getSupportedCountryCode();

		/// <summary>
		/// 请求本机号码认证Token
		/// <summary>
		public abstract void getMobileAuthToken();

		/// <summary>
		/// 验证手机号
		/// <summary>
		public abstract void verifyMobileWithPhone(string phoneNumber);

		/// <summary>
		/// 获取验证码
		/// <summary>
		public abstract void getCode(CodeType method, string phoneNumber, string zone, string tmpCode);

		/// <summary>
		/// 提交验证码
		/// <summary>
		public abstract void commitCode(string phoneNumber, string zone, string tmpCode);

		/// <summary>
		/// 上传隐私协议状态
		/// <summary>
		public abstract void submitPolicyGrantResult(bool isAgree);

	}
}