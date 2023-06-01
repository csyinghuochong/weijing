using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UISoloRewardComponent:Entity,IAwake
    {
        public GameObject Text_ReturnTime;
        public GameObject Text_Result;
        public GameObject Btn_Return;
        public GameObject ItemListNode;

    }

    public class UISoloRewardComponentAwakeSystem : AwakeSystem<UISoloRewardComponent>
    {
        public override void Awake(UISoloRewardComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.Text_ReturnTime = rc.Get<GameObject>("Text_ReturnTime");
            self.Text_Result = rc.Get<GameObject>("Text_Ceng");
            self.Btn_Return = rc.Get<GameObject>("Btn_Return");
            self.ItemListNode = rc.Get<GameObject>("ItemListNode");
            ButtonHelp.AddListenerEx(self.Btn_Return, () => { self.ReturnBtn(); });
        }
    }

    public static class UISoloRewardComponentSystem {

        public static void OnInit(this UISoloRewardComponent self,int type, List<RewardItem> rewardItem) {

            if (type == 1)
            {
                self.Text_Result.GetComponent<Text>().text = "恭喜你！获得本场挑战的胜利";
            }
            else {
                self.Text_Result.GetComponent<Text>().text = "非常遗憾！你在本场挑战失败,请再接再厉";
            }

            //显示奖励列表
            if (rewardItem != null && rewardItem.Count != 0)
            {
                UICommonHelper.ShowItemList(rewardItem, self.ItemListNode, self, 1);
            }
            self.TimeDestory().Coroutine();
        }

        public static async ETTask TimeDestory(this UISoloRewardComponent self) {

            //10秒后强退
            for (int i = 10; i >= 0; i--)
            {
                await TimerComponent.Instance.WaitAsync(1000);
                if (self.Text_ReturnTime != null)
                {
                    self.Text_ReturnTime.GetComponent<Text>().text = $"{i}秒后自动回城";
                }
                if (i <= 0)
                {
                    self.ReturnBtn();
                }
            }
            
        }

        public static void ReturnBtn(this UISoloRewardComponent self) {

            Log.Debug("我点击了返回主城按钮");
            EnterFubenHelp.RequestQuitFuben(self.ZoneScene());
            UIHelper.Remove(self.ZoneScene(), UIType.UISoloReward);
        }

    }
}
