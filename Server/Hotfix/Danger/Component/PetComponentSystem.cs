using System;
using System.Linq;
using System.Collections.Generic;

namespace ET
{

    public static class PetComponentSystem
    {
        public static void CheckPetList(this PetComponent self, List<long> petList)
        {
            for (int i = petList.Count - 1; i >= 0; i--)
            {
                if (petList[i]!= 0 && self.GetPetInfo(petList[i]) == null)
                {
                    petList[i] = 0;
                }
            }
        }

        public static void InitPetInfo(this PetComponent self)
        {
            if (self.RolePetEggs == null || self.RolePetEggs.Count == 0)
            {
                for (int i = 0; i < 3; i++)
                {
                    self.RolePetEggs.Add(new RolePetEgg());
                }
            }
            if (self.PetFormations == null || self.PetFormations.Count != 9)
            {
                self.PetFormations.Clear();
                for (int i = 0; i < 9; i++)
                {
                    self.PetFormations.Add(0);
                }
            }
            if (self.TeamPetList == null || self.TeamPetList.Count != 9)
            {
                self.TeamPetList.Clear();
                for (int i = 0; i < 9; i++)
                {
                    self.TeamPetList.Add(0);
                }
            }
            self.CheckPetList(self.PetFormations);
            self.CheckPetList(self.TeamPetList);

            List<PetConfig> petConfigs = PetConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < petConfigs.Count; i++)
            {
                bool havepet = false;
                for (int p = 0; p < self.PetSkinList.Count; p++)
                {
                    if (self.PetSkinList[p].KeyId == petConfigs[i].Id)
                    {
                        havepet = true;
                        break;
                    }
                }
                if (!havepet)
                {
                    self.PetSkinList.Add(new KeyValuePair() { KeyId = petConfigs[i].Id, Value = petConfigs[i].Skin[0].ToString() });
                }
            }
            for (int i = 0; i < self.RolePetInfos.Count; i++)
            {
                if (self.RolePetInfos[i].PetHeXinList.Count == 0)
                {
                    self.RolePetInfos[i].PetHeXinList = new List<long>() { 0, 0, 0 };
                }
            }
        }

        //获取新宠物
        public static RolePetInfo GenerateNewPet(this PetComponent self, int petId, int skinId)
        {
            PetConfig petConfig = PetConfigCategory.Instance.Get(petId);
            RolePetInfo newpet = new RolePetInfo();
            newpet.Id = IdGenerater.Instance.GenerateId();
            newpet.PetStatus = 0;
            newpet.ConfigId = petConfig.Id;
            newpet.PetLv = petConfig.PetLv;
            newpet.PetExp = 0;
            newpet.PetName = petConfig.PetName;
            newpet.IfBaby = true;
            newpet.SkinId = skinId != 0 ? skinId : petConfig.Skin[0];
            newpet.PetHeXinList = new List<long>() { 0, 0, 0 };
            newpet.AddPropretyNum = 0;
            newpet.AddPropretyValue = "0_0_0_0";
            return newpet;
        }

