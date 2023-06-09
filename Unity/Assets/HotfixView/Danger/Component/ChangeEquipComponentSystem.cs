using System.Collections.Generic;
using UnityEngine;

namespace ET
{

	public class ChangeEquipComponentAwakeSystem : AwakeSystem<ChangeEquipComponent>
	{
		public override void Awake(ChangeEquipComponent self)
		{
            self.Awake();
		}
	}

    public static class ChangeEquipComponentSystem
    {

		public static void Awake(this ChangeEquipComponent self)
		{
            self.target = self.GetParent<Unit>().GetComponent<GameObjectComponent>().GameObject;
        }

        public static void InitWeapon(this ChangeEquipComponent self, int equipId = 0)
        {
            if (UnitHelper.IsCanChangeEquip(self.GetParent<Unit>()))
            {
                self.AddComponent<ChangeEquipHelper>().LoadEquipment_2(self.target);
            }

            self.ChangeWeapon(equipId);
        }

        public static void ChangeWeapon(this ChangeEquipComponent self,  int weaponId)
        {
            int occ = self.GetParent<Unit>().ConfigId;
            UICommonHelper.ShowWeapon(self.GetParent<Unit>().GetComponent<GameObjectComponent>().GameObject, occ, weaponId);
        }
    }


}
