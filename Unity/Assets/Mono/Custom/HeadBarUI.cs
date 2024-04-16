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

    public static bool ObjectVisible(Camera camera,  GameObject obj)
    { 
        Vector3 viewportPosition = camera.WorldToViewportPoint(obj.transform.position);
        if (viewportPosition.x > 0 && viewportPosition.x < 1 
            && viewportPosition.y > 0 && viewportPosition.y < 1
            && viewportPosition.z > 0)
        {
            return true;
        }
        return false;
    }

    public void UpdatePostion()
    {
        if (HeadPos == null || HeadBar == null)
        {
            return;
        }
        if (ObjectVisible(MainCamera, HeadPos.gameObject))
        {
            Vector2 OldPosition = WorldPosiToUIPos.WorldPosiToUIPosition(this.HeadPos.position, HeadBar, UiCamera, MainCamera, false);
            Vector3 NewPosition = Vector3.zero;
            NewPosition.x = OldPosition.x;
            NewPosition.y = OldPosition.y;
            HeadBar.transform.localPosition = NewPosition;
        }
        else
        {
            HeadBar.transform.localPosition = new Vector3(-2000, -2000, 0);
        }
       
        //HeadBar.transform.localPosition = Vector3.SmoothDamp(HeadBar.transform.localPosition, NewPosition, ref velocity, 0.1f);
    }

    private void LateUpdate()
    {
        UpdatePostion();
    }
}