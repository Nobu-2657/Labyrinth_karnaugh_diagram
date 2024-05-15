using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class CheckMystery1 : MonoBehaviour
{
    [SerializeField] GameObject wall;
    [SerializeField] GameObject destroyObj;
    [SerializeField] GameObject parent;
    [SerializeField] Transform Obj1;
    [SerializeField] Transform Obj2;
    private InputField inputField;

    void Start()
    {
        destroyObj = GameObject.Find("ì‰1");
        parent = GameObject.Find("Canvas");
        Obj1 = parent.transform.Find("Panel1");
        Obj2 = Obj1.transform.Find("input1");
        inputField = Obj2.gameObject.GetComponent<InputField>();
        wall = GameObject.Find("Destroy1");
    }

    public void Checker1()
    {
        if (inputField.text == "mystery")
        {
            Destroy(wall);
            Destroy(parent);
            Destroy(destroyObj);
            UnityEngine.Debug.Log("êÊÇ÷êiÇﬂÇÈÇÊÇ§Ç…Ç»Ç¡ÇΩ...!");
        }
        else
        {
            UnityEngine.Debug.Log("ìöÇ¶Ç™à·Ç§ÇÊÇ§Çæ...");
        }
    }
}