        /// <summary>
        /// 宠物洗炼
        /// </summary>
        /// <param name="self"></param>
        /// <param name="rolePetInfo"></param>
        /// <param name="XiLianType"> 1 表示出生  2 表示洗炼 </param>
        /// <returns></returns>
        public static RolePetInfo PetXiLian(this PetComponent self, RolePetInfo rolePetInfo,int XiLianType) {

            PetConfig petConfig = PetConfigCategory.Instance.Get(rolePetInfo.ConfigId);
           
            rolePetInfo.PetPingFen = int.Parse(petConfig.Base_PingFen);
            rolePetInfo.ZiZhi_Hp = RandomHelper.RandomNumber(petConfig.ZiZhi_Hp_Min, petConfig.ZiZhi_Hp_Max);
            rolePetInfo.ZiZhi_Act = RandomHelper.RandomNumber(petConfig.ZiZhi_Act_Min, petConfig.ZiZhi_Act_Max);
            rolePetInfo.ZiZhi_MageAct = RandomHelper.RandomNumber(petConfig.ZiZhi_MageAct_Min, petConfig.ZiZhi_MageAct_Max);
            rolePetInfo.ZiZhi_Def = RandomHelper.RandomNumber(petConfig.ZiZhi_Def_Min, petConfig.ZiZhi_Def_Max);
            rolePetInfo.ZiZhi_Adf = RandomHelper.RandomNumber(petConfig.ZiZhi_Adf_Min, petConfig.ZiZhi_Adf_Max);
            rolePetInfo.ZiZhi_ActSpeed = RandomHelper.RandomNumber(petConfig.ZiZhi_ActSpeed_Min, petConfig.ZiZhi_ActSpeed_Max);
            rolePetInfo.ZiZhi_ChengZhang = (float)petConfig.ZiZhi_ChengZhang_Min;

            //表示出生创建
            if (XiLianType == 1) 
            {
                int minStart = petConfig.InitStartNum[0];
                int maxStart = petConfig.InitStartNum[1];
                rolePetInfo.Star = RandomHelper.RandomNumber(minStart, maxStart);
            }

            string[] skilll = petConfig.BaseSkillID.Split(';');
            rolePetInfo.PetSkill = new List<int>();
            for (int i = 0; i < skilll.Length; i++)
            {
                if (skilll[i] == "0")
                {
                    continue;
                }
                rolePetInfo.PetSkill.Add(int.Parse(skilll[i]));
            }

            //增加宠物专注技能
            skilll = petConfig.ZhuanZhuSkillID.Split(';');
            for (int i = 0; i < skilll.Length; i++)
            {
                if (skilll[i] == "0")
                {
                    continue;
                }
                rolePetInfo.PetSkill.Add(int.Parse(skilll[i]));
            }

            //增加宠物随机技能
            string randomSkillID = petConfig.RandomSkillID;
            if (randomSkillID != "" && randomSkillID != "0")
            {
                string[] randomSkillList = randomSkillID.Split(';');
                for (int i = 0; i < randomSkillList.Length; i++)
                {
                    int skillID = int.Parse(randomSkillList[i]);
                    if (RandomHelper.RandFloat() <= 0.25f)
                    {
                        rolePetInfo.PetSkill.Add(skillID);
                    }
                }
            }

            return rolePetInfo;
        }

        public static RolePetInfo OnAddPet(this PetComponent self, int petId, int skinId = 0)
        {
            RolePetInfo newpet = self.GenerateNewPet(petId, skinId);
            newpet = self.PetXiLian(newpet, 1);
            self.UpdatePetAttribute(newpet);
            self.RolePetInfos.Add(newpet);
            M2C_RolePetUpdate m2C_RolePetUpdate = new M2C_RolePetUpdate();
            m2C_RolePetUpdate.PetInfoAdd = new List<RolePetInfo>();
            m2C_RolePetUpdate.PetInfoAdd.Add(newpet);

            self.GetParent<Unit>().GetComponent<ChengJiuComponent>().OnGetPet(newpet);
            self.GetParent<Unit>().GetComponent<TaskComponent>().OnGetPet();
            MessageHelper.SendToClient( self.GetParent<Unit>(), m2C_RolePetUpdate);

            return newpet;
        }

        //击杀怪物,增加经验等
        public static void OnKillUnit(this PetComponent self, Unit beKill)
        {
            RolePetInfo rolePetInfo = self.GetFightPet();
            if (rolePetInfo == null)
            {
                return;
            }
            if (beKill.Type != UnitType.Monster)
            {
                return;
            }
            MonsterConfig mCof = MonsterConfigCategory.Instance.Get(beKill.ConfigId);
            int playerLv = self.GetParent<Unit>().GetComponent<UserInfoComponent>().UserInfo.Lv;
            if (rolePetInfo.PetLv >= playerLv + 5)
            {
                return;
            }
            Unit petUnit = self.GetParent<Unit>().DomainScene().GetComponent<UnitComponent>().Get(rolePetInfo.Id);
            self.PetAddExp(rolePetInfo, mCof.Exp, petUnit);
        }

