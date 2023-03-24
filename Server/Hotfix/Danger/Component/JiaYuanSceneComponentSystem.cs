using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            long fubeninstanceid = 0;
            self.JiaYuanFubens.TryGetValue(unitid, out fubeninstanceid); 
        }

        public static long GetJiaYuanFubenId(this JiaYuanSceneComponent self, long unitid)
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
            FubenHelp.CreateNpc(fubnescene, jiayuansceneid);
            TransferHelper.NoticeFubenCenter(fubnescene, 1).Coroutine();
            self.JiaYuanFubens.Add(unitid, fubenInstanceId);
            return fubenInstanceId;
        }
    }
}
