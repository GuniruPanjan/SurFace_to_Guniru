using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class highItem : MonoBehaviour
{
    public static int high = 1;   //high�ϐ���錾

    public void OnTouched()
    {
        high += 1;   //high�ϐ��𑝂₷

        Debug.Log("high��1�g����");
    }
}
