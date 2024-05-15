using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerStay1 : MonoBehaviour
{
    [SerializeField] GameObject Panel1;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Panel1.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Panel1.SetActive(false);
        }
    }
}
