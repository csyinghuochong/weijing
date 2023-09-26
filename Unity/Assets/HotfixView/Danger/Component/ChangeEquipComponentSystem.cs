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
            NumericComponent numericComponent = self.GetParent<Unit>().GetComponent<NumericComponent>();
            self.AddComponent<ChangeEquipHelper>().WeaponId = equipId;
            self.GetComponent<ChangeEquipHelper>().LoadEquipment(self.target, fashions, occ, numericComponent.GetAsInt(NumericType.EquipIndex));
        }

        public static void ChangeEquipIndex(this ChangeEquipComponent self)
        {
            NumericComponent numericComponent = self.GetParent<Unit>().GetComponent<NumericComponent>();
            self.GetComponent<ChangeEquipHelper>().EquipIndex = numericComponent.GetAsInt(NumericType.EquipIndex);
        }

        public static void UpdateFashion(this ChangeEquipComponent self, List<int> fashions, int occ, int equipId = 0)
        {
            NumericComponent numericComponent = self.GetParent<Unit>().GetComponent<NumericComponent>();
            self.GetComponent<ChangeEquipHelper>().LoadEquipment(self.target, fashions, occ, numericComponent.GetAsInt(NumericType.EquipIndex));
        }

        public static void ChangeWeapon(this ChangeEquipComponent self,  int weaponId)
        {
            self.GetComponent<ChangeEquipHelper>().ChangeWeapon(weaponId);
        }
    }


}
