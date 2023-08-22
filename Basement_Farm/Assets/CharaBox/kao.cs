using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kao : MonoBehaviour
{
    [SerializeField] private GameObject a;


    public void Update()
    {

        if (GetGenerator.Chara5 >= 1) //Chara1‚ª1ˆÈã‚¾‚Á‚½ê‡•\¦
        {

            a.SetActive(!false);

        }
        if (GetGenerator.Chara5 == 0) //Chara1‚ª1ˆÈ‰º‚¾‚Á‚½ê‡”ñ•\¦
        {
            a.SetActive(false);
        }


    }
}
