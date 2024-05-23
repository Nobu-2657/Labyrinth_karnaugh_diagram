using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;
using static System.Net.Mime.MediaTypeNames;

public class GameSystem : MonoBehaviour
{
    //ダンジョンログ
    public static UnityEngine.UI.Text log_text;
    public static string dungeon_log = "会話ログ\n";

    void Start()
    {
        //log_textという名前のオブジェクトを探してテキストコーポネントを格納
        log_text = GameObject.Find("log_text").GetComponent<UnityEngine.UI.Text>();

        //このようにテキストを追加する。
        dungeon_log += "テキストが変更された\n";

        //テキストを反映させる
        update_dungeon_log();
    }

    //ダンジョンログを更新する
    public static void update_dungeon_log()
    {
        log_text.text = dungeon_log;
    }

}//end