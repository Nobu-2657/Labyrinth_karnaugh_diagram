using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;
using static System.Net.Mime.MediaTypeNames;

public class GameSystem : MonoBehaviour
{
    //�_���W�������O
    public static UnityEngine.UI.Text log_text;
    public static string dungeon_log = "��b���O\n";

    void Start()
    {
        //log_text�Ƃ������O�̃I�u�W�F�N�g��T���ăe�L�X�g�R�[�|�l���g���i�[
        log_text = GameObject.Find("log_text").GetComponent<UnityEngine.UI.Text>();

        //���̂悤�Ƀe�L�X�g��ǉ�����B
        dungeon_log += "�e�L�X�g���ύX���ꂽ\n";

        //�e�L�X�g�𔽉f������
        update_dungeon_log();
    }

    //�_���W�������O���X�V����
    public static void update_dungeon_log()
    {
        log_text.text = dungeon_log;
    }

}//end