using System;
using System.Reflection;

namespace ET
{
    public static class ReflectionHelper
    {

        /// <summary>
        /// 根据实体组件的类型动态修改其字符串属性值
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="newValue">要设置的新值</param>
        /// <returns>是否成功修改</returns>
        public static bool ModifyEntityStringProperty(Entity component, string newValue)
        {

            Type componentType = component.GetType();

            try
            {
                // 方法1：使用Type判断
                if (componentType == typeof(BagComponent))
                {
                    // 获取BagComponent的所有字符串属性
                    ModifyStringProperties(component, newValue);
                    return true;
                }
                else if (componentType == typeof(TaskComponent))
                {
                    // 获取TaskComponent的所有字符串属性
                    ModifyStringProperties(component, newValue);
                    return true;
                }

                // 方法2：使用类型名称判断（更灵活，不依赖具体类型引用）
                string typeName = componentType.Name;
                if (typeName == "BagComponent" || typeName == "TaskComponent")
                {
                    ModifyStringProperties(component, newValue);
                    return true;
                }

                Console.WriteLine($"不支持的类型: {componentType.FullName}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"修改属性时出错: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// 反射修改对象的所有字符串属性
        /// </summary>
        public static void ModifyStringProperties(object obj, string newValue)
        {
            Type type = obj.GetType();

            // 获取所有公共实例属性
            PropertyInfo[] properties = type.GetProperties(
                BindingFlags.Public |
                BindingFlags.Instance |
                BindingFlags.DeclaredOnly
            );

            foreach (PropertyInfo property in properties)
            {
                // 只修改可写的字符串属性
                if (property.CanWrite &&
                    property.PropertyType == typeof(string))
                {
                    try
                    {
                        property.SetValue(obj, newValue);
                        Console.WriteLine($"已修改 {type.Name}.{property.Name} 为: {newValue}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"修改 {property.Name} 失败: {ex.Message}");
                    }
                }
            }
        }


        /// <summary>
        /// 使用特性标记可修改的属性（更优雅的方式）
        /// </summary>
        public static bool ModifyWithAttribute(Entity component, string newValue)
        {

            Type componentType = component.GetType();

            // 查找所有带有[ModifiableString]特性的属性
            PropertyInfo[] properties = componentType.GetProperties(
                BindingFlags.Public |
                BindingFlags.Instance
            );

            bool modified = false;
            foreach (PropertyInfo property in properties)
            {
                
            }

            return modified;
        }
    }
}
