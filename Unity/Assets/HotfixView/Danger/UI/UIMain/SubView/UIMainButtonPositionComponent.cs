using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ET
{
    public class UIMainButtonPositionComponent : Entity, IAwake<GameObject>
    {

        public GameObject GameObject;
        public GameObject Btn_SkilPositionReset;
        public GameObject Btn_SkilPositionCancel;
        public GameObject SkillIconItemCopy;
        public GameObject SkillPositionSet;
        public GameObject Btn_SkilPositionSave;

        public int CurDragIndex;
        public List<Vector2> SkillPositionList = new List<Vector2>();
        public List<Vector2> InitPositionList = new List<Vector2>();
        public List<Vector2> TempPositionList = new List<Vector2>();

        public List<UISkillDragComponent> UISkillDragList = new List<UISkillDragComponent>();
    }

    public class UIMainButtonPositionComponentAwake : AwakeSystem<UIMainButtonPositionComponent, GameObject>
    {
        public override void Awake(UIMainButtonPositionComponent self, GameObject a)
        {
            self.GameObject = a;
            ReferenceCollector rc = a.GetComponent<ReferenceCollector>();
            self.SkillPositionSet = rc.Get<GameObject>("ImageSkillPositionSet");
            self.SkillPositionSet.SetActive(false);

            self.Btn_SkilPositionReset = rc.Get<GameObject>("Btn_SkilPositionReset");
            self.Btn_SkilPositionReset.GetComponent<Button>().onClick.AddListener(self.OnBtn_SkilPositionReset);

            self.Btn_SkilPositionCancel = rc.Get<GameObject>("Btn_SkilPositionCancel");
            self.Btn_SkilPositionCancel.GetComponent<Button>().onClick.AddListener(self.OnBtn_SkilPositionCancel);

            self.Btn_SkilPositionSave = rc.Get<GameObject>("Btn_SkilPositionSave");
            self.Btn_SkilPositionSave.GetComponent<Button>().onClick.AddListener(self.OnBtn_SkilPositionSave);

           
        }
    }

    public static class UIMainButtonPositionComponentSystem
    {
        public static void InitButtons(this UIMainButtonPositionComponent self, GameObject main)
        {
            self.SkillPositionList.Clear();
            ReferenceCollector rc = main.GetComponent<ReferenceCollector>();

            ReferenceCollector rc_skill = rc.Get<GameObject>("UIMainSkill").GetComponent<ReferenceCollector>();
            for (int i = 0; i < 10; i++)
            {
                GameObject go = rc_skill.Get<GameObject>($"UI_MainRoseSkill_item_{i}");

                self.AddSkillDragItem(i, go);
            }

            self.AddSkillDragItem(10, rc_skill.Get<GameObject>("UI_MainRose_attack"));
            self.AddSkillDragItem(11, rc_skill.Get<GameObject>("UI_MainRose_FanGun"));


            self.AddSkillDragItem(12, rc.Get<GameObject>("Btn_RoseEquip"));
            self.AddSkillDragItem(13, rc.Get<GameObject>("Btn_Pet"));
            self.AddSkillDragItem(14, rc.Get<GameObject>("Btn_RoseSkill"));
            self.AddSkillDragItem(15, rc.Get<GameObject>("Btn_ChengJiu"));
            self.AddSkillDragItem(16, rc.Get<GameObject>("Btn_Friend"));
            self.AddSkillDragItem(17, rc.Get<GameObject>("Btn_Task"));

            self.AddSkillDragItem(18, rc.Get<GameObject>("UIMainChat"));

            self.CheckSkilPositionSet();

            self.UpdateSkillPosition();
        }

        public static void AddSkillDragItem(this UIMainButtonPositionComponent self, int i, GameObject go)
        {
            UISkillDragComponent uISkillDrag = self.AddChild<UISkillDragComponent, int, GameObject>(i, go);
            uISkillDrag.BeginDrag_TriggerHandler = self.OnBeginDrag_TriggerHandler;
            uISkillDrag.Drag_TriggerHandler = self.OnDrag_TriggerHandler;
            uISkillDrag.EndDrag_TriggerHandler = self.OnEndDrag_TriggerHandler;
            uISkillDrag.OnCancel_TriggerHandler = self.OnOnCancel_TriggerHandler;
            self.UISkillDragList.Add(uISkillDrag);
            self.SkillPositionList.Add(go.transform.localPosition);
            self.InitPositionList.Add(go.transform.localPosition);
        }

        public static void ShowSkillPositionSet(this UIMainButtonPositionComponent self)
        {
            self.GameObject.SetActive(true);
            self.SkillPositionSet.SetActive(true);

            for (int i = 0; i < self.UISkillDragList.Count; i++)
            {
                self.UISkillDragList[i].Img_EventTrigger.SetActive(true);
            }
        }

        public static void CheckSkilPositionSet(this UIMainButtonPositionComponent self)
        {
            long userid = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.UserId;
            string positonlist = PlayerPrefsHelp.GetString($"PlayerPrefsHelp.SkillPostion_{userid}");
           
            string[] vector2list = positonlist.Split('@');

            self.SkillPositionList.Clear();
            for (int i = 0; i < vector2list.Length; i++)
            {
                string[] vectorinfo = vector2list[i].Split(';');
                if (vectorinfo.Length < 2)
                {
                    continue;
                }
                self.SkillPositionList.Add(new Vector2() { x = float.Parse(vectorinfo[0]), y = float.Parse(vectorinfo[1]) });
            }

            for (int i = self.SkillPositionList.Count; i < self.InitPositionList.Count; i++)
            {
                self.SkillPositionList.Add(self.InitPositionList[i]);
            }

            self.TempPositionList.Clear();
            for (int i = 0; i < self.SkillPositionList.Count; i++)
            {
                self.TempPositionList.Add(self.SkillPositionList[i]);
            }
        }

        public static void UpdateSkillPosition(this UIMainButtonPositionComponent self)
        {
            for (int i = 0; i < self.UISkillDragList.Count; i++)
            {
                self.UISkillDragList[i].GameObject.transform.localPosition = self.TempPositionList[i];
            }
        }

        public static void OnBtn_SkilPositionReset(this UIMainButtonPositionComponent self)
        {
            self.TempPositionList.Clear();
            self.SkillPositionList.Clear();
            for (int i = 0; i < self.InitPositionList.Count; i++)
            {
                self.TempPositionList.Add(self.InitPositionList[i]);
                self.SkillPositionList.Add(self.InitPositionList[i]);
            }

            self.UpdateSkillPosition();
            self.OnBtn_SkilPositionSave();

            self.GameObject.SetActive(false);
            self.SkillPositionSet.SetActive(false);
            for (int i = 0; i < self.UISkillDragList.Count; i++)
            {
                self.UISkillDragList[i].Img_EventTrigger.SetActive(false);
            }
        }

        public static void OnBtn_SkilPositionCancel(this UIMainButtonPositionComponent self)
        {
            self.TempPositionList.Clear();
            for (int i = 0; i < self.SkillPositionList.Count; i++)
            {
                self.TempPositionList.Add(self.SkillPositionList[i]);
            }
            self.UpdateSkillPosition();

            self.GameObject.SetActive(false);
            self.SkillPositionSet.SetActive(false);
            for (int i = 0; i < self.UISkillDragList.Count; i++)
            {
                self.UISkillDragList[i].Img_EventTrigger.SetActive(false);
            }
        }

        public static void OnBtn_SkilPositionSave(this UIMainButtonPositionComponent self)
        {
            string positonlist = string.Empty;
            self.SkillPositionList.Clear();
            for (int i = 0; i < self.TempPositionList.Count; i++)
            {
                self.SkillPositionList.Add(self.TempPositionList[i]);
            }
            for (int i = 0; i < self.SkillPositionList.Count; i++)
            {
                Vector2 vector2 = self.SkillPositionList[i];
                positonlist += $"{vector2.x};{vector2.y}@";
            }
            positonlist = positonlist.Substring(0, positonlist.Length - 1);
            long userid = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.UserId;
            PlayerPrefsHelp.SetString($"PlayerPrefsHelp.SkillPostion_{userid}", positonlist);

            self.GameObject.SetActive(false);
            self.SkillPositionSet.SetActive(false);
            for (int i = 0; i < self.UISkillDragList.Count; i++)
            {
                self.UISkillDragList[i].Img_EventTrigger.SetActive(false);
            }
        }


        public static void OnBeginDrag_TriggerHandler(this UIMainButtonPositionComponent self, int skillIndex)
        {
            Log.Debug($"OnDraging_TriggerHandler :   {skillIndex}");
            self.CurDragIndex = skillIndex;

            self.SkillIconItemCopy = GameObject.Instantiate(self.UISkillDragList[skillIndex].GameObject);
            self.SkillIconItemCopy.SetActive(true);
            UICommonHelper.SetParent(self.SkillIconItemCopy, UIEventComponent.Instance.UILayers[(int)UILayer.Low].gameObject);
        }

        public static void OnDrag_TriggerHandler(this UIMainButtonPositionComponent self, PointerEventData pdata)
        {
            Vector2 localPoint = Vector2.zero;
            RectTransform canvas = self.SkillIconItemCopy.transform.parent.GetComponent<RectTransform>();
            Camera uiCamera = self.DomainScene().GetComponent<UIComponent>().UICamera;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas, pdata.position, uiCamera, out localPoint);

            self.SkillIconItemCopy.transform.localPosition = new Vector3(localPoint.x, localPoint.y, 0f);
        }

        public static void OnEndDrag_TriggerHandler(this UIMainButtonPositionComponent self, PointerEventData pdata)
        {
            self.OnOnCancel_TriggerHandler(pdata);
        }

        public static void OnOnCancel_TriggerHandler(this UIMainButtonPositionComponent self, PointerEventData pdata)
        {
            RectTransform canvas = self.SkillIconItemCopy.transform.parent.GetComponent<RectTransform>();
            GraphicRaycaster gr = canvas.GetComponent<GraphicRaycaster>();
            List<RaycastResult> results = new List<RaycastResult>();
            gr.Raycast(pdata, results);

            for (int i = 0; i < results.Count; i++)
            {
                string name = results[i].gameObject.name;

                bool collide = false;
                if (name.Contains("ImageSkillPositionSet") && self.CurDragIndex < 12)
                {
                    collide = true;
                }
                if (name.Contains("ImageLeftBottomBtns") && self.CurDragIndex >= 12)
                {
                    collide = true;
                }
                if (!collide)
                {
                    continue;
                }

                Camera UiCamera = GameObject.Find("Global/UI/UICamera").GetComponent<Camera>();
                Camera MainCamera = GameObject.Find("Global/Main Camera").GetComponent<Camera>();

                Vector3 uiPos_2 = Vector3.one;
                RectTransformUtility.ScreenPointToWorldPointInRectangle(results[i].gameObject.transform as RectTransform,
                            Input.mousePosition, MainCamera, out uiPos_2);

                Vector2 OldPosition = WorldPosiToUIPos.WorldPosiToUIPosition(uiPos_2, results[i].gameObject, UiCamera, MainCamera, false);
                self.TempPositionList[self.CurDragIndex] = OldPosition;

                self.UpdateSkillPosition();
                break;
            }

            if (self.SkillIconItemCopy != null)
            {
                GameObject.Destroy(self.SkillIconItemCopy);
                self.SkillIconItemCopy = null;
            }
        }

    }
}
