using System.Collections.Generic;

namespace ET
{

    public static class FashionHelper
    {

        public static Dictionary<int, List<string>> FashionBaseTemplate(int occ)
        {
            if (occ == 1)
            {
                return FashionBaseTemplate_1;
            }
            if (occ == 2)
            {
                return FashionBaseTemplate_2;
            }
            if (occ == 3)
            {
                return FashionBaseTemplate_3;
            }
            return FashionBaseTemplate_4;
        }

        //1001  头饰
        //2001  脸
        //3001  身体
        /// <summary>
        /// 默认配置
        /// </summary>
        //战士
        public static Dictionary<int, List<string>> FashionBaseTemplate_1 = new Dictionary<int, List<string>>()
        {
            { 1001,     new List<string>(){"Hero_toufa",} },
            { 2001 ,    new List<string>(){ "Hero_lian", "Hero_meimao", "Hero_yanjing" } },
            { 3001,     new List<string>(){"Hero_pifeng", "Hero_shangyi", "Hero_xiashen", "Hero_xiezi" } }
        };

        //法师
        public static Dictionary<int, List<string>> FashionBaseTemplate_2 = new Dictionary<int, List<string>>()
        {
            { 1001,     new List<string>(){"Hero_toufa", "Hero_fashi", "fashi_fashi2" } },
            { 2001 ,    new List<string>(){ "Hero_lian", "Hero_meimao", "Hero_yanjing" } },
            { 3001,     new List<string>(){"Hero_shangyi", "Hero_xiashen", "Hero_xiezi", "Hero_pifu1", "Hero_pifu2" } }
        };

        //猎人
        public static Dictionary<int, List<string>> FashionBaseTemplate_3 = new Dictionary<int, List<string>>()
        {
            { 1001,     new List<string>(){"Hero_toufa", "Hero_fashi" } },
            { 2001 ,    new List<string>(){ "Hero_lian", "Hero_meimao", "Hero_yanjing" } },
            { 3001,     new List<string>(){ "Hero_weijin","Hero_shangyi", "Hero_xiashen", "Hero_xiezi" } }
        };

        //唤魔师
        public static Dictionary<int, List<string>> FashionBaseTemplate_4 = new Dictionary<int, List<string>>()
        {
            { 1001,     new List<string>(){"Hero_toufa", "Hero_fashi", "fashi_fashi2" } },
            { 2001 ,    new List<string>(){ "Hero_lian", "Hero_meimao", "Hero_yanjing" } },
            { 3001,     new List<string>(){"Hero_shangyi", "Hero_xiashen", "Hero_xiezi"} }
        };

    }
}