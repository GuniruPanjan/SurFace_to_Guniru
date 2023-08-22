using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musiba : MonoBehaviour
{
    public static int Chara6 = 0;

    [SerializeField] private GameObject a;


    public void Update()
    {

        if (Chara6 >= 1) //Chara1‚ª1ˆÈã‚¾‚Á‚½ê‡•\¦
        {

            a.SetActive(!false);

        }
        if (Chara6 == 0) //Chara1‚ª1ˆÈ‰º‚¾‚Á‚½ê‡”ñ•\¦
        {
            a.SetActive(false);
        }


    }
}
