using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chara2Selection : MonoBehaviour
{
    [SerializeField] private GameObject a = GameObject.Find("Canvas");  //GameObject�^�̕ϐ�a��錾�@�D���ȃQ�[���I�u�W�F�N�g���A�^�b�`

    public int Chara2 = 0;   //�L�����ϐ���錾����

    //UI�{�^�����\���ɂ���
    void Start()
    {
        a.SetActive(false);
    }
    //�I�u�W�F�N�g�N���b�N�őI�񂾃L�����ȊO������
    public void OnTouched()
    {
        //�I�΂�Ȃ������L������錾
        GameObject obj1 = GameObject.Find("�L�����P");
        GameObject obj2 = GameObject.Find("��");

        Debug.Log("���߂Ẵ����X�^�[���I");

        //�I�΂�Ȃ������L������j��
        Destroy(obj1);
        Destroy(obj2);

        //UI�{�^����\������
        a.SetActive(true);

        Chara2 += 1;
    }
}
