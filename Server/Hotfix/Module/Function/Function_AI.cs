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

		public void Pet_Create(RolePetInfo petinfo, int createType)
		{
			PetConfig petConfig = PetConfigCategory.Instance.Get(petinfo.ConfigId);
			//更新宠物基本属性
			string petName = petConfig.PetName;
			int zizhiMax_Hp = petConfig.ZiZhi_Hp_Max;
			int zizhiMax_Act = petConfig.ZiZhi_Act_Max;
			int zizhiMax_MageAct = petConfig.ZiZhi_MageAct_Max;
			int zizhiMax_Def = petConfig.ZiZhi_Def_Max;
			int zizhiMax_Adf = petConfig.ZiZhi_Adf_Max;
			int zizhiMax_ActSpeed = petConfig.ZiZhi_ActSpeed_Max;
			int zizhiMax_ChengZhang = (int)petConfig.ZiZhi_ChengZhang_Max;

			int zizhiMin_Hp = petConfig.ZiZhi_Hp_Min;
			int zizhiMin_Act = petConfig.ZiZhi_Act_Min;
			int zizhiMin_MageAct = petConfig.ZiZhi_MageAct_Min;
			int zizhiMin_Def = petConfig.ZiZhi_Def_Min;
			int zizhiMin_Adf = petConfig.ZiZhi_Adf_Min;
			int zizhiMin_ActSpeed = petConfig.ZiZhi_ActSpeed_Min;
			int zizhiMin_ChengZhang = Mathf.FloorToInt((float)petConfig.ZiZhi_ChengZhang_Min);
			int petType = petConfig.PetType;

			//合成资质
			int zizhiNow_Hp = (int)Pet_HeCheng_ZiZhi(zizhiMin_Hp, zizhiMax_Hp, 6500, "1");
			int zizhiNow_Act = (int)Pet_HeCheng_ZiZhi(zizhiMin_Act, zizhiMax_Act, 1600, "1");
			int zizhiNow_MageAct = (int)Pet_HeCheng_ZiZhi(zizhiMin_MageAct, zizhiMax_MageAct, 3200, "1");
			int zizhiNow_Def = (int)Pet_HeCheng_ZiZhi(zizhiMin_Def, zizhiMax_Def, 1600, "1");
			int zizhiNow_Adf = (int)Pet_HeCheng_ZiZhi(zizhiMin_Adf, zizhiMax_Adf, 1600, "1");
			int zizhiNow_ActSpeed = (int)Pet_HeCheng_ZiZhi(zizhiMin_ActSpeed, zizhiMax_ActSpeed, 1600, "1");
			float zizhiNow_ChengZhang = Pet_HeCheng_ZiZhi(zizhiMin_ChengZhang, zizhiMax_ChengZhang, 1.3f);

			//神兽特殊处理
			if (petType == 2)
			{
				zizhiNow_Hp = (int)(zizhiMax_Hp);
				zizhiNow_Act = (int)(zizhiMax_Act);
				zizhiNow_MageAct = (int)(zizhiMax_MageAct);
				zizhiNow_Def = (int)(zizhiMax_Def);
				zizhiNow_Adf = (int)(zizhiMax_Adf);
				zizhiNow_ActSpeed = (int)(zizhiMax_ActSpeed);
				zizhiNow_ChengZhang = zizhiMax_ChengZhang;
			}

			List<int> petSkillStr = new List<int>();
			//读取必带技能
			for (int i = 0; i < petConfig.BaseSkillID.Length; i++)
			{
				petSkillStr.Add(petConfig.BaseSkillID[i]);
			}

			//读取随机技能
			string randomSkillID = petConfig.RandomSkillID;
			if (randomSkillID != "" && randomSkillID != "0")
			{
				string[] randomSkillList = randomSkillID.Split(';');
				for (int i = 0; i < randomSkillList.Length; i++)
				{
					float skillPro = float.Parse(randomSkillList[i].Split(',')[1]);
					string skillID = randomSkillList[i].Split(',')[0];
					if (RandomHelper.RandomNumber(1, 10) * 0.1f <= skillPro)
					{
						petSkillStr.Add(int.Parse(skillID));
					}
				}
			}


			//查询名称
			string nowPetName = petinfo.PetName;
			if (nowPetName != "" && nowPetName != "0")
			{
				petName = nowPetName;
			}

			//保留等级和经验
			int nowPetLv = petinfo.PetLv;
			int nowPetExp = petinfo.PetExp;
			int nowDianShu = 0;
			string addPropretyValue = "0";
			bool ifBaby = petinfo.IfBaby;

			//创建类型
			switch (createType)
			{
				//普通宠物创建
				case 0:
					//随机额外加3级
					nowPetLv = nowPetLv + Function_Role.GetInstance().ReturnRamdomValue_Int(0, 3);
					if (addPropretyValue == "0" || addPropretyValue == "")
					{
						int AddProretyNum = nowPetLv * 5 + 20 + (nowPetLv - 1) * 4;
						addPropretyValue = Function_AI.GetInstance().PetAddPropertyFenPei(AddProretyNum);
					}
					ifBaby = false;
					nowDianShu = 0;
					break;
				//宝宝创建
				case 1:
					//为1级时清空数据
					nowPetLv = 1;
					nowPetExp = 0;
					nowDianShu = 20;
					//随机点数
					int addProretyNum = nowPetLv * 5 + 60;
					addPropretyValue = Function_AI.GetInstance().PetAddPropertyFenPei(addProretyNum);
					ifBaby = true;

					//写入成就(宝宝数量)
					//Game_PublicClassVar.Get_function_Task.ChengJiu_WriteValue("207", "0", "1");
					break;
					/*
				//捕捉创建（因为之前是否宝宝都已经写入进去了）
				case "2":
					addProretyNum = nowPetLv * 5 + 60;
					addPropretyValue = PetAddPropertyFenPei(addProretyNum);
					break;
					*/
			}

			petinfo.PetName = petName;
			petinfo.PetName = petName;
			petinfo.PetLv = nowPetLv;
			petinfo.PetExp = nowPetExp;
			petinfo.PetExp = nowPetExp;
			petinfo.IfBaby = ifBaby;
			petinfo.AddPropretyNum = nowDianShu;
			petinfo.AddPropretyValue = addPropretyValue;
			petinfo.ZiZhi_Hp = zizhiNow_Hp;
			petinfo.ZiZhi_Act = zizhiNow_Act;
			petinfo.ZiZhi_MageAct = zizhiNow_MageAct;
			petinfo.ZiZhi_Def = zizhiNow_Def;
			petinfo.ZiZhi_Adf = zizhiNow_Adf;
			petinfo.ZiZhi_ActSpeed = zizhiNow_ActSpeed;
			petinfo.ZiZhi_ChengZhang = Mathf.FloorToInt(zizhiNow_ChengZhang);
			petinfo.PetSkill = petSkillStr;

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