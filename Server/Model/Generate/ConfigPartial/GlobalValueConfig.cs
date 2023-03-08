using System.Collections.Generic;


namespace ET
{

    public struct DayMonsters
    {
        public int MonsterId;
        public float GaiLv;
        public int TotalNumber;
    }

    public partial class GlobalValueConfigCategory
    {

        public int JianDingFuQulity = 0;

        public int FangunSkillId = 0;

        public int BagMaxCapacity = 0;

        public List<DayMonsters> DayMonsterList = new List<DayMonsters>();

        public override void AfterEndInit()
        {
            DayMonsterList.Clear();
            JianDingFuQulity = this.Get(44).Value2;
            FangunSkillId = int.Parse(this.Get(2).Value);
            BagMaxCapacity = this.Get(3).Value2;

            string[] dayrefresh = this.Get(79).Value.Split('@');
            for (int i = 0; i < dayrefresh.Length; i++)
            {
                string[] itemInfo = dayrefresh[i].Split(';');
                int monsterId = int.Parse(itemInfo[0]);
                float gaiLv = float.Parse(itemInfo[1]);
                int total = int.Parse(itemInfo[2]);
                DayMonsterList.Add(new DayMonsters()
                {
                    MonsterId = monsterId,
                    GaiLv = gaiLv,
                    TotalNumber = total
                });
            }
        }
    }
}
