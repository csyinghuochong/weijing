using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public static class AccountCenterComponentHelper
    {


        public static void CheckSerials(this AccountCenterComponent self)
        {
            Log.Warning("移除第七/八批序列号");
            DBCenterSerialInfo dBCenterSerialInfo = self.DBCenterSerialInfo;
            for (int i = dBCenterSerialInfo.SerialList.Count - 1; i >= 0; i--)
            {
                if (dBCenterSerialInfo.SerialList[i].KeyId == 7
                    || dBCenterSerialInfo.SerialList[i].KeyId == 8)
                {
                    dBCenterSerialInfo.SerialList.RemoveAt(i);  
                }
            }
            dBCenterSerialInfo.SerialIndex = 5;
        }

        public static void GenerateSerials(this AccountCenterComponent self, int sindex)
        {
            DBCenterSerialInfo dBCenterSerialInfo = self.DBCenterSerialInfo;
            for (int i = dBCenterSerialInfo.SerialList.Count - 1; i >= 0; i--)
            {
                if (dBCenterSerialInfo.SerialList[i].KeyId == sindex)
                {
                    Log.Warning("生成序列号: 重复");
                    Console.WriteLine("生成序列号: 重复");
                    return;
                }
            }

            Console.WriteLine($"生成第{sindex}序列号: start");
            Log.Warning($"生成第{sindex}序列号: start");
            string codelist = string.Empty;
            self.DBCenterSerialInfo.SerialIndex = sindex;
            SerialHelper serialHelper = new SerialHelper();
            serialHelper.rep = sindex * 1000;  //累加.每次生成1000
            for (int i = 0; i < 1000; i++)
            {
                string code = serialHelper.GenerateCheckCode(6);
                dBCenterSerialInfo.SerialList.Add(new KeyValuePair() { KeyId = sindex, Value = code, Value2 = "0" });
                codelist += code;
                codelist += "\r\n";
            }
            LogHelper.PaiMaiInfo(codelist);
            Log.Warning($"生成第{sindex}序列号: end");
            Console.WriteLine($"生成第{sindex}序列号: end");
        }

    }
}
