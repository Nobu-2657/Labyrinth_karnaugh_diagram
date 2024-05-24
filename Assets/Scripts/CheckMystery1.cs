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

    void Start()
    {
        destroyObj1 = GameObject.Find("謎1");
        destroyObj2 = GameObject.Find("GameObject");
        parent = GameObject.Find("Canvas");
        Obj1 = parent.transform.Find("Panel1");
        Obj3 = parent.transform.Find("KeyImage");
        Obj4 = Obj3.transform.Find("暗号表_image");
        wall = GameObject.Find("Destroy1");
    }

    public void Checker1()
    {
        if (Obj4.gameObject.activeSelf)
        {
            Obj2 = Obj1.transform.Find("input1b");
            //UnityEngine.Debug.Log(Obj4.gameObject.activeSelf);
        }
        else
        {
            Obj2 = Obj1.transform.Find("input1a");
            //UnityEngine.Debug.Log(Obj4.gameObject.activeSelf);
        }
        inputField = Obj2.gameObject.GetComponent<InputField>();

        if (inputField.text == "mystery")
        {
            Destroy(wall);
            Destroy(destroyObj1);
            Destroy(destroyObj2);
            Obj1.gameObject.SetActive(false);
            UnityEngine.Debug.Log("先へ進めるようになった...!");
        }
        else
        {
            UnityEngine.Debug.Log("答えが違うようだ...");
        }
    }
}
