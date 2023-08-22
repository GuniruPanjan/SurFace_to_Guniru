using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara010Count : MonoBehaviour
{
    public void Onclick()
    {
        Chara010.CharCount010 += 1;
        Debug.Log(Chara010.CharCount010);
    }
}
