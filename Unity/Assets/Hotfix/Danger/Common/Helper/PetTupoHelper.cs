namespace ET
{
    public static class PetTupoHelper
    {
        public static int GetTupoNumericType(int position)
        {
            switch (position)
            {
                case 0:
                    return NumericType.PetTupo_0;
                case 1:
                    return NumericType.PetTupo_1;
                case 2:
                    return NumericType.PetTupo_2;
                case 3:
                    return NumericType.PetTupo_3;
                case 4:
                    return NumericType.PetTupo_4;
                default:
                    return 0;
            }
        }

        public static int GetTupoFailNumericType(int position)
        {
            switch (position)
            {
                case 0:
                    return NumericType.PetTupoFail_0;
                case 1:
                    return NumericType.PetTupoFail_1;
                case 2:
                    return NumericType.PetTupoFail_2;
                case 3:
                    return NumericType.PetTupoFail_3;
                case 4:
                    return NumericType.PetTupoFail_4;
                default:
                    return 0;
            }
        }
    }
}
