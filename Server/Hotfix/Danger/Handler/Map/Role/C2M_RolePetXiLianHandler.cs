using System;
using System.Collections.Generic;

namespace ET
{
    //玩家宠物
    [ActorMessageHandler]
	public class C2M_RolePetXiLianHandler : AMActorLocationRpcHandler<Unit, C2M_RolePetXiLian, M2C_RolePetXiLian>
	{
		protected override async ETTask Run(Unit unit, C2M_RolePetXiLian request, M2C_RolePetXiLian response, Action reply)
		{
			//读取数据库
			RolePetInfo petInfo = unit.GetComponent<PetComponent>().GetPetInfo(request.PetInfoId);
			BagInfo bagInfo = unit.GetComponent<BagComponent>().GetItemByLoc(ItemLocType.ItemLocBag, request.BagInfoID);

			//判断是否有足够的道具
			if (bagInfo == null)
			{
				response.Error = ErrorCore.ERR_ItemNotEnoughError;
				reply();
				return;
			}
			if (unit.GetComponent<BagComponent>().GetItemNumber(bagInfo.ItemID) < request.CostItemNum)
			{
				response.Error = ErrorCore.ERR_ItemNotEnoughError;
				reply();
				return;
			}

			ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfo.ItemID);
			int itemSubType = itemConfig.ItemSubType;
			switch (itemSubType)
			{
				//宠物洗练
				case 105:
					//重置资质系数
					petInfo = unit.GetComponent<PetComponent>().PetXiLian(petInfo,2);
					response.rolePetInfo = petInfo;
					break;
				//增加经验
				case 108:
					int addExp = ExpConfigCategory.Instance.Get(petInfo.PetLv).PetItemUpExp;
					unit.GetComponent<PetComponent>().PetAddExp(petInfo, addExp);
					response.rolePetInfo = petInfo;
					break;
				//增加等级
				case 109:
					unit.GetComponent<PetComponent>().PetAddLv(petInfo, 1);
					response.rolePetInfo = petInfo;
					break;
				case 117:	//洗点
					unit.GetComponent<PetComponent>().OnResetPoint(petInfo);
					response.rolePetInfo = petInfo;
					break;
				case 118: //资质
					unit.GetComponent<PetComponent>().UpdatePetZiZhi(petInfo, bagInfo.ItemID);
					response.rolePetInfo = petInfo;
					break;
				case 119: //成长
					unit.GetComponent<PetComponent>().UpdatePetChengZhang(petInfo, bagInfo.ItemID);
					response.rolePetInfo = petInfo;
					break;
				//学习技能书
				case 121:
					Pet_AddSkill(petInfo, int.Parse(itemConfig.ItemUsePar));
					response.rolePetInfo = petInfo;
					break;
				default:
					break;
			}

			//扣除相关道具
			if (bagInfo != null)
			{
				//扣除道具
				List<RewardItem> rewardItems = new List<RewardItem>();
				rewardItems.Add(new RewardItem() { ItemID = bagInfo.ItemID, ItemNum = 1 });
				unit.GetComponent<BagComponent>().OnCostItemData(rewardItems);		
				unit.GetComponent<ChengJiuComponent>().OnPetXiLian(petInfo);		//激活成就
				unit.GetComponent<TaskComponent>().OnPetXiLian();					//激活任务
			}

			reply();
			await ETTask.CompletedTask;
		}

		//宠物打技能书
		private void Pet_AddSkill(RolePetInfo petinfo, int addSkillID)
		{
			if (petinfo.PetSkill.Contains(addSkillID))
			{
				return;
			}

			//学习规则是随机顶掉当前宠物的一个技能
			if (petinfo.PetSkill.Count > 0 )
			{
				//随机获取替换的技能ID序号
				int tihuanNum =  RandomHelper.RandomNumber(0, petinfo.PetSkill.Count);
				petinfo.PetSkill.Remove(tihuanNum);
			}

			petinfo.PetSkill.Add(addSkillID);
		}

		//宠物自身洗炼
		private int Pet_XilianSelf(RolePetInfo petinfo)
		{
			
			int ErrorCore = -1;
			/*
			int petID = petinfo.ConfigId;
			PetConfig petConfig = PetConfigCategory.Instance.Get(petID);

			int petType = petConfig.PetType;
			if (petType != 0)
			{
				//Game_PublicClassVar.Get_function_UI.GameGirdHint_Front("洗炼变异宠物请使用更强大的道具！");
				ErrorCore = 1;
			}

			
			if (petID != 30000001 && petID != 30000002)
			{
				//3%概率变成变异宠物
				if (RandomHelper.RandomNumber(0, 10) * 0.1f <= 0.03f)
				{
					int petBianYiID = 0; // petConfig.PetBianYiID;
					if (petBianYiID != 0)
					{
						petID = petBianYiID;
					}
					//获取玩家名称
					//string roseName = "";
					//广播【"恭喜玩家" + roseName + "洗炼宠物时一不小心打翻了药坛子,宠物不小心变了一个颜色!"】
				}
			}
			*/
			//Function_AI.GetInstance().Pet_Create(petinfo, 1);

			return ErrorCore;
		}

