
using System.Collections.Generic;

namespace ET
{

	//AwakeSystem 只会执行一次。。 StartSystem每次Add都会在下一帧执行
	public class SkillSetComponentAwakeSystem : AwakeSystem<SkillSetComponent>
	{
		public override void Awake(SkillSetComponent self)
		{
			//根据不同的职业初始化技能
			if (self.SkillList.Count == 0)
			{
				int[] SkillList = OccupationConfigCategory.Instance.Get(self.GetParent<Unit>().GetComponent<UserInfoComponent>().UserInfo.Occ).InitSkillID;
				for (int i = 0; i < SkillList.Length; i++)
				{
					if (i == 0)
					{
						self.SkillList.Add(new SkillPro() { SkillID = SkillList[i], SkillPosition = 1, SkillSetType = (int)SkillSetEnum.Skill });
					}
					else
					{
						self.SkillList.Add(new SkillPro() { SkillID = SkillList[i] });
					}
				}

				string initItem = GlobalValueConfigCategory.Instance.Get(9).Value;
				string[] needList = initItem.Split('@');
				string[] itemInfo = needList[0].Split(';');
				self.SkillList.Add(new SkillPro() { SkillID = int.Parse(itemInfo[0]), SkillPosition = 9, SkillSetType = (int)SkillSetEnum.Item });
			}


			int robotId = self.GetParent<Unit>().GetComponent<UserInfoComponent>().UserInfo.RobotId;
			if (robotId != 0)
			{
				RobotConfig robotConfig = RobotConfigCategory.Instance.Get(robotId);
				self.OnChangeOccTwoRequest(robotConfig.OccTwo);
			}
		}
	}

	public static class SkillSetComponentSystem
	{
		public static int HaveSameTianFu(this SkillSetComponent self, int tianfuId)
		{
			int tifuId = 0;
			TalentConfig talentConfig = TalentConfigCategory.Instance.Get(tianfuId);
			int learnLv = talentConfig.LearnRoseLv;
			for (int i = 0; i < self.TianFuList.Count; i++)
			{
				TalentConfig talentConfig2 = TalentConfigCategory.Instance.Get(self.TianFuList[i]);
				if (talentConfig2.LearnRoseLv == learnLv)
				{
					tifuId = self.TianFuList[i];
					break;
				}
			}
			return tifuId;
		}

		public static void OnActiveTianfu(this SkillSetComponent self, C2M_TianFuActiveRequest request)
		{
			int tianfuId = request.TianFuId;
			TalentConfig talentConfig = TalentConfigCategory.Instance.Get(tianfuId);
			int learnLv = talentConfig.LearnRoseLv;
			bool exist = false;

			for (int i = 0; i < self.TianFuList.Count; i++)
			{
				TalentConfig talentConfig2 = TalentConfigCategory.Instance.Get(self.TianFuList[i]);
				if (talentConfig2.LearnRoseLv == learnLv)
				{
					exist = true;
					self.AddTianFuAttribute(self.TianFuList[i], false);
					self.AddTianFuAttribute(tianfuId, true);
					self.TianFuList[i] = tianfuId;
					break;
				}
			}

			if (!exist)
			{
				self.TianFuList.Add(tianfuId);
				self.AddTianFuAttribute(tianfuId, true);
			}

			self.GetParent<Unit>().GetComponent<SkillPassiveComponent>().UpdatePassiveSkill();
		}

