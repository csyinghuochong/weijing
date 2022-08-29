namespace ET
{
    public static class SingingComponentSystem
    {
        public static void SingingStart(this SingingComponent self, int skillId)
        {
            
        }

        public static void SingingFinish(this SingingComponent self, int error)
        {
            if (error != 0)
            {
                return;
            }
        }
    }
}
