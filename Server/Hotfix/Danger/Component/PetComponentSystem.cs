using System;
using System.Linq;
using System.Collections.Generic;

namespace ET
{

    public static class PetComponentSystem
    {

        public static List<HideProList> GetPetShouHuPro(this PetComponent self)
        {
            List<HideProList> proList = new List<HideProList>();
            if (self.PetShouHuActive == 0)
            {
                return proList;
            }

            int fightNum = 0;
            int nowNum = 0;
            for (int i = 0; i < 4; i++)
            {
                RolePetInfo rolePetInfoNow = self.GetPetInfo(self.PetShouHuList[i]);
                if (rolePetInfoNow == null)
                {
                    continue;
                }
                fightNum = fightNum + rolePetInfoNow.PetPingFen;
                if (i == (self.PetShouHuActive -1)) 
                {
                    nowNum = rolePetInfoNow.PetPingFen;
                }
            }

            //增加属性
            float addFloat = ComHelp.GetPetShouHuPro(nowNum,fightNum);
            HideProList hide = new HideProList();
            hide.HideID = int.Parse(ConfigHelper.PetShouHuAttri[self.PetShouHuActive - 1].Value2);
            hide.HideValue = (long)(addFloat * 10000);
            proList.Add(hide);

            return proList;
        }


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
            if (self.RolePetEggs.Count == 0)
            {
                for (int i = 0; i < 3; i++)
                {
                    self.RolePetEggs.Add(new RolePetEgg());
                }
            }
            if (self.PetFormations.Count != 9)
            {
                self.PetFormations.Clear();
                for (int i = 0; i < 9; i++)
                {
                    self.PetFormations.Add(0);
                }
            }
            if (self.TeamPetList.Count != 9)
            {
                self.TeamPetList.Clear();
                for (int i = 0; i < 9; i++)
                {
                    self.TeamPetList.Add(0);
                }
            }
            if ( self.PetShouHuList.Count != 4)
            {
                self.PetShouHuList.Clear();
                for (int i = 0; i < 4; i++)
                {
                    self.PetShouHuList.Add(0);
                }
            }
            self.CheckPetList(self.PetFormations);
            self.CheckPetList(self.TeamPetList);
            self.CheckPetList(self.PetShouHuList);

