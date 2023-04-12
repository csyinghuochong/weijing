using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{

    [Timer(TimerType.AccountCenterTimer)]
    public class AccountCenterTimer : ATimer<AccountCenterComponent>
    {
        public override void Run(AccountCenterComponent self)
        {
            try
            {
                self.SaveDB().Coroutine();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    [ObjectSystem]
    public class AccountCenterComponentAwake : AwakeSystem<AccountCenterComponent>
    {
        public override void Awake(AccountCenterComponent self)
        {
            self.InitDBRankInfo().Coroutine();
          
            self.Timer = TimerComponent.Instance.NewRepeatedTimer(TimeHelper.Minute * 5 + self.DomainZone() * 800, TimerType.AccountCenterTimer, self);
        }
    }

    [ObjectSystem]
    public class AccountCenterComponentDestroy : DestroySystem<AccountCenterComponent>
    {
        public override void Destroy(AccountCenterComponent self)
        {
            TimerComponent.Instance.Remove(ref self.Timer);
        }
    }


    public static class AccountCenterComponentSystem
    {

        public static int GetSerialKeyId(this AccountCenterComponent self, string serial)
        {
            DBCenterSerialInfo dBCenterSerialInfo = self.DBCenterSerialInfo;
            for (int i = 0; i < dBCenterSerialInfo.SerialList.Count; i++)
            {
                if (dBCenterSerialInfo.SerialList[i].Value != serial)
                {
                    continue;
                }

                return dBCenterSerialInfo.SerialList[i].KeyId ;
            }
            return 1;
        }

        public static int GetSerialReward(this AccountCenterComponent self, string serial)
        {
            DBCenterSerialInfo dBCenterSerialInfo = self.DBCenterSerialInfo;
            for (int i = dBCenterSerialInfo.SerialList.Count - 1; i >= 0; i--)
            {
                if (dBCenterSerialInfo.SerialList[i].Value != serial)
                {
                    continue;
                }
                if (dBCenterSerialInfo.SerialList[i].Value2 == "1")
                {
                    return ErrorCore.ERR_AlreadyReceived;
                }

                dBCenterSerialInfo.SerialList[i].Value2 = "1";
                return ErrorCore.ERR_Success;
            }
            return ErrorCore.ERR_SerialNoExist;
        }

        public static void GenerateSerials(this AccountCenterComponent self, int sindex)
        {
            DBCenterSerialInfo dBCenterSerialInfo = self.DBCenterSerialInfo;
            for (int i = dBCenterSerialInfo.SerialList.Count - 1; i >= 0; i--)
            {
                if (dBCenterSerialInfo.SerialList[i].KeyId == sindex)
                {
                    Log.Debug("生成序列号: 重复");
                    return;
                }
            }

            Log.Debug("生成序列号: start");
            string codelist = string.Empty;
            self.DBCenterSerialInfo.SerialIndex = sindex;
            SerialHelper serialHelper = new SerialHelper();
            serialHelper.rep = sindex * 500;
            for (int i = 0; i < 500; i++)
            {
                string code = serialHelper.GenerateCheckCode(6);
                dBCenterSerialInfo.SerialList.Add(new KeyValuePair() { KeyId = sindex, Value = code, Value2 = "0" });
                codelist += code;
                codelist += "\r\n";
            }
            Log.Debug(codelist);
            Log.Debug("生成序列号: end");
        }

        public static async ETTask InitDBRankInfo(this AccountCenterComponent self)
        {
            List<DBCenterSerialInfo> d2GGetUnit = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterSerialInfo>(self.DomainZone(), _account => _account.Id == self.DomainZone());
            if (d2GGetUnit.Count == 0)
            {
                self.DBCenterSerialInfo = new DBCenterSerialInfo();
                self.DBCenterSerialInfo.Id = self.DomainZone();
            }
            else
            {
                self.DBCenterSerialInfo = d2GGetUnit[0];
            }

            self.SaveDB().Coroutine();
        }

        public static async ETTask SaveDB(this AccountCenterComponent self)
        {
            await Game.Scene.GetComponent<DBComponent>().Save<DBCenterSerialInfo>(self.DomainZone(), self.DBCenterSerialInfo);

            self.TianQITime++;
            if (self.TianQITime >= 12)
            {
                self.TianQITime = 0;
                //self.TianQiValue = RandomHelper.RandomNumber(1, 3);

                int[] rand = { 95,4,1 };
                int index = RandomHelper.RandomByWeight(rand);
                switch (index) {
                    case 0:
                        return;
                    case 1:
                        self.TianQiValue = 1;
                        break;
                    case 2:
                        self.TianQiValue = 2;
                        break;
                }

                List<int> zones = ServerMessageHelper.GetAllZone();
                for (int i = 0; i < zones.Count; i++)
                {
                    long chatServerId = StartSceneConfigCategory.Instance.GetBySceneName(zones[i], "Chat").InstanceId;
                    A2A_ServerMessageRResponse g_SendChatRequest = (A2A_ServerMessageRResponse)await ActorMessageSenderComponent.Instance.Call
                        (chatServerId, new A2A_ServerMessageRequest()
                        {
                            MessageType = NoticeType.TianQiChange,
                            MessageValue = self.TianQiValue.ToString(),
                        });

                    await TimerComponent.Instance.WaitAsync(10000);
                }
            }
        }
    }
}
