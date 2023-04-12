using System;
using UnityEngine;

namespace ET
{
    public class UICellDungeonCellMiniComponent : Entity, IAwake, IDestroy
    {
        public GameObject cellContainer;
        public CellDungeonInfo[] fubenCellInfos = new CellDungeonInfo[9];
        public UICelllDungeonCellItemComponent[] fubenCellUIs = new UICelllDungeonCellItemComponent[9];

        public long Timer;
    }


    public class UICellDungeonCellMiniComponentAwakeSystem : AwakeSystem<UICellDungeonCellMiniComponent>
    {
        public override  void Awake(UICellDungeonCellMiniComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.cellContainer = rc.Get<GameObject>("cellContainer");

            self.OnInitUI().Coroutine();
        }
    }



    public class UICellDungeonCellMiniComponentDestroySystem : DestroySystem<UICellDungeonCellMiniComponent>
    {
        public override void Destroy(UICellDungeonCellMiniComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }

    [Timer(TimerType.UICellDungeonGuide)]
    public class UILevelGuideTimer : ATimer<UICellDungeonCellMiniComponent>
    {
        public override void Run(UICellDungeonCellMiniComponent self)
        {
            try
            {
                self.UpdateOpenEffect();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    public static class UICellDungeonCellMiniComponentSystem
    {
        public static void OnChapterOpen(this UICellDungeonCellMiniComponent self, bool show)
        {
            for (int i = 0; i < self.fubenCellUIs.Length; i++)
            {
                self.fubenCellUIs[i].OnChapterOpen(show);
            }
            if (show)
            {
                self.Timer = TimerComponent.Instance.NewRepeatedTimer(500, TimerType.UICellDungeonGuide, self);
            }
            else
            {
                TimerComponent.Instance.Remove(ref self.Timer);
            }
        }

        public static void UpdateOpenEffect(this UICellDungeonCellMiniComponent self)
        {
            for (int i = 0; i < self.fubenCellUIs.Length; i++)
            {
                self.fubenCellUIs[i].UpdateOpenEffect();
            }
        }

        public static async ETTask OnInitUI(this UICellDungeonCellMiniComponent self)
        {
            GameObject cellItem = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(ABPathHelper.GetUGUIPath("CellDungeon/UICellDungeonCellItem"));
            for (int i = 0; i < 9; i++)
            {
                GameObject cellitem = GameObject.Instantiate(cellItem);
                cellitem.SetActive(true);
                cellitem.transform.SetParent(self.cellContainer.transform);
                cellitem.transform.localScale = Vector3.one * 0.4f;
                cellitem.transform.localPosition = Vector3.zero;

                UI uI = self.AddChild<UI, string, GameObject>("UILevelGuide_" + i, cellitem);
                self.fubenCellUIs[i] = uI.AddComponent<UICelllDungeonCellItemComponent>();
            }
        }

        public static void  OnUpdateUI(this UICellDungeonCellMiniComponent self)
        {
            MapComponent mapComponent = self.ZoneScene().GetComponent<MapComponent>();
            CellDungeonComponent fubenComponent = self.ZoneScene().GetComponent<CellDungeonComponent>();

            //获取周围八个格子的状态
            ChapterConfig chapterConfig = ChapterConfigCategory.Instance.Get(mapComponent.SceneId);
            int[] size = chapterConfig.InitSize;

            CellDungeonInfo fubenCellInfo = fubenComponent.GetFubenCell(fubenComponent.SonFubenInfo.CurrentCell);

            //至少显示3*3的格子，找到一个合适的起点
            int row = fubenCellInfo.row;
            int line = fubenCellInfo.line;

            //确定起点
            int row_start = 0;
            int line_start = 0;
            if (row == 0)
            {
                row_start = 0;
            }
            else if (row + 2 > size[0])
            {
                row_start = row - 2;
            }
            else
            {
                row_start = row - 1;
            }
            if (line == 0)
            {
                line_start = 0;
            }
            else if (line + 2 > size[1])
            {
                line_start = line - 2;
            }
            else
            {
                line_start = line - 1;
            }

            //获取格子数据
            self.fubenCellInfos[0] = fubenComponent.GetFubenCell(row_start, line_start);
            self.fubenCellInfos[1] = fubenComponent.GetFubenCell(row_start + 1, line_start);
            self.fubenCellInfos[2] = fubenComponent.GetFubenCell(row_start + 2, line_start);
            self.fubenCellInfos[3] = fubenComponent.GetFubenCell(row_start, line_start +1);
            self.fubenCellInfos[4] = fubenComponent.GetFubenCell(row_start + 1, line_start + 1);
            self.fubenCellInfos[5] = fubenComponent.GetFubenCell(row_start + 2, line_start + 1);
            self.fubenCellInfos[6] = fubenComponent.GetFubenCell(row_start, line_start + 2);
            self.fubenCellInfos[7] = fubenComponent.GetFubenCell(row_start + 1, line_start + 2);
            self.fubenCellInfos[8] = fubenComponent.GetFubenCell(row_start + 2, line_start + 2);

            for (int i = 0; i < self.fubenCellUIs.Length; i++)
            {
                self.fubenCellUIs[i].OnUpdateUI(self.fubenCellInfos[i]);
            }

            self.OnChapterOpen(false);
        }
    }

}
