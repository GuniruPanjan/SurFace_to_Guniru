using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lowItem : MonoBehaviour
{
    public static int low = 1;   //low変数を宣言

    public void OnTouched()
    {
        low += 1;   //low変数を増やす

        Debug.Log("lowを1使った");
    }
}
