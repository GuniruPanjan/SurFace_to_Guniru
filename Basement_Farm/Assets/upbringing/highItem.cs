using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class highItem : MonoBehaviour
{
    public static int high = 1;   //high•Ï”‚ğéŒ¾

    public void OnTouched()
    {
        high += 1;   //high•Ï”‚ğ‘‚â‚·

        Debug.Log("high‚ğ1g‚Á‚½");
    }
}
