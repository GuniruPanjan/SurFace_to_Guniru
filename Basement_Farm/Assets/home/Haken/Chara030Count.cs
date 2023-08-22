using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara030Count : MonoBehaviour
{
    public void Onclick()
    {
        Chara030.CharCount030 += 1;
        Debug.Log(Chara030.CharCount030);
    }
}
