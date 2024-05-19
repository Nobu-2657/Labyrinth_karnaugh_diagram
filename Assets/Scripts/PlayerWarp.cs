using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWarp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        // transformを取得
        Transform myTransform = this.transform;

        // ワールド座標を基準に、座標を取得
        Vector3 worldPos = myTransform.position;

        switch (other.gameObject.name)
        {
            case "Warp1a":
                worldPos.x = 5.5f;
                worldPos.y = 3.25f;
                worldPos.z = -7.5f;
                myTransform.position = worldPos;  // ワールド座標での座標を設定
                break;

            case "Warp1b":
                worldPos.x = 5.5f;
                worldPos.y = 3.25f;
                worldPos.z = 2.5f;
                myTransform.position = worldPos;  // ワールド座標での座標を設定
                break;

            case "Warp2a":
                worldPos.x = 4.5f;
                worldPos.y = 0.25f;
                worldPos.z = -2.5f;
                myTransform.position = worldPos;  // ワールド座標での座標を設定
                break;

            case "Warp2b":
                worldPos.x = -9.5f;
                worldPos.y = 3.25f;
                worldPos.z = 6.5f;
                myTransform.position = worldPos;  // ワールド座標での座標を設定
                break;

            case "Warp3a":
                worldPos.x = 0.5f;
                worldPos.y = 6.25f;
                worldPos.z = -9.5f;
                myTransform.position = worldPos;  // ワールド座標での座標を設定
                break;

            case "Warp3b":
                worldPos.x = 4.5f;
                worldPos.y = 0.25f;
                worldPos.z = -2.5f;
                myTransform.position = worldPos;  // ワールド座標での座標を設定
                break;

            case "Warp4a":
                worldPos.x = 9.5f;
                worldPos.y = 6.25f;
                worldPos.z = -1.5f;
                myTransform.position = worldPos;  // ワールド座標での座標を設定
                break;

            case "Warp4b":
                worldPos.x = -4.5f;
                worldPos.y = 6.25f;
                worldPos.z = -1.5f;
                myTransform.position = worldPos;  // ワールド座標での座標を設定
                break;

            case "Warp5a":
                worldPos.x = -9.5f;
                worldPos.y = 6.25f;
                worldPos.z = 7.5f;
                myTransform.position = worldPos;  // ワールド座標での座標を設定
                break;

            case "Warp5b":
                worldPos.x = -2.5f;
                worldPos.y = 6.25f;
                worldPos.z = -5.5f;
                myTransform.position = worldPos;  // ワールド座標での座標を設定
                break;

            case "Warp6a":
                worldPos.x = -0.5f;
                worldPos.y = 6.25f;
                worldPos.z = -3.5f;
                myTransform.position = worldPos;  // ワールド座標での座標を設定
                break;

            case "Warp6b":
                worldPos.x = 1.5f;
                worldPos.y = 6.25f;
                worldPos.z = -6.5f;
                myTransform.position = worldPos;  // ワールド座標での座標を設定
                break;

            case "Warp7a":
                worldPos.x = -9.5f;
                worldPos.y = 3.25f;
                worldPos.z = 2.5f;
                myTransform.position = worldPos;  // ワールド座標での座標を設定
                break;

            case "Warp7b":
                worldPos.x = -4.5f;
                worldPos.y = 0.25f;
                worldPos.z = -8.5f;
                myTransform.position = worldPos;  // ワールド座標での座標を設定
                break;
        }
    }
}
