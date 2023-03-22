using UnityEngine;

namespace ET
{

    [Event]
    public class JianYuan_OnJiaYuanUpdate : AEventClass<EventType.JiaYuanUpdate>
    {
        protected override void Run(object cls)
        {
            EventType.JiaYuanUpdate args = cls as EventType.JiaYuanUpdate;
            Scene zoneScene = args.ZoneScene;
            MapComponent mapComponent = zoneScene.GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum != SceneTypeEnum.JiaYuan)
            {
                return;
            }

            int level = zoneScene.GetComponent<UserInfoComponent>().UserInfo.Lv;
            int openCell = 0;
            if (level > 10)
            {
                openCell = 10;
            }
            if (level > 60)
            {
                openCell = 20;
            }
            if (level > 70)
            {
                openCell = 40;
            }
            GameObject NongChangSet = GameObject.Find("NongChangSet");
            for (int i = 0; i < NongChangSet.transform.childCount; i++)
            {
                NongChangSet.transform.GetChild(i).gameObject.SetActive(i < openCell);  
            }

            Scene curscene = zoneScene.CurrentScene();
            JianYuanPlanUIComponent
        }
    }
}
