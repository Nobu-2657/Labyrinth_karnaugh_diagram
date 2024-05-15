using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Result : MonoBehaviour
{
    public Text TimeText;
    int minute;
    float seconds;

    // Start is called before the first frame update
    void Start()
    {
        minute = time.getminute();
        seconds = time.getseconds();

        TimeText.text = "Time " + minute.ToString("00") + ":" + ((int) seconds).ToString ("00");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
