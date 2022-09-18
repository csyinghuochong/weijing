using System.Collections.Generic;

namespace ET
{
	public static class SkillSetComponentSystem
	{
		public static async ETTask RequestSkillSet(this SkillSetComponent self)
		{
			C2M_SkillInitRequest c2M_SkillSet = new C2M_SkillInitRequest() {};
			M2C_SkillInitResponse m2C_SkillSet = (M2C_SkillInitResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_SkillSet);

			self.SkillList = m2C_SkillSet.SkillList;
			self.TianFuList = m2C_SkillSet.TianFuList;
		}

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

		//激活天赋
		public static async ETTask ActiveTianFu(this SkillSetComponent self, int tianfuId)
		{
			C2M_TianFuActiveRequest c2M_SkillSet = new C2M_TianFuActiveRequest() { TianFuId = tianfuId };
			M2C_TianFuActiveResponse m2C_SkillSet = (M2C_TianFuActiveResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_SkillSet);

			if (m2C_SkillSet.Error != 0)
				return;

			//如果有相同等级的天赋则替换
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
			HintHelp.GetInstance().DataUpdate(DataType.OnActiveTianFu);
			HintHelp.GetInstance().ShowHint("激活成功！");
		}

		/// <summary>
		/// 增加天赋属性
		/// </summary>
		/// <param name="self"></param>
		/// <param name="tianfuId"></param>
		public static void AddTianFuAttribute(this SkillSetComponent self, int tianfuId, bool add)
		{
			string[] addPropreListStr = TalentConfigCategory.Instance.Get(tianfuId).AddPropreListStr.Split('@');

			for (int k = 0; k < addPropreListStr.Length; k++)
			{
				string[] properInfo = addPropreListStr[k].Split(';');

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

		public static List<int> GetTianFuIdsByType(this SkillSetComponent self, string proType)
		{
			List<int> tianfuIds = new List<int>();

			for (int i = 0; i < self.TianFuList.Count; i++)
			{
				string[] addPropreListStr = TalentConfigCategory.Instance.Get(self.TianFuList[i]).AddPropreListStr.Split('@');
				for (int k = 0; k < addPropreListStr.Length; k++)
				{
					string[] properInfo = addPropreListStr[k].Split(';');

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
				string[] addPropreListStr = TalentConfigCategory.Instance.Get(tianfuids[i]).AddPropreListStr.Split('@');
				for (int k = 0; k < addPropreListStr.Length; k++)
				{
					string[] properInfo = addPropreListStr[k].Split(';');
					if (properInfo[0] != TianFuProEnum.SkillPropertyAdd)
					{
						continue;
					}
					if (properInfo[1].Contains(skillId.ToString()))
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

		//激活技能
		public static async ETTask ActiveSkillID(this SkillSetComponent self, int skillId)
		{
			C2M_SkillUp c2M_SkillSet = new C2M_SkillUp() { SkillID = skillId };
			M2C_SkillUp m2C_SkillSet = (M2C_SkillUp)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_SkillSet);

			if (m2C_SkillSet.Error != 0)
				return;

			//升级替换技能
			for (int i = self.SkillList.Count - 1; i >= 0; i--)
			{
				if (self.SkillList[i].SkillID == skillId)
				{
					self.SkillList[i].SkillID = m2C_SkillSet.NewSkillID;
					break;
				}
			}

			HintHelp.GetInstance().DataUpdate(DataType.SkillUpgrade, skillId.ToString() + "_" + m2C_SkillSet.NewSkillID.ToString());
		}

		public static  SkillPro GetSkillPro(this SkillSetComponent self, int skillId)
		{
			for (int i = 0; i < self.SkillList.Count; i++)
			{
				if (self.SkillList[i].SkillID == skillId)
					return self.SkillList[i];
			}
			return null;
		}

		public static async ETTask<bool> ChangeOccTwoRequest(this SkillSetComponent self, int occTwoID)
		{
			UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
			int oldOccTwo = userInfoComponent.UserInfo.OccTwo;
			C2M_ChangeOccTwoRequest c2M_ChangeOccTwoRequest = new C2M_ChangeOccTwoRequest() { OccTwoID = occTwoID };
			M2C_ChangeOccTwoResponse m2C_SkillSet = (M2C_ChangeOccTwoResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_ChangeOccTwoRequest);

			if (m2C_SkillSet.Error == 0)
			{
				if (oldOccTwo == 0)
				{
					OccupationTwoConfig occupationTwoConfig = OccupationTwoConfigCategory.Instance.Get(occTwoID);
					int[] addSkills = occupationTwoConfig.SkillID;
					for (int i = 0; i < addSkills.Length; i++)
					{
						SkillPro skillPro = new SkillPro();
						skillPro.SkillID = addSkills[i];
						skillPro.SkillPosition = 0;
						self.SkillList.Add(skillPro);
					}
				}

				UserInfo userInfo = userInfoComponent.UserInfo;
				userInfo.OccTwo = occTwoID;

				//飘字
				HintHelp.GetInstance().ShowHint("恭喜你!转职成功");
				return true;

			}
			else
			{
				//HintHelp.GetInstance().ShowErrHint(m2C_SkillSet.Error);
				return false;
			}

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

			for (int i = 0; i < itemSkills.Count; i++)
			{
				int skillId = itemSkills[i];
				if (skillId == 0)
				{
					continue;
				}

				//其他装备也持有该技能
				if (self.ZoneScene().GetComponent<BagComponent>().IsHaveEquipSkill(skillId))
				{
					continue;
				}

				for (int k = self.SkillList.Count - 1; k >= 0; k--)
				{
					if (self.SkillList[k].SkillSource == (int)SkillSourceEnum.Equip && self.SkillList[k].SkillID == skillId)
					{
						self.SkillList.RemoveAt(k);
						break;
					}
				}
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
				itemSkills.Add( int.Parse(itemConfig.SkillID) );
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
			}
		}

		/// <summary>
		/// 技能设置
		/// </summary>
		/// <param name="self"></param>
		/// <param name="skillId"></param>
		/// <param name="skillType">1技能 2物品</param>
		/// <param name="pos"></param>
		public static async ETTask SetSkillIdByPosition(this SkillSetComponent self, int skillId, int skillType, int pos)
		{
			if (skillType == (int)SkillSetEnum.Skill && pos > 8)
				return;
			if (skillType == (int)SkillSetEnum.Item && pos <= 8)
				return;

			C2M_SkillSet c2M_SkillSet = new C2M_SkillSet() {  SkillID = skillId, SkillType = skillType, Position = pos };
			M2C_SkillSet m2C_SkillSet = (M2C_SkillSet)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_SkillSet);

			if (m2C_SkillSet.Error != 0)
				return;

			//清除之前该位置的技能

			SkillPro newSkill = null;
			if (skillType == 1)
			{
				SkillPro oldSkill = self.GetByPosition(pos);
				if (oldSkill != null)
				{
					oldSkill.SkillPosition = 0;
				}
				newSkill = self.GetBySkillID(skillId);
			}
			else
			{
				SkillPro oldSkill = self.GetByPosition(pos);
				if (oldSkill != null)
				{
					oldSkill.SkillID = 0;
					oldSkill.SkillPosition = 0;
				}
				newSkill = self.GetBySkillID(skillId);
				if (newSkill == null)
				{
					newSkill = new SkillPro();
					self.SkillList.Add(newSkill);
				}
			}

			newSkill.SkillID = skillId;
			newSkill.SkillPosition = pos;
			newSkill.SkillSetType = skillType;

			HintHelp.GetInstance().DataUpdate(DataType.SkillSetting);
		}

		public static bool IfEquipMainSkill(this SkillSetComponent self, int skillId)
		{
			for (int i = self.SkillList.Count - 1; i >= 0; i--)
			{
				if (self.SkillList[i].SkillID == skillId)
				{
					return true;
				}
			}
			return false;
		}

		public static SkillPro GetBySkillID(this SkillSetComponent self, int skillid)
		{
			for (int i = 0; i < self.SkillList.Count; i++)
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
			for (int i = 0; i < self.SkillList.Count; i++)
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

		public static int GetCanUseSkill(this SkillSetComponent self)
		{
			return self.SkillList[0].SkillID;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="self"></param>
		/// <returns>返还技能点</returns>
		public static int OnOccReset(this SkillSetComponent self)
		{
			int sp = 0;
			List<int> skilllist = new List<int>();
			UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
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
					skillId = SkillConfigCategory.Instance.Get(skillId).NextSkillID;
				}
			}

			userInfoComponent.UserInfo.OccTwo = 0;
			HintHelp.GetInstance().DataUpdate(DataType.SkillReset);
			return sp;
		}

		/// <summary>
		/// 重置技能点
		/// </summary>
		/// <param name="self"></param>
		public static void OnSkillReset(this SkillSetComponent self)
		{
			List<int> skilllist = new List<int>();
			UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
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
			HintHelp.GetInstance().DataUpdate(DataType.SkillReset);
		}
	}
}
