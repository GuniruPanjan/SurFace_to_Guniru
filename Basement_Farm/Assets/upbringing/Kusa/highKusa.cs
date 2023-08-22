using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class highKusa : MonoBehaviour
{
    [SerializeField] private GameObject I;

    public static int high = 1;   //high変数を宣言

    public void Update()
    {
        if (GetGenerator.item03 >= 1)
        {
            I.SetActive(!false);
        }
        if (GetGenerator.item03 == 0)
        {
            I.SetActive(false);
        }
    }

    public void OnTouched()
    {
        high += 1;   //high変数を増やす

        GetGenerator.item03 -= 1;   //highアイテムを減らす

        Debug.Log("highを1使った");
    }
}
