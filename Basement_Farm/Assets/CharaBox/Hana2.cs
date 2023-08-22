using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hana2 : MonoBehaviour
{
    [SerializeField] private GameObject a;


    public void Update()
    {

        if (Hanaevolution.hana2 >= 1) //Chara1‚ª1ˆÈã‚¾‚Á‚½ê‡•\¦
        {

            a.SetActive(!false);

        }
        if (Hanaevolution.hana2 == 0) //Chara1‚ª1ˆÈ‰º‚¾‚Á‚½ê‡”ñ•\¦
        {
            a.SetActive(false);
        }

    }
}
