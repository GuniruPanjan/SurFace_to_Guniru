using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sito : MonoBehaviour
{
    [SerializeField] private GameObject a;


    public void Update()
    {

        if (TaijiEvolution.sito >= 1) //Chara1‚ª1ˆÈã‚¾‚Á‚½ê‡•\¦
        {

            a.SetActive(!false);

        }
        if (TaijiEvolution.sito == 0) //Chara1‚ª1ˆÈ‰º‚¾‚Á‚½ê‡”ñ•\¦
        {
            a.SetActive(false);
        }

    }
}