        public static void UpdatePetZiZhi(this PetComponent self, RolePetInfo rolePetInfo, int itemId)
        {
            //10,30;10,30;10,30;10,30;10,30
            PetConfig petConfig = PetConfigCategory.Instance.Get(rolePetInfo.ConfigId);
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(itemId);
            string[] zishiList = itemConfig.ItemUsePar.Split(';');

            string[] ZiZhi_Hp = zishiList[0].Split(',');
            string[] ZiZhi_Act = zishiList[1].Split(',');
            string[] ZiZhi_Def = zishiList[2].Split(',');
            string[] ZiZhi_Adf = zishiList[3].Split(',');
            string[] ZiZhi_MageAct = zishiList[4].Split(',');
            rolePetInfo.ZiZhi_Hp +=  RandomHelper.RandomNumber(int.Parse(ZiZhi_Hp[0]), int.Parse(ZiZhi_Hp[1]));
            rolePetInfo.ZiZhi_Act += RandomHelper.RandomNumber(int.Parse(ZiZhi_Act[0]), int.Parse(ZiZhi_Act[1]));
            rolePetInfo.ZiZhi_Def += RandomHelper.RandomNumber(int.Parse(ZiZhi_Def[0]), int.Parse(ZiZhi_Def[1]));
            rolePetInfo.ZiZhi_Adf += RandomHelper.RandomNumber(int.Parse(ZiZhi_Adf[0]), int.Parse(ZiZhi_Adf[1]));
            rolePetInfo.ZiZhi_MageAct += RandomHelper.RandomNumber(int.Parse(ZiZhi_MageAct[0]), int.Parse(ZiZhi_MageAct[1]));

            rolePetInfo.ZiZhi_Hp = Math.Min(rolePetInfo.ZiZhi_Hp, petConfig.ZiZhi_Hp_Max);
            rolePetInfo.ZiZhi_Act = Math.Min(rolePetInfo.ZiZhi_Act, petConfig.ZiZhi_Act_Max);
            rolePetInfo.ZiZhi_Def = Math.Min(rolePetInfo.ZiZhi_Def, petConfig.ZiZhi_Def_Max);
            rolePetInfo.ZiZhi_Adf = Math.Min(rolePetInfo.ZiZhi_Adf, petConfig.ZiZhi_Adf_Max);
            rolePetInfo.ZiZhi_MageAct = Math.Min(rolePetInfo.ZiZhi_MageAct,petConfig.ZiZhi_MageAct_Max);
        }

        public static void UpdatePetChengZhang(this PetComponent self, RolePetInfo rolePetInfo, int itemId)
        {
            PetConfig petConfig = PetConfigCategory.Instance.Get(rolePetInfo.ConfigId);
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(itemId);
            string[] addinfo = itemConfig.ItemUsePar.Split(',');
            float addChengZhang = RandomHelper.RandomNumberFloat(float.Parse(addinfo[0]), float.Parse(addinfo[1]));
            rolePetInfo.ZiZhi_ChengZhang += addChengZhang;
            rolePetInfo.ZiZhi_ChengZhang = Math.Min(rolePetInfo.ZiZhi_ChengZhang, (float)petConfig.ZiZhi_ChengZhang_Max);
        }

        //重置属性点
        public static void OnResetPoint(this PetComponent self, RolePetInfo rolePetInfo)
        {
            rolePetInfo.AddPropretyNum =( rolePetInfo.PetLv - 1 ) * 5;
            rolePetInfo.AddPropretyValue = "0_0_0_0";
            self.UpdatePetAttribute(rolePetInfo, null);
        }

        //增加经验
        public static void PetAddLv(this PetComponent self, RolePetInfo rolePetInfo, int lv, Unit unitPet = null)
        {
            if (rolePetInfo == null)
            {
                return;
            }
            int playerLv = self.GetParent<Unit>().GetComponent<UserInfoComponent>().UserInfo.Lv;
            int newLevel = rolePetInfo.PetLv + lv;
            newLevel = Math.Min(Math.Max(0, newLevel), playerLv + 5);
            rolePetInfo.AddPropretyNum += (newLevel - rolePetInfo.PetLv) * 5;
            rolePetInfo.PetLv = newLevel;

            //刷新属性
            self.UpdatePetAttribute(rolePetInfo, unitPet);

            //通知客户端
            MessageHelper.SendToClient(self.GetParent<Unit>(), new M2C_PetDataUpdate() { UpdateType = (int)UserDataType.Lv, PetId = rolePetInfo.Id, UpdateTypeValue = rolePetInfo.PetLv.ToString() });
            MessageHelper.SendToClient(self.GetParent<Unit>(), new M2C_PetDataBroadcast() {  UnitId = self.GetParent<Unit>().Id, UpdateType = (int)UserDataType.Lv, PetId = rolePetInfo.Id, UpdateTypeValue = rolePetInfo.PetLv.ToString() });
        }

        public static void OnPetDead(this PetComponent self, long petId)
        {
            RolePetInfo petinfo = self.GetPetInfo(petId);
            petinfo.PetStatus = 0;
            MessageHelper.SendToClient(self.GetParent<Unit>(), new M2C_PetDataUpdate() { UpdateType = (int)UserDataType.PetStatus, PetId = petId, UpdateTypeValue = "0" });
        }

