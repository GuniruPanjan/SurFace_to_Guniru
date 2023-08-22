using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bakuteria : MonoBehaviour
{
    [SerializeField] private GameObject a;


    public void Update()
    {

        if (GetGenerator.Chara9 >= 1) //Chara1‚ª1ˆÈã‚¾‚Á‚½ê‡•\¦
        {

            a.SetActive(!false);

        }
        if (GetGenerator.Chara9 == 0) //Chara1‚ª1ˆÈ‰º‚¾‚Á‚½ê‡”ñ•\¦
        {
            a.SetActive(false);
        }


    }
}
