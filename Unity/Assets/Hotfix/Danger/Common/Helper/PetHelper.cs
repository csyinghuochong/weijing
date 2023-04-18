namespace ET
{
    public static class PetHelper
    {

        public static bool IsShenShou(int configid)
        {
            return configid == 2000001 || configid == 2000002 || configid == 2000003;
        }
    }
}