		/// <summary>
		/// 增加天赋属性
		/// </summary>
		/// <param name="self"></param>
		/// <param name="tianfuId"></param>
		public static void AddTianFuAttribute(this SkillSetComponent self, int tianfuId, bool add)
		{
			if (tianfuId == 0)
			{
				return;
			}

			string[] addPropreListStr = TalentConfigCategory.Instance.Get(tianfuId).AddPropreListStr.Split("@");

			for (int k = 0; k < addPropreListStr.Length; k++)
			{
				string[] properInfo = addPropreListStr[k].Split(";");

				switch (properInfo[0])
				{
					case TianFuProEnum.SkillIdAdd:
						self.OnSkillIdAdd(properInfo, add);
						break;
					case TianFuProEnum.SkillPropertyAdd:
						break;
					case TianFuProEnum.BuffIdAdd:
						break;
					case TianFuProEnum.BuffInitIdAdd:
						break;
					case TianFuProEnum.RolePropertyAdd:
						self.OnRolePropertyAdd(properInfo, add ? 1 : -1);
						break;
					case TianFuProEnum.ReplaceSkillId:
						break;
					case TianFuProEnum.BuffPropertyAdd:
						break;
				}
			}
		}

		public static void OnSkillIdAdd(this SkillSetComponent self, string[] properInfo, bool add)
		{
			int skillId = int.Parse(properInfo[1]);

			int index = -1;
			for (int i = self.SkillList.Count - 1; i >= 0; i--)
			{
				if (self.SkillList[i].SkillID == skillId)
				{
					index = i;
				}
			}
			if (add && index == -1)
			{
				self.SkillList.Add(new SkillPro() { SkillID = skillId, SkillSource = (int)SkillSourceEnum.TianFu });
			}
			if (!add && index >= 0)
			{
				self.SkillList.RemoveAt(index);
			}
		}

		public static void OnRolePropertyAdd(this SkillSetComponent self, string[] properInfo, int rate)
		{
			int numericKey = int.Parse(properInfo[1]);
			int valueType = NumericHelp.GetNumericValueType(numericKey);
			if (valueType == 1)
			{
				self.GetParent<Unit>().GetComponent<HeroDataComponent>().BuffPropertyUpdate_Long(numericKey, long.Parse(properInfo[2]) * rate);
			}
			else
			{
				self.GetParent<Unit>().GetComponent<HeroDataComponent>().BuffPropertyUpdate_Float(numericKey, float.Parse(properInfo[2]) * rate);
			}
		}

		public static List<HideProList> GetTianfuRoleProLists(this SkillSetComponent self)
		{
			List<HideProList> proList = new List<HideProList>();
			for (int i = 0; i < self.TianFuList.Count; i++)
			{
				if (TalentConfigCategory.Instance.Get(self.TianFuList[i]).AddPropreListStr != null && TalentConfigCategory.Instance.Get(self.TianFuList[i]).AddPropreListStr != "")
				{
					string[] addPropreListStr = TalentConfigCategory.Instance.Get(self.TianFuList[i]).AddPropreListStr.Split("@");

					for (int k = 0; k < addPropreListStr.Length; k++)
					{
						string[] properInfo = addPropreListStr[k].Split(";");

						if (properInfo[0] != TianFuProEnum.RolePropertyAdd)
						{
							continue;
						}

						if (NumericHelp.GetNumericValueType(int.Parse(properInfo[1])) == 1)
						{
							proList.Add(new HideProList() { HideID = int.Parse(properInfo[1]), HideValue = long.Parse(properInfo[2]) });
						}
						else {
							proList.Add(new HideProList() { HideID = int.Parse(properInfo[1]), HideValue = (int)(float.Parse(properInfo[2])*10000) });
						}
					}
				}
			}

			return proList;
		}

		public static List<HideProList> GetSkillRoleProLists(this SkillSetComponent self)
		{
			List<HideProList> proList = new List<HideProList>();
			for (int i = 0; i < self.SkillList.Count; i++)
			{
				if (self.SkillList[i].SkillSetType == (int)SkillSetEnum.Item)
				{
					continue;
				}

				SkillConfig skillConfig = SkillConfigCategory.Instance.Get(self.SkillList[i].SkillID);
				if (skillConfig.SkillType != (int)SkillTypeEnum.PassiveAddProSkill)
				{
					continue;
				}

				string GameObjectParameter = skillConfig.GameObjectParameter;
				if (ComHelp.IfNull(GameObjectParameter))
				{
					continue;
				}

				string[] addPro = GameObjectParameter.Split(",");
				int key = int.Parse(addPro[0]);
				if (NumericHelp.GetNumericValueType(key) == 1)
                {
                    proList.Add(new HideProList() { HideID = key, HideValue = long.Parse(addPro[1]) });
                }
                else
                {
                    proList.Add(new HideProList() { HideID = key, HideValue = (int)(float.Parse(addPro[1]) * 10000) });
                }
            }
			return proList;
		}

