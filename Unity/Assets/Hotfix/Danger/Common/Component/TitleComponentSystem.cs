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
          public static List<HideProList> GetTreasurePro(this TitleComponent self)
        {
            List<HideProList> proList = new List<HideProList>();
            int titleId = self.GetParent<Unit>().GetComponent<NumericComponent>().GetAsInt(NumericType.TitleID);
            if (titleId == 0)
            {
                return proList;
            }

            TitleConfig titleConfig = TitleConfigCategory.Instance.Get(titleId);
            string[] attributeInfoList = titleConfig.AddProperty.Split('@');
            for (int a = 0; a < attributeInfoList.Length; a++)
            {
                string[] attributeInfo = attributeInfoList[a].Split(',');
                int numericType = int.Parse(attributeInfo[0]);

                if (NumericHelp.GetNumericValueType(numericType) == 2)
                {
                    float fvalue = float.Parse(attributeInfo[1]);
                    proList.Add(new HideProList() { HideID = numericType, HideValue = (long)(fvalue * 10000) });
                }
                else
                {
                    proList.Add(new HideProList() { HideID = numericType, HideValue = long.Parse(attributeInfo[1]) });
                }
            }

            return proList;
        }


#endif

        public static void OnLogin(this TitleComponent self)
        {
            self.OnCheckTitle();
        }

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

            TitleConfig titleConfig = TitleConfigCategory.Instance.Get(titleId);
            self.TitleList.Add(new KeyValuePairInt() { KeyId = titleId, Value = TimeHelper.ServerNow() + titleConfig.ValidityTime * 1000 });
        }

    }
}
