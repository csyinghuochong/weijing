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

        public static void InitWeapon(this ChangeEquipComponent self,  List<int> fashions, int occ,  int equipId = 0)
        {
            self.AddComponent<ChangeEquipHelper>().LoadEquipment(self.target, fashions, occ);

            self.ChangeWeapon(equipId);
        }

        public static void UpdateFashion(this ChangeEquipComponent self, List<int> fashions, int occ, int equipId = 0)
        {
            self.GetComponent<ChangeEquipHelper>().LoadEquipment(self.target, fashions, occ);
        }

        public static void ChangeWeapon(this ChangeEquipComponent self,  int weaponId)
        {
            int occ = self.GetParent<Unit>().ConfigId;
            UICommonHelper.ShowWeapon(self.GetParent<Unit>().GetComponent<GameObjectComponent>().GameObject, occ, weaponId);
        }
    }


}
