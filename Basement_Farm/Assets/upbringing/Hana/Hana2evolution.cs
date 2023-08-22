using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Hana2evolution : MonoBehaviour
{
    [SerializeField] GameObject Hana2;

    [SerializeField] GameObject Hana3;

    public static int hana3 = 0;

    public int standard = 10;

    public void Update()
    {
        if (normalHana2.normal >= standard)          //一定数lowアイテムを与えて進化する
        {
            Debug.Log("進化した!");

            Hana2.SetActive(false);

            Hanaevolution.hana2 -= 1;

            Hana3.SetActive(!false);

            hana3 += 1;

            normalHana2.normal = 0;
        }
    }
}
