using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kaeru : MonoBehaviour
{
    [SerializeField] private GameObject a;


    public void Update()
    {

        if (Hanaevolution.ka >= 1) //Chara1が1以上だった場合表示
        {

            a.SetActive(!false);

        }
        if (Hanaevolution.ka == 0) //Chara1が1以下だった場合非表示
        {
            a.SetActive(false);
        }

    }
}
