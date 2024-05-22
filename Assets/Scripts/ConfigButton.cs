using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ConfigButton : MonoBehaviour
{

    public void GoBtn()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
