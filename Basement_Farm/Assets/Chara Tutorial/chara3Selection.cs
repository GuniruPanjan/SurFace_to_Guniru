using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chara3Selection : MonoBehaviour
{

    //UI�{�^�����\���ɂ���
    void Start()
    {
       
    }
    //�I�u�W�F�N�g�N���b�N�őI�񂾃L�����ȊO������
    public void OnTouched()
    {
        //�I�΂�Ȃ������L������錾
        GameObject obj = GameObject.Find("monster");
        GameObject obj1 = GameObject.Find("�L�����P");

        Debug.Log("���߂Ẵ����X�^�[���I");

        //�I�΂�Ȃ������L������j��
        Destroy(obj);
        Destroy(obj1);

       

    }
}
