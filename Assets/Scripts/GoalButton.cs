using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalButton : MonoBehaviour
{
    public void RetryBtn()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void TitleBtn()
    {
        SceneManager.LoadScene("Title");
    }
}
