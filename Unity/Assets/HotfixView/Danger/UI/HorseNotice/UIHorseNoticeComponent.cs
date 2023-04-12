using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIHorseNoticeComponent : Entity, IAwake, IUpdate
    {
        public GameObject NoticePosition;
        public GameObject Text_TMP;
        public GameObject Imagebg;

        public List<M2C_HorseNoticeInfo> HorseNoticeInfoList;
        public float MoveSpeed = 300f;
        public float MoveNeedTime = 0f;
        public float MovePassTime = 0f;
        public float MoveStartX = 0f;
        public Vector3 CurPosition;
    }


    public class UIHorseNoticeComponentAwakeSystem : AwakeSystem<UIHorseNoticeComponent>
    {
        public override void Awake(UIHorseNoticeComponent self)
        {

            self.HorseNoticeInfoList = new List<M2C_HorseNoticeInfo>();

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.NoticePosition = rc.Get<GameObject>("NoticePosition");
            self.Text_TMP = rc.Get<GameObject>("Text_TMP");
            self.Imagebg = rc.Get<GameObject>("Imagebg");
            self.CurPosition = self.NoticePosition.transform.localPosition;
        }
    }


    public class UIHorseNoticeComponentUpdateSystem : UpdateSystem<UIHorseNoticeComponent>
    {
        public override void Update(UIHorseNoticeComponent self)
        {
            if (self.HorseNoticeInfoList.Count == 0)
            {
                return;

            }

            self.MovePassTime += Time.deltaTime;
            self.CurPosition.x = self.MoveStartX - self.MoveSpeed * self.MovePassTime;
            self.NoticePosition.transform.localPosition = self.CurPosition;
            if (self.MovePassTime > self.MoveNeedTime)
            {
                self.HorseNoticeInfoList.RemoveAt(0);
                self.NoticePosition.SetActive(false);

                if (self.HorseNoticeInfoList.Count > 0)
                {
                    self.SetHorseNoticeInfo(self.HorseNoticeInfoList[0]);
                }
            }
        }
    }

    public static class UIHorseNoticeComponentSystem
    {

        public static void SetHorseNoticeInfo(this UIHorseNoticeComponent self, M2C_HorseNoticeInfo m2C_HorseNoticeInfo)
        {
            self.MovePassTime = 0f;
            self.NoticePosition.SetActive(true);
            Text textMeshProUGUI = self.Text_TMP.GetComponent<Text>();
            textMeshProUGUI.text = m2C_HorseNoticeInfo.NoticeText;

            self.MoveStartX = 1924 * 0.5f + textMeshProUGUI.preferredWidth * 0.5f;
            self.MoveNeedTime = (self.MoveStartX * 2) / self.MoveSpeed;

            self.CurPosition.x = self.MoveStartX;
        }

        public static void OnRecvHorseNotice(this UIHorseNoticeComponent self, M2C_HorseNoticeInfo m2C_HorseNoticeInfo)
        {
            if (self.HorseNoticeInfoList.Count == 0)
            {
                self.SetHorseNoticeInfo(m2C_HorseNoticeInfo);
            }
            self.HorseNoticeInfoList.Add(m2C_HorseNoticeInfo);
        }
    }

}
