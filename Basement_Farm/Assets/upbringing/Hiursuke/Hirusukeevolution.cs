using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hirusukeevolution : MonoBehaviour
{
    [SerializeField] GameObject Hirusuke;

    [SerializeField] GameObject Hiruku;

    [SerializeField] GameObject Hirunadesu;

    public static int hiruku = 0;
    public static int hirunann = 0;

    public int standard = 10;

    public void Update()
    {
        if (normalHirusuke.normal >= standard)       //一定数normalアイテムを与えて進化する
        {
            Debug.Log("進化した！");

            Hirusuke.SetActive(false);

            hirusuke.Chara4 -= 1;

            Hiruku.SetActive(!false);

            hiruku += 1;

            normalHirusuke.normal = 0;

        }
        //lowItem.
        if (rareHirusuke.rare >= standard)          //一定数lowアイテムを与えて進化する
        {
            Debug.Log("進化した!");

            Hirusuke.SetActive(false);

            hirusuke.Chara4 -= 1;

            Hirunadesu.SetActive(!false);

            hirunann += 1;

            rareHirusuke.rare = 0;
        }
    }
}
