using System.Collections.Generic;
using UnityEngine;

namespace ET
{

    public class Function_AI
    {

		//实例化自身
		private static Function_AI _instance;
        public static Function_AI GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Function_AI();
            }
            return _instance;
        }

		//传入2个宠物资质返回合成后的资质（取2个值的差值进行调整）
		//ziZhiType表示资质的类型,0表示不额外处理,1表示额外处理满级资质,用于捕捉宠物
		public float Pet_HeCheng_ZiZhi(float zizhiValue_1, float zizhiValue_2, float maxZiZhi = 99999, string ziZhiType = "0")
		{
			if (ziZhiType == "1")
			{
				//5%概率满资质
				if (RandomHelper.RandomNumber(1, 10) * 0.1f <= 0.05f)
				{
					return Mathf.Max(zizhiValue_1, zizhiValue_2);
				}
			}

			//获取随机资质
			//float zhizhiValue = Mathf.Min(zizhiValue_1, zizhiValue_2) * 0.75f + (Mathf.Min(zizhiValue_1, zizhiValue_2) * 0.25f + Mathf.Max(zizhiValue_1, zizhiValue_2) - Mathf.Min(zizhiValue_1, zizhiValue_2)) * Random.value * 1.1f;
			float zhizhiValue = Mathf.Min(zizhiValue_1, zizhiValue_2) * 0.75f + ((Mathf.Min(zizhiValue_1, zizhiValue_2) * 0.25f + Mathf.Max(zizhiValue_1, zizhiValue_2) - Mathf.Min(zizhiValue_1, zizhiValue_2))) * (RandomHelper.RandomNumber(1,10)*0.1f) * 1.1f;
			//限制最高资质
			if (zhizhiValue > maxZiZhi)
			{
				zhizhiValue = maxZiZhi;
			}

			return zhizhiValue;
		}

		//增加随机资质
		public bool Pet_AddRandomZiZhi(RolePetInfo petinfo)
		{
			int petID = petinfo.ConfigId;
			//当前资质
			int ziZhi_Hp = petinfo.ZiZhi_Hp;
			int ziZhi_Act = petinfo.ZiZhi_Act;
			int ziZhi_MageAct = petinfo.ZiZhi_MageAct;
			int ziZhi_Def = petinfo.ZiZhi_Def;
			int ziZhi_Adf = petinfo.ZiZhi_Adf;
			int ziZhi_ActSpeed = petinfo.ZiZhi_ActSpeed;

			PetConfig petconf = PetConfigCategory.Instance.Get(petID);
			//最大资质
			float zizhiMax_Hp = petconf.ZiZhi_Hp_Max;
			float zizhiMax_Act = petconf.ZiZhi_Act_Max;
			float zizhiMax_MageAct = petconf.ZiZhi_MageAct_Max;
			float zizhiMax_Def = petconf.ZiZhi_Def_Max;
			float zizhiMax_Adf = petconf.ZiZhi_Adf_Max;
			float zizhiMax_ActSpeed = petconf.ZiZhi_ActSpeed_Max;

			//增加状态
			bool addStatus = false;
			//血量资质
			if (ziZhi_Hp < zizhiMax_Hp)
			{
				if (addRandomZiZhi(petinfo, petinfo.ZiZhi_Hp*2, zizhiMax_Hp))
				{
					addStatus = true;
				}
			}
			//攻击资质
			if (ziZhi_Act < zizhiMax_Act)
			{
				if (addRandomZiZhi(petinfo, petinfo.ZiZhi_Act, zizhiMax_Act))
				{
					addStatus = true;
				}
			}
			//法力资质
			if (ziZhi_MageAct < zizhiMax_MageAct)
			{
				if (addRandomZiZhi(petinfo, petinfo.ZiZhi_MageAct, zizhiMax_MageAct))
				{
					addStatus = true;
				}
			}
			//物防资质
			if (ziZhi_Def < zizhiMax_Def)
			{
				if (addRandomZiZhi(petinfo, petinfo.ZiZhi_Def, zizhiMax_Def))
				{
					addStatus = true;
				}
			}
			//魔防资质
			if (ziZhi_Adf < zizhiMax_Adf)
			{
				if (addRandomZiZhi(petinfo, petinfo.ZiZhi_Adf, zizhiMax_Adf))
				{
					addStatus = true;
				}
			}
			//速度资质
			if (ziZhi_ActSpeed < zizhiMax_ActSpeed)
			{
				if (addRandomZiZhi(petinfo, petinfo.ZiZhi_ActSpeed, zizhiMax_ActSpeed))
				{
					addStatus = true;
				}
			}

			if (!addStatus)
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		//随机增加宠物资质
		public bool addRandomZiZhi(RolePetInfo petinfo, int ziZhi_value, float maxValue)
		{
			int addZiZhiValue = 10 + (int)(RandomHelper.RandomNumber(1,10)*0.1f * 15);
			//血量资质翻倍
			addZiZhiValue = addZiZhiValue + ziZhi_value;

			//资质不能超过上限
			if (addZiZhiValue > maxValue)
			{
				addZiZhiValue = (int)(maxValue);
			}
			return true;
		}

		//增加随机成长
		public bool Pet_AddRandomChengZhang(RolePetInfo petinfo)
		{
			int petID = petinfo.ConfigId;		
			PetConfig petconf = PetConfigCategory.Instance.Get(petID);
			float chengzhang = petinfo.ZiZhi_ChengZhang;
			float ziZhi_ChengZhang_Max = (float)petconf.ZiZhi_ChengZhang_Max;

			if (chengzhang >= ziZhi_ChengZhang_Max)
			{
				return false;
			}
			else
			{
				float addValue = 0.02f + RandomHelper.RandomNumber(1,10) * 0.1f * 0.03f;
				//保底增加
				if (addValue <= 0.01f)
				{
					addValue = 0.01f;
				}
				chengzhang = chengzhang + addValue;
				return true;
			}
		}

		//随机分配指定点数
		public string PetAddPropertyFenPei(int sumNum)
        {
            //取4个随机值
            float ran_1 = Function_Role.GetInstance().ReturnRamdomValue_Float(0, 0.5f);
            float ran_2 = Function_Role.GetInstance().ReturnRamdomValue_Float(0, 0.5f);
            float ran_3 = Function_Role.GetInstance().ReturnRamdomValue_Float(0, 1 - ran_1 - ran_2);
            float ran_4 = 1 - ran_1 - ran_2 - ran_3;
            int add_1 = (int)(sumNum * ran_1);
            int add_2 = (int)(sumNum * ran_2);
            int add_3 = (int)(sumNum * ran_3);
            int add_4 = (int)(sumNum * ran_4);
            return add_1 + ";" + add_2 + ";" + add_3 + ";" + add_4;
        }

    }
}