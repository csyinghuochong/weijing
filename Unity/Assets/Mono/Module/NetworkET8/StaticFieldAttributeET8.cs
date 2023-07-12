//using System;

//namespace ET
//{

//    /// <summary>
//    /// 静态字段需加此标签
//    /// valueToAssign: 初始化时的字段值
//    /// assignNewTypeInstance: 从默认构造函数初始化
//    /// </summary>
//    [AttributeUsage(AttributeTargets.Field)]
//    public class StaticFieldAttributeET8 : Attribute
//    {

//        public readonly object valueToAssign;

//        public readonly bool assignNewTypeInstance;

//        public StaticFieldAttributeET8()
//        {
//            this.valueToAssign = null;
//            this.assignNewTypeInstance = false;
//        }

//        public StaticFieldAttributeET8(object valueToAssign)
//        {
//            this.valueToAssign = valueToAssign;
//            this.assignNewTypeInstance = false;
//        }

//        public StaticFieldAttributeET8(bool assignNewTypeInstance)
//        {
//            this.valueToAssign = null;
//            this.assignNewTypeInstance = assignNewTypeInstance;
//        }
//    }

//}