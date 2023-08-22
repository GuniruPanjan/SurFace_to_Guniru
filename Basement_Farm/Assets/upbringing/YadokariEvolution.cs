using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YadokariEvolution : MonoBehaviour
{
    [SerializeField] GameObject Yadokari;

    [SerializeField] GameObject Kani;

    public static int chara1to3to1 = 0;    //進化キャラ1の変数宣言

    public int standard = 10;        //進化するアイテムの数

    public void Update()
    {
        if(highYadokari.high >= standard)
        {
            Debug.Log("進化した！");

            Yadokari.SetActive(false);

            kabutoevolution.chara1to3 -= 1;

            Kani.SetActive(!false);

            chara1to3to1 += 1;

            highYadokari.high = 0;
        }
    }
}