		public static List<int> GetTianFuIdsByType(this SkillSetComponent self, string proType)
		{
			List<int> tianfuIds = new List<int>();

			for (int i = 0; i < self.TianFuList.Count; i++)
			{
				string[] addPropreListStr = TalentConfigCategory.Instance.Get(self.TianFuList[i]).AddPropreListStr.Split("@");
				for (int k = 0; k < addPropreListStr.Length; k++)
				{
					string[] properInfo = addPropreListStr[k].Split(";");

					if (properInfo[0] != proType)
					{
						continue;
					}
					tianfuIds.Add(self.TianFuList[i]);
				}
			}
			return tianfuIds;
		}

		public static Dictionary<int, float> GetSkillPropertyAdd(this SkillSetComponent self, int skillId)
		{
			List<int> tianfuids = self.GetTianFuIdsByType(TianFuProEnum.SkillPropertyAdd);
			if (tianfuids.Count == 0)
				return null;

			Dictionary<int, float> HideProList = new Dictionary<int, float>();
			for (int i = 0; i < tianfuids.Count; i++)
			{
				string[] addPropreListStr = TalentConfigCategory.Instance.Get(tianfuids[i]).AddPropreListStr.Split("@");
				for (int k = 0; k < addPropreListStr.Length; k++)
				{
					string[] properInfo = addPropreListStr[k].Split(";");
					if (properInfo[0] != TianFuProEnum.SkillPropertyAdd)
					{
						continue;
					}
					if (!properInfo[1].Contains(skillId.ToString()))
					{
						continue;
					}
					int key = int.Parse(properInfo[2]);
					float value = float.Parse(properInfo[3]);
					if (HideProList.ContainsKey(key))
					{
						HideProList[key] += value;
					}
					else
					{
						HideProList.Add( key, value );
					}
				}
			}
			return HideProList;
		}

		public static List<int> GetBuffIdAdd(this SkillSetComponent self, int skillId)
		{
			List<int> tianfuids = self.GetTianFuIdsByType(TianFuProEnum.BuffIdAdd);
			if (tianfuids.Count == 0)
				return null;

			List<int> addBuffs = new List<int>();
			for (int i = 0; i < tianfuids.Count; i++)
			{
				string[] addPropreListStr = TalentConfigCategory.Instance.Get(tianfuids[i]).AddPropreListStr.Split("@");
				for (int k = 0; k < addPropreListStr.Length; k++)
				{
					string[] properInfo = addPropreListStr[k].Split(";");
					if (properInfo[0] != TianFuProEnum.BuffIdAdd)
					{
						continue;
					}
					if (!properInfo[1].Contains(skillId.ToString()))
					{
						continue;
					}
					addBuffs.Add(int.Parse(properInfo[2]));
				}
			}
			return addBuffs;
		}

		public static List<int> GetBuffInitIdAdd(this SkillSetComponent self, int skillId)
		{
			List<int> tianfuids = self.GetTianFuIdsByType(TianFuProEnum.BuffInitIdAdd);
			if (tianfuids.Count == 0)
				return null;

			List<int> addBuffs = new List<int>();
			for (int i = 0; i < tianfuids.Count; i++)
			{
				string[] addPropreListStr = TalentConfigCategory.Instance.Get(tianfuids[i]).AddPropreListStr.Split("@");
				for (int k = 0; k < addPropreListStr.Length; k++)
				{
					string[] properInfo = addPropreListStr[k].Split(";");
					if (properInfo[0] != TianFuProEnum.BuffInitIdAdd)
					{
						continue;
					}
					if (!properInfo[1].Contains(skillId.ToString()))
					{
						continue;
					}
					addBuffs.Add(int.Parse(properInfo[2]));
				}
			}
			return addBuffs;
		}

