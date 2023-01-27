using System.Collections.Generic;

namespace ET
{

    //成就类型数据
    public class SpiritTypeData
    {
        //每个章节对应的成就任务
        public Dictionary<int, List<int>> SpiritChapterTask = new Dictionary<int, List<int>>();
    }

    public class SpiritHelper : Singleton<SpiritHelper>
    {

        public Dictionary<int, List<int>> SpiritTargetData = new Dictionary<int, List<int>>();


        public List<SpiritTypeData> SpiritTypeData = new List<SpiritTypeData>();

        public List<string> SpiritTypeText= new List<string>() { "", "精灵列表", "探索成就", "收集成就" };

        public Dictionary<int, string> ChapterIndexText = new Dictionary<int, string>()
        {
            {0,  "通用" },
            {1,  "第一章" },
            {2,  "第二章" },
            {3,  "第三章" },
            {4,  "第四章" },
            {5,  "第五章" },
            {11,  "角色历练" },
            {12,  "积累成就" },
            {21,  "宠物成就" },
        };

        protected override void InternalInit()
        {
            base.InternalInit();

            InitSpiritList();
        }

        public void InitSpiritList()
        {
            for (int i = 0; i < (int)SpiritTypeEnum.Number; i++)
            {
                SpiritTypeData.Add(new SpiritTypeData());
            }
            Dictionary<int, SpiritConfig> allSpirit = SpiritConfigCategory.Instance.GetAll();

            foreach (var item in allSpirit)
            {
                SpiritConfig SpiritConfig = item.Value;
                int SpiritType = SpiritConfig.Type;
                int chapterId = SpiritConfig.ChapterID;
                int targetType = SpiritConfig.Type;

                SpiritTypeData SpiritTypeDatas = SpiritTypeData[SpiritType];
                if (!SpiritTypeDatas.SpiritChapterTask.ContainsKey(chapterId))
                {
                    SpiritTypeDatas.SpiritChapterTask.Add(chapterId, new List<int>());
                }
                SpiritTypeDatas.SpiritChapterTask[chapterId].Add(item.Key);

                if (!SpiritTargetData.ContainsKey(targetType))
                {
                    SpiritTargetData.Add(targetType, new List<int>());
                }
                SpiritTargetData[targetType].Add(item.Key);
            }
        }

    }
}
