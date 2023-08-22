using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kusa2evolution : MonoBehaviour
{
    [SerializeField] GameObject Kusa;

    [SerializeField] GameObject Kusa2;

    public static int kusa3;

    public int standard = 10;

    public void Update()
    {
        if (highKusa2.high >= standard)       //一定数normalアイテムを与えて進化する
        {
            Debug.Log("進化した！");

            Kusa.SetActive(false);

            KusaEvolution.kusa2 -= 1;

            Kusa2.SetActive(!false);

            kusa3 += 1;

            highKusa2.high = 0;

        }
    }
}
