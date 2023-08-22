using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaijiEvolution : MonoBehaviour
{
    [SerializeField] GameObject Taiji;

    [SerializeField] GameObject Sito;

    [SerializeField] GameObject Tuki;



    public static int sito = 0;    //分岐進化キャラ１の変数宣言
    public static int tuki = 0;    //分岐進化キャラ２の変数宣言

    public int standard = 10;        //進化するアイテムの数



    // Update is called once per frame
    public void Update()
    {

        //normalItem.
        if (normalTaiji.normal >= standard)       //一定数normalアイテムを与えて進化する
        {
            Debug.Log("A進化した！");

            Taiji.SetActive(false);

            taiji.Chara8 -= 1;

            Sito.SetActive(!false);

            sito += 1;

            normalTaiji.normal = 0;

        }
        //lowItem.
        if (highTaiji.high >= standard)          //一定数lowアイテムを与えて進化する
        {
            Debug.Log("B進化した!");

            Taiji.SetActive(false);

            taiji.Chara8 -= 1;

            Tuki.SetActive(!false);

            tuki += 1;

            highTaiji.high = 0;
        }

    }
}
