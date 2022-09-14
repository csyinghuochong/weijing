using UnityEngine;
using UnityEngine.UI;

public class NpcLocal : MonoBehaviour
{
    // Start is called before the first frame update
    public int NpcId;
    public string NpcName;
    public string NpcSpeak;

    public Camera UiCamera;
    public Camera MainCamera;
    public GameObject Blood;

    //观察目标
    public Transform Target;

    public Transform HeadPos;
    //头顶条
    public GameObject HeadBar;

    public GameObject AssetBundle;

    void Start()
    {
        this.UiCamera = GameObject.Find("Global/UI/UICamera").GetComponent<Camera>();
        this.MainCamera = GameObject.Find("Global/Main Camera").GetComponent<Camera>();
        this.Blood = GameObject.Find("Global/UI/Blood");
        this.HeadPos = this.transform.Find("NamePoint");
        if (this.HeadPos == null)
        {
            UnityEngine.Debug.LogError($"NamePoint==null {this.gameObject.name}");
        }
    }

    private void OnDestroy()
    {
        if (this.HeadBar != null)
        {
            GameObject.Destroy(this.HeadBar);
            this.HeadBar = null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (this.Target == null)
        {
            return;
        }
        float distance = Vector3.Distance(Target.position, this.transform.position);
        if (distance < 15f && this.HeadBar == null)
        {
            this.HeadBar = GameObject.Instantiate(this.AssetBundle);
            this.HeadBar.transform.Find("Lab_NpcName").GetComponent<Text>().text = this.NpcName;
            this.HeadBar.transform.Find("Lab_HeadSpeak").GetComponent<Text>().text = this.NpcSpeak;
            this.HeadBar.transform.SetParent(this.Blood.transform);
            this.HeadBar.transform.localScale = Vector3.one;
        }
        if (distance > 15f && this.HeadBar != null)
        {
            GameObject.Destroy(this.HeadBar);
            this.HeadBar = null;
        }

        if (this.HeadBar != null)
        {
            Vector2 OldPosition = WorldPosiToUIPos.WorldPosiToUIPosition(this.HeadPos.position, HeadBar, UiCamera, MainCamera, false);
            Vector3 NewPosition = Vector3.zero;
            NewPosition.x = OldPosition.x;
            NewPosition.y = OldPosition.y;
            this.HeadBar.transform.localPosition = NewPosition;
        }
    }
}
