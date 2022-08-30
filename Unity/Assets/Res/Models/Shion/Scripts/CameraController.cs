using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    float posX;
    float posY;

    void Start()
    {

    }

    void LateUpdate()
    {
        Vector3 playerPos = this.player.transform.position;
        posX = playerPos.x + 1.0f;
        posY = playerPos.y + 1.7f;
        transform.position = new Vector3(posX, posY, transform.position.z);
    }
}
