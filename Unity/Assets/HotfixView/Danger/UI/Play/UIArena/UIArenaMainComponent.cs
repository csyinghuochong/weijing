using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class UIArenaMainComponent : Entity, IAwake
    {
    }

    public static class UIArenaMainComponentSystem
    {
        public static void OnUpdateUI(this UIArenaMainComponent self, M2C_AreneInfoResult message)
        { 
            
        }
    }
}
