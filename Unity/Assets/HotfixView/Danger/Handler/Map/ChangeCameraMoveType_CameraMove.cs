namespace ET
{
    [Event]
    public class ChangeCameraMoveType_CameraMove: AEventClass<EventType.ChangeCameraMoveType>
    {
        protected override void Run(object a)
        {
            EventType.ChangeCameraMoveType args = a as EventType.ChangeCameraMoveType;

            CameraComponent cameraComponent = args.ZoneScene.CurrentScene().GetComponent<CameraComponent>();

            if (args.CameraType == (int)CameraMoveType.Pull)
            {
                cameraComponent.SetPullCamera();
            }
            else if (args.CameraType == (int)CameraMoveType.Rollback)
            {
                cameraComponent.SetRollbackCamera();
            }
        }
    }
}