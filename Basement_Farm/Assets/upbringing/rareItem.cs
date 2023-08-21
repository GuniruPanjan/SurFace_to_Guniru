using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rareItem : MonoBehaviour
{
    public static int rare = 1;    //rare•Ï”‚ğéŒ¾

    public void OnTouched()
    {
        rare += 1;  //rare•Ï”‚ğ‘‚â‚·

        Debug.Log("rare‚ğ1g‚Á‚½");
    }
}
