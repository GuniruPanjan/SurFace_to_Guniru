using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class normalItem : MonoBehaviour
{
    public static int normal = 0;  //�m�[�}���ϐ���錾

    public void OnTouched()
    {
        normal += 1;   //�m�[�}���ϐ��𑝂₷

        Debug.Log("normal��1�g����");
    }
}
