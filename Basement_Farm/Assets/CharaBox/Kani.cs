using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kani : MonoBehaviour
{
    [SerializeField] private GameObject a;


    public void Update()
    {

        if (YadokariEvolution.chara1to3to1 >= 1) //Chara1が1以上だった場合表示
        {

            a.SetActive(!false);

        }
        if (YadokariEvolution.chara1to3to1 == 0) //Chara1が1以下だった場合非表示
        {
            a.SetActive(false);
        }

    }
}