        //增加等级
        public static void PetAddExp(this PetComponent self, RolePetInfo rolePetInfo, int exp, Unit unitpet = null)
        {
            if (rolePetInfo == null)
            {
                return;
            }

            int newExp = rolePetInfo.PetExp + exp;
            ExpConfig xiulianconf1 = ExpConfigCategory.Instance.Get(rolePetInfo.PetLv);
            if (newExp >= xiulianconf1.PetUpExp)
            {
                self.PetAddLv(rolePetInfo, 1, unitpet);
                newExp -= xiulianconf1.PetUpExp;
            }
            rolePetInfo.PetExp = newExp;

            //通知客户端
            MessageHelper.SendToClient(self.GetParent<Unit>(), new M2C_PetDataUpdate() { UpdateType = (int)UserDataType.Exp, PetId = rolePetInfo.Id, UpdateTypeValue = rolePetInfo.PetExp.ToString() });
        }

        public static long GetByKey(this PetComponent self, RolePetInfo rolePetInfo, int numericType)
        {
            for (int i = 0; i < rolePetInfo.Ks.Count; i++)
            {
                if (rolePetInfo.Ks[i] == numericType)
                {
                    return rolePetInfo.Vs[i];
                }
            }
            return 0;
        }

        public static float GetAsFloat(this PetComponent self, RolePetInfo rolePetInfo, int numericType)
        {
            return (float)self.GetByKey(rolePetInfo, numericType) / 10000;
        }

