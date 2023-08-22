using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noramlMusiba2 : MonoBehaviour
{
    [SerializeField] private GameObject I;

    public static int normal = 0;  //ノーマル変数を宣言

    public void Update()
    {
        if (GetGenerator.item01 >= 1)
        {
            I.SetActive(!false);
        }
        if (GetGenerator.item01 == 0)
        {
            I.SetActive(false);
        }
    }

    public void OnTouched()
    {
        normal += 1;   //ノーマル変数を増やす

        GetGenerator.item01 -= 1;     //ノーマルアイテムを減らす

        Debug.Log("normalを1使った");
    }
}
