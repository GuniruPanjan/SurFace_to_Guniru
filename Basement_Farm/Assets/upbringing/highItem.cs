using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class highItem : MonoBehaviour
{
    public static int high = 1;   //high変数を宣言

    public void OnTouched()
    {
        high += 1;   //high変数を増やす

        Debug.Log("highを1使った");
    }
}
