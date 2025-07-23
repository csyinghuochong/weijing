using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Douyin.Game
{
    // toast 管理类
    public class ToastManager : CommonCanvasScript<ToastManager>
    {
        
        // 通用toast GameObject
        private GameObject _toastGameObject;
        // 存储toast消息的队列
        private Queue<string> _toastQueue = new Queue<string>();
        // 标记是否正在显示toast
        private bool _isShowingToast = false;

        // 展示toast
        public void ShowToast(string message)
        {
            _toastQueue.Enqueue(message); // 将消息加入队列
            if (!_isShowingToast)
            {
                StartCoroutine(ShowToastQueue()); // 启动协程显示队列中的消息
            }
        }
        
        // 协程：按顺序显示队列中的toast消息
        private IEnumerator ShowToastQueue()
        {
            _isShowingToast = true;
            while (_toastQueue.Count > 0)
            {
                string message = _toastQueue.Dequeue();
                var toastLayoutScript = this.GetToastLayoutScript();
                if (toastLayoutScript)
                {
                    toastLayoutScript.SetToastContent(message);
                }
                yield return new WaitForSeconds(1f); // 等待一秒
            }
            _isShowingToast = false;
        }
        
        // 关闭ToastUI
        public void HideToast()
        {
            if (this._toastGameObject != null)
            {
                Destroy(this._toastGameObject);
                this._toastGameObject = null;
            }
        }

        // 获取toast布局脚本
        private ToastLayoutScript GetToastLayoutScript()
        {
            if (this._commonCanvasTransform == null)
            {
                Debug.LogError("_commonCanvasTransform is null...");
                return null;
            }

            if (this._toastGameObject == null)
            {
                this._toastGameObject = Instantiate(PrefabLoader.LoadToastLayoutPrefab(), this._commonCanvasTransform);
            }

            return this._toastGameObject == null ? null : this._toastGameObject.GetComponent<ToastLayoutScript>();
        }
    }
}