		public static int GetReplaceSkillId(this SkillSetComponent self, int skillId)
		{
			List<int> tianfuids = self.GetTianFuIdsByType(TianFuProEnum.ReplaceSkillId);
			if (tianfuids.Count == 0)
				return 0;
			for (int i = 0; i < tianfuids.Count; i++)
			{
				string[] addPropreListStr = TalentConfigCategory.Instance.Get(tianfuids[i]).AddPropreListStr.Split("@");
				for (int k = 0; k < addPropreListStr.Length; k++)
				{
					string[] properInfo = addPropreListStr[k].Split(";");
					if (properInfo[0] != TianFuProEnum.ReplaceSkillId)
					{
						continue;
					}
					if (properInfo[1] != skillId.ToString())
					{
						continue;
					}
					return int.Parse(properInfo[2]);
				}
			}
			return 0;
		}

		public static Dictionary<int, float> GetBuffPropertyAdd(this SkillSetComponent self, int buffId)
		{
			List<int> tianfuids = self.GetTianFuIdsByType(TianFuProEnum.BuffPropertyAdd);
			if (tianfuids.Count == 0)
				return null;

			Dictionary<int, float> HideProList = new Dictionary<int, float>();
			for (int i = 0; i < tianfuids.Count; i++)
			{
				string[] addPropreListStr = TalentConfigCategory.Instance.Get(tianfuids[i]).AddPropreListStr.Split("@");
				for (int k = 0; k < addPropreListStr.Length; k++)
				{
					string[] properInfo = addPropreListStr[k].Split(";");
					if (properInfo[0] != TianFuProEnum.SkillPropertyAdd)
					{
						continue;
					}
					if (!properInfo[1].Contains(buffId.ToString()))
					{
						continue;
					}
					int key = int.Parse(properInfo[2]);
					float value = float.Parse(properInfo[3]);
					if (HideProList.ContainsKey(key))
					{
						HideProList[key] += value;
					}
					else
					{
						HideProList.Add(key, value);
					}
				}
			}
			return HideProList;
		}

		//转换职业
		public static void OnChangeOccTwoRequest(this SkillSetComponent self, int occTwo)
		{
			if (occTwo == 0)
			{
				return;
			}
			UserInfo useInfo = self.GetParent<Unit>().GetComponent<UserInfoComponent>().UserInfo;
			if (useInfo.OccTwo != 0)
			{
				useInfo.OccTwo = occTwo;
				return;
			}
			
			useInfo.OccTwo = occTwo;
			//新增技能
			OccupationTwoConfig occupationTwoConfig = OccupationTwoConfigCategory.Instance.Get(occTwo);
			int[] addSkills = occupationTwoConfig.SkillID;
			for (int i = 0; i < addSkills.Length; i++)
			{
				SkillPro skillPro = new SkillPro();
				skillPro.SkillID = addSkills[i];
				skillPro.SkillPosition = 0;

				self.SkillList.Add(skillPro);
			}

			Function_Fight.GetInstance().UnitUpdateProperty_Base(self.GetParent<Unit>(), true);

			self.GetParent<Unit>().GetComponent<SkillPassiveComponent>().UpdatePassiveSkill();
		}

		/// <summary>
		/// 脱下装备
		/// </summary>
		/// <param name="self"></param>
		/// <param name="bagInfo"></param>
		public static void OnTakeOffEquip(this SkillSetComponent self, BagInfo bagInfo)
		{
			ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfo.ItemID);
			List<int> itemSkills = new List<int>();
			if (itemConfig.SkillID.Length > 1)
			{
				itemSkills.Add(int.Parse(itemConfig.SkillID));
			}
			itemSkills.AddRange(bagInfo.HideSkillLists);

