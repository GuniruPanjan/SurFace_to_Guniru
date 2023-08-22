using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hirunanndesu : MonoBehaviour
{
    [SerializeField] private GameObject a;


    public void Update()
    {

        if (Hirusukeevolution.hirunann >= 1) //Chara1‚ª1ˆÈã‚¾‚Á‚½ê‡•\¦
        {

            a.SetActive(!false);

        }
        if (Hirusukeevolution.hirunann == 0) //Chara1‚ª1ˆÈ‰º‚¾‚Á‚½ê‡”ñ•\¦
        {
            a.SetActive(false);
        }

    }
}
