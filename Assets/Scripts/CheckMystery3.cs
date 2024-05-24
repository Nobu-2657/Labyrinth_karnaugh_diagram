using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class CheckMystery3 : MonoBehaviour
{
    [SerializeField] GameObject wall;
    [SerializeField] GameObject destroyObj1;
    [SerializeField] GameObject destroyObj2;
    [SerializeField] GameObject parent;
    [SerializeField] Transform Obj1;
    [SerializeField] Transform Obj2;
    [SerializeField] Transform Obj3;
    [SerializeField] Transform Obj4;
    private InputField inputField1;
    private InputField inputField2;
    private InputField inputField3;

    [SerializeField] private ItemDataBase itemDataBase;
    [SerializeField] private ItemManager itemManager;
    private int keyCount = 0;

    public Fungus.Flowchart flowchart;
    public string sendMessageMystery3TrueHave3 = "";
    public string sendMessageMystery3TrueHave2 = "";
    public string sendMessageMystery3TrueHave1 = "";
    public string sendMessageMystery3TrueHave0 = "";
    public string sendMessageMystery3FalseHave3 = "";
    public string sendMessageMystery3FalseHave2 = "";
    public string sendMessageMystery3FalseHave1 = "";
    public string sendMessageMystery3FalseHave0 = "";

    void Start()
    {
        destroyObj1 = GameObject.Find("謎3");
        destroyObj2 = GameObject.Find("GameObject3");
        parent = GameObject.Find("Canvas");
        Obj1 = parent.transform.Find("Panel3");
        Obj2 = Obj1.transform.Find("input3a");
        Obj3 = Obj1.transform.Find("input3b");
        Obj4 = Obj1.transform.Find("input3c");
        inputField1 = Obj2.gameObject.GetComponent<InputField>();
        inputField2 = Obj3.gameObject.GetComponent<InputField>();
        inputField3 = Obj4.gameObject.GetComponent<InputField>();
        wall = GameObject.Find("謎解きfinal");
    }

    public void Checker3()
    {
        //鍵を何個持っているか
        for (int i = 0; i < itemDataBase.GetItemLists().Count; i++)
        {
            if (itemManager.HasItem(itemDataBase.GetItemLists()[i]))
            {
                keyCount++;
            }
        }

        UnityEngine.Debug.Log("よろしくお願いしまーす！！！");
        if (inputField1.text == "659" && inputField2.text == "1019" && inputField3.text == "2003")
        {
            Destroy(wall);
            Destroy(destroyObj1);
            Destroy(destroyObj2);
            Obj1.gameObject.SetActive(false);
            UnityEngine.Debug.Log("解けた...!");
            switch (keyCount)
            {
                case 0:
                    flowchart.SendFungusMessage(sendMessageMystery3TrueHave0);
                    break;
                case 1:
                    flowchart.SendFungusMessage(sendMessageMystery3TrueHave1);
                    break;
                case 2:
                    flowchart.SendFungusMessage(sendMessageMystery3TrueHave2);
                    break;
                case 3:
                    flowchart.SendFungusMessage(sendMessageMystery3TrueHave3);
                    break;
            }

        }
        else
        {
            UnityEngine.Debug.Log("もう一度解きます...!");

            switch (keyCount)
            {
                case 0:
                    flowchart.SendFungusMessage(sendMessageMystery3FalseHave0);
                    break;
                case 1:
                    flowchart.SendFungusMessage(sendMessageMystery3FalseHave1);
                    break;
                case 2:
                    flowchart.SendFungusMessage(sendMessageMystery3FalseHave2);
                    break;
                case 3:
                    flowchart.SendFungusMessage(sendMessageMystery3FalseHave3);
                    break;
            }
        }
    }
}
