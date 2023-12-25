using System.Collections.Generic;

namespace ET
{
    public static class UserInfoComponentSystemEx
    {

        public static List<int> GetMakeListByType(this UserInfoComponent self, int makeType)
        {
            List<int> makeIds =  new List<int> { };
            if (makeType == 0)
            { 
                return makeIds;
            }
            for(int i = 0; i < self.UserInfo.MakeList.Count; i++)
            {
                EquipMakeConfig equipMakeConfig = EquipMakeConfigCategory.Instance.Get(self.UserInfo.MakeList[i]);
                if (equipMakeConfig.ProficiencyType == makeType)
                {
                    makeIds.Add(self.UserInfo.MakeList[i]);
                }
            }
            return makeIds; 
        }

        public static void ClearMakeListByType(this UserInfoComponent self, int makeType)
        {
            if (makeType == 0)
            {
                return;
            }
            for (int i = self.UserInfo.MakeList.Count - 1; i >= 0; i--)
            {
                int makeId = self.UserInfo.MakeList[i];
                if (makeId == 0)
                {
                    self.UserInfo.MakeList.RemoveAt(i);
                    continue;
                }

                EquipMakeConfig equipMakeConfig = EquipMakeConfigCategory.Instance.Get(makeId);
                if (equipMakeConfig.ProficiencyType == makeType)
                {
                    self.UserInfo.MakeList.RemoveAt(i); 
                }
            }
        }

        public static int GetMonsterKillNumber(this UserInfoComponent self, int monsterId)
        {
            for (int i = 0; i < self.UserInfo.MonsterRevives.Count; i++)
            {
                KeyValuePair keyValuePair = self.UserInfo.MonsterRevives[i];
                if (keyValuePair.KeyId != monsterId)
                {
                    continue;
                }
                if (!string.IsNullOrEmpty(keyValuePair.Value2))
                {
                    return int.Parse(keyValuePair.Value2);
                }
                else
                {
                    return 1;
                }
            }
            return 0;
        }

        public static long GetReviveTime(this UserInfoComponent self, int monsterId)
        {
            for (int i = 0; i < self.UserInfo.MonsterRevives.Count; i++)
            {
                if (self.UserInfo.MonsterRevives[i].KeyId == monsterId)
                {
                    return long.Parse(self.UserInfo.MonsterRevives[i].Value);
                }
            }
            return 0;
        }
       
        public static long GetSceneFubenTimes(this UserInfoComponent self, int sceneId)
        {
            for (int i = 0; i < self.UserInfo.DayFubenTimes.Count; i++)
            {
                if (self.UserInfo.DayFubenTimes[i].KeyId == sceneId)
                {
                    return self.UserInfo.DayFubenTimes[i].Value;
                }
            }
            return 0;
        }
       
        public static int GetDayItemUse(this UserInfoComponent self, int mysteryId)
        {
            for (int i = 0; i < self.UserInfo.DayItemUse.Count; i++)
            {
                if (self.UserInfo.DayItemUse[i].KeyId == mysteryId)
                {
                    return (int)self.UserInfo.DayItemUse[i].Value;
                }
            }
            return 0;
        }


        public static void OnDayItemUse(this UserInfoComponent self, int itemId)
        {
            for (int i = 0; i < self.UserInfo.DayItemUse.Count; i++)
            {
                if (self.UserInfo.DayItemUse[i].KeyId == itemId)
                {
                    self.UserInfo.DayItemUse[i].Value += 1;
                    return;
                }
            }
            self.UserInfo.DayItemUse.Add(new KeyValuePairInt() { KeyId = itemId, Value = 1 });
        }

        public static void AddSceneFubenTimes(this UserInfoComponent self, int sceneId)
        {
            for (int i = 0; i < self.UserInfo.DayFubenTimes.Count; i++)
            {
                if (self.UserInfo.DayFubenTimes[i].KeyId == sceneId)
                {
                    self.UserInfo.DayFubenTimes[i].Value++;
                    return;
                }
            }
            self.UserInfo.DayFubenTimes.Add(new KeyValuePairInt() { KeyId = sceneId, Value = 1 });
        }

        public static void ClearFubenTimes(this UserInfoComponent self, int sceneId)
        {
            for (int i = 0; i < self.UserInfo.DayFubenTimes.Count; i++)
            {
                if (self.UserInfo.DayFubenTimes[i].KeyId == sceneId)
                {
                    self.UserInfo.DayFubenTimes[i].Value = 0;
                    break;
                }
            }
        }


        public static void AddFubenTimes(this UserInfoComponent self, int sceneId, int times)
        {
            for (int i = 0; i < self.UserInfo.DayFubenTimes.Count; i++)
            {
                if (self.UserInfo.DayFubenTimes[i].KeyId == sceneId)
                {
                    long curTimes = self.UserInfo.DayFubenTimes[i].Value -= times;
                    if (curTimes < 0)
                    {
                        curTimes = 0;
                    }
                    self.UserInfo.DayFubenTimes[i].Value = curTimes;
                    break;
                }
            }
        }

    }



}