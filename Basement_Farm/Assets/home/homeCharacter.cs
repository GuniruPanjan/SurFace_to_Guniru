using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homeCharacter : MonoBehaviour
{
    [SerializeField] private GameObject a1 = GameObject.Find("�L����1");

    void Update()
    {
        if (kabuto.Home1 >= 1)  //�P�ȏゾ�����ꍇ�L�������\�������
        {
            a1.SetActive(!false);
        }
        if (kabuto.Home1 == 0)  //0�ȉ��������ꍇ�L��������\��
        {
            a1.SetActive(false);
        }
    }
}
