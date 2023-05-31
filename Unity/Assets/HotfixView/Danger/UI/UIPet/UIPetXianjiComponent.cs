using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace ET
{
    public class UIPetXianjiComponent : Entity, IAwake, IDestroy
    {
        public GameObject Btn_Close;
        public GameObject PetIconDi;
        public GameObject Button_Xianji;
        public GameObject PetIcon;
        public GameObject Lab_PetNum;
        public GameObject Lab_PetName;
        public GameObject Label_JianDingShow;

        public long PetUpId;
        public long PetXianjiId;
    }


    public class UIPetXianjiComponentAwake : AwakeSystem<UIPetXianjiComponent>
    {
        public override void Awake(UIPetXianjiComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
        
            self.Btn_Close = rc.Get<GameObject>("Btn_Close");
            self.Btn_Close.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove( self.ZoneScene(), UIType.UIPetXianji);  });

            self.PetIconDi = rc.Get<GameObject>("PetIconDi");
            ButtonHelp.AddListenerEx(self.PetIconDi, () => { self.OnPetIconDi().Coroutine(); });

            self.Button_Xianji = rc.Get<GameObject>("Button_Xianji");
            ButtonHelp.AddListenerEx(self.Button_Xianji, () => { self.OnButton_Xianji().Coroutine(); });

            self.PetIcon = rc.Get<GameObject>("PetIcon");
            self.Lab_PetNum = rc.Get<GameObject>("Lab_PetNum");
            self.Lab_PetName = rc.Get<GameObject>("Lab_PetName");
            self.Label_JianDingShow = rc.Get<GameObject>("Label_JianDingShow");

            DataUpdateComponent.Instance.AddListener(DataType.PetItemSelect, self);
        }
    }


    public class UIPetXianjiComponentDestroy: DestroySystem<UIPetXianjiComponent>
    {
        public override void Destroy(UIPetXianjiComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.PetItemSelect, self);
        }
    }

    public static class UIPetXianjiComponentSystem
    {
        public static void OnInitUI(this UIPetXianjiComponent self, long petId)
        {
            self.PetUpId = petId;
        }

        public static void PetItemSelect(this UIPetXianjiComponent self, string dataParams)
        {
            string[] paramsList = dataParams.Split('@');
            self.PetXianjiId = long.Parse(paramsList[1]);
            RolePetInfo rolePetInfo = self.ZoneScene().GetComponent<PetComponent>().GetPetInfoByID(self.PetXianjiId);

            PetSkinConfig petSkinConfig = PetSkinConfigCategory.Instance.Get(rolePetInfo.SkinId);
            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.PetHeadIcon, petSkinConfig.IconID.ToString());
            self.PetIcon.GetComponent<Image>().sprite = sp;
            self.PetIcon.SetActive(true);

            //显示
            RolePetInfo PetUpInfo = self.ZoneScene().GetComponent<PetComponent>().GetPetInfoByID(self.PetXianjiId);
            if (PetUpInfo != null)
            {
                self.Lab_PetName.GetComponent<Text>().text = PetUpInfo.PetName;
                int fightNum = PetHelper.PetPingJia(PetUpInfo);
                self.Lab_PetNum.GetComponent<Text>().text = "评分:" +  fightNum.ToString();

                if (fightNum <= 3000)
                {
                    self.Label_JianDingShow.GetComponent<Text>().text = "一般";
                    self.Label_JianDingShow.GetComponent<Text>().color = UICommonHelper.QualityReturnColor(1);
                }

                if (fightNum <= 5000)
                {
                    self.Label_JianDingShow.GetComponent<Text>().text = "较好";
                    self.Label_JianDingShow.GetComponent<Text>().color = UICommonHelper.QualityReturnColor(2);
                }

                if (fightNum <= 7000)
                {
                    self.Label_JianDingShow.GetComponent<Text>().text = "极好";
                    self.Label_JianDingShow.GetComponent<Text>().color = UICommonHelper.QualityReturnColor(3);
                }

                if (fightNum > 7000)
                {
                    self.Label_JianDingShow.GetComponent<Text>().text = "完美";
                    self.Label_JianDingShow.GetComponent<Text>().color = UICommonHelper.QualityReturnColor(4);
                }
            }
            
        }

        public static async ETTask OnPetIconDi(this UIPetXianjiComponent self)
        {
            UI ui = await UIHelper.Create(self.DomainScene(), UIType.UIPetSelect);
            ui.GetComponent<UIPetSelectComponent>().OnSetType(PetOperationType.XianJi);
        }

        public static async ETTask OnButton_Xianji(this UIPetXianjiComponent self)
        {

            if (self.PetXianjiId <= 0) {
                FloatTipManager.Instance.ShowFloatTip("请放入对应祭品宠物");
                return;
            }

            RolePetInfo oldPetUpInfo = self.ZoneScene().GetComponent<PetComponent>().GetPetInfoByID(self.PetUpId);

            C2M_RolePetUpStage c2M_RolePetUpStage = new C2M_RolePetUpStage() { PetInfoId = self.PetUpId,PetInfoXianJiId = self.PetXianjiId };
            M2C_RolePetUpStage m2C_RolePetUpStageg = (M2C_RolePetUpStage)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_RolePetUpStage);

            if (m2C_RolePetUpStageg.Error == ErrorCore.ERR_Success)
            {
                UI uI = await UIHelper.Create(self.DomainScene(), UIType.UIPetChouKaGet);
                PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
                List<KeyValuePair> oldPetSkin = petComponent.GetPetSkinCopy();
                uI.GetComponent<UIPetChouKaGetComponent>().OnInitUI(m2C_RolePetUpStageg.NewPetInfo, oldPetSkin, false, oldPetUpInfo);

                for (int i = petComponent.RolePetInfos.Count - 1; i >= 0; i--)
                {
                    if (petComponent.RolePetInfos[i].Id == m2C_RolePetUpStageg.NewPetInfo.Id)
                    {
                        petComponent.RolePetInfos[i] = m2C_RolePetUpStageg.NewPetInfo;
                    }
                }

                //删除献祭单位
                self.ZoneScene().GetComponent<PetComponent>().RemovePet(self.PetXianjiId);
                UIHelper.GetUI(self.ZoneScene(), UIType.UIPet).GetComponent<UIPetComponent>().UIPageView.UISubViewList[(int)PetPageEnum.PetList].GetComponent<UIPetListComponent>().OnUpdateUI();


                await ETTask.CompletedTask;
            }


            

            //关闭界面
            UIHelper.Remove(self.ZoneScene(), UIType.UIPetXianji);

        }
    }
}