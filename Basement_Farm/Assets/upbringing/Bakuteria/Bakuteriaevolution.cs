using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bakuteriaevolution : MonoBehaviour
{
    [SerializeField] GameObject Bakuteria;

    [SerializeField] GameObject Kisei;

    [SerializeField] GameObject kurisutaru;



    public static int kisei = 0;    //分岐進化キャラ１の変数宣言
    public static int bagu = 0;    //分岐進化キャラ２の変数宣言

    public int standard = 10;        //進化するアイテムの数



    // Update is called once per frame
    public void Update()
    {

        //normalItem.
        if (normalBakuteria.normal >= standard)       //一定数normalアイテムを与えて進化する
        {
            Debug.Log("A進化した！");

            Bakuteria.SetActive(false);

            GetGenerator.Chara9 -= 1;

            Kisei.SetActive(!false);

            kisei += 1;

            normalBakuteria.normal = 0;

        }
        //lowItem.
        if (rareBakuteria.rare >= standard)          //一定数lowアイテムを与えて進化する
        {
            Debug.Log("B進化した!");

            Bakuteria.SetActive(false);

            GetGenerator.Chara9 -= 1;

            kurisutaru.SetActive(!false);

            bagu += 1;

            rareBakuteria.rare = 0;
        }

    }
}
