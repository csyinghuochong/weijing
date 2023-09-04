using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIDemonMainComponent: Entity, IAwake, IDestroy
    {
        public GameObject RankingListNode;
        public GameObject PlayerInfoItem_1;
        public GameObject PlayerInfoItem_2;
        public GameObject PlayerInfoItem_3;
        public GameObject PlayerInfoItem_Other;

        public Text ReadyTimeText;

        public long EndTime;
        public long ReadyTime;
        public List<GameObject> Rankings = new List<GameObject>();
    }

    public class UIDemonMainComponentAwake: AwakeSystem<UIDemonMainComponent>
    {
        public override void Awake(UIDemonMainComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.RankingListNode = rc.Get<GameObject>("RankingListNode");
            self.PlayerInfoItem_1 = rc.Get<GameObject>("PlayerInfoItem_1");
            self.PlayerInfoItem_2 = rc.Get<GameObject>("PlayerInfoItem_2");
            self.PlayerInfoItem_3 = rc.Get<GameObject>("PlayerInfoItem_3");
            self.PlayerInfoItem_Other = rc.Get<GameObject>("PlayerInfoItem_Other");
            self.ReadyTimeText = rc.Get<GameObject>("ReadyTimeText").GetComponent<Text>();

            self.Rankings.Add(self.PlayerInfoItem_1);
            self.Rankings.Add(self.PlayerInfoItem_2);
            self.Rankings.Add(self.PlayerInfoItem_3);
            self.Rankings.Add(self.PlayerInfoItem_Other);

            self.PlayerInfoItem_1.SetActive(false);
            self.PlayerInfoItem_2.SetActive(false);
            self.PlayerInfoItem_3.SetActive(false);
            self.PlayerInfoItem_Other.SetActive(false);

            FuntionConfig funtionConfig = FuntionConfigCategory.Instance.Get(1059);
            string[] openTimes = funtionConfig.OpenTime.Split('@');
            self.ReadyTime = (int.Parse(openTimes[1].Split(';')[0]) * 60 + int.Parse(openTimes[1].Split(';')[1])) * 60;
            self.EndTime = (int.Parse(openTimes[2].Split(';')[0]) * 60 + int.Parse(openTimes[2].Split(';')[1])) * 60;

            self.UpdateRanking().Coroutine();
            self.ShoweTime().Coroutine();
        }
    }

    public static class UIDemonMainComponentSystem
    {
        public static async ETTask ShoweTime(this UIDemonMainComponent self)
        {
            while (!self.IsDisposed)
            {
                DateTime dateTime = TimeInfo.Instance.ToDateTime(TimeHelper.ServerNow());
                long curTime = (dateTime.Hour * 60 + dateTime.Minute) * 60 + dateTime.Second;
                long endTime = self.EndTime - curTime;

                long readyTime = self.ReadyTime - curTime;
                if (readyTime > 0)
                {
                    self.ReadyTimeText.GetComponent<Text>().text = $"准备倒计时 {readyTime / 60}:{readyTime % 60}";
                }
                else if (endTime > 0)
                {
                    self.ReadyTimeText.GetComponent<Text>().text = $"活动结束倒计时 {endTime / 60}:{endTime % 60}";
                }

                await TimerComponent.Instance.WaitAsync(1000);
                if (self.IsDisposed)
                {
                    break;
                }
            }
        }

        public static async ETTask UpdateRanking(this UIDemonMainComponent self)
        {
            long instacnid = self.InstanceId;
            C2R_RankDemonRequest request = new C2R_RankDemonRequest();
            R2C_RankDemonResponse response =
                    await self.DomainScene().GetComponent<SessionComponent>().Session.Call(request) as R2C_RankDemonResponse;

            if (instacnid != self.InstanceId)
            {
                return;
            }

            self.GetParent<UI>().GameObject.transform.SetAsFirstSibling();

            if (response.RankList == null || response.RankList.Count < 1)
            {
                return;
            }

            int num = 0;
            for (int i = 0; i < response.RankList.Count; i++)
            {
                if (i == 0)
                {
                    self.PlayerInfoItem_1.GetComponentInChildren<Text>().text =
                            $"第{i + 1}名 {response.RankList[i].PlayerName}";
                    self.PlayerInfoItem_1.SetActive(true);
                }
                else if (i == 1)
                {
                    self.PlayerInfoItem_2.GetComponentInChildren<Text>().text =
                            $"第{i + 1}名 {response.RankList[i].PlayerName}";
                    self.PlayerInfoItem_2.SetActive(true);
                }
                else if (i == 2)
                {
                    self.PlayerInfoItem_3.GetComponentInChildren<Text>().text =
                            $"第{i + 1}名 {response.RankList[i].PlayerName}";
                    self.PlayerInfoItem_3.SetActive(true);
                }
                else
                {
                    if (num < self.Rankings.Count)
                    {
                        self.Rankings[i].SetActive(true);
                        self.Rankings[i].GetComponentInChildren<Text>().text =
                                $"第{i + 1}名 {response.RankList[i].PlayerName}";
                    }
                    else
                    {
                        GameObject go = GameObject.Instantiate(self.PlayerInfoItem_Other);
                        go.GetComponentInChildren<Text>().text = $"第{i + 1}名 {response.RankList[i].PlayerName}";
                        go.SetActive(true);
                        UICommonHelper.SetParent(go, self.RankingListNode);
                        self.Rankings.Add(go);
                    }
                }

                num++;
            }

            for (int i = num; i < self.Rankings.Count; i++)
            {
                self.Rankings[i].SetActive(false);
            }

            await ETTask.CompletedTask;
        }

        public static void UpdateRanking(this UIDemonMainComponent self, M2C_RankDemonMessage message)
        {
            int num = 0;
            for (int i = 0; i < message.RankList.Count; i++)
            {
                if (i == 0)
                {
                    self.PlayerInfoItem_1.GetComponentInChildren<Text>().text =
                            $"第{i + 1}名 {message.RankList[i].PlayerName}";
                    self.PlayerInfoItem_1.SetActive(true);
                }
                else if (i == 1)
                {
                    self.PlayerInfoItem_2.GetComponentInChildren<Text>().text =
                            $"第{i + 1}名 {message.RankList[i].PlayerName}";
                    self.PlayerInfoItem_2.SetActive(true);
                }
                else if (i == 2)
                {
                    self.PlayerInfoItem_3.GetComponentInChildren<Text>().text =
                            $"第{i + 1}名 {message.RankList[i].PlayerName}";
                    self.PlayerInfoItem_3.SetActive(true);
                }
                else
                {
                    if (num < self.Rankings.Count)
                    {
                        self.Rankings[i].SetActive(true);
                        self.Rankings[i].GetComponentInChildren<Text>().text =
                                $"第{i + 1}名 {message.RankList[i].PlayerName}";
                    }
                    else
                    {
                        GameObject go = GameObject.Instantiate(self.PlayerInfoItem_Other);
                        go.GetComponentInChildren<Text>().text = $"第{i + 1}名 {message.RankList[i].PlayerName}";
                        go.SetActive(true);
                        UICommonHelper.SetParent(go, self.RankingListNode);
                        self.Rankings.Add(go);
                    }
                }

                num++;
            }

            for (int i = num; i < self.Rankings.Count; i++)
            {
                self.Rankings[i].SetActive(false);
            }
        }

        public static void ShowCancelButton(this UIDemonMainComponent self, bool show)
        {
        }
    }
}