		////超级金柳露洗炼
		private void Pet_XiLianJinluliu(RolePetInfo petinfo)
		{
			Function_AI.GetInstance().Pet_Create(petinfo, 1);

			//langStrHint = Game_PublicClassVar.Get_gameSettingLanguge.LoadLocalizationHint("hint_226");
			//Game_PublicClassVar.Get_function_UI.GameGirdHint_Front(langStrHint);
			//Game_PublicClassVar.Get_function_UI.GameGirdHint_Front("你的宠物被一股强大的能力赋予了！");
			//消耗当前的道具,刷新对应的栏位显示
		}

		//成长提高
		private bool Pet_AddRandomChengZhang(RolePetInfo petinfo)
		{
			return Function_AI.GetInstance().Pet_AddRandomChengZhang(petinfo);
			//langStrHint = Game_PublicClassVar.Get_gameSettingLanguge.LoadLocalizationHint("hint_228");
			//Game_PublicClassVar.Get_function_UI.GameGirdHint_Front(langStrHint);
			////Game_PublicClassVar.Get_function_UI.GameGirdHint_Front("一股神秘的力量让你的宠物成长提高了！");
			//Obj_PetShow.GetComponent<UI_PetXiLianShow>().showPetProperty();
			////消耗当前的道具,刷新对应的栏位显示
			//if (Game_PublicClassVar.Get_function_Rose.CostBagItem(XiLianNeedItemID, int.Parse(XiLianNeedItemNum)))
			//{
			//	BagItemSkillBtnList();
			//	nowXiLianNum = nowXiLianNum + 1;
			//}
		}

		//宝宝属性点重置
		private bool Pet_AddProprety(RolePetInfo petinfo)
		{
			//判定目标是否为宝宝
			bool ifBaby = petinfo.IfBaby;
			if (ifBaby == false)
			{
				//langStrHint = Game_PublicClassVar.Get_gameSettingLanguge.LoadLocalizationHint("hint_229");
				//Game_PublicClassVar.Get_function_UI.GameGirdHint_Front(langStrHint);
				return false;
			}

			//读取宠物技能点数
			string addPropretyValue = petinfo.AddPropretyValue;
			int addPropretyNum = petinfo.AddPropretyNum;
			int petLv = petinfo.PetLv;
			string[] addPropretyValueList = addPropretyValue.Split(';');
			int nowNum = 0;
			for (int i = 0; i < addPropretyValueList.Length; i++)
			{
				nowNum = nowNum + int.Parse(addPropretyValueList[i]);
			}

			int nowChongZhiNumOne = 15 + (petLv - 1) * 1;
			if (nowNum >= nowChongZhiNumOne * 4)
			{
				nowNum = nowNum - nowChongZhiNumOne * 4;
			}
			else
			{
				//宠物属性使用失败,当前加点总数必须大于一定值。
				//langStrHint = Game_PublicClassVar.Get_gameSettingLanguge.LoadLocalizationHint("hint_230");
				//Game_PublicClassVar.Get_function_UI.GameGirdHint_Front(langStrHint);
				//Game_PublicClassVar.Get_function_UI.GameGirdHint_Front("重置失败,点数不符！");
				return false;
			}

			//消耗当前的道具,刷新对应的栏位显示
			//销毁道具
			//if (Game_PublicClassVar.Get_function_Rose.CostBagItem(XiLianNeedItemID, int.Parse(XiLianNeedItemNum)))
			bool ifCostStatus = true; // await Function_Role.GetInstance().Bag_CostItem(player.UserId, (int)(request.OperateBagID), (int)(request.OperateBagNum));
			if (ifCostStatus)
			{
				nowNum = nowNum + addPropretyNum;
				petinfo.AddPropretyValue = nowChongZhiNumOne + "_" + nowChongZhiNumOne + "_" + nowChongZhiNumOne + "_" + nowChongZhiNumOne;
				petinfo.AddPropretyNum = nowNum;
				//Game_PublicClassVar.Get_function_DataSet.DataSet_WriteData("AddPropretyValue", nowChongZhiNumOne + ";" + nowChongZhiNumOne + ";" + nowChongZhiNumOne + ";" + nowChongZhiNumOne, "ID", petSpaceID, "RosePet");
				//Game_PublicClassVar.Get_function_DataSet.DataSet_WriteData("AddPropretyNum", nowNum.ToString(), "ID", petSpaceID, "RosePet");
				//Game_PublicClassVar.Get_function_DataSet.DataSet_SetXml("RosePet");
				//langStrHint = Game_PublicClassVar.Get_gameSettingLanguge.LoadLocalizationHint("hint_231");
				//Game_PublicClassVar.Get_function_UI.GameGirdHint_Front(langStrHint);
				//nowXiLianNum = nowXiLianNum + 1;
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}