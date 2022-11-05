using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    [Timer(TimerType.DungeonReviveTimer)]
    public class DungeonReviveTimer : ATimer<UICellDungeonReviveComponent>
    {
        public override void Run(UICellDungeonReviveComponent self)
        {
            try
            {
                self.Check();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    public class UICellDungeonReviveComponent : Entity, IAwake, IDestroy
    {
        public GameObject Text_CostName;
        public GameObject ImageCost;
        public GameObject Text_Cost;
        public GameObject Text_ExitTip;
        public GameObject Button_Revive;
        public GameObject Button_Exit;
        public GameObject Text_ExitDes;

        public long Timer;
        public int LeftTime;
        public int SceneType;
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
            self.Text_ExitDes = rc.Get<GameObject>("Text_ExitDes");

            self.Button_Revive.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_Revive(); });
            self.Button_Exit.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_Exit(); });
        }
    }

    [ObjectSystem]
    public class UILevelReviveComponentDestroySystem : DestroySystem<UICellDungeonReviveComponent>
    {
        public override void Destroy(UICellDungeonReviveComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }

    public static class UILevelReviveComponentSystem
    {
        public static void Check(this UICellDungeonReviveComponent self)
        {
            if (self.LeftTime < 0)
            {
                self.OnAuto_Exit();
                TimerComponent.Instance?.Remove(ref self.Timer);
            }
            else
            {
                self.Text_ExitTip.GetComponent<Text>().text = string.Format("{0}秒后退出副本", self.LeftTime);
            }
            self.LeftTime--;
        }

        public static bool IsNoAutoExit(this UICellDungeonReviveComponent self, int sceneType)
        {
            return sceneType == SceneTypeEnum.TeamDungeon || sceneType == SceneTypeEnum.Battle;
        }

        public static void OnInitUI(this UICellDungeonReviveComponent self, int seneTypeEnum)
        {
            self.SceneType = seneTypeEnum;
            self.LeftTime = seneTypeEnum == SceneTypeEnum.TeamDungeon ? 20 : 10;
            self.Timer = TimerComponent.Instance.NewRepeatedTimer(1000, TimerType.DungeonReviveTimer, self);

            self.Check();
            string reviveCost = GlobalValueConfigCategory.Instance.Get(5).Value;
            string[] needList = reviveCost.Split(';');

            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(int.Parse(needList[0]));
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
            else 
            {
                self.Text_Cost.GetComponent<Text>().text = selfNum + "/" + needNum + "("+"道具不足"+")";
                self.Text_Cost.GetComponent<Text>().color = Color.yellow;
            }

            if (self.SceneType != SceneTypeEnum.LocalDungeon) {
                self.Text_ExitDes.GetComponent<Text>().text = "返回出生点";
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
            UIHelper.Remove(self.DomainScene(), UIType.UICellDungeonRevive);
        }

        public static void OnAuto_Exit(this UICellDungeonReviveComponent self)
        {
            MapComponent mapComponent = self.ZoneScene().GetComponent<MapComponent>();
            if (!self.IsNoAutoExit(mapComponent.SceneTypeEnum))
            {
                EnterFubenHelp.RequestQuitFuben(self.DomainScene());
                UIHelper.Remove(self.DomainScene(), UIType.UICellDungeonRevive);
            }
        }

        public static void RequestTeamDungeonRBorn(this UICellDungeonReviveComponent self)
        {
            C2M_TeamDungeonRBornRequest request = new C2M_TeamDungeonRBornRequest() { };
            self.ZoneScene().GetComponent<SessionComponent>().Session.Send(request);
        }

        public static void OnButton_Exit(this UICellDungeonReviveComponent self)
        {
            MapComponent mapComponent = self.ZoneScene().GetComponent<MapComponent>();
            if (self.IsNoAutoExit(mapComponent.SceneTypeEnum))
            {
                if (self.LeftTime > 0)
                {
                    if (self.SceneType == SceneTypeEnum.LocalDungeon)
                    {
                        FloatTipManager.Instance.ShowFloatTip($"{self.LeftTime}秒后可返回主城！");
                    }
                    else {
                        FloatTipManager.Instance.ShowFloatTip($"{self.LeftTime}秒后可返回出生点！");
                    }
                }
                else
                {
                    self.RequestTeamDungeonRBorn();
                    UIHelper.Remove(self.DomainScene(), UIType.UICellDungeonRevive);
                }
            }
            else
            {
                EnterFubenHelp.RequestQuitFuben(self.DomainScene());
                UIHelper.Remove(self.DomainScene(), UIType.UICellDungeonRevive);
            }
        }

    }

}
