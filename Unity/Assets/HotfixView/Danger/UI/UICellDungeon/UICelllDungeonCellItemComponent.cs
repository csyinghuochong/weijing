using UnityEngine;
using UnityEngine.UI;
using System.Linq;

namespace ET
{
    public class UICelllDungeonCellItemComponent : Entity, IAwake
    {
        public Transform Transform;
        public Image ImagePassAble;

        public CellDungeonInfo fubenCellInfo;

        public bool ShowOpen;
        public float PassTime;
    }

    [ObjectSystem]
    public class UICelllDungeonCellItemComponentAwakeSystem : AwakeSystem<UICelllDungeonCellItemComponent>
    {
        public override void Awake(UICelllDungeonCellItemComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.ImagePassAble = rc.Get<GameObject>("passable").GetComponent<Image>();
            self.Transform = self.GetParent<UI>().GameObject.transform;

            self.ShowOpen = false;
            self.PassTime = 0f;
        }
    }

    public static class UICelllDungeonCellItemComponentSystem
    {
        public static void UpdateOpenEffect(this UICelllDungeonCellItemComponent self)
        {
            if (!self.ShowOpen)
                return;

            self.PassTime += 1;
            //self.CrossFadeAlpha((self.PassTime % 2)==1?1:0.5f);
            self.CrossFadeAlpha(self.PassTime % 2);
            //self.ImagePassAble.CrossFadeAlpha(self.PassTime % 2, 1f, false);
        }

        public static void CrossFadeAlpha(this UICelllDungeonCellItemComponent self, float alpha)
        {
            for (int i = 0; i < self.Transform.childCount; i++)
            {
                Image image = self.Transform.GetChild(i).gameObject.GetComponent<Image>();

                if (image==null)
                {
                    continue;
                }
                image.CrossFadeAlpha(alpha, 1f, false);
            }
        }

        public static void OnChapterOpen(this UICelllDungeonCellItemComponent self, bool open)
        {
            if (!open)
            {
                self.ShowOpen = false;
                self.CrossFadeAlpha(1f);
                return;
            }

            CellDungeonComponent fubenComponent = self.ZoneScene().GetComponent<CellDungeonComponent>();

            ChapterConfig chapterConfig = ChapterConfigCategory.Instance.Get(fubenComponent.ChapterId);
            CellDungeonInfo fubenCellInfo = self.fubenCellInfo;
            int cellIndex = fubenComponent.GetCellIndex(fubenCellInfo.row, fubenCellInfo.line);
            int[] size = chapterConfig.InitSize;

            bool benext = false;
            if (Mathf.Abs(cellIndex - fubenComponent.SonFubenInfo.CurrentCell) == 1 && (fubenCellInfo.line == (int)(fubenComponent.SonFubenInfo.CurrentCell / size[0]))
                   || Mathf.Abs(cellIndex - fubenComponent.SonFubenInfo.CurrentCell) == size[0])
            {
                benext = true;
            }
            self.ShowOpen = benext && (fubenCellInfo.ctype == (byte)CellDungeonStatu.Passable|| fubenCellInfo.ctype == (byte)CellDungeonStatu.Start || fubenCellInfo.ctype == (byte)CellDungeonStatu.End);
        }

