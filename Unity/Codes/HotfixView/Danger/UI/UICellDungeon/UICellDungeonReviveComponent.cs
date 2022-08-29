
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UICellDungeonReviveComponent : Entity, IAwake, IUpdate
    {
        public GameObject Text_CostName;
        public GameObject ImageCost;
        public GameObject Text_Cost;
        public GameObject Text_ExitTip;
        public GameObject Button_Revive;
        public GameObject Button_Exit;

        public int LeftTime;
        public float Timer;
    }

    [ObjectSystem]
    public class UILevelReviveComponentAwakeSystem : AwakeSystem<UICellDungeonReviveComponent>
    {
        public override void Awake(UICellDungeonReviveComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Text_CostName = rc.Get<GameObject>("Text_CostName");
            self.ImageCost = rc.Get<GameObject>("ImageCost");
            self.Text_Cost = rc.Get<GameObject>("Text_Cost");
            self.Text_ExitTip = rc.Get<GameObject>("Text_ExitTip");
            self.Button_Revive = rc.Get<GameObject>("Button_Revive");
            self.Button_Exit = rc.Get<GameObject>("Button_Exit");

            self.Button_Revive.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_Revive(); });
            self.Button_Exit.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_Exit(); });

            self.LeftTime = 10;
            self.OnInitUI();
        }
    }

    [ObjectSystem]
    public class UILevelReviveComponentUpdateSystem : UpdateSystem<UICellDungeonReviveComponent>
    {
        public override void Update(UICellDungeonReviveComponent self)
        {
            self.Check();
        }
    }

    public static class UILevelReviveComponentSystem
    {
        public static void Check(this UICellDungeonReviveComponent self)
        {
            self.Timer += Time.deltaTime;
            if (self.Timer < 1)
                return;
            self.Timer = 0;

             self.LeftTime--;
            if (self.LeftTime < 0)
                self.OnButton_Exit();
            else
                self.Text_ExitTip.GetComponent<Text>().text = string.Format("{0}秒后退出副本", self.LeftTime);
        }

        public static void OnInitUI(this UICellDungeonReviveComponent self)
        {
            string reviveCost = GlobalValueConfigCategory.Instance.Get(5).Value;
            string[] needList = reviveCost.Split(';');

            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(int.Parse(needList[0]));
            self.Text_ExitTip.GetComponent<Text>().text = string.Format("{0}秒后退出副本", self.LeftTime);
            self.Text_CostName.GetComponent<Text>().text = itemConfig.ItemName;

            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.ItemIcon, itemConfig.Icon);
            self.ImageCost.GetComponent<Image>().sprite = sp;

            //显示副本
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            long selfNum = bagComponent.GetItemNumber(int.Parse(needList[0]));
            long needNum = int.Parse(needList[1]);
            if (selfNum >= needNum)
            {
                self.Text_Cost.GetComponent<Text>().text = selfNum + "/" + needNum;
                self.Text_Cost.GetComponent<Text>().color = Color.green;
            }
            else {
                self.Text_Cost.GetComponent<Text>().text = selfNum + "/" + needNum + "("+"道具不足"+")";
                self.Text_Cost.GetComponent<Text>().color = Color.yellow;
            }
            
        }

        public static void OnButton_Revive(this UICellDungeonReviveComponent self)
        {
            string reviveCost = GlobalValueConfigCategory.Instance.Get(5).Value;
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            bool success = bagComponent.CheckNeedItem(reviveCost);
            if (!success)
            {
                FloatTipManager.Instance.ShowFloatTip("道具不足");
                return;
            }

            EnterFubenHelp.SendReviveRequest(self.DomainScene()).Coroutine();
            UIHelper.Remove(self.DomainScene(), UIType.UICellDungeonRevive).Coroutine();
        }

        public static void OnButton_Exit(this UICellDungeonReviveComponent self)
        {
            EnterFubenHelp.RequestQuitFuben(self.DomainScene());
            UIHelper.Remove(self.DomainScene(), UIType.UICellDungeonRevive).Coroutine();
        }

    }

}
