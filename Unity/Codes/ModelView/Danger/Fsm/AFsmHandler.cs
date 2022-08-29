namespace ET
{

    public class FsmHandlerAttribute : BaseAttribute
    {
        
    }

    [FsmHandler]
    public abstract class AFsmHandler
    {

        public int FsmType;
        public int EquipType;
        public FsmComponent FsmComponent;
        public ETCancellationToken CancellationToken;

        public abstract void OnInit( );

        /// <summary>
        /// 正式进入此状态时需要进行的逻辑
        /// </summary>
        public abstract void OnEnter(string paramss = "");

        public abstract void OnReEnter(string paramss = "");

        /// <summary>
        /// 离开此状态时需要进行的逻辑
        /// </summary>
        public abstract void OnExit();

    }
}
