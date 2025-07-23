using System;
using Douyin.Game;
using UnityEngine;

public class DialogManager : CommonCanvasScript<DialogManager>
{
    private GameObject _dialog;
    
    public void ShowDialog(string title,Action okCallBack,Action cancelCallBack)
    {
        var dialog = GetDialog();
        dialog.ShowDialog(title,okCallBack,cancelCallBack);
    }

    private Dialog GetDialog()
    {
        if (this._dialog == null)
        {
            this._dialog = Instantiate(PrefabLoader.LoadDialogPrefab(), this._commonCanvasTransform);
        }

        return this._dialog == null ? null : this._dialog.GetComponent<Dialog>();
    }
}
