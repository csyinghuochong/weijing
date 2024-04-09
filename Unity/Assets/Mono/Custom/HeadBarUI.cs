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

    private Vector3 velocity = Vector3.zero;

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

        Vector2 OldPosition = WorldPosiToUIPos.WorldPosiToUIPosition(this.HeadPos.position, HeadBar, UiCamera, MainCamera, false);
        Vector3 NewPosition = Vector3.zero;
        NewPosition.x = OldPosition.x;
        NewPosition.y = OldPosition.y;
        // HeadBar.transform.localPosition = NewPosition;
        HeadBar.transform.localPosition = Vector3.SmoothDamp(HeadBar.transform.localPosition, NewPosition, ref velocity, 0.1f);
    }

    private void LateUpdate()
    {
        UpdatePostion();
    }
}