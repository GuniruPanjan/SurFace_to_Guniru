using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bagu : MonoBehaviour
{
    [SerializeField] private GameObject a;


    public void Update()
    {

        if (Bakuteriaevolution.bagu >= 1) //Chara1が1以上だった場合表示
        {

            a.SetActive(!false);

        }
        if (Bakuteriaevolution.bagu == 0) //Chara1が1以下だった場合非表示
        {
            a.SetActive(false);
        }


    }
}
