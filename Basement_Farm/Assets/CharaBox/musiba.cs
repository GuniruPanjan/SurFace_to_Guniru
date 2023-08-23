using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musiba : MonoBehaviour
{
    
    [SerializeField] private GameObject a;

    public static int Chara6 = 0;

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
