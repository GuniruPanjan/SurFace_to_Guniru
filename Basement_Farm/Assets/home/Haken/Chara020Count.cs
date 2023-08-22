using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara020Count : MonoBehaviour
{
    public void Onclick()
    {
        Chara020.CharCount020 += 1;
        Debug.Log(Chara020.CharCount020);
    }
}
