
using System;

namespace ET
{

    /// <summary>
    /// 公有弹窗类提示
    /// </summary>

    public class PopupTipHelp
    {

        /// <summary>
        /// 打开公用弹窗
        /// </summary>
        /// <param name="title"></param>
        /// <param name="content"></param>
        /// <param name="okhandle"></param>
        public static async ETTask<UI> OpenPopupTip(Scene scene, string title, string content, Action okhandle, Action cancelHandle=null)
        {
            UI uipopup = await UIHelper.Create(scene, UIType.UIPopupview);
            if (uipopup != null)
            {
                uipopup.GetComponent<UIPopupComponent>().InitData(title, content, okhandle, cancelHandle);
            }
            return uipopup;
        }

        /// <summary>
        /// 公用弹窗，只显示确定按钮
        /// </summary>
        /// <param name="scene"></param>
        /// <param name="title"></param>
        /// <param name="content"></param>
        /// <param name="okhandle"></param>
        /// <returns></returns>
        public static async ETTask OpenPopupTip_2(Scene scene, string title, string content, Action okhandle)
        {
            await UIHelper.Create(scene, UIType.UIPopupview);
            UI uipopup = scene.GetComponent<UIComponent>().Get(UIType.UIPopupview);
            UIPopupComponent uIPopupComponent = uipopup.GetComponent<UIPopupComponent>();
            uIPopupComponent.InitData(title, content, okhandle, null);

            uIPopupComponent.closeButton.SetActive(false);
            uIPopupComponent.cancelButton.SetActive(false);
            uIPopupComponent.confirButton.transform.localPosition = new UnityEngine.Vector3(0f, -169f, 0f);
            /*
            if (okhandle == null) {
                UIHelper.Remove(scene, UIType.UIPopupview).Coroutine();
            }
            */
        }

        /// <summary>
        /// 公用弹窗，只显示确定按钮（比2大一些的弹窗）
        /// </summary>
        /// <param name="scene"></param>
        /// <param name="title"></param>
        /// <param name="content"></param>
        /// <param name="okhandle"></param>
        /// <returns></returns>
        public static async ETTask OpenPopupTip_3(Scene scene, string title, string content, Action okhandle)
        {
            await UIHelper.Create(scene, UIType.UI_CommonHint_2);
            UI uipopup = scene.GetComponent<UIComponent>().Get(UIType.UI_CommonHint_2);
            UIPopupComponent uIPopupComponent = uipopup.GetComponent<UIPopupComponent>();
            uIPopupComponent.InitData(title, content, okhandle, null);
            uIPopupComponent.UIType = UIType.UI_CommonHint_2;

            uIPopupComponent.closeButton.SetActive(false);
            uIPopupComponent.cancelButton.SetActive(false);
            UnityEngine.Vector3 old = uIPopupComponent.confirButton.transform.localPosition;
            uIPopupComponent.confirButton.transform.localPosition = new UnityEngine.Vector3(0f, old.y, 0f);
        }

    }

}
