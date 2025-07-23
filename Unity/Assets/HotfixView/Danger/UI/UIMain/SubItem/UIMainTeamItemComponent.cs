using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

namespace ET
{

    public class UIMainTeamItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject GameObject;
        public GameObject DamageValue;
        public GameObject ImageBooldValue;
        public GameObject PlayerName;
        public GameObject PlayerLv;
        public GameObject ImageHead;

        public TeamPlayerInfo TeamPlayerInfo;

        public long UnitId;
    }


    public class UIMainTeamItemComponentAwakeSystem : AwakeSystem<UIMainTeamItemComponent, GameObject>
    {
        public override void Awake(UIMainTeamItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.DamageValue = rc.Get<GameObject>("DamageValue");
            self.ImageBooldValue = rc.Get<GameObject>("ImageBooldValue");
            self.PlayerName = rc.Get<GameObject>("PlayerName");
            self.PlayerLv = rc.Get<GameObject>("PlayerLv");
            self.ImageHead = rc.Get<GameObject>("ImageHead");

            self.DamageValue.GetComponent<Text>().text = "";
        }
    }

    public static class UIMainTeamItemComponentSystem
    {

        public static void OnUpdateDamage(this UIMainTeamItemComponent self, TeamPlayerInfo teamPlayerInfo)
        {
            long value = teamPlayerInfo.Damage;
            string str = value.ToString();
            if (GameSettingLanguge.Language == 0)
            {
                if (value >= 10000)
                {
                    str = ((float)value / 10000.0f).ToString("F2") + "万";
                }
            }
            else
            {
                if (value >= 1000)
                {
                    str = ((float)value / 1000.0f).ToString("F2") + "K";
                }
            }

            self.DamageValue.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("输出:") + str;
        }

        public static void OnReset(this UIMainTeamItemComponent self)
        {
            self.DamageValue.GetComponent<Text>().text = "";
        }

        public static void OnUpdateHP(this UIMainTeamItemComponent self, Unit unit)
        {
            if (unit.Id != self.UnitId)
            {
                return;
            }

            float curhp = unit.GetComponent<NumericComponent>().GetAsLong(NumericType.Now_Hp); 
            float blood = curhp / unit.GetComponent<NumericComponent>().GetAsLong(NumericType.Now_MaxHp);
            blood = Mathf.Clamp01(blood);
            self.ImageBooldValue.transform.localScale = new Vector3(blood, 1,1);
        }

        public static void OnUpdateItem(this UIMainTeamItemComponent self, TeamPlayerInfo teamPlayerInfo)
        {
            if (self.UnitId == 0)
            {
                self.GameObject.SetActive(true);
            }

            self.TeamPlayerInfo = teamPlayerInfo;
            self.UnitId = teamPlayerInfo.UserID;
            self.PlayerName.GetComponent<Text>().text = teamPlayerInfo.PlayerName;
            self.PlayerLv.GetComponent<Text>().text = string.Format(GameSettingLanguge.LoadLocalization("{0}级"), teamPlayerInfo.PlayerLv);
            self.OnUpdateDamage(teamPlayerInfo);
            UICommonHelper.ShowOccIcon(self.ImageHead, teamPlayerInfo.Occ);
        }

    }
}
