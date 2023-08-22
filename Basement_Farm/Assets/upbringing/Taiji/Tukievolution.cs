using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tukievolution : MonoBehaviour
{
    [SerializeField] GameObject Tuki;

    [SerializeField] GameObject Ajin;

    public static int ajin = 0;

    public int standard = 10;

    public void Update()
    {
        if(rareTuki.rare >= standard)
        {
            Debug.Log("êiâªÇµÇΩÅI");

            Tuki.SetActive(false);

            TaijiEvolution.tuki -= 1;

            Ajin.SetActive(!false);

            ajin += 1;

            rareTuki.rare = 0;
        }

    }
}
