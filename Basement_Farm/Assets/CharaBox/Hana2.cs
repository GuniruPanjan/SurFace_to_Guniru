using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hana2 : MonoBehaviour
{
    [SerializeField] private GameObject a;


    public void Update()
    {

        if (Hanaevolution.hana2 >= 1) //Chara1が1以上だった場合表示
        {

            a.SetActive(!false);

        }
        if (Hanaevolution.hana2 == 0) //Chara1が1以下だった場合非表示
        {
            a.SetActive(false);
        }

    }
}
