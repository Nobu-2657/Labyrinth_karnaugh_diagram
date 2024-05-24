using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class CheckMystery1 : MonoBehaviour
{
    [SerializeField] GameObject wall;
    [SerializeField] GameObject destroyObj1;
    [SerializeField] GameObject destroyObj2;
    [SerializeField] GameObject parent;
    [SerializeField] Transform Obj1;
    [SerializeField] Transform Obj2;
    [SerializeField] Transform Obj3;
    [SerializeField] Transform Obj4;
    private InputField inputField;

    public Fungus.Flowchart flowchart;
    public string sendMessageMystery1TrueHave = "";
    public string sendMessageMystery1TrueHavnt = "";
    public string sendMessageMystery1FalseHave = "";
    public string sendMessageMystery1FalseHavnt = "";

    void Start()
    {
        destroyObj1 = GameObject.Find("ì‰1");
        destroyObj2 = GameObject.Find("Mystery1Manager");
        parent = GameObject.Find("Canvas");
        Obj1 = parent.transform.Find("Panel1");
        Obj3 = parent.transform.Find("KeyImage");
        Obj4 = Obj3.transform.Find("à√çÜï\_image");
        wall = GameObject.Find("Destroy1");
    }

    public void Checker1()
    {
        if (Obj4.gameObject.activeSelf)
        {
            Obj2 = Obj1.transform.Find("input1b");
            UnityEngine.Debug.Log(Obj4.gameObject.activeSelf);
        }
        else
        {
            Obj2 = Obj1.transform.Find("input1a");
            UnityEngine.Debug.Log(Obj4.gameObject.activeSelf);
        }
        inputField = Obj2.gameObject.GetComponent<InputField>();

        if (inputField.text == "mystery")
        {
            Destroy(wall);
            Destroy(destroyObj1);
            Destroy(destroyObj2);
            Obj1.gameObject.SetActive(false);
            UnityEngine.Debug.Log("êÊÇ÷êiÇﬂÇÈÇÊÇ§Ç…Ç»Ç¡ÇΩ...!");
            if (Obj4.gameObject.activeSelf)
            {
                flowchart.SendFungusMessage(sendMessageMystery1TrueHave);
            }
            else
            {
                flowchart.SendFungusMessage(sendMessageMystery1TrueHavnt);
            }
        }
        else
        {
            UnityEngine.Debug.Log("ìöÇ¶Ç™à·Ç§ÇÊÇ§Çæ...");
            if (Obj4.gameObject.activeSelf)
            {
                flowchart.SendFungusMessage(sendMessageMystery1FalseHave);
            }
            else
            {
                flowchart.SendFungusMessage(sendMessageMystery1FalseHavnt);
            }
        }
    }
}
