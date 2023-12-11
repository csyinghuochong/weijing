using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class UnitGuaJiComponen:Entity,IAwake,IDestroy
    {

        public int forNum;
        public bool MoveStatus;         //移动状态
        public bool FightStatus;        //战斗状态
        public bool IfSellStatus;
        public bool IfGuaJiRange;
        public bool IfGuaJiAutoUseItem;
        public List<int> skillXuHaoList;
        public UI UIMain;
        public int XuHaoNum;

        public LockTargetComponent LockTargetComponent;
    }
}
