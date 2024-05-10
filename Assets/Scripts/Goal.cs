using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{

     private void OnTriggerEnter(Collider other)
    {
        //もしゴールオブジェクトのコライダーに接触した時の処理。
        if (other.CompareTag("Goal"))
        {
            //ゴールシーンを表示
            SceneManager.LoadScene("Goal");
        }
    }
}
