
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SocialPlatforms.GameCenter;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class kabuto : MonoBehaviour
{
  

    [SerializeField] private GameObject a = GameObject.Find("�Q�[��1");

   
    public void Update()
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
