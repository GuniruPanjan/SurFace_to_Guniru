using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kusa2 : MonoBehaviour
{
    [SerializeField] private GameObject a;


    public void Update()
    {

        if (KusaEvolution.kusa2 >= 1) //Chara1が1以上だった場合表示
        {

            a.SetActive(!false);

        }
        if (KusaEvolution.kusa2 == 0) //Chara1が1以下だった場合非表示
        {
            a.SetActive(false);
        }


    }
}
