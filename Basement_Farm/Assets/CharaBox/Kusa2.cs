using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kusa2 : MonoBehaviour
{
    [SerializeField] private GameObject a;


    public void Update()
    {

        if (KusaEvolution.kusa2 >= 1) //Chara1‚ª1ˆÈã‚¾‚Á‚½ê‡•\¦
        {

            a.SetActive(!false);

        }
        if (KusaEvolution.kusa2 == 0) //Chara1‚ª1ˆÈ‰º‚¾‚Á‚½ê‡”ñ•\¦
        {
            a.SetActive(false);
        }


    }
}
