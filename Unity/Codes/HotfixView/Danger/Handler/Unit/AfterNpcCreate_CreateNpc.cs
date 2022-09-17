using System;
using UnityEngine;

namespace ET
{
    [Event]
    public class AfterNpcCreate_CreateNpc : AEventClass<EventType.AfterNpcCreate>
    {
        protected override void Run(object cls)
        {
            RunSync(cls as EventType.AfterNpcCreate).Coroutine();
        }

        private async ETTask RunSync(EventType.AfterNpcCreate args)
        {
            try
            {
           
                Unit unit = args.Unit;
                int npcId = unit.GetComponent<UnitInfoComponent>().UnitCondigID;

                NpcConfig config = NpcConfigCategory.Instance.Get(npcId);
                var path = ABPathHelper.GetUnitPath("Npc/" + config.Asset);
                GameObject prefab = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
                GameObject go = UnityEngine.Object.Instantiate(prefab, GlobalComponent.Instance.Unit, true);

                go.transform.localPosition = unit.Position;
                go.transform.rotation = unit.Rotation;

                if (go.layer != LayerMask.NameToLayer(LayerEnum.NPC.ToString()))
                {
                    LayerHelp.ChangeLayer(go.transform, LayerEnum.NPC);
                }
                if (go.GetComponent<Collider>() == null)
                {
                    BoxCollider box = go.AddComponent<BoxCollider>();
                    box.size = new Vector3(1f, 2f, 1f);
                    box.center = new Vector3(0f, 1f, 0f);
                }
                go.name = config.Id.ToString();
                unit.AddComponent<GameObjectComponent, GameObject>(go);
                unit.AddComponent<AnimatorComponent>();
                unit.AddComponent<HeroTransformComponent>();
                unit.UpdateUIType = HeadBarType.NpcHeadBarUI;
                unit.AddComponent<NpcHeadBarComponent>();
                unit.AddComponent<FsmComponent>();
            }
            catch (Exception ex)
            {
                Log.Error(ex.ToString());
            }
        }
    }
}
