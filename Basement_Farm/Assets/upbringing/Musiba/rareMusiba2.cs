using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rareMusiba2 : MonoBehaviour
{
    [SerializeField] private GameObject I;

    public static int rare = 1;    //rare変数を宣言

    public void Update()
    {
        if (GetGenerator.item04 >= 1)
        {
            I.SetActive(!false);
        }
        if (GetGenerator.item04 == 0)
        {
            I.SetActive(false);
        }
    }

    public void OnTouched()
    {
        rare += 1;  //rare変数を増やす

        GetGenerator.item04 -= 1;    //rareアイテム減らす

        Debug.Log("rareを1使った");
    }
}
