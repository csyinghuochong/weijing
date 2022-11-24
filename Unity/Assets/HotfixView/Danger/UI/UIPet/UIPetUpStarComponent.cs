using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPetUpStarComponent : Entity, IAwake
    {

        public GameObject Text_UpRate;
        public GameObject Text_ItemNumber;
        public GameObject Text_ItemName;
        public GameObject Img_ItemIcon;
        public GameObject Img_ItemQuality;
        public GameObject UIPetInfo1;
        public GameObject Btn_UpStar;
        public GameObject Obj_Text_UpRate;

        public UI[] UIPetUpStarItemList;
        public GameObject[] Button_AddList;
        public UIPetInfoShowComponent UIPetInfoShowComponent;

        public RolePetInfo MainPetInfo;
        public PetComponent PetComponent;

        public int UpStarStoneId;
        public int UpStarStoneNum;
    }

    [ObjectSystem]
    public class UIPetUpStarComponentAwakeSystem : AwakeSystem<UIPetUpStarComponent>
    {
        public override void Awake(UIPetUpStarComponent self)
        {
            self.MainPetInfo = null;
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Text_UpRate = rc.Get<GameObject>("Text_UpRate");
            self.Text_ItemNumber = rc.Get<GameObject>("Text_ItemNumber");
            self.Text_ItemName = rc.Get<GameObject>("Text_ItemName");
            self.Img_ItemIcon = rc.Get<GameObject>("Img_ItemIcon");
            self.Img_ItemQuality = rc.Get<GameObject>("Img_ItemQuality");
            self.Obj_Text_UpRate = rc.Get<GameObject>("Text_UpRate");


            self.UIPetUpStarItemList = new UI[3]; //186  24  -147
            for (int i = 0; i < self.UIPetUpStarItemList.Length; i++)
            {
                GameObject item = null;
                if (i == 0)
                    item = rc.Get<GameObject>("UIPetUpStarItem1");
                else
                    item = GameObject.Instantiate(self.UIPetUpStarItemList[0].GameObject);
                UICommonHelper.SetParent(item,  self.GetParent<UI>().GameObject);
                item.transform.localPosition = new Vector3(486f, 186f - i * 165, -147f);
                self.UIPetUpStarItemList[i] = self.AddChild<UI, string, GameObject>( "HeChengShow_1", item);
                self.UIPetUpStarItemList[i].AddComponent<UIPetUpStarItemComponent>();
                self.UIPetUpStarItemList[i].GameObject.SetActive(false);
            }
            self.Button_AddList = new GameObject[3];
            for (int i = 0; i < 3; i++)
            {
                self.Button_AddList[i] = rc.Get<GameObject>("Button_Add_" + (i+1));
            }
            self.Button_AddList[0].GetComponent<Button>().onClick.AddListener(() => { self.OnButton_Add(0).Coroutine(); });
            self.Button_AddList[1].GetComponent<Button>().onClick.AddListener(() => { self.OnButton_Add(1).Coroutine(); });
            self.Button_AddList[2].GetComponent<Button>().onClick.AddListener(() => { self.OnButton_Add(2).Coroutine(); });

            self.UIPetInfo1 = rc.Get<GameObject>("UIPetInfo1");
            

            self.Btn_UpStar = rc.Get<GameObject>("Btn_UpStar");
            self.Btn_UpStar.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_UpStar().Coroutine(); });

            self.PetComponent = self.ZoneScene().GetComponent<PetComponent>();

            string upStarStone = GlobalValueConfigCategory.Instance.Get(7).Value;
            string[] upStarStoneInfo = upStarStone.Split(';');
            self.UpStarStoneId = int.Parse(upStarStoneInfo[0]);
            self.UpStarStoneNum = int.Parse(upStarStoneInfo[1]);

            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(self.UpStarStoneId);
            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.ItemIcon, itemConfig.Icon);
            self.Img_ItemIcon.GetComponent<Image>().sprite = sp;
            string qualityiconStr = FunctionUI.GetInstance().ItemQualiytoPath(itemConfig.ItemQuality);
            self.Img_ItemQuality.GetComponent<Image>().sprite = ABAtlasHelp.GetIconSprite(ABAtlasTypes.ItemQualityIcon, qualityiconStr);
            self.Text_ItemName.GetComponent<Text>().text = itemConfig.ItemName;

            self.GetParent<UI>().OnUpdateUI = () => { self.OnUpdateUI(); };

            self.OnInitUI().Coroutine();
        }
    }

    public static class UIPetUpStarComponentSystem
    {
        public static async ETTask OnInitUI(this UIPetUpStarComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("Main/Pet/UIPetInfoShow");
            await ETTask.CompletedTask;
            GameObject bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            self.UIPetInfoShowComponent = self.AddChild<UIPetInfoShowComponent, GameObject>(UnityEngine.Object.Instantiate(bundleGameObject));
            self.UIPetInfoShowComponent.Weizhi = 0;
            self.UIPetInfoShowComponent.BagOperationType = PetOperationType.UpStar_Main;
            UICommonHelper.SetParent(self.UIPetInfoShowComponent.GameObject, self.UIPetInfo1);
            self.UIPetInfoShowComponent.OnInitData(self.MainPetInfo);
        }

        public static void OnPetUpStarUpdate(this UIPetUpStarComponent self, string dataparams)
        {
            RolePetInfo rolePetInfo = self.PetComponent.GetPetInfoByID(long.Parse(dataparams));
            self.MainPetInfo = rolePetInfo;

            self.ResetUpStarList();
            self.UpdateCostItem();
            self.UIPetInfoShowComponent.OnInitData(rolePetInfo);
        }

        public static void UpdateCostItem(this UIPetUpStarComponent self)
        {
            long number = self.ZoneScene().GetComponent<BagComponent>().GetItemNumber(self.UpStarStoneId);
            self.Text_ItemNumber.GetComponent<Text>().text = string.Format("{0}/{1}", self.UpStarStoneNum, number);
        }

        public static void OnUpdateUI(this UIPetUpStarComponent self)
        {
            self.MainPetInfo = null;
            self.ResetUpStarList();
            self.UpdateCostItem();
            self.UIPetInfoShowComponent?.OnInitData(self.MainPetInfo);
        }

        public static void ResetUpStarList(this UIPetUpStarComponent self)
        {
            for (int i = 0; i < self.UIPetUpStarItemList.Length; i++)
            {
                self.UIPetUpStarItemList[i].GetComponent<UIPetUpStarItemComponent>().OnUpdateUI(null);
                self.Button_AddList[i].SetActive(true);
            }
        }

        public static List<long> GetFuZhPetList(this UIPetUpStarComponent self)
        {
            List<long> selected = new List<long>();
            for (int i = 0; i < self.UIPetUpStarItemList.Length; i++)
            {
                UIPetUpStarItemComponent uIPetUpStarItemComponent = self.UIPetUpStarItemList[i].GetComponent<UIPetUpStarItemComponent>();
                if (uIPetUpStarItemComponent.RolePetInfo == null)
                {
                    continue;
                }
                selected.Add(uIPetUpStarItemComponent.RolePetInfo.Id);
            }
            return selected;
        }

        public static List<long> GetSelectedPet(this UIPetUpStarComponent self)
        {
            List<long> selected = new List<long>();
            selected.AddRange(self.GetFuZhPetList());
            if (self.MainPetInfo != null)
            {
                selected.Add(self.MainPetInfo.Id);
            }
            return selected;
        }

        public static void PetMainSelect(this UIPetUpStarComponent self, RolePetInfo rolePetInfo)
        {
            self.MainPetInfo = rolePetInfo;
            self.ResetUpStarList();
            self.UIPetInfoShowComponent.OnInitData(rolePetInfo);
        }

        public static void PetItemSelect(this UIPetUpStarComponent self, RolePetInfo rolePetInfo)
        {
            UI uIpet = UIHelper.GetUI(self.ZoneScene(), UIType.UIPet);
            int PetItemWeizhi = uIpet.GetComponent<UIPetComponent>().PetItemWeizhi;

            self.UIPetUpStarItemList[PetItemWeizhi].GetComponent<UIPetUpStarItemComponent>().OnUpdateUI(rolePetInfo);
            self.Button_AddList[PetItemWeizhi].SetActive(false);

            float upStartLvPro = 0;
            if (self.MainPetInfo != null)
            {
                switch (self.MainPetInfo.Star)
                {
                    case 0:
                        upStartLvPro = 0.25f;
                        break;
                    case 1:
                        upStartLvPro = 0.25f;
                        break;
                    case 2:
                        upStartLvPro = 0.2f;
                        break;
                    case 3:
                        upStartLvPro = 0.15f;
                        break;
                    case 4:
                        upStartLvPro = 0.1f;
                        break;
                }
            }

            upStartLvPro = upStartLvPro * self.GetFuZhPetList().Count;
            self.Obj_Text_UpRate.GetComponent<Text>().text = upStartLvPro * 100 +"%";
            /*
            foreach (long id in self.GetFuZhPetList()) {
                //self.DomainScene().GetComponent<UnitComponent>().MyUnit.GetComponent<PetComponent>().GetPetInfoByID(id);
            }
            */
        }

        public static async ETTask OnButton_Add(this UIPetUpStarComponent self, int index)
        {
            if (self.MainPetInfo == null)
            {
                FloatTipManager.Instance.ShowFloatTip("请先选择要升星的宠物");
                return;
            }
            UI uIpet = UIHelper.GetUI(self.ZoneScene(), UIType.UIPet);
            uIpet.GetComponent<UIPetComponent>().PetItemWeizhi = index;

            UI ui = await UIHelper.Create(self.DomainScene(), UIType.UIPetSelect);
            ui.GetComponent<UIPetSelectComponent>().OnSetType(PetOperationType.UpStar_FuZh);
        }

        public static async ETTask OnBtn_UpStar(this UIPetUpStarComponent self)
        { 
            if (self.MainPetInfo == null)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("请选择需要升星的宠物！"));
                return;
            }
            if (self.MainPetInfo.Star >= 5)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("已经最大星数！"));
                return;
            }
            if (self.GetFuZhPetList().Count == 0)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("请选择需要消耗的宠物！"));
                return;
            }
            int errorCode = await self.PetComponent.RequestUpStar(self.MainPetInfo.Id, self.GetFuZhPetList());
            if (errorCode == ErrorCore.ERR_Success)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("宠物升星成功！"));
            }
        }
    }
}
