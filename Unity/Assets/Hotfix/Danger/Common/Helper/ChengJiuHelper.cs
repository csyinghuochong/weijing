using System.Collections.Generic;

namespace ET
{

    //成就类型数据
    public class ChengJiuTypeData
    {
        //每个章节对应的成就任务
        public Dictionary<int, List<int>> ChengJiuChapterTask = new Dictionary<int, List<int>>();
    }

    public class ChengJiuHelper : Singleton<ChengJiuHelper>
    {

        public Dictionary<int, List<int>> ChengJiuTargetData = new Dictionary<int, List<int>>();


        public List<ChengJiuTypeData> ChengJiuTypeData = new List<ChengJiuTypeData>();

        public List<string> ChengJiuTypeText= new List<string>() { "", "关卡成就", "探索成就", "收集成就" };

        public Dictionary<int, string> ChapterIndexText = new Dictionary<int, string>()
        {
            {0,  "通用" },
            {1,  "第一章" },
            {2,  "第二章" },
            {3,  "第三章" },
            {4,  "第四章" },
            {5,  "第五章" },
            {10,  "组队副本" },
            {11,  "角色历练" },
            {12,  "积累成就" },
            {21,  "宠物成就" },
        };

        protected override void InternalInit()
        {
            base.InternalInit();

            InitChengJiuList();
        }

        public void InitChengJiuList()
        {
            for (int i = 0; i < (int)ChengJiuTypeEnum.Number; i++)
            {
                ChengJiuTypeData.Add(new ChengJiuTypeData());
            }
            Dictionary<int, ChengJiuConfig> allChengjiu = ChengJiuConfigCategory.Instance.GetAll();

            foreach (var item in allChengjiu)
            {
                ChengJiuConfig chengJiuConfig = item.Value;
                int chengjiuType = chengJiuConfig.ChengjiuType;
                int chapterId = chengJiuConfig.ChapterId;
                int targetType = chengJiuConfig.TargetType;

                ChengJiuTypeData chengJiuTypeDatas = ChengJiuTypeData[chengjiuType];
                if (!chengJiuTypeDatas.ChengJiuChapterTask.ContainsKey(chapterId))
                {
                    chengJiuTypeDatas.ChengJiuChapterTask.Add(chapterId, new List<int>());
                }
                chengJiuTypeDatas.ChengJiuChapterTask[chapterId].Add(item.Key);

                if (!ChengJiuTargetData.ContainsKey(targetType))
                {
                    ChengJiuTargetData.Add(targetType, new List<int>());
                }
                ChengJiuTargetData[targetType].Add(item.Key);
            }
        }

    }
}
