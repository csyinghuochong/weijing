using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadBarUI : MonoBehaviour
{
    // Start is called before the first frame update

    public Camera UiCamera;
    public Camera MainCamera;

    public Transform HeadPos;
    public GameObject HeadBar;

    void Start()
    {
        UiCamera = GameObject.Find("Global/UI/UICamera").GetComponent<Camera>();
        MainCamera = GameObject.Find("Global/Main Camera").GetComponent<Camera>();
    }

    public void UpdatePostion()
    {
        if (HeadPos == null || HeadBar == null)
        {
            return;
        }
        Vector2 OldPosition = WorldPosiToUIPosi(HeadPos.position, HeadBar, UiCamera, MainCamera, false);
        Vector3 NewPosition = Vector3.zero;
        NewPosition.x = OldPosition.x;
        NewPosition.y = OldPosition.y;
        HeadBar.transform.localPosition = NewPosition;
    }

    private void Update()
    {
        UpdatePostion();
    }

    /// <summary>
    /// 世界坐标转换成当前坐标
    /// </summary>
    /// <returns></returns>
    public Vector2 WorldPosiToUIPosi(Vector3 worldVec3, GameObject go, Camera uiCamera, Camera mainCamera, bool wordspace = false)
    {
        if (wordspace)
        {
            RectTransform canvas = go.transform.parent.GetComponent<RectTransform>();
            Vector2 localPoint = Vector2.zero;
            Vector2 screenPoint = RectTransformUtility.WorldToScreenPoint(mainCamera, worldVec3);
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas, screenPoint, null, out localPoint);
            return localPoint;
        }
        else
        {
            worldVec3 = mainCamera.WorldToScreenPoint(worldVec3);
            RectTransform canvas = go.transform.parent.GetComponent<RectTransform>();
            Vector2 localPoint = Vector2.zero;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas, worldVec3, uiCamera, out localPoint);
            return localPoint;
        }
    }
}
