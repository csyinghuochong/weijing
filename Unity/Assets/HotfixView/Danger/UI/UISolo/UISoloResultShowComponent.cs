using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UISoloResultShowComponent : Entity, IAwake
    {
        public GameObject ImageHeadIcon;
        public GameObject Text_Combat;
        public GameObject Text_Name;
        public GameObject Text_Rank;
        public GameObject Text_JiFen;

    }
    public class UISoloResultShowComponentAwake : AwakeSystem<UISoloResultShowComponent>
    {
        public override void Awake(UISoloResultShowComponent self)
        {
            //获取对应的控件
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.ImageHeadIcon = rc.Get<GameObject>("ImageHeadIcon");
            self.Text_Combat = rc.Get<GameObject>("Text_Combat");
            self.Text_Name = rc.Get<GameObject>("Text_Name");
            self.Text_Rank = rc.Get<GameObject>("Text_Rank");
            self.Text_JiFen = rc.Get<GameObject>("Text_JiFen");
        }
    }


    public static class UISoloResultShowComponentSystem {

        public static void OnInit(this UISoloResultShowComponent self, SoloPlayerResultInfo soloInfo,int rank) {

            self.Text_Name.GetComponent<Text>().text = soloInfo.Name;
            self.Text_Rank.GetComponent<Text>().text = rank.ToString();
            self.Text_Combat.GetComponent<Text>().text = $"{soloInfo.WinNum}胜{soloInfo.FailNum}败";
            self.Text_JiFen.GetComponent<Text>().text = soloInfo.Combat.ToString();
        }

    
    }


}
