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

    void Start()
    {
        destroyObj = GameObject.Find("��2");
        parent = GameObject.Find("Canvas");
        Obj1 = parent.transform.Find("Panel2");
        Obj2 = Obj1.transform.Find("input2");
        inputField = Obj2.gameObject.GetComponent<InputField>();
        wall = GameObject.Find("���� �����[�g");
    }

    public void Checker2()
    {
        if (inputField.text == "back")
        {
            Destroy(wall);
            Obj1.gameObject.SetActive(false);
            UnityEngine.Debug.Log("�ǂ����Ŕ����J�����C������...");
        }
        else
        {
            UnityEngine.Debug.Log("�����������N����Ȃ�����...");
        }
    }
}
