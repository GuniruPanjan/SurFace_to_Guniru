using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class charaevolution : MonoBehaviour
{
    [SerializeField] private GameObject a1 = GameObject.Find("�L����1");



    public static int chara1to2 = 0;    //����i���L�����P�̕ϐ��錾
    public static int chara1to3 = 0;    //����i���L�����Q�̕ϐ��錾

    [SerializeField] private GameObject chara1;

    public int standard = 10;        //�i������A�C�e���̐�
    public static int normal = 0;           //�i���p�̃A�C�e���P
    public static int low = 0;              //�i���p�̃A�C�e���Q

    bool evolution = false;          //�i������x�������s����
    bool evolution2 = false;         //����i������x�������s����

    public GameObject chara2;
   

    // Update is called once per frame
    public void Update()
    {
        if(BoxChara1.UpbringingChara1 >= 1)  //�P�ȏゾ�����ꍇ�L�������\�������
        {
            a1.SetActive(!false);
        }
        if(BoxChara1.UpbringingChara1 == 0)  //0�ȉ��������ꍇ�L��������\��
        {
            a1.SetActive(false);
        }


        for(int i = 0;i < standard;i++)
        {
            if (Input.GetKey(KeyCode.A)) //A�L�[����͂����normal�̃A�C�e�����^������
            {
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
       

        if(normal == standard)       //��萔normal�A�C�e����^���Đi������
        {
            if(!evolution)
            {
                evolution = true;
                Debug.Log("A�i�������I");

                Destroy(gameObject);

                //GameObject chara2 = GameObject.CreatePrimitive(PrimitiveType.Cube);

                Instantiate(chara2,new Vector3(0.0f,0.0f,0.0f), Quaternion.identity);

                chara1Selection.Chara1 -= 1;

                chara1to2 += 1;
            }
            
        }
        if(low == standard)          //��萔low�A�C�e����^���Đi������
        {
            if(!evolution2)
            {
                evolution2 = true;
                Debug.Log("B�i������!");

                Destroy(gameObject);

                //GameObject chara3 = GameObject.CreatePrimitive(PrimitiveType.Cube);

                chara1Selection.Chara1 -= 1;

                chara1to3 += 1;
                
            }
        }
        
    }
}
