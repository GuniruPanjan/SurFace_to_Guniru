using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara005Count : MonoBehaviour
{
    public void Onclick()
    {
        Chara005.CharCount005 += 1;
        Debug.Log(Chara005.CharCount005);
    }
}
