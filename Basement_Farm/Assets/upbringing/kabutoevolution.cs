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



    public static int chara1to2 = 0;    //分岐進化キャラ１の変数宣言
    public static int chara1to3 = 0;    //分岐進化キャラ２の変数宣言

    public int standard = 10;        //進化するアイテムの数

   

    // Update is called once per frame
    public void Update()
    {
       
        //normalItem.
        if (normalItem.normal >= standard)       //一定数normalアイテムを与えて進化する
        {
            Debug.Log("A進化した！");

            Charakabuto.SetActive(false);

            chara1Selection.Chara1 -= 1;

            Kurage.SetActive(!false);

            chara1to2 += 1;

            normalItem.normal = 0;

        }
        //lowItem.
        if (lowItem.low >= standard)          //一定数lowアイテムを与えて進化する
        {
            Debug.Log("B進化した!");

            Charakabuto.SetActive(false);

            chara1Selection.Chara1 -= 1;

            Yadokari.SetActive(!false);

            chara1to3 += 1;

            lowItem.low = 0;
        }
        
    }
}
