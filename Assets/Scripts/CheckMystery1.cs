using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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
    private InputField inputField;

    void Start()
    {
        destroyObj1 = GameObject.Find("��1");
        destroyObj2 = GameObject.Find("GameObject");
        parent = GameObject.Find("Canvas");
        Obj1 = parent.transform.Find("Panel1");
        //Canvas�̈Í��\��non-active��������...
        Obj2 = Obj1.transform.Find("input1a");
        //Canvas�̈Í��\��active��������...
        //Obj2 = Obj1.transform.Find("input1b");
        inputField = Obj2.gameObject.GetComponent<InputField>();
        wall = GameObject.Find("Destroy1");
    }

    public void Checker1()
    {
        if (inputField.text == "mystery")
        {
            Destroy(wall);
            Destroy(destroyObj1);
            Destroy(destroyObj2);
            Obj1.gameObject.SetActive(false);
            UnityEngine.Debug.Log("��֐i�߂�悤�ɂȂ���...!");
        }
        else
        {
            UnityEngine.Debug.Log("�������Ⴄ�悤��...");
        }
    }
}
