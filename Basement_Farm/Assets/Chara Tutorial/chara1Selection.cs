using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SocialPlatforms.GameCenter;
using UnityEngine.UI;

public class chara1Selection : MonoBehaviour
{
    [SerializeField] private GameObject a = GameObject.Find("Canvas");  //GameObject�^�̕ϐ�a��錾�@�D���ȃQ�[���I�u�W�F�N�g���A�^�b�`

    //UI�{�^�����\���ɂ���
    void Start()
    {
        a.SetActive(false);
    }

    //�I�u�W�F�N�g�N���b�N�őI�񂾃L�����ȊO������
    public void OnTouched()
    {
        //�I�΂�Ȃ������L������錾
        GameObject obj = GameObject.Find("monster");
        GameObject obj2 = GameObject.Find("��");

        Debug.Log("���߂Ẵ����X�^�[���I");

        //�I�΂�Ȃ������L������j��
        Destroy(obj);
        Destroy(obj2);

        //UI�{�^����\������
        a.SetActive(true);

    }


}
