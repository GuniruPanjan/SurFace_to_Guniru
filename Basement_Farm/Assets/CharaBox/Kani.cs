using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kani : MonoBehaviour
{
    [SerializeField] private GameObject a;


    public void Update()
    {

        if (YadokariEvolution.chara1to3to1 >= 1) //Chara1‚ª1ˆÈã‚¾‚Á‚½ê‡•\¦
        {

            a.SetActive(!false);

        }
        if (YadokariEvolution.chara1to3to1 == 0) //Chara1‚ª1ˆÈ‰º‚¾‚Á‚½ê‡”ñ•\¦
        {
            a.SetActive(false);
        }

    }
}
