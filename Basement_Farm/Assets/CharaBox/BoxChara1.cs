using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class BoxChara1 : MonoBehaviour
{

    [SerializeField] private GameObject a = GameObject.Find("�Q�[��1");

    void Update()
    {
       
        if (chara1Selection.Chara1 >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            a.SetActive(!false);

        }
        if (chara1Selection.Chara1 == 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            a.SetActive(false);
        }
        

    }
}
