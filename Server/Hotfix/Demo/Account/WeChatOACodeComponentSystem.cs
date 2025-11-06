using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace ET
{

    public class WeChatOACodeComponentAwake : AwakeSystem<WeChatOACodeComponent>
    {
        public override void Awake(WeChatOACodeComponent self)
        {

        }
    }

    public class WeChatOACodeComponentDestroy : DestroySystem<WeChatOACodeComponent>
    {
        public override void Destroy(WeChatOACodeComponent self)
        {
            self.WeChatOACodeDict.Clear();
        }
    }

    public static class WeChatOACodeComponentSystem
    {

        //HttpWeChatOAHandler回调
        public static async ETTask<string> BingWeChatOACodeResult(this WeChatOACodeComponent self, string  fromusername, string code)
        {
            await ETTask.CompletedTask;

            if (ComHelp.IsInnerNet())
            {
                code = self.WeChatOACodeDict.Values.ToList()[^1];
            }

            if (!self.WeChatOACodeDict.Values.ToList().Contains(code))
            {
                return "验证码错误";
            }

            // 获取第一个匹配的键（可能为0，需注意字典未包含目标值的情况）
            //3055377010755960832  先锋1区  飞鸟依纳
            long unitId = self.WeChatOACodeDict.FirstOrDefault(kvp => kvp.Value == code).Key;
            if (unitId == 0)
            {
                return "验证码错误";
            }

            //C2M_PaiMaiBuyHandler 190

            int oldzone = UnitIdStruct.GetUnitZone(unitId);
            int newzone = ServerHelper.GetNewServerId(oldzone);

            //绑定成功
            // NumericType.WeChatOABind = 1;
            //在线发消息L2M_WeChatOABindResult
            //不在线直接存数据库
            IActorResponse reqEnter = (M2L_WeChatOABindResult)await ActorLocationSenderComponent.Instance.Call(unitId, new L2M_WeChatOABindResult()
            {
                UnitID = unitId,    
                BindResult = 1,
            });
            if (reqEnter.Error == ErrorCode.ERR_Success)
            {
                Log.Debug($"绑定成功   {unitId}  {code}");
                Console.WriteLine($"绑定成功   {unitId}  {code}");
            }
            else
            {
                List<NumericComponent> numericComponents = await Game.Scene.GetComponent<DBComponent>().Query<NumericComponent>(newzone, d => d.Id == unitId);
                Log.Debug($"绑定失败   {unitId}  {numericComponents.Count}");
                Console.WriteLine($"绑定失败   {unitId}  {numericComponents.Count}");
                return "绑定成功 玩家不在线 重新绑定";
            }
            

            return "绑定成功！";
        }


        /// <summary>
        /// 每次请求都重新刷新验证码。玩家下线移除
        /// </summary>
        /// <param name="self"></param>
        /// <param name="unitId"></param>
        /// <returns></returns>
        public static int GenerateWeChatOACode(this WeChatOACodeComponent self, long unitId)
        {
            if (self.WeChatOACodeDict.ContainsKey(unitId))
            {
                self.WeChatOACodeDict.Remove(unitId);
            }

            while (!self.WeChatOACodeDict.ContainsKey(unitId))
            {
                string newcode = GenerateSecureFourDigitNumber().ToString();
                if (!self.WeChatOACodeDict.Values.ToList().Contains(newcode))
                {
                    self.WeChatOACodeDict.Add(unitId, newcode);
                }
            }

            // 解析字符串并获取结果
            int.TryParse(self.WeChatOACodeDict[unitId], out int result);

            // 直接返回解析结果（如果解析失败，result 将为 0）
            return result;
        }

        public static int GenerateSecureFourDigitNumber()
        {

            // 生成1000到9999之间的随机四位数
            using (var rng = RandomNumberGenerator.Create())
            {
                byte[] buffer = new byte[4]; // 4字节(32位)已足够覆盖四位数范围
                rng.GetBytes(buffer);

                // 转换为32位无符号整数，确保非负
                uint randomValue = BitConverter.ToUInt32(buffer, 0);

                // 计算范围：9999 - 1000 + 1 = 9000
                const uint range = 9000;
                const int minValue = 1000;

                // 计算结果：随机值 % 范围 + 最小值
                uint result = (randomValue % range) + minValue;

                return (int)result;
            }
        }
    }

}
