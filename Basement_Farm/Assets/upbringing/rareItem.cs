using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rareItem : MonoBehaviour
{
    public static int rare = 1;    //rare変数を宣言

    public void OnTouched()
    {
        rare += 1;  //rare変数を増やす

        Debug.Log("rareを1使った");
    }
}
