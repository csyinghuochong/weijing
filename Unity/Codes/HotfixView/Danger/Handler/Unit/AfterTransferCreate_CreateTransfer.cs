using UnityEngine;

namespace ET
{

    [Event]
    public class AfterTransferCreate_CreateTransfer : AEventClass<EventType.AfterTransferCreate>
    {
        protected override void  Run(object cls)
        {
            RunAsync(cls as EventType.AfterTransferCreate);
        }

        private  void RunAsync(EventType.AfterTransferCreate args)
        {
            Unit unit = args.Unit;
            var path = ABPathHelper.GetUnitPath("Monster/DorrWay_1");
            GameObject prefab =  ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject go = UnityEngine.Object.Instantiate(prefab, GlobalComponent.Instance.Unit, true);
            if (unit == null)
            {
                Log.Error("AfterTransferCreate_CreateTransfer :args.Unit == null");
            }
            go.name = unit.Id.ToString();
            go.transform.localPosition = unit.Position;         //设置传送坐标点

            switch (unit.GetComponent<ChuansongComponent>().DirectionType)
            {
                case 1: //上
                    go.transform.localRotation = Quaternion.Euler(-90, 0, 180);         //设置旋转
                    break;
                case 2: //左
                    go.transform.localRotation = Quaternion.Euler(-90, 0, 90);         //设置旋转
                    break;
                case 3: //下
                    go.transform.localRotation = Quaternion.Euler(-90, 0, 0);         //设置旋转
                    break;
                case 4: //右
                    go.transform.localRotation = Quaternion.Euler(-90, 0, -90);         //设置旋转
                    break;
            }
            unit.UpdateUIType = HeadBarType.TransferUI;
            UnitInfoComponent unitInfoComponent = unit.GetComponent<UnitInfoComponent>();
            unit.AddComponent<GameObjectComponent>().GameObject = go;
            unit.UpdateUIType = HeadBarType.TransferUI;
            unit.AddComponent<TransferUIComponent>().OnInitUI(unitInfoComponent.UnitCondigID).Coroutine();
            unit.GetComponent<ChuansongComponent>().ChuanSongOpen = true;
        }
    }
}
