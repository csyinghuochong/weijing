
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ET
{

    public class JiaYuanSceneComponentAwake : AwakeSystem<JiaYuanSceneComponent>
    {
        public override void Awake(JiaYuanSceneComponent self)
        {
            self.JiaYuanFubens.Clear(); 
        }
    }

    public static class JiaYuanSceneComponentSystem
    {

        public static void OnUnitLeave(this JiaYuanSceneComponent self, Scene scene, long unitid)
        {
            List<Unit> units = UnitHelper.GetUnitList(scene, UnitType.Player);
            if (units.Count > 0)
            {
                return;
            }

            long fubeninstanceid = 0;
            self.JiaYuanFubens.TryGetValue(unitid, out fubeninstanceid);

            TransferHelper.NoticeFubenCenter(scene, 2).Coroutine();
            scene.Dispose();
            if (fubeninstanceid != 0)
            {
                self.JiaYuanFubens.Remove(unitid);
            }
        }

        public static async ETTask CreateJiaYuanUnit(this JiaYuanSceneComponent self, Scene fubnescene, long unitid)
        {
            JiaYuanComponent jiaYuanComponent = await DBHelper.GetComponentCache<JiaYuanComponent>(fubnescene.DomainZone(), unitid);
            jiaYuanComponent.OnEnter();
            await DBHelper.SaveComponent(fubnescene.DomainZone(), unitid, jiaYuanComponent);

            for (int i = 0;i < jiaYuanComponent.JiaYuanPastureList_7.Count; i++)
            {
                UnitFactory.CreatePasture(fubnescene, jiaYuanComponent.JiaYuanPastureList_7[i], unitid);
            }
            for (int i = 0; i < jiaYuanComponent.JianYuanPlantList_7.Count; i++)
            {
                UnitFactory.CreatePlan(fubnescene, jiaYuanComponent.JianYuanPlantList_7[i], unitid);
            }

            long serverTime = TimeHelper.ServerNow();
            for (int i = 0; i < jiaYuanComponent.JiaYuanMonster_2.Count; i++)
            {
                JiaYuanMonster keyValuePair = jiaYuanComponent.JiaYuanMonster_2[i];
                Vector3 vector3 = new Vector3(keyValuePair.x, keyValuePair.y, keyValuePair.z);
                UnitFactory.CreateMonster(fubnescene, keyValuePair.ConfigId, vector3, new CreateMonsterInfo()
                {
                    Camp = CampEnum.CampMonster1,
                    BornTime = serverTime - keyValuePair.BornTime,
                    UnitId = keyValuePair.unitId
                }); 
            }
            for (int i = 0; i < jiaYuanComponent.JiaYuanPetList_2.Count; i++)
            {
                UnitFactory.CreateJiaYuanPet(fubnescene, unitid, jiaYuanComponent.JiaYuanPetList_2[i]);
            }
        }

        public static async ETTask<long> GetJiaYuanFubenId(this JiaYuanSceneComponent self, long unitid)
        {
            if (self.JiaYuanFubens.ContainsKey(unitid))
            {
                return self.JiaYuanFubens[unitid];
            }
            int jiayuansceneid = 102;
            long fubenid = IdGenerater.Instance.GenerateId();
            long fubenInstanceId = IdGenerater.Instance.GenerateInstanceId();
            Scene fubnescene = SceneFactory.Create(self, fubenid, fubenInstanceId, self.DomainZone(), "JiaYuan" + fubenid.ToString(), SceneType.Fuben);
            fubnescene.AddComponent<JiaYuanDungeonComponent>();
            MapComponent mapComponent = fubnescene.GetComponent<MapComponent>();
            mapComponent.SetMapInfo((int)SceneTypeEnum.JiaYuan, jiayuansceneid, 0);
            mapComponent.NavMeshId = SceneConfigCategory.Instance.Get(jiayuansceneid).MapID.ToString();
            await self.CreateJiaYuanUnit(fubnescene, unitid);
            FubenHelp.CreateNpc(fubnescene, jiayuansceneid);
            TransferHelper.NoticeFubenCenter(fubnescene, 1).Coroutine();
            self.JiaYuanFubens.Add(unitid, fubenInstanceId);
            return fubenInstanceId;
        }
    }
}
