using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musiba3 : MonoBehaviour
{
    [SerializeField] private GameObject a;


    public void Update()
    {

        if (Musiba2Evolution.musi >= 1) //Chara1が1以上だった場合表示
        {

            a.SetActive(!false);

        }
        if (Musiba2Evolution.musi == 0) //Chara1が1以下だった場合非表示
        {
            a.SetActive(false);
        }


    }
}