			BagComponent bagComponent = self.GetParent<Unit>().GetComponent<BagComponent>();
			for (int i = 0; i < itemSkills.Count; i++)
			{
				int skillId = itemSkills[i];
				if (skillId == 0)
				{
					continue;
				}

				//其他装备也持有该技能
				if (bagComponent.IsHaveEquipSkill(skillId))
				{
					continue;
				}
				for (int k = self.SkillList.Count - 1; k >= 0; k--)
				{
					if (self.SkillList[k].SkillSource == (int)SkillSourceEnum.Equip && self.SkillList[k].SkillID == skillId)
					{
						self.GetParent<Unit>().GetComponent<SkillPassiveComponent>().RemoveRolePassiveSkill(skillId);
						self.SkillList.RemoveAt(k);
						break;
					}
				}
			}

			EquipConfig equipConfig = EquipConfigCategory.Instance.Get(itemConfig.ItemEquipID);
			int tianFuid = equipConfig.TianFuId;
			if (tianFuid > 0 && self.TianFuList.Contains(tianFuid))
			{
				self.TianFuList.Remove(tianFuid);
				self.AddTianFuAttribute(tianFuid, false);
			}
		}

		/// <summary>
		/// 穿戴装备
		/// </summary>
		/// <param name="self"></param>
		/// <param name="bagInfo"></param>
		public static void OnWearEquip(this SkillSetComponent self, BagInfo bagInfo)
		{
			ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfo.ItemID);
			List<int> itemSkills = new List<int>();
			if (itemConfig.SkillID.Length > 1)
			{
				itemSkills.Add(int.Parse(itemConfig.SkillID));
			}
			itemSkills.AddRange(bagInfo.HideSkillLists);

			for (int i = 0; i < itemSkills.Count; i++)
			{
				int skillId = itemSkills[i];
				if (skillId == 0)
				{
					continue;
				}
				if (self.GetBySkillID(skillId) != null)
				{
					continue;
				}

				SkillPro skillPro = new SkillPro();
				skillPro.SkillID = skillId;
				skillPro.SkillPosition = 0;
				skillPro.SkillSetType = (int)SkillSetEnum.Skill;
				skillPro.SkillSource = (int)SkillSourceEnum.Equip;
				self.SkillList.Add(skillPro);
				self.GetParent<Unit>().GetComponent<SkillPassiveComponent>().AddRolePassiveSkill(skillId);
			}

