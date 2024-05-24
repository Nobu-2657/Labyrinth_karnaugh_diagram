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
        UnityEngine.Debug.Log("よろしくお願いしまーす！！！");
        if (inputField1.text == "659" && inputField2.text == "1019" && inputField3.text == "2003")
        {
            Destroy(wall);
            Destroy(destroyObj1);
            Destroy(destroyObj2);
            Obj1.gameObject.SetActive(false);
            UnityEngine.Debug.Log("解けた...!");
        }
        else
        {
            UnityEngine.Debug.Log("もう一度解きます...!");
        }
    }
}
