using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnTriggerStay3 : MonoBehaviour
{
    [SerializeField] GameObject Panel3;
    [SerializeField] Transform Key1;
    [SerializeField] Transform Key2;
    [SerializeField] Transform Key3;
    [SerializeField] GameObject parent;
    [SerializeField] Transform Obj1;
    [SerializeField] Transform Obj2;
    [SerializeField] Transform Obj3;
    [SerializeField] Transform Obj4;
    [SerializeField] InputField inputField1;
    [SerializeField] InputField inputField2;
    [SerializeField] InputField inputField3;

    void Start()
    {
        parent = GameObject.Find("Canvas");
        Obj1 = parent.transform.Find("Panel3");
        Obj2 = Obj1.transform.Find("input3a");
        Obj3 = Obj1.transform.Find("input3b");
        Obj4 = Obj1.transform.Find("input3c");
        inputField1 = Obj2.gameObject.GetComponent<InputField>();
        inputField2 = Obj3.gameObject.GetComponent<InputField>();
        inputField3 = Obj4.gameObject.GetComponent<InputField>();
    }

    public void OnClickReset()
    {
        inputField1.text = "";
        inputField2.text = "";
        inputField3.text = "";
    }

    void OnTriggerStay(Collider other){

        
        if (other.CompareTag("Player")){
            Panel3.SetActive(true);
            if (Key1.gameObject.activeSelf)
            {
                inputField1.text = "659";
            }
            if (Key2.gameObject.activeSelf)
            {
                inputField2.text = "1019";
            }
            if (Key3.gameObject.activeSelf)
            {
                inputField3.text = "2003";
            }
        }
    }

    void OnTriggerExit(Collider other){
        if (other.CompareTag("Player")){
            Panel3.SetActive(false);
        }
    }
}
