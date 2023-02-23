using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{

    [Event]
    public class ChengJiu_OnChengJiuActive : AEventClass<EventType.ChengJiuActive>
    {
        protected override async void Run(object cls)
        {
            EventType.ChengJiuActive args = cls as EventType.ChengJiuActive;

            UI uiBattleMain = UIHelper.GetUI(args.ZoneScene, UIType.UIChengJiuActivite);
            if (uiBattleMain == null)
            {
                uiBattleMain = await UIHelper.Create(args.ZoneScene, UIType.UIChengJiuActivite);
            }
            uiBattleMain.GetComponent<UIChengJiuActiviteComponent>().OnInitUI(args.m2C_ChengJiu.ChengJiuId).Coroutine();
        }
    }
}
