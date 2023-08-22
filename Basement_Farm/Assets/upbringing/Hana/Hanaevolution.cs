using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hanaevolution : MonoBehaviour
{
    [SerializeField] GameObject Hana;

    [SerializeField] GameObject Kaeru;

    [SerializeField] GameObject Hana2;

    public static int ka = 0;
    public static int hana2 = 0;

    public int standard = 10;

    public void Update()
    {
        if (lowHana.low >= standard)       //一定数normalアイテムを与えて進化する
        {
            Debug.Log("A進化した！");

            Hana.SetActive(false);

            chara3Selection.Chara3 -= 1;

            Kaeru.SetActive(!false);

            ka += 1;

            lowHana.low = 0;

        }
        //lowItem.
        if (normalHana.normal >= standard)          //一定数lowアイテムを与えて進化する
        {
            Debug.Log("B進化した!");

            Hana.SetActive(false);

            chara3Selection.Chara3 -= 1;

            Hana2.SetActive(!false);

            hana2 += 1;

            normalHana.normal = 0;
        }
    }
}
