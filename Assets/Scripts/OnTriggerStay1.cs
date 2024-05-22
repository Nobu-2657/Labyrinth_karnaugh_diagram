using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class OnTriggerStay1 : MonoBehaviour
{
    [SerializeField] GameObject Panel1;
    [SerializeField] GameObject KeyImage;
    [SerializeField] Transform Input1a;
    [SerializeField] Transform Input1b;
    [SerializeField] Transform Image1a;
    [SerializeField] Transform Image1b;
    [SerializeField] Transform Vigenere; 

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Vigenere.gameObject.activeSelf)
            {
                Input1b.gameObject.SetActive(true);
                Image1b.gameObject.SetActive(true);
            }
            else
            {
                Input1a.gameObject.SetActive(true);
                Image1a.gameObject.SetActive(true);
            }
            
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Vigenere.gameObject.activeSelf)
            {
                Input1b.gameObject.SetActive(false);
                Image1b.gameObject.SetActive(false);
            }
            else
            {
                Input1a.gameObject.SetActive(false);
                Image1a.gameObject.SetActive(false);
            }
        }
    }
}
