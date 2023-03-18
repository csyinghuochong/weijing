using System.Collections.Generic;

namespace ET
{
	public static class SkillSetComponentSystem
	{
		public static async ETTask RequestSkillSet(this SkillSetComponent self)
		{
			C2M_SkillInitRequest c2M_SkillSet = new C2M_SkillInitRequest() { };
			M2C_SkillInitResponse m2C_SkillSet = (M2C_SkillInitResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_SkillSet);

			self.UpdateSkillSet(m2C_SkillSet.SkillSetInfo);
		}

		public static void UpdateSkillSet(this SkillSetComponent self, SkillSetInfo skillSetInfo)
		{
			self.SkillList = skillSetInfo.SkillList;
			self.TianFuList = skillSetInfo.TianFuList;
			self.LifeShieldList = skillSetInfo.LifeShieldList;
			self.TianFuList1 = skillSetInfo.TianFuList1;
			self.TianFuPlan = skillSetInfo.TianFuPlan;
		}

		public static List<int> TianFuList(this SkillSetComponent self)
		{
			return self.TianFuPlan == 0 ? self.TianFuList : self.TianFuList1;
		}

		public static int HaveSameTianFu(this SkillSetComponent self, int tianfuId)
		{
			TalentConfig talentConfig = TalentConfigCategory.Instance.Get(tianfuId);
			int learnLv = talentConfig.LearnRoseLv;
			int sameId = 0;
			List<int> tianfulist = self.TianFuList();
			for (int i = 0; i < tianfulist.Count; i++)
			{
				TalentConfig talentConfig2 = TalentConfigCategory.Instance.Get(tianfulist[i]);
				if (talentConfig2.LearnRoseLv == learnLv)
				{
					sameId = tianfulist[i];
					break;
				}
			}
			return sameId;
		}

		//激活天赋
		public static async ETTask ActiveTianFu(this SkillSetComponent self, int tianfuId)
		{
			C2M_TianFuActiveRequest c2M_SkillSet = new C2M_TianFuActiveRequest() { TianFuId = tianfuId };
			M2C_TianFuActiveResponse m2C_SkillSet = (M2C_TianFuActiveResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_SkillSet);

			if (m2C_SkillSet.Error != 0)
			{
				return;
			}

			//如果有相同等级的天赋则替换
			HintHelp.GetInstance().DataUpdate(DataType.OnActiveTianFu);
			HintHelp.GetInstance().ShowHint("激活成功！");
		}

		public static void TianFuRemove(this SkillSetComponent self, int tianFuid)
		{
			//可以判断一下装备是否还有此天赋
			List<int> tianfuIds = self.TianFuList;
			if (tianFuid > 0 && tianfuIds.Contains(tianFuid))
			{
				tianfuIds.Remove(tianFuid);
				self.AddTianFuAttribute(tianFuid, false);
			}
			tianfuIds = self.TianFuList1;
			if (tianFuid > 0 && tianfuIds.Contains(tianFuid))
			{
				tianfuIds.Remove(tianFuid);
				self.AddTianFuAttribute(tianFuid, false);
			}
		}

		public static void TianFuAdd(this SkillSetComponent self, int tianFuid)
		{
			if (tianFuid > 0 && !self.TianFuList().Contains(tianFuid))
			{
				self.TianFuList().Add(tianFuid);
				self.AddTianFuAttribute(tianFuid, true);
			}
		}

		public static void UpdateTianFuPlan(this SkillSetComponent self, int plan)
		{
			self.TianFuPlan = plan;

			List<int> oldtianfus = plan == 0 ? self.TianFuList1 : self.TianFuList;
			for (int i = 0; i < oldtianfus.Count; i++)
			{
				self.AddTianFuAttribute(oldtianfus[i], false);
			}
			List<int> newtianfus = plan == 0 ? self.TianFuList : self.TianFuList1;
			for (int i = 0; i < newtianfus.Count; i++)
			{
				self.AddTianFuAttribute(newtianfus[i], true);
			}
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
			List<int> tianfuids = self.TianFuList();
			List<int> typetianfus = new List<int>();

			for (int i = 0; i < tianfuids.Count; i++)
			{
				string[] addPropreListStr = TalentConfigCategory.Instance.Get(tianfuids[i]).AddPropreListStr.Split('@');
				for (int k = 0; k < addPropreListStr.Length; k++)
				{
					string[] properInfo = addPropreListStr[k].Split(';');

					if (properInfo[0] != proType)
					{
						continue;
					}
					typetianfus.Add(tianfuids[i]);
				}
			}
			return typetianfus;
		}

		public static bool IsSkillSingingCancel(this SkillSetComponent self, int skillId)
		{
			List<int> tianfuids = self.GetTianFuIdsByType(TianFuProEnum.SkillSingingCancel);
			if (tianfuids.Count == 0)
				return false;

			for (int i = 0; i < tianfuids.Count; i++)
			{
				string[] addPropreListStr = TalentConfigCategory.Instance.Get(tianfuids[i]).AddPropreListStr.Split('@');
				for (int k = 0; k < addPropreListStr.Length; k++)
				{
					string[] properInfo = addPropreListStr[k].Split(';');

					if (!properInfo[1].Contains(skillId.ToString()))
					{
						return true;
					}
				}
			}
			return false;
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

		public static SkillPro GetSkillPro(this SkillSetComponent self, int skillId)
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

			C2M_SkillSet c2M_SkillSet = new C2M_SkillSet() { SkillID = skillId, SkillType = skillType, Position = pos };
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

		public static SkillPro GetCanUseSkill(this SkillSetComponent self)
		{
			SkillPro skillPro = self.SkillList[RandomHelper.RandomNumber(0, self.SkillList.Count)];
			return skillPro;
		}

		public static int GetLifeShieldShowId(this SkillSetComponent self, int shieldType)
		{
			int curLv = self.GetLifeShieldLevel(shieldType);
			int maxLv = LifeShieldConfigCategory.Instance.LifeShieldList[shieldType].Count;
			int nextlifeId = 0;
			if (curLv == maxLv)
			{
				nextlifeId = LifeShieldConfigCategory.Instance.LifeShieldList[shieldType][curLv];
			}
			else
			{
				nextlifeId = LifeShieldConfigCategory.Instance.LifeShieldList[shieldType][curLv + 1];
			}
			return nextlifeId;
		}

		public static LifeShieldInfo GetLifeShieldByType(this SkillSetComponent self, int sType)
		{
			for (int i = 0; i < self.LifeShieldList.Count; i++)
			{
				if ((int)self.LifeShieldList[i].ShieldType == sType)
				{
					return self.LifeShieldList[i];
				}
			}

			return null;
		}

		/// <summary>
		/// 生命之盾之外的其他最小等级
		/// </summary>
		/// <param name="self"></param>
		/// <returns></returns>
		public static int GetOtherMinLevel(this SkillSetComponent self)
		{
			int minLevel = 0;
			for (int i = 0; i < self.LifeShieldList.Count; i++)
			{
				if ((int)self.LifeShieldList[i].ShieldType == 6)
				{
					continue;
				}
				if (minLevel == 0 || self.LifeShieldList[i].Level < minLevel)
				{
					minLevel = self.LifeShieldList[i].Level;
				}
			}
			return minLevel;
		}

		public static int GetLifeShieldLevel(this SkillSetComponent self, int sType)
		{
			for (int i = 0; i < self.LifeShieldList.Count; i++)
			{
				if ((int)self.LifeShieldList[i].ShieldType == sType)
				{
					return self.LifeShieldList[i].Level;
				}
			}

			return 0;
		}
	}
}
