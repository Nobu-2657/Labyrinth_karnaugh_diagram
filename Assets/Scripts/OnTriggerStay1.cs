using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerStay1 : MonoBehaviour
{
    [SerializeField] GameObject Panel1;
    [SerializeField] Transform Input1a;
    [SerializeField] Transform Input1b;
    [SerializeField] Transform Image1a;
    [SerializeField] Transform Image1b;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Panel1.SetActive(true);

            //Canvas�̈Í��\��non-active��������...
            Input1a.gameObject.SetActive(true);
            Image1a.gameObject.SetActive(true);

            //Canvas�̈Í��\��active��������...
            //Input1b.gameObject.SetActive(true);
            //Image1b.gameObject.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Panel1.SetActive(false);

            //Canvas�̈Í��\��non-active��������...
            Input1a.gameObject.SetActive(false);
            Image1a.gameObject.SetActive(false);

            //Canvas�̈Í��\��active��������...
            //Input1b.gameObject.SetActive(false);
            //Image1b.gameObject.SetActive(false);
        }
    }
}
