using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeEvolution : MonoBehaviour
{
    [SerializeField] GameObject Eye;

    [SerializeField] GameObject Eye2;

    public static int eye2 = 0;

    public int standard = 10;

    public void Update()
    {
        if(highEye.high >= standard)
        {
            Debug.Log("êiâªÇµÇΩ");

            Eye.SetActive(false);

            chara2Selection.Chara2 -= 1;

            Eye2.SetActive(!false);

            highEye.high = 0;

            eye2 += 1;


        }
    }
}
