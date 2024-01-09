namespace ET
{
    public static class MathHelper
    {

        /// <summary>
        /// 弧度转角度
        /// </summary>
        /// <param name="radians"></param>
        /// <returns></returns>
        public static float RadToDeg(float radians)
        {
            return (float)(radians * 180 / System.Math.PI);
        }
        
        /// <summary>
        /// 角度转弧度
        /// </summary>
        /// <param name="degrees"></param>
        /// <returns></returns>
        public static float DegToRad(float degrees)
        {
            return (float)(degrees * System.Math.PI / 180);
        }
    }
}