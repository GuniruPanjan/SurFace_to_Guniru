using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SocialPlatforms.GameCenter;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class kabutoevolution : MonoBehaviour
{
    [SerializeField] GameObject Charakabuto;

    [SerializeField] GameObject Kurage;

    [SerializeField] GameObject Yadokari;



    public static int chara1to2 = 0;    //����i���L�����P�̕ϐ��錾
    public static int chara1to3 = 0;    //����i���L�����Q�̕ϐ��錾

    public int standard = 10;        //�i������A�C�e���̐�
    public static int normal = 0;           //�i���p�̃A�C�e���P
    public static int low = 0;              //�i���p�̃A�C�e���Q

   

    // Update is called once per frame
    void Update()
    {

        for(int i = 0;i < standard;i++)
        {
            if (Input.GetKey(KeyCode.A)) //A�L�[����͂����normal�̃A�C�e�����^������
            {
                Debug.Log("����ɂ���");
                
                if (normal < 10)      //10�ɂȂ�܂�normal�̃A�C�e�����^������
                {
                    normal++;

                }

            }
        }
        
        for(int i = 0;i < standard; i++)
        {
            if (Input.GetKey(KeyCode.B))  //B�L�[����͂����low�A�C�e�����^������
            {
               
                if (low < 10)         //10�ɂȂ�܂�low�̃A�C�e�����^������
                {
                    low++;
                }
            }
        }

        //normalItem.
        if (normalItem.normal >= standard)       //��萔normal�A�C�e����^���Đi������
        {
            Debug.Log("A�i�������I");

            Charakabuto.SetActive(false);

            //GameObject chara2 = GameObject.CreatePrimitive(PrimitiveType.Cube);

            //Instantiate(chara2,new Vector3(0.0f,0.0f,0.0f), Quaternion.identity);

            chara1Selection.Chara1 -= 1;

            Kurage.SetActive(!false);

            chara1to2 += 1;

        }
        //lowItem.
        if (lowItem.low >= standard)          //��萔low�A�C�e����^���Đi������
        {
            Debug.Log("B�i������!");

            Charakabuto.SetActive(false);

            //GameObject chara3 = GameObject.CreatePrimitive(PrimitiveType.Cube);

            //Instantiate(chara1, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);

            chara1Selection.Chara1 -= 1;

            Yadokari.SetActive(!false);

            chara1to3 += 1;
        }
        
    }
}
