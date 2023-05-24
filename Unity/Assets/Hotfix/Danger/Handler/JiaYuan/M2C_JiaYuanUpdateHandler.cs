using System;


namespace ET
{

    [MessageHandler]
    public class M2C_JiaYuanUpdateHandler : AMHandler<M2C_JiaYuanUpdate>
    {
        protected override void Run(Session session, M2C_JiaYuanUpdate message)
        {
            JiaYuanComponent jiaYuanComponent = session.ZoneScene().GetComponent<JiaYuanComponent>();
            jiaYuanComponent.PurchaseItemList_7 = message.PurchaseItemList;
            //EventType.AreneInfo.Instance.m2C_Battle = message;
            //EventType.AreneInfo.Instance.ZoneScene = session.ZoneScene();
            //EventSystem.Instance.PublishClass(EventType.AreneInfo.Instance);
        }
    }
}
