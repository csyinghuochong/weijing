using System;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{
    public Text Title;
    public Button OKButton;
    public Button CanelButton;

    private Action _okCallBack;
    private Action _cancelCallBack;

    private void Awake()
    {
        OKButton.onClick.AddListener(() =>
        {
            _okCallBack?.Invoke();
            Destroy(gameObject);
        });
        
        CanelButton.onClick.AddListener((() =>
        {
            _cancelCallBack?.Invoke();
            Destroy(gameObject);
        }));
    }

    public void ShowDialog(string title, Action okCallBack, Action cancelCallBack)
    {
        _okCallBack = okCallBack;
        _cancelCallBack = cancelCallBack;
        Title.text = title;
    }
}
