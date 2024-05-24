using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;
using static System.Net.Mime.MediaTypeNames;

public class GameSystem : MonoBehaviour
{
    private int i = 0;
    private int j = 0;
    private int k = 0;
    private int l = 0;
    //[SerializeField] private Item vigenere;
    [SerializeField] Transform Vigenere;

    //ダンジョンログ
    public UnityEngine.UI.Text log_text;
    public string dungeon_log = "会話ログ\n";

    void Start()
    {
        //log_textという名前のオブジェクトを探してテキストコーポネントを格納
        log_text = GameObject.Find("log_text").GetComponent<UnityEngine.UI.Text>();

        //このようにテキストを追加する。
        //dungeon_log += "テキストが変更された\n";

        //テキストを反映させる
        update_dungeon_log();
    }

    //ダンジョンログを更新する
    public void update_dungeon_log()
    {
        log_text.text = dungeon_log;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EventLogObject"))
        {
            ItemManager itemManager = FindObjectOfType<ItemManager>(); // シーン内からItemManagerを探す
            switch (other.gameObject.name)
            {
                case "EventLogObject1":
                    if(i==0)
                    {
                        dungeon_log += "壁の向こうに空間があるようだ...\n";
                        update_dungeon_log();
                        i++;
                    }
                    break;

                case "EventLogObject2":
                    if (j == 0)
                    {
                        if (!Vigenere.gameObject.activeSelf)
                        {
                            dungeon_log += "暗号表が必要そうだ...\n";
                            update_dungeon_log();
                            j++;
                        }
                    }
                    break;

                case "EventLogObject3":
                    if (k == 0)
                    {
                        dungeon_log += "暗号表を手に入れた！\n";
                        update_dungeon_log();
                        k++;
                    }
                    break;

                case "EventLogObject4":
                    if (l == 0)
                    {
                        dungeon_log += "先へ進めそうだ\n";
                        update_dungeon_log();
                        l++;
                    }
                    break;
            }
            
        }
    }

}//end