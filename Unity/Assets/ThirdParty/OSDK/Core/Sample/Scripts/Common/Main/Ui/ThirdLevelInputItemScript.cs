using System;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

namespace Douyin.Game
{
    // 输入框类型的三级列表
    public class ThirdLevelInputItemScript : BaseUi
    {
        [Header("输入框")] [SerializeField] private InputField inputField;

        [Header("内容文本")] [SerializeField] private Text contentText;

        [Header("预制文本")] [SerializeField] private Text inputFieldPlaceholder;

        [Header("分割线布局")] [SerializeField] private GameObject divideViewLayout;

        // 而级列表实体类
        private SecondLevelFunctionsEntity _secondLevelFunctionsEntity;

        // 三级列表实体类
        private ThirdLevelFunctionsEntity _thirdLevelFunctionsEntity;

        private void Start()
        {
            // 监听文本框的数据变化
            this.inputField.onValueChanged.AddListener(val =>
            {
                if (this._thirdLevelFunctionsEntity != null)
                {
                    switch (this._thirdLevelFunctionsEntity.NameId)
                    {
                        // 输入支付金额
                        case MainListItemId.PAYMENT_ENTER_AMOUNT:
                            ReflectionSetPropertyVal(
                                "Douyin.Game.PaymentFunctionScript", 
                                "Instance",
                                "TotalAmount", 
                                val);
                            break;
                        // 输入敏感词
                        case MainListItemId.GAME_PROTECT_SENSITIVE_WORDS_INPUT:
                            ReflectionSetPropertyVal(
                                "Douyin.Game.AppreciationFunctionScript", 
                                "Instance",
                                "currentInputSensitiveWords", 
                                val);
                            break;
                        //兑换码
                        case MainListItemId.INPUT_REDEEM_CODE:
                            ReflectionSetPropertyVal(
                                "Douyin.Game.RedeemCodeSystemFunctionScript",
                                "Instance",
                                "Input_redeem_code",
                                val);
                            break;
                        //经度
                        case MainListItemId.InputLongitude:
                            ReflectionSetPropertyVal(
                                "Douyin.Game.AdFunctionScript",
                                "Instance",
                                "Longitude",
                                val);
                            break;
                        //纬度
                        case MainListItemId.InputLatitude:
                            ReflectionSetPropertyVal(
                                "Douyin.Game.AdFunctionScript",
                                "Instance",
                                "Latitude",
                                val);
                            break;
                    }
                }
            });
        }
        
        private static void ReflectionSetPropertyVal(string typeName,string getPropertyName,string setPropertyName,string val)
        {
            var type = Type.GetType(typeName);
            var instanceProperty = type?.BaseType?.GetProperty(getPropertyName);
            var instance = instanceProperty?.GetValue(null);
            PropertyInfo piInstance = type?.GetProperty(setPropertyName);
            piInstance?.SetValue(instance,val);
        }
        
        // 初始化三级列表数据内容
        public void InitThirdItemData(
            SecondLevelFunctionsEntity secondLevelFunctionsEntity,
            ThirdLevelFunctionsEntity thirdLevelFunctionsEntity)
        {
            switch (thirdLevelFunctionsEntity.NameId)
            {
                // 兑换码设置成允许输入字母
                case MainListItemId.INPUT_REDEEM_CODE:
                case MainListItemId.GAME_PROTECT_SENSITIVE_WORDS_INPUT:
                    inputField.contentType = InputField.ContentType.Standard;
                    break;
                case MainListItemId.InputLatitude:
                case MainListItemId.InputLongitude:
                    inputField.contentType = InputField.ContentType.DecimalNumber;
                    break;
                default:
                    inputField.contentType = InputField.ContentType.DecimalNumber;
                    break;
            }
            this._secondLevelFunctionsEntity = secondLevelFunctionsEntity;
            this._thirdLevelFunctionsEntity = thirdLevelFunctionsEntity;
            this.OnRefreshUi();
        }

        // 隐藏分割线
        public void HideDividerViewLayout()
        {
            if (this.divideViewLayout != null && this.divideViewLayout.gameObject != null)
            {
                this.divideViewLayout.gameObject.SetActive(false);
            }
        }

        // 刷新UI
        public override void OnRefreshUi()
        {
            this.inputField.placeholder.GetComponent<Text>().text = this._thirdLevelFunctionsEntity == null
                ? string.Empty
                : this._thirdLevelFunctionsEntity.GetContent();
        }

        // 释放资源
        public override void OnRelease()
        {
        }
    }
}