using UnityEngine;
using System.Collections.Generic;

namespace ET
{
    public static class PetFubenSceneComponentSystem
    {

        public static void OnKillEvent(this PetFubenSceneComponent self)
        {
            PetComponent petComponent = self.MainUnit.GetComponent<PetComponent>();
            int number = 0;
            for (int i = 0; i < petComponent.PetFormations.Count; i++)
            {
                number += (petComponent.PetFormations[i] != 0 ? 1 : 0);
            }

            bool allMonsterDead = FubenHelp.IsAllMonsterDead(self.DomainScene());
            int alivedPetNumber = FubenHelp.GetAlivePetNumber(self.DomainScene());
            if (!allMonsterDead && alivedPetNumber > 0)
            {
                return;
            }
            int petfubeId = self.DomainScene().GetComponent<MapComponent>().SonSceneId;
            M2C_FubenSettlement m2C_FubenSettlement = new M2C_FubenSettlement();
            m2C_FubenSettlement.BattleResult = allMonsterDead ? 1 : 0;
            if (!allMonsterDead)
            {
                m2C_FubenSettlement.StarInfos = new List<int>() { 0, 0, 0 };
            }
            else if (alivedPetNumber >= number)  //星数规则 1星通关 2星 胜利后己方宠物3-4 3星满员
            {
                m2C_FubenSettlement.StarInfos = new List<int>() { 1, 1, 1 };
            }
            else if (alivedPetNumber >= 3)
            {
                m2C_FubenSettlement.StarInfos = new List<int>() { 1, 1, 0 };
            }
            else
            {
                m2C_FubenSettlement.StarInfos = new List<int>() { 1, 0, 0 };
            }
            
            MessageHelper.SendToClient(self.MainUnit, m2C_FubenSettlement);
            if (allMonsterDead)
            {
                self.MainUnit.GetComponent<PetComponent>().OnPassPetFuben(petfubeId, 3);
            }
        }

        public static void  GeneratePetFuben(this PetFubenSceneComponent self, Unit unit, int sceneId)
        {
            long instanceId = self.InstanceId;
            unit.GetComponent<StateComponent>().StateTypeAdd(StateTypeEnum.WuDi);

            PetComponent petComponent = unit.GetComponent<PetComponent>();
            List<long> pets = petComponent.PetFormations;
            for (int i = 0; i < pets.Count; i++)
            {
                RolePetInfo rolePetInfo = petComponent.GetPetInfo(pets[i]);
                if (rolePetInfo == null)
                {
                    continue;
                }
                Unit petunit =  UnitFactory.CreateFubenPet(unit.DomainScene(), 0,
                    1,  rolePetInfo, AIHelp.Formation_1[i]);
                petunit.GetComponent<AIComponent>().StopAI = true;
            }
            if (instanceId != self.InstanceId)
            {
                return;
            }

            PetFubenConfig petFubenConfig = PetFubenConfigCategory.Instance.Get(sceneId);
            self.GenerateCellMonsters(petFubenConfig.Cell_1, 0);
            self.GenerateCellMonsters(petFubenConfig.Cell_2, 1);
            self.GenerateCellMonsters(petFubenConfig.Cell_3, 2);
            self.GenerateCellMonsters(petFubenConfig.Cell_4, 3);
            self.GenerateCellMonsters(petFubenConfig.Cell_5, 4);
            self.GenerateCellMonsters(petFubenConfig.Cell_6, 5);
            self.GenerateCellMonsters(petFubenConfig.Cell_7, 6);
            self.GenerateCellMonsters(petFubenConfig.Cell_8, 7);
            self.GenerateCellMonsters(petFubenConfig.Cell_9, 8);
        }

        public static void GenerateCellMonsters(this PetFubenSceneComponent self, string cellInfo, int index)
        {
			//70004001;1@70004002;1
			string[] monsters = cellInfo.Split('@');
            Vector3 position = AIHelp.Formation_2[index];

            for (int i = 0; i < monsters.Length; i++)
			{
				if (string.IsNullOrEmpty(monsters[i]) || monsters[i].Length <= 1)
				{
					continue;
				}
				//70004001;1
				string[] monsterinfo = monsters[i].Split(';');
                int monsterId = int.Parse(monsterinfo[0]);
                int cmcount = int.Parse(monsterinfo[1]);

                for (int c = 0; c < cmcount; c++)
                {
                    float range = 0.5f;
                    Vector3 vector3 = new Vector3(position.x + RandomHelper.RandomNumberFloat(-1 * range, range),
                        position.y, position.z + RandomHelper.RandomNumberFloat(-1 * range, range));
                    Unit monsterunit=  UnitFactory.CreateMonster(self.DomainScene(), monsterId, vector3,  new CreateMonsterInfo()
                    { FubenDifficulty= FubenDifficulty.None, Camp = 2});
                    monsterunit.GetComponent<AIComponent>().StopAI = true;
                }
            }
		}
    }
}
