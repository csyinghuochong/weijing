using UnityEngine;

namespace ET
{
    //伤害范围检测函数
    public interface Shape
    {
        bool Contains(Vector3 point);
    }

    public class Circle : Shape
    {
        public Vector3 s_position { get; set; }   //检测体坐标
        public float range { get; set; }       //检测范围

        /// <summary>
        /// 是否在一定范围内
        /// </summary>
        /// <param name="point">被检测体坐标</param>
        /// <returns></returns>
        public bool Contains(Vector3 t_point)
        {
            return Vector3.Distance(s_position, t_point) <= range;
        }
    }

    public class Rectangle : Shape
    {

        public Vector3 s_position { get; set; }     //检测体坐标
        public Vector3 s_forward { get; set; }      //检测体朝向

        public float x_range { get; set; }      //检测X范围[左右的方向]
        public float z_range { get; set; }      //检测Z范围[向前的方向]

        public bool Contains(Vector3 t_point)
        {
            //计算玩家与敌人的距离
            //float distance = Vector3.Distance(s_position, t_point);
            //玩家与敌人的方向向量
            Vector3 temVec = t_point - s_position;
            if (temVec == Vector3.zero)
            {
                return true;
            }
            //与玩家正前方做点积
            float forwardDistance = Vector3.Dot(temVec, s_forward.normalized);
            if (forwardDistance > 0 && forwardDistance <= z_range)
            {
                Vector3 newVec = Quaternion.Euler(0f, 90f, 0f) * s_forward;
                float rightDistance = Vector3.Dot(temVec, newVec.normalized);

                if (Mathf.Abs(rightDistance) <= x_range)
                {
                    return true;
                }
            }
            return false;
        }
    }

    public class Fan : Shape
    {
        public Vector3 s_position { get; set; }     //检测体坐标

        public Quaternion s_rotation;

        public float skill_distance;

        public float skill_angle;

        public bool Contains(Vector3 t_point)
        {
            float distance = Vector3.Distance(s_position, t_point);//距离
            Vector3 norVec = s_rotation * Vector3.forward;
            Vector3 temVec = t_point - s_position;
            float dot_len = Vector3.Dot(norVec.normalized, temVec.normalized);
#if NOT_UNITY
            float jiajiao = Mathf.Rad2Deg(Mathf.Acos(dot_len));//计算两个向量间的夹角
#else
            float jiajiao = Mathf.Acos(dot_len) * Mathf.Rad2Deg;//计算两个向量间的夹角
#endif
            return distance < skill_distance && jiajiao <= skill_angle;
        }
    }
}
