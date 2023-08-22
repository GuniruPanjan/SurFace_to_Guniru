using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara006Count : MonoBehaviour
{
    public void Onclick()
    {
        Chara006.CharCount006 += 1;
        Debug.Log(Chara006.CharCount006);
    }
}
