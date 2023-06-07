using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIJiaYuanChouKaComponent:Entity, IAwake, IDestroy
    {

        public GameObject Btn_ChouKaOne;
        public GameObject Btn_ChouKaTen;

        public GameObject chouKaShowItemNode;
    }

    public class UIJiaYuanChouKaComponentIAwake : AwakeSystem<UIJiaYuanChouKaComponent>
    {
        public override void Awake(UIJiaYuanChouKaComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Btn_ChouKaOne = rc.Get<GameObject>("Btn_ChouKaOne");
            self.Btn_ChouKaTen = rc.Get<GameObject>("Btn_ChouKaTen");
            self.chouKaShowItemNode = rc.Get<GameObject>("chouKaShowItemNode");

            self.Btn_ChouKaOne.GetComponent<Button>().onClick.AddListener(()=>self.ChouKa(1));
            self.Btn_ChouKaOne.GetComponent<Button>().onClick.AddListener(() => self.ChouKa(10));

        }

    }

    public static class UIJiaYuanChouKaComponentSystem {

        //抽卡
        public static void ChouKa(this UIJiaYuanChouKaComponent self,int chouKaNum) { 
        


        }

        //展示抽卡
        public static void ShowChouKaReward(this UIJiaYuanChouKaComponent self) {
            string rewardListStr = "10036001;1@10036035;1";
            UICommonHelper.ShowItemList(rewardListStr, self.chouKaShowItemNode, self, 0.8f);
        }
    }
}
