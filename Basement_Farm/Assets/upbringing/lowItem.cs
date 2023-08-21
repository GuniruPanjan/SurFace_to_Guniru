using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lowItem : MonoBehaviour
{
    public static int low = 1;   //low•Ï”‚ğéŒ¾

    public void OnTouched()
    {
        low += 1;   //low•Ï”‚ğ‘‚â‚·

        Debug.Log("low‚ğ1g‚Á‚½");
    }
}
