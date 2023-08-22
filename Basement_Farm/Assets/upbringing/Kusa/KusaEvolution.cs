using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KusaEvolution : MonoBehaviour
{
    [SerializeField] GameObject Kusa;

    [SerializeField] GameObject Kusa2;

    public static int kusa2;

    public int standard = 10;

    public void Update()
    {
        if (normalKusa.normal >= standard)       //一定数normalアイテムを与えて進化する
        {
            Debug.Log("進化した！");

            Kusa.SetActive(false);

            kusa.Chara7 -= 1;

            Kusa2.SetActive(!false);

            kusa2 += 1;

            normalKusa.normal = 0;

        }
    }
}
