using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SocialPlatforms.GameCenter;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BoxChara2 : MonoBehaviour
{
    [SerializeField] private GameObject b = GameObject.Find("�Q�[���L����2");

    void Update()
    {

        if (chara2Selection.Chara2 >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            b.SetActive(!false);

        }
        if (chara2Selection.Chara2 == 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            b.SetActive(false);
        }


    }
}