			EquipConfig equipConfig = EquipConfigCategory.Instance.Get(itemConfig.ItemEquipID);
			int tianFuid = equipConfig.TianFuId;
			if (tianFuid > 0 && !self.TianFuList.Contains(tianFuid))
			{
				self.TianFuList.Add(tianFuid);
				self.AddTianFuAttribute(tianFuid, true);
			}
		}

		public static int SetSkillIdByPosition(this SkillSetComponent self, C2M_SkillSet request)
		{
			SkillPro newSkill = null;
			if (request.SkillType == 1)	//技能
			{
				SkillPro oldSkill = self.GetByPosition(request.Position);
				if (oldSkill != null)
				{
					oldSkill.SkillPosition = 0;
				}
				newSkill = self.GetBySkillID(request.SkillID);
			}
			else	//药剂
			{
				SkillPro oldSkill = self.GetByPosition(request.Position);
				if (oldSkill != null)
				{
					oldSkill.SkillID = 0;
					oldSkill.SkillPosition = 0;
				}
				newSkill = self.GetBySkillID(request.SkillID);
				if (newSkill == null)
				{
					newSkill = new SkillPro();
					self.SkillList.Add(newSkill);
				}
			}
			newSkill.SkillID = request.SkillID;
			newSkill.SkillPosition = request.Position;
			newSkill.SkillSetType = request.SkillType;

			return ErrorCore.ERR_Success;
		}

		public static SkillPro GetBySkillID(this SkillSetComponent self, int skillid)
		{
			for (int i = self.SkillList.Count - 1; i >= 0; i--)
			{
				if (self.SkillList[i].SkillID == skillid)
				{
					return self.SkillList[i];
				}
			}
			return null;
		}

		public static SkillPro GetByPosition(this SkillSetComponent self, int pos)
		{
			for (int i = self.SkillList.Count - 1; i >= 0; i--)
			{
				if (self.SkillList[i].SkillPosition == pos)
				{
					return self.SkillList[i];
				}
			}
			return null;
		}

		/// <summary>
		/// 技能书
		/// </summary>
		/// <param name="self"></param>
		/// <param name="skillSourceEnum"></param>
		/// <param name="skillId"></param>
		public static void OnAddSkill(this SkillSetComponent self, SkillSourceEnum skillSourceEnum, int skillId)
		{
			if (self.GetBySkillID(skillId) != null)
			{
				return;
			}
			SkillPro skillPro = new SkillPro();
			skillPro.SkillID = skillId;
			skillPro.SkillPosition = 0;
			skillPro.SkillSetType = (int)SkillSetEnum.Skill;
			skillPro.SkillSource = (int)skillSourceEnum;
			self.SkillList.Add(skillPro);
		}

		/// <summary>
		/// 重置第二职业
		/// </summary>
		/// <param name="self"></param>
		public static int OnOccReset(this SkillSetComponent self)
		{
			int sp = 0;
			List<int> skilllist = new List<int>();
			UserInfoComponent userInfoComponent = self.GetParent<Unit>().GetComponent<UserInfoComponent>();
			if (userInfoComponent.UserInfo.OccTwo != 0)
			{
				int[] twoskill = OccupationTwoConfigCategory.Instance.Get(userInfoComponent.UserInfo.OccTwo).SkillID;
				skilllist.AddRange(twoskill);
			}

			for (int i = 0; i < skilllist.Count; i++)
			{
				int skillId = skilllist[i];
				while (skillId != 0)
				{
					SkillPro skillPro = self.GetBySkillID(skillId);
					if (skillPro != null)
					{
						self.SkillList.Remove(skillPro);
						break;
					}
					SkillConfig skillConfig = SkillConfigCategory.Instance.Get(skillId);
					int nextId = skillConfig.NextSkillID;
					if (nextId != 0)
					{
						sp += skillConfig.CostSPValue;
					}
					skillId = nextId;
				}
			}
			userInfoComponent.UserInfo.OccTwo = 0;
			return sp;
		}

		/// <summary>
		/// 重置技能点
		/// </summary>
		/// <param name="self"></param>
		public static void OnSkillReset(this SkillSetComponent self)
		{
			List<int> skilllist = new List<int>();
			UserInfoComponent userInfoComponent = self.GetParent<Unit>().GetComponent<UserInfoComponent>();
			int[] initskill = OccupationConfigCategory.Instance.Get(userInfoComponent.UserInfo.Occ).InitSkillID;
			skilllist.AddRange(initskill);
			if (userInfoComponent.UserInfo.OccTwo != 0)
			{
				int[] twoskill = OccupationTwoConfigCategory.Instance.Get(userInfoComponent.UserInfo.OccTwo).ShowTalentSkill;
				skilllist.AddRange(twoskill);
			}

			for (int i = 0; i < skilllist.Count; i++)
			{
				int skillId = skilllist[i];
				while (skillId != 0)
				{
					SkillPro skillPro = self.GetBySkillID(skillId);
					if (skillPro != null)
					{
						skillPro.SkillID = skilllist[i];
						skillPro.SkillPosition = 0;
						break;
					}
					skillId = SkillConfigCategory.Instance.Get(skillId).NextSkillID;
				}
			}
		}
	}
}
