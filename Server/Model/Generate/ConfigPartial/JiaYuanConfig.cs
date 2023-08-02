using System.Collections.Generic;

namespace ET
{
    public partial class JiaYuanConfigCategory
    {

        public Dictionary<int, Dictionary<int, int>> JiaYuanProMax = new Dictionary<int, Dictionary<int, int>>();


        public int GetProMax(int jiayuanlv, int keyid)
        {
            if (!JiaYuanProMax.ContainsKey(jiayuanlv))
            {
                return 0;
            }
            if (!JiaYuanProMax[jiayuanlv].ContainsKey(keyid))
            {
                return 0;
            }
            return JiaYuanProMax[jiayuanlv][keyid];
        }

        public override void AfterEndInit()
        {
            foreach (JiaYuanConfig functionConfig in this.GetAll().Values)
            {
   
                if (!JiaYuanProMax.ContainsKey(functionConfig.Id))
                {
                    Dictionary<int, int> keyValuePairs = new Dictionary<int, int>() { };

                    JiaYuanProMax.Add(functionConfig.Id, keyValuePairs);
                    string proMax = functionConfig.ProMax;
                    string[] prolist = proMax.Split(';');

                    for (int i = 0; i < prolist.Length; i++)
                    {
                        if (string.IsNullOrEmpty(prolist[i]))
                        {
                            continue;
                        }
                        string[] proinfo = prolist[i].Split(',');
                        if (proinfo.Length < 2)
                        {
                            continue;
                        }

                        int key = int.Parse(proinfo[0]);
                        int val = int.Parse(proinfo[1]);
                        if (!keyValuePairs.ContainsKey(key))
                        {
                            keyValuePairs.Add( key, val );
                        }
                    }
                }

            }
        }
    }
}
