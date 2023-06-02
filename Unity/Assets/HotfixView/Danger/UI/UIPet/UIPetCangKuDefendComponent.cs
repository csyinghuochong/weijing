using ET;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPetCangKuDefendComponent : Entity, IAwake<GameObject>
    {
        public GameObject GameObject;
    }

    public static class UIPetCangKuDefendComponentSystem
    {
        public static void OnUpdateUI(this UIPetCangKuDefendComponent self, int index)
        { 
            
        }
    }
}