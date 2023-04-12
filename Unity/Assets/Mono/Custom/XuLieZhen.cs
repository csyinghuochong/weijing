using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XuLieZhen : MonoBehaviour
{
    public Image Image;
    public int Index = -1;
    public List<Sprite> Sprites = new List<Sprite>();

    public float PassTime = 0f;
    public float Interval = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    public void SetSize(Sprite sprite, Vector2 localScale, Vector3 localPosition)
    {
        this.Index = -1;
        this.Image = GetComponent<Image>();
        this.Image.sprite = sprite;
        this.Image.SetNativeSize();
        this.Image.transform.localScale = localScale;
        this.Image.transform.localPosition = localPosition;
    }

    public void SetFirst(Sprite sprite)
    {
        this.Image = GetComponent<Image>();
        this.Image.sprite = sprite;
    }

    public void SetSprites(List<Sprite> sprites )
    {
        this.Index = 0;
        this.Sprites = sprites; 
    }

    // Update is called once per frame
    void Update()
    {
        if (this.Sprites.Count <= 0)
        {
            return;
        }
        this.PassTime += Time.deltaTime;
        if (this.PassTime <= this.Interval)
        {
            return;
        }
        if (this.Index >= this.Sprites.Count)
        {
            this.Index = 0;
        }
        this.Image.sprite = this.Sprites[this.Index];
        this.PassTime = 0f;
        this.Index++;
    }
}