            if (self.PetShouHuActive == 0)
            {
                self.PetShouHuActive = 1;
            }
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
                    self.PetSkinList.Add(new KeyValuePair() { KeyId = petConfigs[i].Id, Value = String.Empty });
                }
            }

            Unit unit = self.GetParent<Unit>();
            UserInfo userInfo = unit.GetComponent<UserInfoComponent>().UserInfo;
            for (int i = 0; i < self.RolePetInfos.Count; i++)
            {
                RolePetInfo rolePetInfo = self.RolePetInfos[i];
                rolePetInfo.PlayerName = userInfo.Name;
                if (rolePetInfo.PetHeXinList.Count == 0)
                {
                    rolePetInfo.PetHeXinList = new List<long>() { 0, 0, 0 };
                }
                if (rolePetInfo.ShouHuPos == 0)
                {
                    rolePetInfo.ShouHuPos = RandomHelper.RandomNumber(1, 5);
                }
                if (PetHelper.IsShenShou(rolePetInfo.ConfigId))
                {
                    for (int skill = rolePetInfo.PetSkill.Count - 1; skill >= 0; skill--)
                    {
                        int skillid = rolePetInfo.PetSkill[skill];
                        if (skillid >= 80001001 && skillid <= 80001028)
                        {
                            rolePetInfo.PetSkill.RemoveAt(skill);
                        }
                    }
                    rolePetInfo.ShouHuPos = 5;
                }
            }
        }

        //获取新宠物
        public static RolePetInfo GenerateNewPet(this PetComponent self, int petId, int skinId)
        {
            Unit unit = self.GetParent<Unit>();
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
            newpet.ShouHuPos = RandomHelper.RandomNumber(1, 5);
            newpet.PlayerName = unit.GetComponent<UserInfoComponent>().UserInfo.Name;
            return newpet;
        }

        //取随机值 保留两位
        public static float RandomNumberFloatKeep2(this PetComponent self, float lower, float upper)
        {

            float value = lower + ((upper - lower) * RandomHelper.RandFloat());
            return (float)Math.Round(value, 2);
        }

        public static void OnLogin(this PetComponent self)
        {
            self.CheckPetPingFen();
            self.CheckPetZiZhi();
        }

        public static void CheckPetPingFen(this PetComponent self)
        {
            Unit unit = self.GetParent<Unit>();
            int maxping = self.GetPetMaxPingFen();

            unit.GetComponent<ChengJiuComponent>().TriggerEvent(ChengJiuTargetEnum.PegScoreToValue_307, 0, maxping);

            int arrayping = self.GetPetArrayPingFen();
            unit.GetComponent<ChengJiuComponent>().TriggerEvent(ChengJiuTargetEnum.PetArrayScoreToValue_308, 0, arrayping);
        }

        public static void CheckPetZiZhi(this PetComponent self)
        {
            Unit unit = self.GetParent<Unit>();
            unit.GetComponent<ChengJiuComponent>().TriggerEvent(ChengJiuTargetEnum.ZiZhiToValue_311, 1, self.GetPetMaxZiZhi(1));
            unit.GetComponent<ChengJiuComponent>().TriggerEvent(ChengJiuTargetEnum.ZiZhiToValue_311, 2, self.GetPetMaxZiZhi(2));
            unit.GetComponent<ChengJiuComponent>().TriggerEvent(ChengJiuTargetEnum.ZiZhiToValue_311, 3, self.GetPetMaxZiZhi(3));
            unit.GetComponent<ChengJiuComponent>().TriggerEvent(ChengJiuTargetEnum.ZiZhiToValue_311, 4, self.GetPetMaxZiZhi(4));
            unit.GetComponent<ChengJiuComponent>().TriggerEvent(ChengJiuTargetEnum.ZiZhiToValue_311, 5, self.GetPetMaxZiZhi(5));
        }

        public static int GetPetMaxZiZhi(this PetComponent self, int zizhiType)
        {
            int maxPing = 0;
            for (int i = 0; i < self.RolePetInfos.Count; i++)
            {
                int zishi = 0;
                switch (zizhiType)
                {
                   
                    case 1: //="获得宠物生命资质超过"&K386&"点"
                        zishi = self.RolePetInfos[i].ZiZhi_Hp;
                        break;
                    case 2: //="获得宠物攻击资质超过"&K387&"点"
                        zishi = self.RolePetInfos[i].ZiZhi_Act;
                        break;
                    case 3: //="获得宠物物防资质超过"&K388&"点"
                        zishi = self.RolePetInfos[i].ZiZhi_Def;
                        break;
                    case 4: //="获得宠物魔防资质超过"&K389&"点"
                        zishi = self.RolePetInfos[i].ZiZhi_Adf;
                        break;
                    case 5: //="获得宠物魔法资质超过"&K390&"点"
                        zishi = self.RolePetInfos[i].ZiZhi_MageAct;
                        break;
                }

                if (zishi >= maxPing)
                {
                    maxPing = zishi;
                }
            }
            return maxPing;
        }

        public static int GetPetMaxPingFen(this PetComponent self)
        {
            int maxPing = 0;
            for (int i = 0; i < self.RolePetInfos.Count; i++)
            {
                if (self.RolePetInfos[i].PetPingFen >= maxPing)
                {
                    maxPing = self.RolePetInfos[i].PetPingFen;
                }
            }
            return maxPing;
        }

        public static int GetPetArrayPingFen(this PetComponent self)
        {
            int pingfen_1 = 0;
            int pingfen_2 = 0;
            for (int i = 0; i < self.TeamPetList.Count; i++)
            {
                RolePetInfo rolePetInfo = self.GetPetInfo(self.TeamPetList[i]);
                if (rolePetInfo!= null)
                {
                    pingfen_1 += rolePetInfo.PetPingFen;
                }
            }
            for (int i = 0; i < self.PetFormations.Count; i++)
            {
                RolePetInfo rolePetInfo = self.GetPetInfo(self.PetFormations[i]);
                if (rolePetInfo != null)
                {
                    pingfen_2 += rolePetInfo.PetPingFen;
                }
            }
            return Math.Max(pingfen_1, pingfen_2);
        }

        /// <summary>
        /// 宠物洗炼
        /// </summary>
        /// <param name="self"></param>
        /// <param name="rolePetInfo"></param>
        /// <param name="XiLianType"> 1 表示出生  2 表示洗炼 </param>
        /// <returns></returns>
        public static RolePetInfo PetXiLian(this PetComponent self, RolePetInfo rolePetInfo,int XiLianType) 
        {

            Unit unit = self.GetParent<Unit>();
            PetConfig petConfig = PetConfigCategory.Instance.Get(rolePetInfo.ConfigId);
           
            rolePetInfo.PetPingFen = int.Parse(petConfig.Base_PingFen);
            rolePetInfo.ZiZhi_Hp = RandomHelper.RandomNumber(petConfig.ZiZhi_Hp_Min, petConfig.ZiZhi_Hp_Max);
            rolePetInfo.ZiZhi_Act = RandomHelper.RandomNumber(petConfig.ZiZhi_Act_Min, petConfig.ZiZhi_Act_Max);
            rolePetInfo.ZiZhi_MageAct = RandomHelper.RandomNumber(petConfig.ZiZhi_MageAct_Min, petConfig.ZiZhi_MageAct_Max);
            rolePetInfo.ZiZhi_Def = RandomHelper.RandomNumber(petConfig.ZiZhi_Def_Min, petConfig.ZiZhi_Def_Max);
            rolePetInfo.ZiZhi_Adf = RandomHelper.RandomNumber(petConfig.ZiZhi_Adf_Min, petConfig.ZiZhi_Adf_Max);
            rolePetInfo.ZiZhi_ActSpeed = RandomHelper.RandomNumber(petConfig.ZiZhi_ActSpeed_Min, petConfig.ZiZhi_ActSpeed_Max);
            rolePetInfo.ZiZhi_ChengZhang = self.RandomNumberFloatKeep2((float)petConfig.ZiZhi_ChengZhang_Min, (float)petConfig.ZiZhi_ChengZhang_Max);

            self.CheckPetPingFen();
            self.CheckPetZiZhi();

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
                    if (RandomHelper.RandFloat() <= 0.2f)
                    {
                        rolePetInfo.PetSkill.Add(skillID);
                    }
                }
            }

            return rolePetInfo;
        }

        //第一次获得宠物的时候调用
        public static RolePetInfo OnAddPet(this PetComponent self, int petId, int skinId = 0)
        {
            PetConfig petConfig = PetConfigCategory.Instance.Get(petId);
            List<int> weight = new List<int>(petConfig.SkinPro);
            int index = RandomHelper.RandomByWeight(weight);
            skinId = petConfig.Skin[index];
            self.OnUnlockSkin(petConfig.Id + ";" + skinId.ToString());
            //self.OnUnlockSkin(petConfig.Id + ";" + petConfig.Skin[0].ToString());

            RolePetInfo newpet = self.GenerateNewPet(petId, skinId);
            newpet = self.PetXiLian(newpet, 1);
            self.UpdatePetAttribute(newpet, false);
            self.RolePetInfos.Add(newpet);
            M2C_RolePetUpdate m2C_RolePetUpdate = new M2C_RolePetUpdate();
            m2C_RolePetUpdate.PetInfoAdd = new List<RolePetInfo>();
            m2C_RolePetUpdate.PetInfoAdd.Add(newpet);

            self.GetParent<Unit>().GetComponent<ChengJiuComponent>().OnGetPet(newpet);
            self.GetParent<Unit>().GetComponent<TaskComponent>().OnGetPet();
            MessageHelper.SendToClient(self.GetParent<Unit>(), m2C_RolePetUpdate);

            //如果有皮肤的话更新一次角色属性
            Function_Fight.GetInstance().UnitUpdateProperty_Base(self.GetParent<Unit>(), true, true);
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

            //超过5级不能获得经验
            if (rolePetInfo.PetLv >= playerLv + 5)
            {
                return;
            }

            self.PetAddExp(rolePetInfo, mCof.Exp);
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

        //宠物进化
        public static void UpdatePetStage(this PetComponent self, RolePetInfo rolePetInfo,int pingfen)
        {
            PetConfig petConfig = PetConfigCategory.Instance.Get(rolePetInfo.ConfigId);

            int maxZiZhi = 20;
            int minZiZhi = 10;

            float floatPro = (float)(pingfen / 7500);
            minZiZhi = (int)((float)minZiZhi * floatPro);
            maxZiZhi = (int)((float)maxZiZhi * floatPro);

            if (minZiZhi < 5) 
            {
                minZiZhi = 5;
            }

            if (minZiZhi > 10)
            {
                minZiZhi = 10;
            }

            if (maxZiZhi < 20)
            {
                maxZiZhi = 20;
            }

            if (maxZiZhi > 30) 
            {
                maxZiZhi = 30;
            }

            string[] ZiZhi_Hp = new string[] { (minZiZhi * 2).ToString(), (maxZiZhi * 2f).ToString() };
            string[] ZiZhi_Act = new string[] { minZiZhi.ToString(), maxZiZhi.ToString() };
            string[] ZiZhi_Def = new string[] { minZiZhi.ToString(), maxZiZhi.ToString() };
            string[] ZiZhi_Adf = new string[] { minZiZhi.ToString(), maxZiZhi.ToString() };
            string[] ZiZhi_MageAct = new string[] { minZiZhi.ToString(), maxZiZhi.ToString() };

            int oldZiZhiHp = rolePetInfo.ZiZhi_Hp;
            int oldZiZhiAct = rolePetInfo.ZiZhi_Act;
            int oldZiZhiDef = rolePetInfo.ZiZhi_Def;
            int oldZiZhiAdf = rolePetInfo.ZiZhi_Adf;
            int oldZiZhiMageAct = rolePetInfo.ZiZhi_MageAct;

            rolePetInfo.ZiZhi_Hp += RandomHelper.RandomNumber(int.Parse(ZiZhi_Hp[0]), int.Parse(ZiZhi_Hp[1]) + 1);
            rolePetInfo.ZiZhi_Act += RandomHelper.RandomNumber(int.Parse(ZiZhi_Act[0]), int.Parse(ZiZhi_Act[1])+1);
            rolePetInfo.ZiZhi_Def += RandomHelper.RandomNumber(int.Parse(ZiZhi_Def[0]), int.Parse(ZiZhi_Def[1])+1);
            rolePetInfo.ZiZhi_Adf += RandomHelper.RandomNumber(int.Parse(ZiZhi_Adf[0]), int.Parse(ZiZhi_Adf[1])+1);
            rolePetInfo.ZiZhi_MageAct += RandomHelper.RandomNumber(int.Parse(ZiZhi_MageAct[0]), int.Parse(ZiZhi_MageAct[1])+1);

            rolePetInfo.ZiZhi_Hp = Math.Min(rolePetInfo.ZiZhi_Hp, petConfig.ZiZhi_Hp_Max);
            rolePetInfo.ZiZhi_Act = Math.Min(rolePetInfo.ZiZhi_Act, petConfig.ZiZhi_Act_Max);
            rolePetInfo.ZiZhi_Def = Math.Min(rolePetInfo.ZiZhi_Def, petConfig.ZiZhi_Def_Max);
            rolePetInfo.ZiZhi_Adf = Math.Min(rolePetInfo.ZiZhi_Adf, petConfig.ZiZhi_Adf_Max);
            rolePetInfo.ZiZhi_MageAct = Math.Min(rolePetInfo.ZiZhi_MageAct, petConfig.ZiZhi_MageAct_Max);

            //有些宠物突破上线需要在这里做处理
            rolePetInfo.ZiZhi_Hp = Math.Max(rolePetInfo.ZiZhi_Hp, oldZiZhiHp);
            rolePetInfo.ZiZhi_Act = Math.Max(rolePetInfo.ZiZhi_Act, oldZiZhiAct);
            rolePetInfo.ZiZhi_Def = Math.Max(rolePetInfo.ZiZhi_Def, oldZiZhiDef);
            rolePetInfo.ZiZhi_Adf = Math.Max(rolePetInfo.ZiZhi_Adf, oldZiZhiAdf);
            rolePetInfo.ZiZhi_MageAct = Math.Max(rolePetInfo.ZiZhi_MageAct, oldZiZhiMageAct);

            //概率增加1个技能    1-2  100%   3 50%   4 20%    5 10%  
            int addSkillID = 0;

            //获取原始宠物技能数量
            float addSkillPro = 0;
            if (rolePetInfo.PetSkill.Count <= 2)
            {
                addSkillPro = 1;
            }

            if (rolePetInfo.PetSkill.Count == 3)
            {
                addSkillPro = 0.5f;
            }

            if (rolePetInfo.PetSkill.Count == 4)
            {
                addSkillPro = 0.2f;
            }

            if (rolePetInfo.PetSkill.Count == 5)
            {
                addSkillPro = 0.1f;
            }

            if (RandomHelper.RandFloat01() < addSkillPro)
            {
                if (RandomHelper.RandFloat01() <= 0.7f) {
                    //低级技能概率70%
                    int add = RandomHelper.RandomNumber(1, 28);
                    addSkillID = 80001000 + add;
                }
                else
                {
                    //高级技能30%
                    int add = RandomHelper.RandomNumber(1, 28);
                    addSkillID = 80002000 + add;
                }
            }



            //如果当前技能有了那么就忽略掉此次技能附加。
            if (rolePetInfo.PetSkill.Contains(addSkillID))
            {
                addSkillID = 0;
            }

            if (addSkillID != 0)
            {
                rolePetInfo.PetSkill.Add(addSkillID);
            }

            //设置成已进化
            rolePetInfo.UpStageStatus = 2;

            //刷新一下宠物属性
            self.UpdatePetAttribute(rolePetInfo, true);
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
            self.UpdatePetAttribute(rolePetInfo, false);
        }

        //增加经验
        public static void PetAddLv(this PetComponent self, RolePetInfo rolePetInfo, int lv)
        {
            if (rolePetInfo == null)
            {
                return;
            }
            Unit unit = self.GetParent<Unit>();
            int playerLv = unit.GetComponent<UserInfoComponent>().UserInfo.Lv;
            int newLevel = rolePetInfo.PetLv + lv;
            newLevel = Math.Min(Math.Max(0, newLevel), playerLv + 5);
            rolePetInfo.AddPropretyNum += (newLevel - rolePetInfo.PetLv) * 5;
            rolePetInfo.PetLv = newLevel;

            //每次升级有概率进化状态
            if (RandomHelper.RandFloat01() <= 0.02f && rolePetInfo.UpStageStatus == 0) 
            { 
                rolePetInfo.UpStageStatus = 1;
                unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.Message, "恭喜你,你的宠物在升级时金光一闪,领悟进化！");
            }

            //刷新属性
            self.UpdatePetAttribute(rolePetInfo, true);

            //通知客户端
            MessageHelper.SendToClient(self.GetParent<Unit>(), new M2C_PetDataUpdate() { UpdateType = (int)UserDataType.Lv, PetId = rolePetInfo.Id, UpdateTypeValue = rolePetInfo.PetLv.ToString() });
            MessageHelper.Broadcast(self.GetParent<Unit>(), new M2C_PetDataBroadcast() { UnitId = self.GetParent<Unit>().Id, UpdateType = (int)UserDataType.Lv, PetId = rolePetInfo.Id, UpdateTypeValue = rolePetInfo.PetLv.ToString() });

        }

        public static void OnPetDead(this PetComponent self, long petId)
        {
            RolePetInfo petinfo = self.GetPetInfo(petId);
            petinfo.PetStatus = 0;
            MessageHelper.SendToClient(self.GetParent<Unit>(), new M2C_PetDataUpdate() { UpdateType = (int)UserDataType.PetStatus, PetId = petId, UpdateTypeValue = "0" });
        }

        public static void OnPetWalk(this PetComponent self, long petId, int petstatu)
        {
            RolePetInfo petinfo = self.GetPetInfo(petId);
            petinfo.PetStatus = petstatu;
            MessageHelper.SendToClient(self.GetParent<Unit>(), new M2C_PetDataUpdate() { UpdateType = (int)UserDataType.PetStatus, PetId = petId, UpdateTypeValue = petstatu.ToString() });
        }

        //增加等级
        public static void PetAddExp(this PetComponent self, RolePetInfo rolePetInfo, int exp)
        {
            if (rolePetInfo == null)
            {
                return;
            }

            int newExp = rolePetInfo.PetExp + exp;
            ExpConfig xiulianconf1 = ExpConfigCategory.Instance.Get(rolePetInfo.PetLv);
            if (newExp >= xiulianconf1.PetUpExp)
            {
                self.PetAddLv(rolePetInfo, 1);
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

        public static void UpdatePetAttribute(this PetComponent self, RolePetInfo rolePetInfo, bool updateUnit = false)
        {
            rolePetInfo.PetPingFen = ComHelp.PetPingJia(rolePetInfo);
            //获取宠物资质
            float actPro = self.GetZiZhiAddPro(1,rolePetInfo.ZiZhi_Act);
            float magePro = self.GetZiZhiAddPro(1, rolePetInfo.ZiZhi_MageAct);
            float defPro = self.GetZiZhiAddPro(1, rolePetInfo.ZiZhi_Def);
            float adfPro = self.GetZiZhiAddPro(1, rolePetInfo.ZiZhi_Def);
            float hpPro = self.GetZiZhiAddPro(2, rolePetInfo.ZiZhi_Hp);

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

            float speed = petCof.Base_MoveSpeed;

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

            //宠物技能
            for (int i = 0; i < rolePetInfo.PetSkill.Count; i++)
            {
                SkillConfig skillCof = SkillConfigCategory.Instance.Get(rolePetInfo.PetSkill[i]);
                if (ComHelp.IfNull(skillCof.GameObjectParameter))
                {
                    continue;
                }

                //判定是否为附加属性
                if (skillCof.SkillType != 5) {
                    continue;
                }

                string[] skillStrList = skillCof.GameObjectParameter.Split(';');
                if (skillStrList.Length == 0)
                {
                    continue;
                }

                for (int y = 0; y < skillStrList.Length; y++)
                {
                    try
                    {
                        string[] attriItem = skillStrList[y].Split(',');
                        if (attriItem.Length == 0)
                        {
                            continue;
                        }
                        int typeId = int.Parse(attriItem[0]);
                        Function_Fight.AddUpdateProDicList(typeId, NumericHelp.GetNumericValueType(typeId) == 2 ? (long)(10000 * float.Parse(attriItem[1])) : long.Parse(attriItem[1]), attriDic);
                    }
                    catch (Exception ex)
                    {
                        Log.Info($"attri Eption：{rolePetInfo.PetSkill[i]} {ex.ToString()}");
                    }
                }
            }

            foreach (var item in attriDic)
            {
                int numericType = item.Key;
                int nowValue = (int)numericType / 100;
                int attriIndex = rolePetInfo.Ks.IndexOf(nowValue);
                if (attriIndex == -1 || attriIndex >= rolePetInfo.Vs.Count)
                {
                    continue;
                }
                rolePetInfo.Vs[attriIndex] += item.Value;
            }

            //如果是出战的宠物。再广播一下属性
            if (updateUnit == false)
            {
                return;
            }
            Unit petUnit = self.GetParent<Unit>().GetParent<UnitComponent>().Get(rolePetInfo.Id);
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

        //根据资质换算出当前系数
        private static float GetZiZhiAddPro(this PetComponent self, int type ,int value) {

            float pro = 0.8f;

            if (type == 1) {
                if (value >= 1200)
                {
                    //超出算法
                    pro = 0.8f + ((value-1200) / 600.0f);
                }
                else {
                    //低出算法
                    pro = (float)value/1500.0f;
                }
            }

            if (type == 2)
            {
                if (value >= 2400)
                {
                    //超出算法
                    pro = 0.8f + ((value - 2400) / 1200.0f);
                }
                else
                {
                    //低出算法
                    pro = (float)value / 3000.0f;
                }
            }

            return pro;
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
                    //重复激活
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

        //判断当前宠物是否已满
        public static bool PetIsFull(this PetComponent self) {

            Unit unit = self.GetParent<Unit>();
            int userLv = unit.GetComponent<UserInfoComponent>().UserInfo.Lv;
            if (self.RolePetInfos.Count >= ComHelp.GetPetMaxNumber(unit, userLv))
            {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
