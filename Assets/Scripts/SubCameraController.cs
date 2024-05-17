using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubCameraController : MonoBehaviour
{
    Vector3 cameraPos;
    [SerializeField]  float crouchCameraHeight = 0f;
    float cameraHeight = 0f;
    float defCameraHeight;
    private bool isCharging = false;
    // Start is called before the first frame update
    void Start()
    {
        PlayerController playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        isCharging = playerController.isCharging;
        if (isCharging)
        {
            if (m_Camera.transform.localPosition.y <= crouchCameraHeight)
            {
    
            }
            else
            {
                cameraHeight -= 0.02f;
            }
        }
        else
        {
            //if (m_Camera.transform.localPosition.y >= defCameraHeight)
            if (cameraHeight >= 0)
            {
                cameraHeight = 0f;
            }
            else
            {
                cameraHeight += 0.06f;
            }
        }
    }
}
