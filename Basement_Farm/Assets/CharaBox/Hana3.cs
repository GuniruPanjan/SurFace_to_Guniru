using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hana3 : MonoBehaviour
{
    [SerializeField] private GameObject a;


    public void Update()
    {

        if (Hana2evolution.hana3 >= 1) //Chara1が1以上だった場合表示
        {

            a.SetActive(!false);

        }
        if (Hana2evolution.hana3 == 0) //Chara1が1以下だった場合非表示
        {
            a.SetActive(false);
        }

    }
}
