using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eye2Evolution : MonoBehaviour
{
    [SerializeField] GameObject Eye2;

    [SerializeField] GameObject AI;

    public static int ai = 0;

    public int standard = 10;

    public void Update()
    {
        if(highEye2.high >= standard)
        {
            Debug.Log("êiâªÇµÇΩ");

            Eye2.SetActive(false);

            EyeEvolution.eye2 -= 1;

            AI.SetActive(!false);

            highEye2.high = 0;

            ai += 1;
        }
    }
}
