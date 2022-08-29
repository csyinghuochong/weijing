namespace ET
{

    //价格计算工具
    public static class GettotalFeeTool
    {
        //微信
        //获取订单支付总额
        public static int WeChatGettotalFee(string payValue, string objCount)
        {
            //首先根据不同ID获取物品对应的单价
            int fee = (int)(int.Parse(payValue) * 100);
            //通过单价乘以数量得出物品总价
            //int totalFee = fee * (int.Parse(objCount));
            return fee;
        }

        public static int AliGettotalFee(int payValue, int objCount)
        {
            //首先根据不同ID获取物品对应的单价
            return payValue;
        }

    }
}
