using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bakuteria : MonoBehaviour
{
    [SerializeField] private GameObject a;


    public void Update()
    {

        if (GetGenerator.Chara9 >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            a.SetActive(!false);

        }
        if (GetGenerator.Chara9 <= 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            Debug.Log("�o�N�e���A");
            Destroy(this.gameObject);
        }


    }
}
