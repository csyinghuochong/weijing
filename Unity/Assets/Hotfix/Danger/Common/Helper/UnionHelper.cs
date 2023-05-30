using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public static class UnionHelper
    {

        public static Dictionary<int, string> UnionPosition = new Dictionary<int, string>
        {
            { 0, "族员"},
            { 1, "族长"},
            { 2, "副族长"},
            { 3, "长老"},
        };

        public static int GetXiuLianId(int postion)
        {
            int numerType = 0;
            switch (postion)
            {
                case 0:
                    numerType = NumericType.UnionXiuLian_0;
                    break;
                case 1:
                    numerType = NumericType.UnionXiuLian_1;
                    break;
                case 2:
                    numerType = NumericType.UnionXiuLian_2;
                    break;
                case 3:
                    numerType = NumericType.UnionXiuLian_3;
                    break;
                default:
                    break;
            }
            return numerType;
        }
    }
}
