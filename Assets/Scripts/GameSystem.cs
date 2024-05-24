using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;
using static System.Net.Mime.MediaTypeNames;

public class GameSystem : MonoBehaviour
{
    private int i = 0;
    private int j = 0;
    private int k = 0;
    private int l = 0;
    [SerializeField] Transform Vigenere;
    [SerializeField] GameObject destroyWall;
    public Fungus.Flowchart flowchart;
    public string sendMessageAnotherRoute = "";
    public string sendMessageNeedVigenere = "";
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EventLogObject"))
        {
            switch (other.gameObject.name)
            {
                case "EventLogObject1":
                    if(i==0)
                    {
                        if (destroyWall)
                        {
                            flowchart.SendFungusMessage(sendMessageAnotherRoute);
                            i++;
                        }
                    }
                    break;

                case "EventLogObject2":
                    if (j == 0)
                    {
                        if (!Vigenere.gameObject.activeSelf)
                        {
                            flowchart.SendFungusMessage(sendMessageNeedVigenere);
                            j++;
                        }
                    }
                    break;

                case "EventLogObject3":
                    if (k == 0)
                    {
                        
                        k++;
                    }
                    break;
            }
            
        }
    }

}//end