using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lowItem : MonoBehaviour
{
    public static int low = 1;   //low�ϐ���錾

    public void OnTouched()
    {
        low += 1;   //low�ϐ��𑝂₷

        Debug.Log("low��1�g����");
    }
}
