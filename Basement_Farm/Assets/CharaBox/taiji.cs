using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class taiji : MonoBehaviour
{
    public static int Chara8 = 0;

    [SerializeField] private GameObject a;


    public void Update()
    {

        if (Chara8 >= 1) //Chara1‚ª1ˆÈã‚¾‚Á‚½ê‡•\¦
        {

            a.SetActive(!false);

        }
        if (Chara8 == 0) //Chara1‚ª1ˆÈ‰º‚¾‚Á‚½ê‡”ñ•\¦
        {
            a.SetActive(false);
        }


    }
}
