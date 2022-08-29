using System;
using System.Collections.Generic;
using System.IO;

namespace ET
{
    [ObjectSystem]
    public class RandNameComponentAwakeSystem : AwakeSystem<RandNameComponent>
    {
        public override void Awake(RandNameComponent self)
        {
            self.RandNameXing = self.ReadFile("../Config/Name/RandName_Xing.txt");
            self.RandNameNameList = self.ReadFile("../Config/Name/RandName_Name.txt");
        }
    }

    public static class RandNameComponentSystem
    {

        public static List<string> ReadFile(this RandNameComponent self, string path)
        {
            List<string> vs = new List<string>();
            string ReadLine;
            string[] array;
            StreamReader reader = new StreamReader(path, System.Text.Encoding.Default);
            while (reader.Peek() >= 0)
            {
                try
                {
                    ReadLine = reader.ReadLine();
                    if (ReadLine != "")
                    {
                        ReadLine = ReadLine.Replace("\"", "");
                        array = ReadLine.Split('@');
                        if (array.Length == 0)
                        {
                            break;
                        }
                        vs.Add(array[0]);
                    }
                }
                catch (Exception ex)
                {
                    Log.Debug(ex.ToString());
                    break;
                }
            }

            return vs;
        }

        public static string GetRandomName(this RandNameComponent self)
        {
            int xingXuHao = RandomHelper.RandomNumber(0, self.RandNameXing.Count);
            int nameXuHao = RandomHelper.RandomNumber(0, self.RandNameNameList.Count);
            return self.RandNameXing[xingXuHao] + self.RandNameNameList[nameXuHao];
        }
    }
}
