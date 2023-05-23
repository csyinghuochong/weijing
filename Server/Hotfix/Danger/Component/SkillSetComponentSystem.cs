
using System;
using System.Collections.Generic;

namespace ET
{

	//AwakeSystem 只会执行一次。。 StartSystem每次Add都会在下一帧执行
	public class SkillSetComponentAwakeSystem : AwakeSystem<SkillSetComponent>
	{
		public override void Awake(SkillSetComponent self)
		{
			self.TianFuPlan = 0;
			self.TianFuList.Clear();
			self.TianFuList1.Clear();

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
				self.SkillList.Add(new SkillPro() { SkillID = int.Parse(needList[0].Split(';')[0]), SkillPosition = 9, SkillSetType = (int)SkillSetEnum.Item });
				self.SkillList.Add(new SkillPro() { SkillID = int.Parse(needList[1].Split(';')[0]), SkillPosition = 10, SkillSetType = (int)SkillSetEnum.Item });
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

		public static List<int> TianFuList(this SkillSetComponent self)
		{
			//if (SkillHelp.NoTianFuAdd)
			{
				return self.TianFuPlan == 0 ? self.TianFuList : self.TianFuList1;
			}
			//else
			//{
			//	List<int> tianfulist = self.TianFuPlan == 0 ? self.TianFuList : self.TianFuList1;
			//	tianfulist.AddRange(self.TianFuAddition);
			//	return tianfulist;
			//}
        }

		public static List<int> TianFuListAll(this SkillSetComponent self)
		{
            List<int> list = new List<int>();

            List<int> tianfulist = self.TianFuPlan == 0 ? self.TianFuList : self.TianFuList1;
            for (int i = 0; i < tianfulist.Count; i++)
            {
                list.Add(tianfulist[i]);
            }

            list.AddRange(self.TianFuAddition);
            return list;
        }

		public static int HaveSameTianFu(this SkillSetComponent self, int tianfuId)
		{
			int tifuId = 0;
			TalentConfig talentConfig = TalentConfigCategory.Instance.Get(tianfuId);
			int learnLv = talentConfig.LearnRoseLv;
			List<int> tianfuList = self.TianFuList();

			for (int i = 0; i < tianfuList.Count; i++)
			{
				TalentConfig talentConfig2 = TalentConfigCategory.Instance.Get(tianfuList[i]);
				if (talentConfig2.LearnRoseLv == learnLv)
				{
					tifuId = tianfuList[i];
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
			List<int> tianfuList = self.TianFuList();
			for (int i = 0; i < tianfuList.Count; i++)
			{
				TalentConfig talentConfig2 = TalentConfigCategory.Instance.Get(tianfuList[i]);
				if (talentConfig2.LearnRoseLv == learnLv)
				{
					exist = true;
					self.AddTianFuAttribute(tianfuList[i], false);
					self.AddTianFuAttribute(tianfuId, true);
					tianfuList[i] = tianfuId;
					break;
				}
			}

			if (!exist)
			{
				tianfuList.Add(tianfuId);
				self.AddTianFuAttribute(tianfuId, true);
			}

			self.UpdateSkillSet();
			self.GetParent<Unit>().GetComponent<SkillPassiveComponent>().UpdatePassiveSkill();
		}

		public static void TianFuRemove(this SkillSetComponent self, int tianFuid)
		{
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

		public static void AddiontTianFu(this SkillSetComponent self, int tianFuid, bool active)
		{
			if (self.TianFuAddition.Contains(tianFuid) && !active)
			{
				self.TianFuAddition.Remove(tianFuid);
				self.AddTianFuAttribute(tianFuid, true);
			}
			if (!self.TianFuAddition.Contains(tianFuid) && active)
			{
				self.TianFuAddition.Add(tianFuid);
				self.AddTianFuAttribute(tianFuid, false);
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

			self.UpdateSkillSet();
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
			List<int> tianfuids = self.TianFuListAll();
			for (int i = 0; i < tianfuids.Count; i++)
			{
				if (TalentConfigCategory.Instance.Get(tianfuids[i]).AddPropreListStr != null && TalentConfigCategory.Instance.Get(tianfuids[i]).AddPropreListStr != "")
				{
					string[] addPropreListStr = TalentConfigCategory.Instance.Get(tianfuids[i]).AddPropreListStr.Split("@");

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

				string[] addProList = GameObjectParameter.Split(";");
				for (int p = 0; p < addProList.Length; p++ )
				{
					string[] addPro = addProList[p].Split(",");
					if (addPro.Length < 2)
					{
						break;
					}
					int key = int.Parse(addPro[0]);
					try
					{
						if (NumericHelp.GetNumericValueType(key) == 1)
						{
							proList.Add(new HideProList() { HideID = key, HideValue = long.Parse(addPro[1]) });
						}
						else
						{
							proList.Add(new HideProList() { HideID = key, HideValue = (int)(float.Parse(addPro[1]) * 10000) });
						}
					}
					catch (Exception ex)
					{
						Log.Error($"{ex.ToString()} {GameObjectParameter}");
					}
				}
            }
			return proList;
		}

		//和GetSkillRoleProLists方法一致 主要是获取类型为8的被动技能,8的被动技能不加战斗力
		public static List<HideProList> GetSkillRoleProLists_8(this SkillSetComponent self)
		{
			List<HideProList> proList = new List<HideProList>();
			for (int i = 0; i < self.SkillList.Count; i++)
			{
				if (self.SkillList[i].SkillSetType == (int)SkillSetEnum.Item)
				{
					continue;
				}

				SkillConfig skillConfig = SkillConfigCategory.Instance.Get(self.SkillList[i].SkillID);

				if (skillConfig.SkillType != (int)SkillTypeEnum.PassiveAddProSkillNoFight)
				{
					continue;
				}

				string GameObjectParameter = skillConfig.GameObjectParameter;
				if (ComHelp.IfNull(GameObjectParameter))
				{
					continue;
				}

				string[] addProList = GameObjectParameter.Split(";");
				for (int p = 0; p < addProList.Length; p++)
				{
					string[] addPro = addProList[p].Split(",");
					if (addPro.Length < 2)
					{
						break;
					}
					int key = int.Parse(addPro[0]);
					try
					{
						if (NumericHelp.GetNumericValueType(key) == 1)
						{
							proList.Add(new HideProList() { HideID = key, HideValue = long.Parse(addPro[1]) });
						}
						else
						{
							proList.Add(new HideProList() { HideID = key, HideValue = (int)(float.Parse(addPro[1]) * 10000) });
						}
					}
					catch (Exception ex)
					{
						Log.Error($"{ex.ToString()} {GameObjectParameter}");
					}
				}
			}
			return proList;
		}

		public static List<int> GetTianFuIdsByType(this SkillSetComponent self, string proType)
		{
			List<int> typeTianfus = new List<int>();
			List<int> tianfuIds = self.TianFuListAll();
			for (int i = 0; i < tianfuIds.Count; i++)
			{
				string[] addPropreListStr = TalentConfigCategory.Instance.Get(tianfuIds[i]).AddPropreListStr.Split("@");
				for (int k = 0; k < addPropreListStr.Length; k++)
				{
					string[] properInfo = addPropreListStr[k].Split(";");

					if (properInfo[0] != proType)
					{
						continue;
					}
					if (!typeTianfus.Contains(tianfuIds[i]))
					{
						typeTianfus.Add(tianfuIds[i]);
					}
				}
			}
			return typeTianfus;
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

		public static bool IsSkillSingingCancel(this SkillSetComponent self, int skillId)
		{
			List<int> tianfuids = self.GetTianFuIdsByType(TianFuProEnum.SkillSingingCancel);
			if (tianfuids.Count == 0)
				return  false;

			for (int i = 0; i < tianfuids.Count; i++)
			{
				string[] addPropreListStr = TalentConfigCategory.Instance.Get(tianfuids[i]).AddPropreListStr.Split("@");
				for (int k = 0; k < addPropreListStr.Length; k++)
				{
					string[] properInfo = addPropreListStr[k].Split(";");
					
					if (!properInfo[1].Contains(skillId.ToString()))
					{
						return true;
					}
				}
			}
			return false;
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
					if (properInfo[0] != TianFuProEnum.BuffPropertyAdd)
					{
						continue;
					}
					if (!properInfo[1].Contains(buffId.ToString()))
					{
						continue;
					}
					try
					{
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
					catch (Exception ex)
					{
						Log.Error($"GetBuffPropertyAdd: {tianfuids[i]}: " + ex.ToString());
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

			self.UpdateSkillSet();

			Function_Fight.GetInstance().UnitUpdateProperty_Base(self.GetParent<Unit>(), true, true);
			self.GetParent<Unit>().GetComponent<SkillPassiveComponent>().UpdatePassiveSkill();
		}

		public static void OnAddItemSkill(this SkillSetComponent self, List<int> itemSkills)
		{
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

			self.UpdateSkillSet();
		}

		public static void OnRmItemSkill(this SkillSetComponent self, List<int> itemSkills)
		{
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

			self.UpdateSkillSet();
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
			itemSkills.AddRange(bagInfo.InheritSkills);
			self.OnRmItemSkill( itemSkills );

			EquipConfig equipConfig = EquipConfigCategory.Instance.Get(itemConfig.ItemEquipID);
			self.TianFuRemove(equipConfig.TianFuId);
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
			itemSkills.AddRange(bagInfo.InheritSkills);
			self.OnAddItemSkill(itemSkills);

			EquipConfig equipConfig = EquipConfigCategory.Instance.Get(itemConfig.ItemEquipID);
			self.TianFuAdd(equipConfig.TianFuId);
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

			for (int i = self.SkillList.Count -1; i >= 0; i--)
			{
				if (self.SkillList[i].SkillID == 0)
				{
					self.SkillList.RemoveAt(i);	
				}
			}
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
		public static void OnAddSkillBook(this SkillSetComponent self, SkillSourceEnum skillSourceEnum, int skillId)
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

			self.UpdateSkillSet();
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

			self.UpdateSkillSet();
			return sp;
		}
		
		public static List<HideProList> GetShieldProLists(this SkillSetComponent self)
        {
			List<HideProList> proList = new List<HideProList>();
			for (int i = 0; i < self.LifeShieldList.Count; i++)
			{
				if (self.LifeShieldList[i].Level == 0)
				{
					continue;
				}

				int lifeShiledid = LifeShieldConfigCategory.Instance.GetShieldId(self.LifeShieldList[i].ShieldType, self.LifeShieldList[i].Level);
				if (lifeShiledid == 0)
				{
					continue;
				}

				LifeShieldConfig lifeShieldConfig = LifeShieldConfigCategory.Instance.Get(lifeShiledid);
				string[] attributeInfoList = lifeShieldConfig.AddProperty.Split('@');
				for (int a = 0; a < attributeInfoList.Length; a++)
				{
					string[] attributeInfo = attributeInfoList[a].Split(';');
					int numericType = int.Parse(attributeInfo[0]);

					if (NumericHelp.GetNumericValueType(numericType) == 2)
					{
						float fvalue = float.Parse(attributeInfo[1]);
						proList.Add(new HideProList() { HideID = numericType, HideValue = (long)(fvalue * 10000) });
					}
					else
					{
						long lvalue = 0;
						try
						{
							lvalue = long.Parse(attributeInfo[1]);
						}
						catch (Exception ex)
						{
							Log.Debug(ex.ToString() + $"报错LifeShield: {lifeShiledid}");
						}

						proList.Add(new HideProList() { HideID = numericType, HideValue = lvalue });
					}
				}
			}
			return proList;	
        }

		public static void OnShieldAddExp(this SkillSetComponent self, int shieldType, int addExp) 
		{
			LifeShieldInfo keyValuePair = null;
			for (int i = 0; i < self.LifeShieldList.Count; i++)
			{
				if ((int)self.LifeShieldList[i].ShieldType == shieldType)
				{
					keyValuePair = self.LifeShieldList[i];
				}
			}
			if (keyValuePair == null)
			{
				//默认0级 0经验
				keyValuePair = new LifeShieldInfo() { ShieldType = shieldType, Level = 0, Exp = 0 };
				self.LifeShieldList.Add(keyValuePair);
			}

			int curLv = keyValuePair.Level;
			int curExp = keyValuePair.Exp;
			int maxLv= LifeShieldConfigCategory.Instance.LifeShieldList[shieldType].Count;
			if (curLv == maxLv)
			{
				curExp += addExp;
				keyValuePair.Exp = curExp;
				return;
			}

			int nextlifeId = LifeShieldConfigCategory.Instance.LifeShieldList[shieldType][curLv + 1];
			LifeShieldConfig lifeShieldConfig = LifeShieldConfigCategory.Instance.Get(nextlifeId);
			if (curExp + addExp < lifeShieldConfig.ShieldExp)
			{
				curExp += addExp;
				keyValuePair.Exp = curExp;
				return;
			}

			//可以升级
			keyValuePair.Level = (curLv + 1);
			keyValuePair.Exp = (curExp + addExp - lifeShieldConfig.ShieldExp);
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

			self.UpdateSkillSet();
		}

		public static void UpdateSkillSet(this SkillSetComponent self)
		{
			SkillSetInfo SkillSetInfo = self.M2C_SkillSetMessage.SkillSetInfo;
			SkillSetInfo.TianFuPlan = self.TianFuPlan;
			SkillSetInfo.TianFuList = self.TianFuList;
			SkillSetInfo.TianFuList1 = self.TianFuList1;
			SkillSetInfo.SkillList = self.SkillList;
			SkillSetInfo.LifeShieldList = self.LifeShieldList;

			MessageHelper.SendToClient( self.GetParent<Unit>(), self.M2C_SkillSetMessage);
		}
	}
}
