using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hirusuke : MonoBehaviour
{
    [SerializeField] private GameObject a;


    public void Update()
    {

        if (GetGenerator.Chara4 >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            a.SetActive(!false);

        }
        if (GetGenerator.Chara4 == 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            a.SetActive(false);
        }


    }
}
