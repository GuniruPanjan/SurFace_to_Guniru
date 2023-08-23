using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara004Count : MonoBehaviour
{
    public void Onclick()
    {
        Chara004.CharCount004 += 1;
        Debug.Log(Chara004.CharCount004);
    }
}
