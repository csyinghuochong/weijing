using System.Collections.Generic;

namespace ET
{
    public partial class DungeonConfigCategory
    {

        public Dictionary<int, int> DungeonToChapter = new Dictionary<int, int>();

        Dictionary<int, List<KeyValuePairInt>> AutoPathList = new Dictionary<int, List<KeyValuePairInt>> (); 

        public override void AfterEndInit()
        {
            foreach (DungeonConfig functionConfig in this.GetAll().Values)
            {
                int dungeonid = functionConfig.Id;

                if (!string.IsNullOrEmpty(functionConfig.AutoPath))
                {
                    string[] autoPathList = functionConfig.AutoPath.Split(';');
                    for (int i = 0; i < autoPathList.Length; i++)
                    {
                        string[] AutoPathItem = autoPathList[i].Split(',');

                        int targetdungeon = int.Parse(AutoPathItem[0]);
                        int transfomid = int.Parse(AutoPathItem[1]);

                        if (!AutoPathList.ContainsKey(dungeonid))
                        {
                            AutoPathList.Add(dungeonid, new List<KeyValuePairInt>());
                        }

                        AutoPathList[dungeonid].Add(new KeyValuePairInt() { KeyId = targetdungeon, Value = transfomid });
                    }
                }

                DungeonToChapter.Add(dungeonid, functionConfig.ChapterId);
            }
        }

        public int GetTransformId(int dungoenid, int targetdungoen)
        {
            List<KeyValuePairInt> keyValuePairInts = null;
            AutoPathList.TryGetValue( dungoenid, out keyValuePairInts );
            if (keyValuePairInts == null)
            {
                return 0;
            }
            for (int i = 0; i < keyValuePairInts.Count; i++)
            {
                if (  keyValuePairInts[i].KeyId == targetdungoen )
                {
                    return (int)keyValuePairInts[i].Value;
                }
            }
            return 0;
        }
    }
}
