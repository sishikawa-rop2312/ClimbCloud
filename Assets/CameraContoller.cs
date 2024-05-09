using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraContoller : MonoBehaviour
{
    public Transform player;

    void Start()
    {

    }

    // 
    void LateUpdate()
    {
        Vector3 playerPos = this.player.position;
        transform.position = new Vector3(transform.position.x, playerPos.y, transform.position.z);
    }
}
