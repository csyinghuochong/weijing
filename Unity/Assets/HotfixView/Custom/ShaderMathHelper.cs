using UnityEngine;

namespace ET
{

    public static class ShaderMathHelper
    {
        //3个坐标轴互相垂直，并且长度为1，标准正交基
        //左手右手坐标系。(照相的L)食指大拇指L. 中指超前左手坐标系unity中使用。  
        //坐直。向右伸直右手(X)。  头顶是Y  正前方是Z轴正向即可左手， 反之为右手坐标系
        //举起你左手，握拳，四根手指的方向即可旋转正方向

        //矢量的定义，矢量是n维空间中一种包含了模和方向的有向线段 v=(x,y)二维矢量 v=(x,y,z)三维矢量
        //标量用小写的字母表示  矢量用小写的粗体字母表示  矩形用大写的粗体字母
        //点是一个没有大小之分的空间位置 矢量是一个有模和方向但是没有位置的量

        //标量是只有模没有方向的量，虽然我们不能把矢量和标量想加减。 但是可以相乘，结果可能会得到一个不同长度并且方向相反的新矢量
        //矢量和标量的乘法，只需要把矢量的每个分量和标量相乘即可：
        //从几何意义看，把一个矢量v和一个标量k想乘，意味吧矢量v缩放.  当k小于0， 则方向相反

        //矢量的加法和减法 对应分量相加。 

        //矢量的模  分量的平方之和 开根号

        //单位矢量，很多情况下，只关心矢量的方向而不是模。例如在计算光照时，需要得到顶点的法线方向和光源方向，此时不关心矢量的长度，就需要计算单位矢量

        //单位矢量指得是那些模为1的矢量。单位矢量也称为归一化的矢量，对任何给定的非零矢量，把他转换成单位矢量的过程就是归一化
        //矢量归一化可用矢量的模除以该矢量得到

        //归一化矢量
        public static Vector2 GetNormalized(Vector2 dest)
        { 
            float changdu = dest.magnitude;
            if (changdu == 0)
            { 
                return dest;    
            }
            return dest / changdu;  
        }

        //矢量的点积。矢量之间也可以进行乘法，但是和标量之间的乘法有大不同，
        //矢量的乘法有点积(内积) 和叉积(外积) 
        //点积的名称a.b  公式一： a.b=(ax,ay,az).(bx,by.bz) = ax*bx + ay*by + az*bz 各分量的乘 之和。点积满足交换律
        //点积的一个重要几何意义就是投影
        public static float GetDot_1(Vector2 from, Vector2 dest)
        {
            float dot = from.x * dest.x +  from.y* dest.y;
            return dot; 
        }

        public static float GetDot_2(Vector2 from, Vector2 dest)
        {
            return Vector2.Dot(from, dest); 
        }

        public static float GetDot_3(Vector2 from, Vector2 dest)
        {
            float angle = Vector2.Angle(from, dest);
            float hudu = MathHelper.DegToRad(angle);
            float cos = Mathf.Cos(hudu);
            return from.magnitude * dest.magnitude * cos;
        }
        //假设有一个单位矢量a 和 一个长度不限的矢量B.  我们希望得到b 在平行a的一条直线上的投影，  就可以使用单位矢量a . b 得到b 在 a方向上的投影
        //通俗点解释就是 一个光源垂直于a 方向的， b在a方向的投影就是 b 在 a方向上的影子
        //a b的方向夹角大于90度， 结果小于0    等于90度结果小于0   小于90度结果大于0
        //点积可结合标量乘法。(ka).b = a.(kb) = k(a.b)相对于对最后的点积结果进行缩放
        //点积可以结合矢量加法和乘法， a.(b+c) = a.b + a.c
        //一个矢量和本身进行点积的结果，是该矢量的模的平方  
        //我们只想比较两个矢量的长度大小， 可以直接使用点积的结果，毕竟开平方也很消耗性能
        //点积的公式2  a.b = |a||b|cosQ   
        //对两个单位矢量进行点积，a.b    cosQ =直角边/斜边  单位矢量a.b刚好对应cosQ对应的直角边  a.b = 直角边/斜边 = cosQ
        //a.b = (|a|a单位矢量)(|b|b单位矢量) = |a||b|cosQ
        //两个矢量的点积可以表示为两个矢量的模相乘 再 乘以他们夹角的余铉值 当夹角小于90度 cosQ>0   。夹角=90度 cosQ=0
        //利用这个公式我们还可以求得两个向量之间的夹角 = arcos(a.b). 反余弦操作

        //另一个重要的矢量运算就是叉积，也被称为外积。与点积不同的是。矢量叉积的结果任是一个矢量。而非标量a X b
        //即结果矢量的第一个分量。他是第一个矢量的y分量乘以第二个矢量的z分量 减去 第一个矢量的z分量，乘以第二个矢量的y分量
        // a X b = ( Ax, Ay, Az ) X (Bx, By, Bz) = ( Ay*Bz - Az*By, Az*Bx - Ax*Bz, Ax*By - Ay*Bx ) 第一个矢量的分量*第二个矢量的对角的分量-第一个矢量的分量（下一个并且非当前）*第二个矢量的对角的分量
        //叉积不满足交换律，但是满足反交换律 aXb= -(bXa) 也不满足结合律
        //aXb的长度等于a和b的模再乘以他们之间的正弦值 |aXb| = |a||b|sinQ    a b平行得到的是零向量而非标量0
        //矢量的方向， 手指的方向a. 手臂的反方向b， 大拇指就是a X b 的方向。  类似于竖起大拇指
        //叉积的作用是计算垂直于一个平面的三角形的矢量 或者 判断三角片面的朝向   左右手坐标系得到的叉积结果一致   只是看起来相反 细想细想
        //叉乘大于0在右手边 小于0在左手边
        public static Vector3 GetCross_1(Vector3 from, Vector3 dest)
        { 
            return Vector3.Cross(from, dest);
        }

        public static Vector3 GetCross_2(Vector3 from, Vector3 dest)
        {
            return new Vector3( from.y * dest.z - from.z * dest.y, from.z * dest.x - from.x * dest.z, from.x* dest.y - from.y * dest.x );
        }

        //根据左手定则，y轴是法向量的方向，当y大于零的时候，敌人在我方右边，当y小于零的时候，敌人在我方左边。
        public static void CalculateCross(Unit cubeRed, Unit cubeBlue)
        {
            Vector3 relativePosition = cubeRed.Position - cubeBlue.Position;
            Vector3 cubeForward = cubeBlue.Forward;
            Vector3 result = Vector3.Cross(cubeForward, relativePosition);
            Log.ILog.Debug(result.y.ToString());
        }
    }
}