        public static void UpdatePetAttribute(this PetComponent self, RolePetInfo rolePetInfo, Unit petUnit = null)
        {
            //获取宠物资质
            float actPro = 1f - ((1500 - rolePetInfo.ZiZhi_Act) / 750.0f);
            float magePro = 1f - ((1500 - rolePetInfo.ZiZhi_MageAct) / 750.0f);
            float defPro = 1f - ((1500 - rolePetInfo.ZiZhi_Def) / 750.0f);
            float adfPro = 1f - ((1500 - rolePetInfo.ZiZhi_Def) / 750.0f);
            float hpPro = 1f - ((3000 - rolePetInfo.ZiZhi_Hp) / 1500.0f);

            //属性加点对应属性 力量-攻击 智力-魔法 体质-血量 耐力就是物防和魔防
            PetConfig petCof = PetConfigCategory.Instance.Get(rolePetInfo.ConfigId);

            //获取加点属性
            string[] attributeinfos = rolePetInfo.AddPropretyValue.Split('_');
            int pro_LiLiang = int.Parse(attributeinfos[0]);          //力量
            int pro_ZhiLi = int.Parse(attributeinfos[1]);            //智力
            int pro_TiZhi = int.Parse(attributeinfos[2]);            //体制
            int pro_NaiLi = int.Parse(attributeinfos[3]);            //耐力


            int act_Now = (int)((petCof.Base_Act + rolePetInfo.PetLv * petCof.Lv_Act + pro_LiLiang * 10) * actPro * rolePetInfo.ZiZhi_ChengZhang);
            int mage_Now = (int)((petCof.Base_MageAct + rolePetInfo.PetLv * petCof.Lv_MageAct + pro_ZhiLi * 10) * magePro * rolePetInfo.ZiZhi_ChengZhang);
            int hp_Now = (int)((petCof.Base_Hp + rolePetInfo.PetLv * petCof.Lv_Hp + pro_TiZhi * 40 + pro_NaiLi * 10) * hpPro * rolePetInfo.ZiZhi_ChengZhang);
            int def_Now = (int)((petCof.Base_Def + rolePetInfo.PetLv * petCof.Lv_Def + pro_NaiLi * 5) * defPro * rolePetInfo.ZiZhi_ChengZhang);
            int adf_Now = (int)((petCof.Base_Adf + rolePetInfo.PetLv * petCof.Lv_Adf + pro_NaiLi * 5) * adfPro * rolePetInfo.ZiZhi_ChengZhang);

            float speed = 5f;
            
            //存储数据
            rolePetInfo.Ks.Clear();
            rolePetInfo.Vs.Clear();

            rolePetInfo.Ks.Add((int)NumericType.Base_Speed_Base);
            rolePetInfo.Vs.Add((long)speed * 10000);

            rolePetInfo.Ks.Add((int)NumericType.Now_Speed);
            rolePetInfo.Vs.Add((long)speed * 10000);

            rolePetInfo.Ks.Add((int)NumericType.Now_Hp);
            rolePetInfo.Vs.Add(hp_Now);

            rolePetInfo.Ks.Add((int)NumericType.Now_MaxHp);
            rolePetInfo.Vs.Add(hp_Now);

            rolePetInfo.Ks.Add((int)NumericType.Now_MaxAct);
            rolePetInfo.Vs.Add(act_Now);

            rolePetInfo.Ks.Add((int)NumericType.Now_Mage);
            rolePetInfo.Vs.Add(mage_Now);

            rolePetInfo.Ks.Add((int)NumericType.Now_MaxDef);
            rolePetInfo.Vs.Add(def_Now);

            rolePetInfo.Ks.Add((int)NumericType.Now_MaxAdf);
            rolePetInfo.Vs.Add(adf_Now);

            rolePetInfo.Ks.Add((int)NumericType.PetSkin);
            rolePetInfo.Vs.Add(rolePetInfo.SkinId);

            rolePetInfo.Ks.Add((int)NumericType.Now_Cri);
            rolePetInfo.Vs.Add(0);

            rolePetInfo.Ks.Add((int)NumericType.Now_Res);
            rolePetInfo.Vs.Add(0);

            rolePetInfo.Ks.Add((int)NumericType.Now_Hit);
            rolePetInfo.Vs.Add(0);

            rolePetInfo.Ks.Add((int)NumericType.Now_Dodge);
            rolePetInfo.Vs.Add(0);

            //宠物之核
            Dictionary<int, long> attriDic = new Dictionary<int, long>();
            BagComponent bagComponent = self.GetParent<Unit>().GetComponent<BagComponent>();
            for (int i = 0; i < rolePetInfo.PetHeXinList.Count; i++)
            {
                long baginfoId = rolePetInfo.PetHeXinList[i];
                if (baginfoId == 0)
                {
                    continue;
                }

                BagInfo bagInfo = bagComponent.GetItemByLoc(ItemLocType.ItemPetHeXinEquip, baginfoId);
                //100203;790
                string attriStr = ItemConfigCategory.Instance.Get(bagInfo.ItemID).ItemUsePar;
                string[] attriList = attriStr.Split('@');
                for (int a = 0; a < attriList.Length; a++ )
                {
                    try
                    {
                        string[] attriItem = attriList[a].Split(';');
                        int typeId = int.Parse(attriItem[0]);
                        Function_Fight.AddUpdateProDicList(typeId, NumericHelp.GetNumericValueType(typeId) == 2 ? (long)(10000 * float.Parse(attriItem[1])) : long.Parse(attriItem[1]), attriDic);
                    }
                    catch(Exception ex)
                    {
                        Log.Info($"attriStrexc Eption： {attriStr} {ex.ToString()}");
                    }
                }
            }
            foreach (var item in attriDic)
            {
                int numericType = item.Key;
                int nowValue = (int)numericType / 100;
                int attriIndex = rolePetInfo.Ks.IndexOf(nowValue);
                rolePetInfo.Vs[attriIndex] += item.Value;
            }

            //如果是出战的宠物。再广播一下属性
            if (petUnit == null)
            {
                return;
            }
            NumericComponent numericComponent = petUnit.GetComponent<NumericComponent>();
            numericComponent.ApplyValue(NumericType.Now_Hp, self.GetByKey(rolePetInfo, NumericType.Now_Hp), true);
            numericComponent.ApplyValue(NumericType.Now_MaxHp, self.GetByKey(rolePetInfo, NumericType.Now_MaxHp), true);
            numericComponent.ApplyValue(NumericType.Now_MaxAct, self.GetByKey(rolePetInfo, NumericType.Now_MaxAct), true);
            numericComponent.ApplyValue(NumericType.Now_Mage, self.GetByKey(rolePetInfo, NumericType.Now_Mage), true);
            numericComponent.ApplyValue(NumericType.Now_MaxDef, self.GetByKey(rolePetInfo, NumericType.Now_MaxDef), true);
            numericComponent.ApplyValue(NumericType.Now_MaxAdf, self.GetByKey(rolePetInfo, NumericType.Now_MaxAdf), true);
        }

