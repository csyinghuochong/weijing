using System.Linq;
using System.Collections.Generic;

namespace ET
{

    public static class PetComponentSystem
    {

        public static async ETTask RequestAllPets(this PetComponent self)
        {
            C2M_RolePetList c2M_RolePetList = new C2M_RolePetList();
            M2C_RolePetList m2C_RolePetList = (M2C_RolePetList)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_RolePetList);

            self.RolePetInfos = m2C_RolePetList.RolePetInfos;
            self.TeamPetList = m2C_RolePetList.TeamPetList;
            self.RolePetEggs = m2C_RolePetList.RolePetEggs;
            self.PetFormations = m2C_RolePetList.PetFormations;
            self.PetFubenInfos = m2C_RolePetList.PetFubenInfos;
            self.PetFubeRewardId = m2C_RolePetList.PetFubeRewardId;
            self.PetSkinList = m2C_RolePetList.PetSkinList;
            self.PetShouHuList = m2C_RolePetList.PetShouHuList;
            self.PetShouHuActive = m2C_RolePetList.PetShouHuActive;
        }

        public static void OnRecvRolePetUpdate(this PetComponent self, M2C_RolePetUpdate m2C_RolePetUpdate)
        {
            RolePetInfo rolePetInfo = m2C_RolePetUpdate.PetInfoAdd[0];
            PetConfig petConfig = PetConfigCategory.Instance.Get(rolePetInfo.ConfigId);
            self.OnUnlockSkin($"{rolePetInfo.ConfigId};{rolePetInfo.SkinId}");
            //self.OnUnlockSkin($"{rolePetInfo.ConfigId};{petConfig.Skin[0]}");

            self.RolePetInfos.AddRange(m2C_RolePetUpdate.PetInfoAdd);
        }


        public static RolePetInfo GetPetInfoByID(this PetComponent self, long petid)
        {
            for (int i = self.RolePetInfos.Count - 1; i >= 0; i--)
            {
                if (self.RolePetInfos[i].Id == petid)
                {
                    return self.RolePetInfos[i];
                }
            }
            return null;
        }

        public static long GetFightPetId(this PetComponent self)
        {
            RolePetInfo rolePetInfo = self.GetFightPet();
            return rolePetInfo!=null ? rolePetInfo.Id : 0;  
        }

        public static RolePetInfo GetFightPet(this PetComponent self)
        {
            for (int i = self.RolePetInfos.Count - 1; i >= 0; i--)
            {
                if (self.RolePetInfos[i].PetStatus == 1)
                {
                    return self.RolePetInfos[i];
                }
            }
            return null;
        }

        public static async ETTask RequestPetFight(this PetComponent self, long petId, int fight)
        {
            //简单写一下，有其他出战的则不能出战。
            for (int i = self.RolePetInfos.Count - 1; i >= 0; i--)
            {
                if (self.RolePetInfos[i].PetStatus == 1 && self.RolePetInfos[i].Id != petId && fight == 1)
                {
                    return;
                }
            }

            C2M_RolePetFight c2M_RolePetFight = new C2M_RolePetFight() { PetInfoId = petId, PetStatus = fight };
            M2C_RolePetFight m2C_RolePetFight = (M2C_RolePetFight)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_RolePetFight);

            for (int i = self.RolePetInfos.Count - 1; i >= 0; i--)
            {
                if (self.RolePetInfos[i].Id == petId)
                {
                    self.RolePetInfos[i].PetStatus = fight;
                }
            }

