using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kusa3 : MonoBehaviour
{
    [SerializeField] private GameObject a;


    public void Update()
    {

        if (Kusa2evolution.kusa3 >= 1) //Chara1が1以上だった場合表示
        {

            a.SetActive(!false);

        }
        if (Kusa2evolution.kusa3 == 0) //Chara1が1以下だった場合非表示
        {
            a.SetActive(false);
        }


    }
}
