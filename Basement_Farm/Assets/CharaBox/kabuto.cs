
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SocialPlatforms.GameCenter;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class kabuto : MonoBehaviour
{
  

    [SerializeField] private GameObject a;

   
    public void Update()
    {
       
        if (chara1Selection.Chara1 >= 1) //Chara1‚ª1ˆÈã‚¾‚Á‚½ê‡•\Ž¦
        {

            a.SetActive(!false);

        }
        if (chara1Selection.Chara1 == 0) //Chara1‚ª1ˆÈ‰º‚¾‚Á‚½ê‡”ñ•\Ž¦
        {
            a.SetActive(false);
        }
        if(GetGenerator.Chara1 >= 1)
        {
            a.SetActive(!false);
        }
        if(GetGenerator.Chara1 == 0)
        {
            a.SetActive(false);
        }
    }
}
