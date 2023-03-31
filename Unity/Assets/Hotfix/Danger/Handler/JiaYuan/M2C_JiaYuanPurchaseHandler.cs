using System;


namespace ET
{

    [MessageHandler]
    public class M2C_JiaYuanPurchaseHandler : AMHandler<M2C_JiaYuanPurchaseUpdate>
    {
        protected override void Run(Session session, M2C_JiaYuanPurchaseUpdate message)
        {
            session.ZoneScene().GetComponent<JiaYuanComponent>().PurchaseItemList_4 = message.PurchaseItemList;
            //EventType.AreneInfo.Instance.m2C_Battle = message;
            //EventType.AreneInfo.Instance.ZoneScene = session.ZoneScene();
            //EventSystem.Instance.PublishClass(EventType.AreneInfo.Instance);
        }
    }
}
