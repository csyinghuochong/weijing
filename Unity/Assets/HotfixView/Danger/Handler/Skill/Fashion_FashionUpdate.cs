using System.Collections.Generic;

namespace ET
{

    public class Fashion_FashionUpdate : AEventClass<EventType.FashionUpdate>
    {
        protected override void Run(object numerice)
        {
            EventType.FashionUpdate args = numerice as EventType.FashionUpdate;

            Unit unit = args.Unit;  
            List<int> fashionids = args.Unit.GetComponent<UnitInfoComponent>().FashionEquipList;

            NumericComponent numericComponent = args.Unit.GetComponent<NumericComponent>();
            int weaponid = numericComponent.GetAsInt(NumericType.Now_Weapon);

            unit.GetComponent<ChangeEquipComponent>().UpdateFashion(fashionids, unit.ConfigId, weaponid);
        }
    }
}