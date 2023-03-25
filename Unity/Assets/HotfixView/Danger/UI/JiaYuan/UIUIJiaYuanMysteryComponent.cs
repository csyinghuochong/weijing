using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIUIJiaYuanMysteryComponent : Entity, IAwake, IDestroy
    {
        public GameObject cellContainer1;
        public GameObject closeButton;
        public GameObject RawImage;

        public UserInfoComponent UserInfoComponent;
        public UIModelShowComponent uIModelShowComponent;
        public List<UI> SellList = new List<UI>();
    }
}