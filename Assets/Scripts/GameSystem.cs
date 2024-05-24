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

    //�_���W�������O
    public UnityEngine.UI.Text log_text;
    public string dungeon_log = "��b���O\n";

    void Start()
    {
        //log_text�Ƃ������O�̃I�u�W�F�N�g��T���ăe�L�X�g�R�[�|�l���g���i�[
        log_text = GameObject.Find("log_text").GetComponent<UnityEngine.UI.Text>();

        //���̂悤�Ƀe�L�X�g��ǉ�����B
        //dungeon_log += "�e�L�X�g���ύX���ꂽ\n";

        //�e�L�X�g�𔽉f������
        update_dungeon_log();
    }

    //�_���W�������O���X�V����
    public void update_dungeon_log()
    {
        log_text.text = dungeon_log;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EventLogObject"))
        {
            ItemManager itemManager = FindObjectOfType<ItemManager>(); // �V�[��������ItemManager��T��
            switch (other.gameObject.name)
            {
                case "EventLogObject1":
                    if(i==0)
                    {
                        dungeon_log += "�ǂ̌������ɋ�Ԃ�����悤��...\n";
                        update_dungeon_log();
                        i++;
                    }
                    break;

                case "EventLogObject2":
                    if (j == 0)
                    {
                        if (!Vigenere.gameObject.activeSelf)
                        {
                            dungeon_log += "�Í��\���K�v������...\n";
                            update_dungeon_log();
                            j++;
                        }
                    }
                    break;

                case "EventLogObject3":
                    if (k == 0)
                    {
                        dungeon_log += "�Í��\����ɓ��ꂽ�I\n";
                        update_dungeon_log();
                        k++;
                    }
                    break;

                case "EventLogObject4":
                    if (l == 0)
                    {
                        dungeon_log += "��֐i�߂�����\n";
                        update_dungeon_log();
                        l++;
                    }
                    break;
            }
            
        }
    }

}//end