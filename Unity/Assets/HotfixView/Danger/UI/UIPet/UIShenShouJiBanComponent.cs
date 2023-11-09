using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIShenShouJiBanComponent: Entity, IAwake, IDestroy
    {
        public GameObject Btn_Close;
        public GameObject PetItemNode;
        public GameObject PetTuJianItem;
        public GameObject EffectListNode;
        public GameObject EffectText;

        public List<string> AssetPath = new List<string>();
    }

    public class UIShenShouJiBanComponentAwakeSystem: AwakeSystem<UIShenShouJiBanComponent>
    {
        public override void Awake(UIShenShouJiBanComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Btn_Close = rc.Get<GameObject>("Btn_Close");
            self.PetItemNode = rc.Get<GameObject>("PetItemNode");
            self.PetTuJianItem = rc.Get<GameObject>("PetTuJianItem");
            self.EffectListNode = rc.Get<GameObject>("EffectListNode");
            self.EffectText = rc.Get<GameObject>("EffectText");

            self.PetTuJianItem.SetActive(false);
            self.EffectText.SetActive(false);

            self.Btn_Close.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove(self.ZoneScene(), UIType.UIShenShouJiBan); });

            self.UpdateInfo();
        }
    }

    public class UIShenShouJiBanComponentDestroySystem: DestroySystem<UIShenShouJiBanComponent>
    {
        public override void Destroy(UIShenShouJiBanComponent self)
        {
            for (int i = 0; i < self.AssetPath.Count; i++)
            {
                if (!string.IsNullOrEmpty(self.AssetPath[i]))
                {
                    ResourcesComponent.Instance.UnLoadAsset(self.AssetPath[i]);
                }
            }

            self.AssetPath = null;
        }
    }

    public static class UIShenShouJiBanComponentSystem
    {
        public static void UpdateInfo(this UIShenShouJiBanComponent self)
        {
            string path2 = ABPathHelper.GetMaterialPath("UI_Hui");
            Material mat = ResourcesComponent.Instance.LoadAsset<Material>(path2);
            self.AssetPath.Add(path2);
            PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
            List<RolePetInfo> rolePetInfos = petComponent.RolePetInfos;

            foreach (PetConfig petConfig in PetConfigCategory.Instance.GetAll().Values)
            {
                if (petConfig.PetType == 2)
                {
                    GameObject go = GameObject.Instantiate(self.PetTuJianItem);
                    string path = ABPathHelper.GetAtlasPath_2(ABAtlasTypes.PetHeadIcon, petConfig.HeadIcon);
                    Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
                    self.AssetPath.Add(path);
                    bool flag = false;
                    foreach (RolePetInfo rolePetInfo in rolePetInfos)
                    {
                        if (rolePetInfo.ConfigId == petConfig.Id)
                        {
                            flag = true;
                        }
                    }

                    if (!flag)
                    {
                        go.GetComponent<ReferenceCollector>().Get<GameObject>("Image_ItemIcon").GetComponent<Image>().material = mat;
                    }

                    go.GetComponent<ReferenceCollector>().Get<GameObject>("Image_ItemIcon").GetComponent<Image>().sprite = sp;
                    go.GetComponent<ReferenceCollector>().Get<GameObject>("Label_ItemName").GetComponent<Text>().text = petConfig.PetName;
                    UICommonHelper.SetParent(go, self.PetItemNode);
                    go.SetActive(true);
                }
            }

            int shenshouNumber = self.ZoneScene().GetComponent<PetComponent>().GetShenShouNumber();

            for (int i = 1; i <= ConfigHelper.ShenShouJiBan.Count; i++)
            {
                GameObject go = GameObject.Instantiate(self.EffectText);
                string str = $"激活({i}/{i}) ";
                foreach (PropertyValue propertyValue in ConfigHelper.ShenShouJiBan[i])
                {
                    string proName = ItemViewHelp.GetAttributeName(propertyValue.HideID);
                    int showType = NumericHelp.GetNumericValueType(propertyValue.HideID);

                    if (showType == 2)
                    {
                        float value = (float)propertyValue.HideValue / 100f;
                        str += proName + " " + value.ToString("0.##") + "%" + " ";
                    }
                    else
                    {
                        str += proName + " " + propertyValue.HideValue + " ";
                    }
                }

                go.GetComponent<Text>().text = str;
                go.GetComponent<Text>().color = shenshouNumber >= i ? new Color(110f, 140f, 7f, 255f) : new Color(128f,128f,128f, 255f);

                UICommonHelper.SetParent(go, self.EffectListNode);
                go.SetActive(true);
            }
        }
    }
}