        public static void OnUpdateUI(this UICelllDungeonCellItemComponent self, CellDungeonInfo fubenCellInfo)
        {
            self.fubenCellInfo = fubenCellInfo;
            CellDungeonComponent fubenComponent = self.ZoneScene().GetComponent<CellDungeonComponent>();
            ChapterConfig chapterConfig = ChapterConfigCategory.Instance.Get(fubenComponent.ChapterId);
            GameObject cell = self.GetParent<UI>().GameObject;

            int[] size = chapterConfig.InitSize;
            int cellIndex = fubenComponent.GetCellIndex(fubenCellInfo.row, fubenCellInfo.line);
            bool ifCurCell = fubenComponent.SonFubenInfo.CurrentCell == cellIndex;
            cell.transform.Find("liang").gameObject.SetActive(ifCurCell);           //获取自身所在的格子
            cell.transform.Find("impassable").gameObject.SetActive(fubenCellInfo.ctype == (byte)CellDungeonStatu.Impassable);
            cell.transform.Find("passable").gameObject.SetActive((fubenCellInfo.ctype == (byte)CellDungeonStatu.Passable) && ifCurCell == false);

            if (fubenCellInfo.ctype == (byte)CellDungeonStatu.Start) {

                //获取自己的行和列位置
                int row = fubenComponent.SonFubenInfo.CurrentCell % size[0];
                int line = fubenComponent.SonFubenInfo.CurrentCell / size[0];

                int rowCha = Mathf.Abs(row - fubenCellInfo.row);
                int lineCha = Mathf.Abs(line - fubenCellInfo.line);

                Log.Info("rowCha = " + rowCha + "lineCha = " + lineCha);

                if (rowCha <= 1 && lineCha <= 1 && rowCha!= lineCha) {
                    cell.transform.Find("passable").gameObject.SetActive(true);
                }
            }

            //cell.transform.Find("passable").gameObject.SetActive((fubenCellInfo.ctype == (byte)FubenCellStatu.Start || fubenCellInfo.ctype == (byte)FubenCellStatu.Passable) && ifCurCell == false);
            cell.transform.Find("start").gameObject.SetActive(fubenCellInfo.ctype == (byte)CellDungeonStatu.Start);
            cell.transform.Find("hui").gameObject.SetActive(true);

            if (fubenCellInfo.ctype == (byte)CellDungeonStatu.Passable || fubenCellInfo.ctype == (byte)CellDungeonStatu.Impassable)
            {
                cell.transform.Find("end").gameObject.SetActive(false);
                cell.transform.Find("walked").gameObject.SetActive(false);
            }
            else
            {
                cell.transform.Find("end").gameObject.SetActive(fubenCellInfo.ctype == (byte)CellDungeonStatu.End);
                cell.transform.Find("walked").gameObject.SetActive(fubenCellInfo.pass);
            }

            cell.transform.Find("TeShu_ShenMi").gameObject.SetActive(fubenComponent.HaveFubenCellNpc(CellDungeonNpc.ShenMiNpc, cellIndex));
            cell.transform.Find("TeShu_HuiFu").gameObject.SetActive(fubenComponent.HaveFubenCellNpc(CellDungeonNpc.HuiFuItem, cellIndex) && fubenCellInfo.ctype != (byte)CellDungeonStatu.Impassable);
            cell.transform.Find("TeShu_Chest").gameObject.SetActive(fubenComponent.HaveFubenCellNpc(CellDungeonNpc.ChestList, cellIndex) && fubenCellInfo.ctype != (byte)CellDungeonStatu.Impassable);
            cell.transform.Find("TeShu_MoNeng").gameObject.SetActive(fubenComponent.HaveFubenCellNpc(CellDungeonNpc.MoLengRoom, cellIndex, 101) && fubenCellInfo.ctype != (byte)CellDungeonStatu.Impassable);

            //精英副本关卡
            bool ifShowJingYingStatus = false;
            if(fubenComponent.HaveFubenCellNpc(CellDungeonNpc.MoLengRoom, cellIndex, 201) && fubenCellInfo.ctype != (byte)CellDungeonStatu.Impassable){
                ifShowJingYingStatus = true;
            }
            if (ifShowJingYingStatus == false && fubenComponent.HaveFubenCellNpc(CellDungeonNpc.MoLengRoom, cellIndex, 202) && fubenCellInfo.ctype != (byte)CellDungeonStatu.Impassable)
            {
                ifShowJingYingStatus = true;
            }
            if (ifShowJingYingStatus == false && fubenComponent.HaveFubenCellNpc(CellDungeonNpc.MoLengRoom, cellIndex, 203) && fubenCellInfo.ctype != (byte)CellDungeonStatu.Impassable)
            {
                ifShowJingYingStatus = true;
            }
            if (ifShowJingYingStatus == false && fubenComponent.HaveFubenCellNpc(CellDungeonNpc.MoLengRoom, cellIndex, 204) && fubenCellInfo.ctype != (byte)CellDungeonStatu.Impassable)
            {
                ifShowJingYingStatus = true;
            }
            cell.transform.Find("TeShu_JingYing").gameObject.SetActive(ifShowJingYingStatus);
            //cell.transform.Find("TeShu_JingYing").gameObject.SetActive(fubenComponent.FubenInfo.JING.Contains(cellIndex) && fubenCellInfo.ctype != (byte)FubenCellType.Impassable);

            //当前格子
            if (ifCurCell && fubenComponent.HaveFubenCellNpc(CellDungeonNpc.HuiFuItem, cellIndex))
            {
                Entity[] unitList = self.DomainScene().CurrentScene().GetComponent<UnitComponent>().Children.Values.ToArray();
                bool ifCostStatus = true;
                for (int i = 0; i < unitList.Length; i++)
                {
                    if (unitList[i].GetComponent<UnitInfoComponent>().Type == UnitType.Monster)
                    {
                        if (unitList[i].GetComponent<UnitInfoComponent>().UnitCondigID == 80000001)
                        {
                            ifCostStatus = false;
                        }
                        if (ifCostStatus)
                        {
                            cell.transform.Find("TeShu_HuiFu").gameObject.SetActive(false);
                        }
                    }
                }
            }
        }

    }

}
