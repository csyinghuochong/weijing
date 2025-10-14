using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UICellDungeonReviveComponent : Entity, IAwake,IDestroy
    {
        public GameObject Text_CostName;
        public GameObject ImageCost;
        public GameObject Text_Cost;
        public GameObject Text_ExitTip;
        public GameObject Button_Revive;
        public GameObject Button_Exit;
        public GameObject Text_ExitDes;
        public GameObject Node_2;
        public GameObject Node_1;

        public long Timer;
        public int LeftTime;
        public int SceneType;
        
        public List<string> AssetPath = new List<string>();
    }


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

            self.Node_1 = rc.Get<GameObject>("Node_1");
            self.Node_2 = rc.Get<GameObject>("Node_2");

            self.Button_Revive.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_Revive(); });
            self.Button_Exit.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_Exit(); });

            ButtonHelp.AddListenerEx(self.Node_2.transform.Find("Item_1/Button_GoTo").gameObject, () => { self.OnButton_GoToOpera(1); });
            ButtonHelp.AddListenerEx(self.Node_2.transform.Find("Item_2/Button_GoTo").gameObject, () => { self.OnButton_GoToOpera(2); });
            ButtonHelp.AddListenerEx(self.Node_2.transform.Find("Item_3/Button_GoTo").gameObject, () => { self.OnButton_GoToOpera(3); });
            ButtonHelp.AddListenerEx(self.Node_2.transform.Find("Item_4/Button_GoTo").gameObject, () => { self.OnButton_GoToOpera(4); });

            self.OnLanguageUpdate();
        }
    }
    public class UICellDungeonReviveComponentDestroy : DestroySystem<UICellDungeonReviveComponent>
    {
        public override void Destroy(UICellDungeonReviveComponent self)
        {
            for(int i = 0; i < self.AssetPath.Count; i++)
            {
                if (!string.IsNullOrEmpty(self.AssetPath[i]))
                {
                    ResourcesComponent.Instance.UnLoadAsset(self.AssetPath[i]); 
                }
            }
            self.AssetPath = null;
        }
    }
    public static class UICellDungeonReviveComponentSystem
    {
        public static void OnLanguageUpdate(this UICellDungeonReviveComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            rc.Get<GameObject>("Text_ExitTip_2").GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 48 : 40;
            if (GameSettingLanguge.Language == 1)
            {
                Vector2 position = rc.Get<GameObject>("Img_ExitTip").GetComponent<RectTransform>().localPosition;
                position.y = -450f;
                rc.Get<GameObject>("Img_ExitTip").GetComponent<RectTransform>().localPosition = position;
                
                position = rc.Get<GameObject>("Text_CostName").GetComponent<RectTransform>().localPosition;
                position.x = 300f;
                rc.Get<GameObject>("Text_CostName").GetComponent<RectTransform>().localPosition = position;
            }
        }

        public static bool IsNoAutoExit(this UICellDungeonReviveComponent self, int sceneType)
        {
            return sceneType == SceneTypeEnum.TeamDungeon
                || sceneType == SceneTypeEnum.Battle
                || sceneType == SceneTypeEnum.BaoZang
                || sceneType == SceneTypeEnum.MiJing
                || sceneType == SceneTypeEnum.UnionRace;
        }

        public static void Check(this UICellDungeonReviveComponent self, int leftTime)
        {
            self.LeftTime = leftTime;
            self.Text_ExitTip.GetComponent<Text>().text = string.Format(GameSettingLanguge.LoadLocalization("{0}秒后退出副本"), leftTime);
            if (leftTime <= 0)
            {
                self.OnAuto_Exit();
            }
        }


        public static async ETTask BegingTimer(this UICellDungeonReviveComponent self)
        {
            self.Check(self.LeftTime);
            long instanceId = self.InstanceId;
            for (int i = self.LeftTime -1; i >= 0; i--)
            {
                await TimerComponent.Instance.WaitAsync(1000);
                if (instanceId != self.InstanceId)
                {
                    return;
                }
                self.Check(i);
            }
        }

        public static  void OnButton_GoToOpera(this UICellDungeonReviveComponent self, int operatype)
        {
            self.ZoneScene().GetComponent<BattleMessageComponent>().GoToOperate = operatype;
            self.OnButton_Exit();
        }

        public static void UpdateStatus(this UICellDungeonReviveComponent self)
        {
            int operatenum = 0;
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            UserInfo userInfo = userInfoComponent.UserInfo;
            List<BagInfo> bagitemlist = bagComponent.GetBagList();
            for (int i = 0; i < bagitemlist.Count; i++)
            {
                BagInfo bagInfo = bagitemlist[i];
                if (bagInfo == null)
                {
                    continue;
                }

                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfo.ItemID);
                List<BagInfo> curEquiplist = bagComponent.GetEquipListByWeizhi(itemConfig.ItemSubType);

                bool showup = ItemHelper.CheckUpItem(userInfo, bagInfo, curEquiplist);
                if (showup)
                {
                    operatenum |= 1<<1;
                    break;
                }
            }

            SkillSetComponent skillSetComponent = self.ZoneScene().GetComponent<SkillSetComponent>();
            int skillsp = userInfoComponent.UserInfo.Sp;
            if( skillsp >= 3 && skillSetComponent.GetCanUpSkill(skillsp).Count > 0)
            {
                operatenum |= 1 << 2;
            }

            PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
            if (petComponent.FightPetId==0 && petComponent.RolePetInfos.Count > 0 && petComponent.GetFightPetId() == 0)
            {
                operatenum |= 1 << 3;
            }

            
            if(bagComponent.GetItemNumber(10010076) > 0)
            {
                operatenum |= 1 << 4;
            }

            self.Node_2.transform.Find("Item_1").gameObject.SetActive((operatenum & (1 << 1)) > 0);
            self.Node_2.transform.Find("Item_2").gameObject.SetActive((operatenum & (1 << 2)) > 0);
            self.Node_2.transform.Find("Item_3").gameObject.SetActive((operatenum & (1 << 3)) > 0);
            self.Node_2.transform.Find("Item_4").gameObject.SetActive((operatenum & (1 << 4)) > 0);


            self.Node_1.SetActive(operatenum == 0);
            self.Node_2.SetActive(operatenum > 0);
        }

        public static void OnInitUI(this UICellDungeonReviveComponent self, int seneTypeEnum)
        {
            self.SceneType = seneTypeEnum;
            self.LeftTime = seneTypeEnum == SceneTypeEnum.TeamDungeon ? 3 : 10;

            self.BegingTimer().Coroutine();
            self.UpdateStatus();

            string reviveCost = GlobalValueConfigCategory.Instance.Get(5).Value;
            string[] needList = reviveCost.Split(';');

            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(int.Parse(needList[0]));
            self.Text_CostName.GetComponent<Text>().text = itemConfig.GetItemName();

            string path =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.ItemIcon, itemConfig.Icon);
            Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
            if (!self.AssetPath.Contains(path))
            {
                self.AssetPath.Add(path);
            }
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
                self.Text_Cost.GetComponent<Text>().text = selfNum + "/" + needNum + "(" + GameSettingLanguge.LoadLocalization("道具不足") + ")";
                self.Text_Cost.GetComponent<Text>().color = Color.yellow;
            }

            if (self.SceneType != SceneTypeEnum.LocalDungeon) {
                self.Text_ExitDes.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("返回出生点");
            }
        }

        public static void OnButton_Revive(this UICellDungeonReviveComponent self)
        {
            string reviveCost = GlobalValueConfigCategory.Instance.Get(5).Value;
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            bool success = bagComponent.CheckNeedItem(reviveCost);
            if (!success)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("道具不足！"));
                return;
            }
            if (self.SceneType == SceneTypeEnum.UnionRace)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("不支持复活"));
                return;
            }

            EnterFubenHelp.SendReviveRequest(self.DomainScene(), true).Coroutine();
            UIHelper.Remove(self.DomainScene(), UIType.UICellDungeonRevive);
        }

        public static void OnAuto_Exit(this UICellDungeonReviveComponent self)
        {
            MapComponent mapComponent = self.ZoneScene().GetComponent<MapComponent>();
            if (self.IsNoAutoExit(mapComponent.SceneTypeEnum))
            {
                return;
            }
            SessionComponent sessionComponent = self.ZoneScene().GetComponent<SessionComponent>();
            if (sessionComponent.Session == null || sessionComponent.Session.IsDisposed)
            {
                return;
            }

            EnterFubenHelp.RequestQuitFuben(self.DomainScene());
            UIHelper.Remove(self.DomainScene(), UIType.UICellDungeonRevive);
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
                        FloatTipManager.Instance.ShowFloatTip(string.Format(GameSettingLanguge.LoadLocalization("{0}秒后可返回主城！"), self.LeftTime));
                    }
                    else
                    {
                        FloatTipManager.Instance.ShowFloatTip(string.Format(GameSettingLanguge.LoadLocalization("{0}秒后可返回出生点！"), self.LeftTime));
                    }
                }
                else
                {
                    EnterFubenHelp.SendReviveRequest(self.ZoneScene(), false).Coroutine();
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
