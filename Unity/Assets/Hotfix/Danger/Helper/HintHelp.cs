namespace ET
{

    public class HintHelp 
    {
        //实例化自身
        private static HintHelp _instance;
        public static HintHelp GetInstance()
        {
            if (_instance == null)
            {
                _instance = new HintHelp();
            }
            return _instance;
        }

        //展示飘字
        public void ShowHint(string hintText)
        {
            EventType.CommonHint.Instance.HintText = hintText;
            EventSystem.Instance.PublishClass(EventType.CommonHint.Instance);
        }

        public void ShowHintError(int error)
        {
            if (error == ErrorCore.ERR_CanNotMove_NetWait 
             || error == ErrorCore.ERR_CanNotUseSkill_NetWait
             || error == ErrorCore.ERR_CanNotMove_Rigidity
             || error == ErrorCore.ERR_CanNotUseSkill_Rigidity)
            {
                return;
            }
            EventType.CommonHintError.Instance.errorValue = error;
            EventSystem.Instance.PublishClass(EventType.CommonHintError.Instance);
        }

        public void DataUpdate(int dataType, string dataParam = "")
        {
            EventType.DataUpdate.Instance.DataType = dataType;
            EventType.DataUpdate.Instance.DataParams = dataParam;
            EventSystem.Instance.PublishClass(EventType.DataUpdate.Instance);
        }
    }
}
