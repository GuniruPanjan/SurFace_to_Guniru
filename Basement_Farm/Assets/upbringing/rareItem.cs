using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rareItem : MonoBehaviour
{
    public static int rare = 1;    //rare�ϐ���錾

    public void OnTouched()
    {
        rare += 1;  //rare�ϐ��𑝂₷

        Debug.Log("rare��1�g����");
    }
}
