using UnityEngine;
using System.Linq;

namespace ET
{

    [Event]
    public class Unit_ChuanSongOpen : AEventClass<EventType.ChuanSongOpen>
    {

        protected override void Run(object cls)
        {
            EventType.ChuanSongOpen args = (EventType.ChuanSongOpen)cls;
            CellDungeonComponent fubenComponent = args.ZoneScene.GetComponent<CellDungeonComponent>();
            CellDungeonInfo fubenCellInfo = fubenComponent.GetFubenCell(fubenComponent.SonFubenInfo.CurrentCell);
            
            if (fubenCellInfo.ctype != (int)CellDungeonStatu.End)
            {
                Entity[] allunits = args.ZoneScene.CurrentScene().GetComponent<UnitComponent>().Children.Values.ToArray();
                for (int i = 0; i < allunits.Length; i++)
                {
                    if (allunits[i].GetComponent<UnitInfoComponent>().Type != UnitType.Chuansong)
                    {
                        continue;
                    }

                    GameObject gameObject = allunits[i].GetComponent<GameObjectComponent>().GameObject;
                    gameObject.transform.Find("CanWalkEffect").gameObject.SetActive(true);
                }

                UI uimain = UIHelper.GetUI(args.ZoneScene, UIType.UIMain);
                uimain.GetComponent<UIMainComponent>().OnChapterOpen();
            }
        }
    }
}
