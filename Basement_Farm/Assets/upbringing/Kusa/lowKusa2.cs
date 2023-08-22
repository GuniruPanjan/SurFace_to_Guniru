using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lowKusa2 : MonoBehaviour
{
    [SerializeField] private GameObject I;

    public static int low = 1;   //low変数を宣言

    public void Update()
    {
        if (GetGenerator.item02 >= 1)
        {
            I.SetActive(!false);
        }
        if (GetGenerator.item02 == 0)
        {
            I.SetActive(false);
        }
    }

    public void OnTouched()
    {
        low += 1;   //low変数を増やす

        GetGenerator.item02 -= 1;     //lowアイテムを減らす

        Debug.Log("lowを1使った");
    }
}
