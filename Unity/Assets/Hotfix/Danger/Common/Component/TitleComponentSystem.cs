using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{

    [ObjectSystem]
    public class TitleComponentSystemAwake: AwakeSystem<TitleComponent>
    {

        public override void Awake(TitleComponent self)
        {
            self.TitleList.Clear();
        }
    }

    public static class TitleComponentSystem
    {

#if SERVER
        public static List<HideProList> GetProList(this TitleComponent self)
        {
            List<HideProList> proList = new List<HideProList>();
            return proList;
        }
#endif

        /// <summary>
        /// 移除过期称号
        /// </summary>
        /// <param name="self"></param>
        public static void OnCheckTitle(this TitleComponent self)
        {
            long serverTime = TimeHelper.ServerNow();
            for (int i = self.TitleList.Count - 1; i >= 0; i--)
            {
                if (self.TitleList[i].Value < serverTime)
                {
                    self.TitleList.RemoveAt(i);
                }
            }
        }

        public static bool IsHaveTitle(this TitleComponent self, int titleId)
        {
            for (int i = 0; i < self.TitleList.Count; i++)
            {
                if (self.TitleList[i].KeyId == titleId)
                {
                    return true;
                }
            }
            return false;
        }

        public static void OnActiveTile(this TitleComponent self, int titleId)
        {
            for (int i = self.TitleList.Count - 1; i >= 0; i--)
            {
                if (self.TitleList[i].KeyId == titleId)
                {
                    self.TitleList.RemoveAt(i);
                }
            }

            self.TitleList.Add(new KeyValuePairInt() { KeyId = titleId, Value = TimeHelper.ServerNow() });
        }

    }
}
