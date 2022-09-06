using System;
using UnityEngine;

public static class WorldPosiToUIPos
{


    /// <summary>
    /// 世界坐标转换成当前坐标
    /// </summary>
    /// <returns></returns>
    public static Vector2 WorldPosiToUIPosition(Vector3 worldVec3, GameObject go, Camera uiCamera, Camera mainCamera, bool wordspace = false)
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