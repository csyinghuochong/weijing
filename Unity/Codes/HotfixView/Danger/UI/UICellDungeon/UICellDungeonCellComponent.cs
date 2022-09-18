using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UICellDungeonCellComponent : Entity, IAwake
    {
        //public GameObject cellItem;
        public GameObject cellContainer;
        public GameObject closeButton;

    }

    [ObjectSystem]
    public class UICellDungeonCellComponentAwakeSystem : AwakeSystem<UICellDungeonCellComponent>
    {
        public override void Awake(UICellDungeonCellComponent self)
        {

            //self.GetParent<UI>().GameObject.GetComponent<RectTransform>(). = Vector3.zero;

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            //self.cellItem = rc.Get<GameObject>("cellItem");
            self.cellContainer = rc.Get<GameObject>("cellContainer");

            self.closeButton = rc.Get<GameObject>("closeButton");
            self.closeButton.GetComponent<Button>().onClick.AddListener(() => { self.OnClickCoseButton(); });

            self.InitUI().Coroutine();
        }
    }

    public static class UICellDungeonCellComponentSystem
    {
        public static async ETTask InitUI(this UICellDungeonCellComponent self)
        {
            CellDungeonComponent fubenComponent = self.ZoneScene().GetComponent<CellDungeonComponent>();
            ChapterConfig chapterConfig = ChapterConfigCategory.Instance.Get(fubenComponent.ChapterId);
            int[] size = chapterConfig.InitSize;

            self.cellContainer.GetComponent<GridLayoutGroup>().constraintCount = size[0];
            int totalsize = size[0] * size[1];

            await ETTask.CompletedTask;
            GameObject cellItem = ResourcesComponent.Instance.LoadAsset<GameObject>(ABPathHelper.GetUGUIPath("Chapter/UILevelCellItem"));
            for (int i = 0; i < totalsize; i++)
            {
                GameObject cellitem = GameObject.Instantiate(cellItem);
                cellitem.SetActive(true);
                cellitem.transform.SetParent(self.cellContainer.transform);
                cellitem.transform.localScale = Vector3.one;
                cellitem.transform.localPosition = Vector3.zero;

                UI uI = self.AddChild<UI, string, GameObject>("UILevelGuide_" + i, cellitem);
                uI.AddComponent<UICelllDungeonCellItemComponent>().OnUpdateUI(fubenComponent.GetFubenCell(i));
            }
        }

        public static void OnClickCoseButton(this UICellDungeonCellComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UICellDungeonCell);
        }


    }
}