        public static void RemovePet(this PetComponent self, long petId)
        {
            for (int i = self.RolePetInfos.Count - 1; i>= 0; i--)
            {
                if (self.RolePetInfos[i].Id == petId)
                {
                    self.RolePetInfos.RemoveAt(i);
                    break;
                }
            }

            self.ResetFormation(self.PetFormations, petId);
            self.ResetFormation(self.TeamPetList, petId);
        }

        /// <summary>
        /// Get可以取缓存数据，不用读缓存数据库
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static RolePetInfo GetPetInfo(this PetComponent self, long PetId)
        {
            RolePetInfo petInfo = null;
            for (int i = 0; i < self.RolePetInfos.Count; i++)
            {
                if (self.RolePetInfos[i].Id == PetId)
                {
                    return self.RolePetInfos[i];
                }
            }

            return petInfo;
        }

        public static long GetFightPetId(this PetComponent self)
        {
            RolePetInfo rolePetInfo = self.GetFightPet();
            return rolePetInfo != null ? rolePetInfo.Id : 0;
        }

        public static RolePetInfo GetFightPet(this PetComponent self)
        {
            RolePetInfo petId = null;
            for (int i = 0; i < self.RolePetInfos.Count; i++)
            {
                if (self.RolePetInfos[i].PetStatus == 1)
                {
                    petId = self.RolePetInfos[i];
                }
            }
            return petId;
        }

        public static void OnRolePetFenjie(this PetComponent self, long petId)
        {
            for (int i = self.RolePetInfos.Count - 1; i >= 0; i--)
            {
                if (self.RolePetInfos[i].Id == petId)
                {
                    int cofID = self.RolePetInfos[i].ConfigId;
                    self.RolePetInfos.RemoveAt(i);

                 
                    break;
                }
            }
        }

        public static List<RolePetInfo> GetAllPets(this PetComponent self)
        {
            for (int i = 0; i < self.RolePetInfos.Count; i++)
            {
                RolePetInfo rolePetInfo = self.RolePetInfos[i];
                if (string.IsNullOrEmpty(rolePetInfo.AddPropretyValue))
                {
                    rolePetInfo.AddPropretyNum = (rolePetInfo.PetLv - 1) * 5;
                    rolePetInfo.AddPropretyValue = "0_0_0_0";
                }
            }
            return self.RolePetInfos;
        }

        public static int GetTotalStar(this PetComponent self)
        {
            int star = 0;
            for (int i = 0; i < self.PetFubenInfos.Count; i++)
            {
                star += self.PetFubenInfos[i].Star;
            }

            return star;
        }

        /// <summary>
        /// 获取可以领取的最小星级奖励
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static int GetCanRewardId(this PetComponent self)
        {
            int rewardId = 0;
            int totalStar = self.GetTotalStar();
            List<PetFubenRewardConfig> rewardConfigs = PetFubenRewardConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < rewardConfigs.Count; i++)
            {
                if (rewardConfigs[i].NeedStar <= totalStar
                    && rewardConfigs[i].Id > self.PetFubeRewardId)
                {
                    rewardId = rewardConfigs[i].Id;
                    break;
                }
            }

            return rewardId;
        }

        public static void OnUnlockSkin(this PetComponent self, string skininfo)
        {
            string[] petskininfo = skininfo.Split(';');
            int petId = int.Parse(petskininfo[0]);
            int skinId = int.Parse(petskininfo[1]);
        
            for (int p = 0; p < self.PetSkinList.Count; p++)
            {
                if (self.PetSkinList[p].KeyId != petId)
                {
                    continue;
                }
                if (!self.PetSkinList[p].Value.Contains(skinId.ToString()))
                {
                    self.PetSkinList[p].Value += ("_" + skinId.ToString());
                }
            }
        }

        public static void ResetFormation(this PetComponent self, List<long> formation, long petId)
        {
            for (int i = 0; i < formation.Count; i++)
            {
                if (formation[i] == petId)
                {
                    formation[i] = 0;
                }
            }
        }

        public static void OnPassPetFuben(this PetComponent self, int petfubenId, int star)
        {
            for (int i = 0; i < self.PetFubenInfos.Count; i++)
            {
                if (self.PetFubenInfos[i].PetFubenId == petfubenId)
                {
                    self.PetFubenInfos[i].Star = star > self.PetFubenInfos[i].Star ? star : self.PetFubenInfos[i].Star;
                    return;
                }
            }
            self.PetFubenInfos.Add( new PetFubenInfo() { PetFubenId = petfubenId, Star = star, Reward = 0 } );
        }
    }
}
