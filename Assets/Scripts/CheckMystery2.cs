using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class CheckMystery2 : MonoBehaviour
{
    [SerializeField] GameObject wall;
    [SerializeField] GameObject destroyObj;
    [SerializeField] GameObject parent;
    [SerializeField] Transform Obj1;
    [SerializeField] Transform Obj2;
    private InputField inputField;
    private int flag = 0;

    public Fungus.Flowchart flowchart;
    public string sendMessageMystery2True = "";
    public string sendMessageMystery2TrueTwice = "";
    public string sendMessageMystery2False = "";

    void Start()
    {
        destroyObj = GameObject.Find("ì‰2");
        parent = GameObject.Find("Canvas");
        Obj1 = parent.transform.Find("Panel2");
        Obj2 = Obj1.transform.Find("input2");
        inputField = Obj2.gameObject.GetComponent<InputField>();
        wall = GameObject.Find("ì‡ï« ó†ÉãÅ[Ég");
    }

    public void Checker2()
    {
        if (inputField.text == "back")
        {
            Destroy(wall);
            Obj1.gameObject.SetActive(false);
            if(flag == 0)
            {
                flowchart.SendFungusMessage(sendMessageMystery2True);
                flag++;
            }
            else
            {
                flowchart.SendFungusMessage(sendMessageMystery2TrueTwice);
            }            

            
        }
        else
        {
            UnityEngine.Debug.Log("ÇµÇ©ÇµâΩÇ‡ãNÇ±ÇÁÇ»Ç©Ç¡ÇΩ...");
            flowchart.SendFungusMessage(sendMessageMystery2False);
        }
    }
}
