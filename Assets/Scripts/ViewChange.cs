using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewChange : MonoBehaviour
{
    public Camera mainCamera;
    public Camera subCamera;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera.enabled = true;
        subCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F5))
        {
            mainCamera.enabled = !mainCamera.enabled;
            subCamera.enabled = !subCamera.enabled;
        }
    }
}