            HintHelp.GetInstance().DataUpdate(DataType.OnPetFightSet);
        }

        public static async ETTask<int > RequestUpStar(this PetComponent self, long mainId, List<long> costIds)
        {
            C2M_RolePetUpStar c2M_RolePetXiLian = new C2M_RolePetUpStar() { PetInfoId = mainId, CostPetInfoIds = costIds };
            M2C_RolePetUpStar m2C_RolePetXiLian = (M2C_RolePetUpStar)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_RolePetXiLian);

            if (m2C_RolePetXiLian.Error != 0)
            {
                return m2C_RolePetXiLian.Error;
            }

            for (int i = 0; i < costIds.Count; i++)
            {
                self.RemovePet(costIds[i]);
            }

            for (int i = self.RolePetInfos.Count - 1; i >= 0; i--)
            {
                if (self.RolePetInfos[i].Id == mainId)
                {
                    self.RolePetInfos[i] = m2C_RolePetXiLian.rolePetInfo;
                }
            }
            HintHelp.GetInstance().DataUpdate(DataType.PetUpStarUpdate, mainId.ToString());
            return ErrorCore.ERR_Success;
        }

        public static void RemovePet(this PetComponent self, long petId)
        {
            for (int i = self.RolePetInfos.Count - 1; i >= 0; i--)
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

        public static async ETTask RequestFenJie(this PetComponent self, long petId)
        {
            C2M_RolePetFenjie c2M_RolePetXiLian = new C2M_RolePetFenjie() {  PetInfoId = petId };
            M2C_RolePetFenjie m2C_RolePetXiLian = (M2C_RolePetFenjie)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_RolePetXiLian);

            if (m2C_RolePetXiLian.Error != 0)
            {
                return;
            }
            self.RemovePet(petId);
            HintHelp.GetInstance().DataUpdate(DataType.PetFenJieUpdate);
        }

        public static async ETTask RequestXiLian(this PetComponent self, long itemId, long petId)
        {
            C2M_RolePetXiLian c2M_RolePetXiLian = new C2M_RolePetXiLian() { BagInfoID = itemId, PetInfoId = petId };
            M2C_RolePetXiLian m2C_RolePetXiLian = (M2C_RolePetXiLian)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_RolePetXiLian);

            //Log.ILog.Info("ConfigId = " + m2C_RolePetXiLian.rolePetInfo.ConfigId + "ZIZHI:" + m2C_RolePetXiLian.rolePetInfo.ZiZhi_Hp);

            if (m2C_RolePetXiLian.Error != 0)
            {
                return;
            }
            for (int i = self.RolePetInfos.Count - 1; i >= 0; i--)
            {
                if (self.RolePetInfos[i].Id == m2C_RolePetXiLian.rolePetInfo.Id)
                {
                    self.RolePetInfos[i] = m2C_RolePetXiLian.rolePetInfo;
                }
            }

            //出发对应提示
            HintHelp.GetInstance().ShowHint("道具在宠物身上发生了作用！");
            HintHelp.GetInstance().DataUpdate(DataType.PetXiLianUpdate);
        }

        public static void OnPetProtect(this PetComponent self, long rolePetInfoId, bool isprotect)
        {
            for (int i = 0; i < self.RolePetInfos.Count; i++)
            {
                if (self.RolePetInfos[i].Id == rolePetInfoId)
                {
                    self.RolePetInfos[i].IsProtect = isprotect;
                }
            }
        }

        /// <summary>
        /// operateType 1上阵  2替换  3下阵 
        /// </summary>
        /// <param name="self"></param>
        /// <param name="rolePetInfoId"></param>
        /// <param name="index"></param>
        /// <param name="operateType"></param>
        public static void OnFormationSet(this PetComponent self, long rolePetInfoId, int index, int operateType)
        {
            //index == -1 下阵
            if (operateType == 1)
            {
                for (int i = 0; i < self.PetFormations.Count; i++)
                {
                    if (self.PetFormations[i] == rolePetInfoId && i != index)
                    {
                        self.PetFormations[i] = 0;
                    }
                }
                self.PetFormations[index] = rolePetInfoId;
            }
            if (operateType == 2)
            {
                int oldIndex = -1;
                for (int i = 0; i < self.PetFormations.Count; i++)
                {
                    if (self.PetFormations[i] == rolePetInfoId)
                    {
                        oldIndex = i;
                    }
                }
                self.PetFormations[oldIndex] = self.PetFormations[index];
                self.PetFormations[index] = rolePetInfoId;
            }
            if (operateType == 3)
            {
                for (int i = 0; i < self.PetFormations.Count; i++)
                {
                    if (self.PetFormations[i] == rolePetInfoId)
                    {
                        self.PetFormations[i] = 0;
                    }
                }
            }
        }

        public static int GetPetFuben(this PetComponent self)
        {
            int petfubenId = 0;
            for (int i = 0; i < self.PetFubenInfos.Count; i++)
            {
                if (self.PetFubenInfos[i].PetFubenId > petfubenId)
                {
                    petfubenId = self.PetFubenInfos[i].PetFubenId;
                }
            }
            return petfubenId;
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
                    && rewardConfigs[i].Id > self.PetFubeRewardId )
                {
                    rewardId = rewardConfigs[i].Id;
                    break;
                }
            }

            return rewardId;
        }

        public static int GetFubenStar(this PetComponent self, int petfubenId)
        {
            for (int i = 0; i < self.PetFubenInfos.Count; i++)
            {
                if (self.PetFubenInfos[i].PetFubenId == petfubenId)
                {
                    return self.PetFubenInfos[i].Star;
                }
            }
            return 0;
        }

        public static void OnRolePetUpdate(this PetComponent self, RolePetInfo rolePetInfo)
        {
            for (int i = self.RolePetInfos.Count - 1; i >= 0; i--)
            {
                if (self.RolePetInfos[i].Id == rolePetInfo.Id)
                {
                    self.RolePetInfos[i] = rolePetInfo;
                    break;
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
            self.PetFubenInfos.Add(new PetFubenInfo() { PetFubenId = petfubenId, Star = star, Reward = 0 });
        }

        public static bool HavePetSkin(this PetComponent self, int petId, int skinId)
        {
            for (int p = 0; p < self.PetSkinList.Count; p++)
            {
                if (self.PetSkinList[p].KeyId != petId)
                {
                    continue;
                }
                return self.PetSkinList[p].Value.Contains(skinId.ToString());
            }
            return false;
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

        public static List<long> GetPetFormatList(this PetComponent self, int sceneType)
        {
            if (sceneType == SceneTypeEnum.PetDungeon)
            {
                return self.PetFormations;
            }
            if (sceneType == SceneTypeEnum.PetTianTi)
            {
                return self.TeamPetList;
            }
            return null;
        }

        public static List<KeyValuePair> GetPetSkinCopy(this PetComponent self)
        {
            List<KeyValuePair> keyValuePairs = new List<KeyValuePair>();
            for (int i = 0; i < self.PetSkinList.Count; i++)
            {
                //keyValuePairs.Add(ComHelp.DeepCopy<KeyValuePair>(self.PetSkinList[i])) ;
                keyValuePairs.Add(new KeyValuePair() { KeyId = self.PetSkinList[i].KeyId, Value = self.PetSkinList[i].Value });
            }
            return keyValuePairs;
        }

        /// <summary>
        /// 宠物合成
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static void  OnRecvHeCheng(this PetComponent self, M2C_RolePetHeCheng m2C_RolePetHeCheng)
        {
            self.RemovePet(m2C_RolePetHeCheng.DeletePetInfoId);
            for (int i = self.RolePetInfos.Count - 1; i >=0 ; i--)
            {
                if (self.RolePetInfos[i].Id == m2C_RolePetHeCheng.rolePetInfo.Id)
                {
                    self.RolePetInfos[i] = m2C_RolePetHeCheng.rolePetInfo;
                }
            }
            HintHelp.GetInstance().DataUpdate(DataType.PetHeChengUpdate);
        }

    }
}
