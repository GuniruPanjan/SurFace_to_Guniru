using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hana3 : MonoBehaviour
{
    [SerializeField] private GameObject a;


    public void Update()
    {

        if (Hana2evolution.hana3 >= 1) //Chara1‚ª1ˆÈã‚¾‚Á‚½ê‡•\¦
        {

            a.SetActive(!false);

        }
        if (Hana2evolution.hana3 == 0) //Chara1‚ª1ˆÈ‰º‚¾‚Á‚½ê‡”ñ•\¦
        {
            a.SetActive(false);
        }

    }
}
