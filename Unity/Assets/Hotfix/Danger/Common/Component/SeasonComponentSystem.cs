

namespace ET
{

    public static class SeasonComponentSystem
    {

#if SERVER


        public static void OnLogin(this SeasonComponent self)
        { 
            
        }

        /// <summary>
        /// 刷新赛季之王出现的副本和时间
        /// </summary>
        /// <param name="self"></param>
        public static void FreshBossInfo(this SeasonComponent self)
        { 
            
        }

#endif


    }

}