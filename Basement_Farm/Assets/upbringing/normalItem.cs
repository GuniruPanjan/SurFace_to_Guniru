using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class normalItem : MonoBehaviour
{
    public static int normal = 0;  //ノーマル変数を宣言

    public void OnTouched()
    {
        normal += 1;   //ノーマル変数を増やす

        Debug.Log("normalを1使った");
    }
}
