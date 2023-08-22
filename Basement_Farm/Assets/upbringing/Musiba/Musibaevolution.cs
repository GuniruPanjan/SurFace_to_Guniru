using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musibaevolution : MonoBehaviour
{
    [SerializeField] GameObject Musiba;

    [SerializeField] GameObject Musiba2;

    public static int musiba2;

    public int standard = 10;

    public void Update()
    {
        if (highMusiba.high >= standard)       //一定数normalアイテムを与えて進化する
        {
            Debug.Log("進化した！");

            Musiba.SetActive(false);

            musiba.Chara6 -= 1;

            Musiba2.SetActive(!false);

            musiba2 += 1;

            highMusiba.high = 0;

        }
    }
}
