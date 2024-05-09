using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraContoller : MonoBehaviour
{
    public Transform player;

    void Start()
    {

    }

    // 他ファイルのUpdateが実行され終わってから実行したいのでLateUpdate()を使用（教科書と異なるがカメラの追従はこちらがいいそう）
    void LateUpdate()
    {
        Vector3 playerPos = this.player.position;
        // transform.position = new Vector3(transform.position.x, playerPos.y, transform.position.z);

        // カメラをキャラと同じタイミングで動かすのではなく、Lerpで時間差でカメラを動かすことができる（教科書と異なる）
        Vector3 targetPos = new Vector3(transform.position.x, playerPos.y, transform.position.z);
        transform.position = Vector3.Lerp(
            transform.position,
            targetPos,
            0.02f
        );
    }
}
