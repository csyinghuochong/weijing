using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterMove : MonoBehaviour
{

    public float MaxX = 10;
    private Vector2 beginVector2;
    private Material material;
    private float beingX;

    // Start is called before the first frame update
    void Start()
    {
        GameObject water = this.gameObject;
        this.material = water.GetComponent<MeshRenderer>().materials[0];
        this.beginVector2 = material.GetTextureOffset("_MainTex");
        beingX = this.beginVector2.x;
        MaxX = beingX + 10;
    }

    // Update is called once per frame
    void Update()
    {
        this.beginVector2.x += Time.deltaTime * 0.1f;
        this.beginVector2.x = this.beginVector2.x >= MaxX ? beingX : this.beginVector2.x;
        material.SetTextureOffset("_MainTex", this.beginVector2);
    }
}
