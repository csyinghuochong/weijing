using System;

namespace ET
{

	public enum VersionMode
	{
		Alpha = 0,              //仅内部人员使用。一般不向外部发布
		Beta = 1,               //公开测试版
		BanHao = 2,
	}

	public static class EnumHelper
	{
		public static int EnumIndex<T>(int value)
		{
			int i = 0;
			foreach (object v in Enum.GetValues(typeof (T)))
			{
				if ((int) v == value)
				{
					return i;
				}
				++i;
			}
			return -1;
		}

		public static T FromString<T>(string str)
		{
            if (!Enum.IsDefined(typeof(T), str))
            {
                return default(T);
            }
            return (T)Enum.Parse(typeof(T), str);
        }
    }
}