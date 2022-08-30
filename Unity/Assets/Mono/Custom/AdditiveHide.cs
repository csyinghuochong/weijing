using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdditiveHide : MonoBehaviour
{

    bool show = true;
    public List<string> hideObjects = new List<string>();

    void Awake()
    {
        show = false;
        for (int i = 0; i < this.transform.childCount; i++)
        {
            if (!this.transform.GetChild(i).gameObject.activeSelf)
            {
                hideObjects.Add(this.transform.GetChild(i).gameObject.name);
            }

            this.transform.GetChild(i).gameObject.SetActive(false);
        }
    }

    public void ToggleShow()
    {
        show = !show;
        for (int i = 0; i < this.transform.childCount; i++)
        {
            if (show)
                this.transform.GetChild(i).gameObject.SetActive(show && !hideObjects.Contains(this.transform.GetChild(i).gameObject.name));
            else
                this.transform.GetChild(i).gameObject.SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
