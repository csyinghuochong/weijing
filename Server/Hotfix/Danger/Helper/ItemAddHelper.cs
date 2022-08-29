namespace ET
{
    public static class ItemAddHelper
    {

        public static void OnGetItem(this Unit self, int itemId)
        {
            self.GetComponent<TaskComponent>().OnGetItem(itemId);
            self.GetComponent<ShoujiComponent>().OnGetItem(itemId);
        }
    }
}
