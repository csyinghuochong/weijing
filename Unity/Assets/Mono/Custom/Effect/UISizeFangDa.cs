using UnityEngine;
using UnityEngine.UI;

public class UISizeFangDa : MonoBehaviour
{
    private float size = 1;
    public GameObject Obj_Img;
    private float fangdaValue;
    // Use this for initialization
    void Start()
    {
        size = 1f;
        fangdaValue = 1.5f;
    }

    void OnEnable()
    {
        size = 1f;
        fangdaValue = 1.5f;
        this.gameObject.transform.localScale = Vector3.one;
    }

    void OnDisable()
    {
        this.gameObject.transform.localScale = Vector3.one;
    }

    public void ResetValue()
    {
        fangdaValue = 1.5f;
    }

    // Update is called once per frame
    void Update()
    {
        size = size + Time.deltaTime * 1.5f;
        this.gameObject.transform.localScale = new Vector3(size, size, size);

        if (size >= 1.5f) {
            this.gameObject.SetActive(false);
        }

        /*
        float toumingValue = (fangdaValue - size) / (fangdaValue - 1.1f);
        if (toumingValue < 0)
        {
            toumingValue = 0;
        }
        Obj_Img.GetComponent<Image>().color = new Color(1, 1, 1, toumingValue);
        */
    }
}
