using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara007Count : MonoBehaviour
{
    public void Onclick()
    {
        Chara007.CharCount007 += 1;
        Debug.Log(Chara007.CharCount007);
    }
}
