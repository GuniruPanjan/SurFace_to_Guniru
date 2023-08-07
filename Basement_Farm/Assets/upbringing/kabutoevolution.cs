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



    public static int chara1to2 = 0;    //分岐進化キャラ１の変数宣言
    public static int chara1to3 = 0;    //分岐進化キャラ２の変数宣言

    [SerializeField] public GameObject chara1;

    public int standard = 10;        //進化するアイテムの数
    public static int normal = 0;           //進化用のアイテム１
    public static int low = 0;              //進化用のアイテム２

    bool evolution = false;          //進化を一度だけ実行する
    bool evolution2 = false;         //分岐進化を一度だけ実行する

    [SerializeField] public GameObject chara2;
   

    // Update is called once per frame
    void Update()
    {


        for(int i = 0;i < standard;i++)
        {
            if (Input.GetKey(KeyCode.A)) //Aキーを入力するとnormalのアイテムが与えられる
            {
                if (normal < 10)      //10になるまでnormalのアイテムが与えられる
                {
                    normal++;

                }

            }
        }
        
        for(int i = 0;i < standard; i++)
        {
            if (Input.GetKey(KeyCode.B))  //Bキーを入力するとlowアイテムが与えられる
            {
                if (low < 10)         //10になるまでlowのアイテムが与えられる
                {
                    low++;
                }
            }
        }
       

        if(normalItem.normal == standard)       //一定数normalアイテムを与えて進化する
        {
            if(!evolution)
            {
                evolution = true;
                Debug.Log("A進化した！");

                Destroy(gameObject);

                //GameObject chara2 = GameObject.CreatePrimitive(PrimitiveType.Cube);

                Instantiate(chara2,new Vector3(0.0f,0.0f,0.0f), Quaternion.identity);

                chara1Selection.Chara1 -= 1;

                chara1to2 += 1;
            }
            
        }
        if(lowItem.low == standard)          //一定数lowアイテムを与えて進化する
        {
            if(!evolution2)
            {
                evolution2 = true;
                Debug.Log("B進化した!");

                Destroy(gameObject);

                //GameObject chara3 = GameObject.CreatePrimitive(PrimitiveType.Cube);

                chara1Selection.Chara1 -= 1;

                chara1to3 += 1;
                
            }
        }
        
    }
}
