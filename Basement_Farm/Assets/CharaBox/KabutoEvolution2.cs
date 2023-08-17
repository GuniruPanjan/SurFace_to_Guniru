using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KabutoEvolution2 : MonoBehaviour
{
    [SerializeField] private GameObject a;


    public void Update()
    {

        if (kabutoevolution.chara1to3 >= 1) //Chara1‚ª1ˆÈã‚¾‚Á‚½ê‡•\¦
        {

            a.SetActive(!false);

        }
        if (kabutoevolution.chara1to3 == 0) //Chara1‚ª1ˆÈ‰º‚¾‚Á‚½ê‡”ñ•\¦
        {
            a.SetActive(false);
        }

    }
}
