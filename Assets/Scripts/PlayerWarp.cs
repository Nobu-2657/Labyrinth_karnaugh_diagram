using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWarp : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        // transform���擾
        Transform myTransform = this.transform;

        // ���[���h���W����ɁA���W���擾
        Vector3 worldPos = myTransform.position;

        // ���[���h���W����ɁA��]���擾
        Vector3 worldAngle = myTransform.eulerAngles;

        switch (other.gameObject.name)
        {
            case "Warp1a":
                worldPos.x = 5.5f;
                worldPos.y = 3.25f;
                worldPos.z = -7.5f;
                myTransform.position = worldPos;  // ���[���h���W�ł̍��W��ݒ�

                worldAngle.y = 90.0f;
                myTransform.eulerAngles = worldAngle; // ��]�p�x��ݒ�
                break;

            case "Warp1b":
                worldPos.x = 5.5f;
                worldPos.y = 3.25f;
                worldPos.z = 2.5f;
                myTransform.position = worldPos;  // ���[���h���W�ł̍��W��ݒ�

                worldAngle.y = 0.0f;
                myTransform.eulerAngles = worldAngle; // ��]�p�x��ݒ�
                break;

            case "Warp2a":
                worldPos.x = 4.5f;
                worldPos.y = 0.25f;
                worldPos.z = -2.5f;
                myTransform.position = worldPos;  // ���[���h���W�ł̍��W��ݒ�

                worldAngle.y = 90.0f;
                myTransform.eulerAngles = worldAngle; // ��]�p�x��ݒ�
                break;

            case "Warp2b":
                worldPos.x = -9.5f;
                worldPos.y = 3.25f;
                worldPos.z = 6.5f;
                myTransform.position = worldPos;  // ���[���h���W�ł̍��W��ݒ�

                worldAngle.y = 0.0f;
                myTransform.eulerAngles = worldAngle; // ��]�p�x��ݒ�
                break;

            case "Warp3a":
                worldPos.x = 0.5f;
                worldPos.y = 6.25f;
                worldPos.z = -9.5f;
                myTransform.position = worldPos;  // ���[���h���W�ł̍��W��ݒ�

                worldAngle.y = 270.0f;
                myTransform.eulerAngles = worldAngle; // ��]�p�x��ݒ�
                break;

            case "Warp3b":
                worldPos.x = 4.5f;
                worldPos.y = 0.25f;
                worldPos.z = -2.5f;
                myTransform.position = worldPos;  // ���[���h���W�ł̍��W��ݒ�

                worldAngle.y = 270.0f;
                myTransform.eulerAngles = worldAngle; // ��]�p�x��ݒ�
                break;

            case "Warp4a":
                worldPos.x = 9.5f;
                worldPos.y = 6.25f;
                worldPos.z = -1.5f;
                myTransform.position = worldPos;  // ���[���h���W�ł̍��W��ݒ�

                worldAngle.y = 90.0f;
                myTransform.eulerAngles = worldAngle; // ��]�p�x��ݒ�
                break;

            case "Warp4b":
                worldPos.x = -4.5f;
                worldPos.y = 6.25f;
                worldPos.z = -1.5f;
                myTransform.position = worldPos;  // ���[���h���W�ł̍��W��ݒ�

                worldAngle.y = 90.0f;
                myTransform.eulerAngles = worldAngle; // ��]�p�x��ݒ�
                break;

            case "Warp5a":
                worldPos.x = -9.5f;
                worldPos.y = 6.25f;
                worldPos.z = 7.5f;
                myTransform.position = worldPos;  // ���[���h���W�ł̍��W��ݒ�

                worldAngle.y = 0.0f;
                myTransform.eulerAngles = worldAngle; // ��]�p�x��ݒ�
                break;

            case "Warp5b":
                worldPos.x = -2.5f;
                worldPos.y = 6.25f;
                worldPos.z = -5.5f;
                myTransform.position = worldPos;  // ���[���h���W�ł̍��W��ݒ�

                worldAngle.y = 180.0f;
                myTransform.eulerAngles = worldAngle; // ��]�p�x��ݒ�
                break;

            case "Warp6a":
                worldPos.x = -0.5f;
                worldPos.y = 6.25f;
                worldPos.z = -3.5f;
                myTransform.position = worldPos;  // ���[���h���W�ł̍��W��ݒ�

                worldAngle.y = 0.0f;
                myTransform.eulerAngles = worldAngle; // ��]�p�x��ݒ�
                break;

            case "Warp6b":
                worldPos.x = 1.5f;
                worldPos.y = 6.25f;
                worldPos.z = -6.5f;
                myTransform.position = worldPos;  // ���[���h���W�ł̍��W��ݒ�

                worldAngle.y = 0.0f;
                myTransform.eulerAngles = worldAngle; // ��]�p�x��ݒ�
                break;

            case "Warp7a":
                worldPos.x = -9.5f;
                worldPos.y = 3.25f;
                worldPos.z = 2.5f;
                myTransform.position = worldPos;  // ���[���h���W�ł̍��W��ݒ�

                worldAngle.y = 180.0f;
                myTransform.eulerAngles = worldAngle; // ��]�p�x��ݒ�
                break;

            case "Warp7b":
                worldPos.x = -4.5f;
                worldPos.y = 0.25f;
                worldPos.z = -8.5f;
                myTransform.position = worldPos;  // ���[���h���W�ł̍��W��ݒ�

                worldAngle.y = 180.0f;
                myTransform.eulerAngles = worldAngle; // ��]�p�x��ݒ�
                break;
        }
    }
}
