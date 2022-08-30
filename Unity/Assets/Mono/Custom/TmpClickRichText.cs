using System;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class TmpClickRichText : MonoBehaviour, IPointerClickHandler
{

    public TextMeshProUGUI text;
    public Action<string> ClickHandler;

    /// <summary>
    /// <link=“id”>111111111</link>点击取出“id”
    /// </summary>
    /// <param name="eventData"></param>
    public void OnPointerClick(PointerEventData eventData)
    {
        Camera camera = GameObject.Find("Global/UI/UICamera").GetComponent<Camera>();
        Vector3 pos = new Vector3(eventData.position.x, eventData.position.y, 0);
        int linkIndex = TMP_TextUtilities.FindIntersectingLink(text, pos, camera);
        if (linkIndex > -1)
        {
            TMP_LinkInfo tMP_TextInfo = text.textInfo.linkInfo[linkIndex];
            ClickHandler(tMP_TextInfo.GetLinkID());
        }
    }

}
