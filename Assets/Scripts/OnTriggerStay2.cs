using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerStay2 : MonoBehaviour
{
    [SerializeField] GameObject Panel2;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Panel2.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Panel2.SetActive(false);
        }
    }
}
