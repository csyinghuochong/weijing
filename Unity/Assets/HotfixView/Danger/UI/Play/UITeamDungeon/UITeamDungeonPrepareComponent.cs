using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UITeamDungeonPrepareComponent : Entity, IAwake, IDestroy
    {
        public GameObject Button_Agree;
        public GameObject Button_Refuse;
        public GameObject TextCountDown;
        public GameObject[] TeamPlayerItemList = new GameObject[3];
        public TeamInfo TeamInfo;
        public long Timer;
    }

    public class UITeamDungeonPrepareComponentAwake : AwakeSystem<UITeamDungeonPrepareComponent>
    {
        public override void Awake(UITeamDungeonPrepareComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.TextCountDown = rc.Get<GameObject>("TextCountDown");
            for (int i = 0; i < 3; i++)
            { 
                self.TeamPlayerItemList[i] = rc.Get<GameObject>($"TeamPlayerItem{i}");
            }

            self.Button_Refuse = rc.Get<GameObject>("Button_Refuse");
            ButtonHelp.AddListenerEx(self.Button_Refuse, () => { self.OnButton_Agree(2).Coroutine(); });
            self.Button_Agree = rc.Get<GameObject>("Button_Agree");
            ButtonHelp.AddListenerEx(self.Button_Agree, () => { self.OnButton_Agree(1).Coroutine(); });

            self.ShowCountDount().Coroutine();
        }
    }

    public class UITeamDungeonPrepareComponentDestroy : DestroySystem<UITeamDungeonPrepareComponent>
    {
        public override void Destroy(UITeamDungeonPrepareComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }

    public static class UITeamDungeonPrepareComponentSystem
    {

        public static async ETTask ShowCountDount(this UITeamDungeonPrepareComponent self)
        {
            long instanceid = self.InstanceId;
            TimerComponent.Instance?.Remove(ref self.Timer);
            for(int i = 20;  i >= 0; i--)
            {
                self.TextCountDown.GetComponent<Text>().text = $"倒计时:{i}";
                await TimerComponent.Instance.WaitAsync(1000);
                if (instanceid != self.InstanceId)
                {
                    return;
                }
            }

            await self.OnButton_Agree(2);
            if (instanceid == self.InstanceId && self.ZoneScene()!=null)
            {
                UIHelper.Remove(self.ZoneScene(), UIType.UITeamDungeonPrepare);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="self"></param>
        /// <param name="preare">0没选择 1 同意 2拒绝</param>
        /// <returns></returns>
        public static async ETTask OnButton_Agree(this UITeamDungeonPrepareComponent self, int preare)
        {
            Scene zoneScene = self.ZoneScene();
            MapComponent mapComponent = zoneScene.GetComponent<MapComponent>();
            if (preare == 1 
                && mapComponent.SceneTypeEnum != SceneTypeEnum.MainCityScene
                && mapComponent.SceneTypeEnum != SceneTypeEnum.LocalDungeon)
            {
                FloatTipManager.Instance.ShowFloatTip("请先退出当前副本！");
                return;
            }

            int errorCode = TeamHelper.CheckTimesAndLevel(UnitHelper.GetMyUnitFromZoneScene(zoneScene), self.TeamInfo);
            if (preare == 1 && errorCode != ErrorCore.ERR_Success)
            {
                ErrorHelp.Instance.ErrorHint(errorCode);
                return;
            }
           
            long unitid = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.UserId;
            for (int i = 0; i < self.TeamInfo.PlayerList.Count; i++)
            {
                if (self.TeamInfo.PlayerList[i].UserID != unitid)
                {
                    continue;
                }
                if (self.TeamInfo.PlayerList[i].Prepare != 0)
                {
                    return;
                }
            }

            C2M_TeamDungeonPrepareRequest  request = new C2M_TeamDungeonPrepareRequest() { TeamInfo = self.TeamInfo, Prepare = preare };
            M2C_TeamDungeonPrepareResponse response = (M2C_TeamDungeonPrepareResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
        }

        public static void OnUpdateUI(this UITeamDungeonPrepareComponent self, TeamInfo teamInfo, int error)
        {
            self.TeamInfo = teamInfo;
            for (int i = 0; i < 3; i++)
            {
                self.TeamPlayerItemList[i].SetActive(false);
            }

            string haverefuse = string.Empty;
            for (int i = 0; i < self.TeamInfo.PlayerList.Count; i++)
            {
                TeamPlayerInfo teamPlayerInfo = self.TeamInfo.PlayerList[i];
                GameObject gameObject = self.TeamPlayerItemList[i];
                gameObject.SetActive(true);
                gameObject.transform.Find("Text_WaitHint").gameObject.SetActive(teamPlayerInfo.Prepare ==0);
                gameObject.transform.Find("Image_Agree").gameObject.SetActive(teamPlayerInfo.Prepare == 1);
                gameObject.transform.Find("Image_Refuse").gameObject.SetActive(teamPlayerInfo.Prepare == 2);
                gameObject.transform.Find("Text_Name").GetComponent<Text>().text = teamPlayerInfo.PlayerName;
                gameObject.transform.Find("ImagePlayer/Text_Level").GetComponent<Text>().text = $"{teamPlayerInfo.PlayerLv}级";
                UICommonHelper.ShowOccIcon(gameObject.transform.Find("ImagePlayer/ImageMask/ImageHead").gameObject, teamPlayerInfo.Occ);
                if (teamPlayerInfo.Prepare == 2)
                {
                    haverefuse = teamPlayerInfo.PlayerName;
                }
            }

            if (!String.IsNullOrEmpty(haverefuse))
            {
                FloatTipManager.Instance.ShowFloatTip($"{haverefuse} 不同意进入副本");
                UIHelper.Remove(self.ZoneScene(), UIType.UITeamDungeonPrepare);
                return;
            }
            if (error != ErrorCore.Err_HaveNotPrepare)
            {
                UIHelper.Remove(self.ZoneScene(), UIType.UITeamDungeon);
                UIHelper.Remove(self.ZoneScene(), UIType.UITeamDungeonPrepare);
            }
        }
    }
}
