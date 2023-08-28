using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SocialPlatforms.GameCenter;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class hana : MonoBehaviour
{
    [SerializeField] private GameObject c;

    void Update()
    {

        if (chara3Selection.Chara3 >= 1) //Chara1‚ª1ˆÈã‚¾‚Á‚½ê‡•\¦
        {

            c.SetActive(!false);

        }
        if (chara3Selection.Chara3 <= 0) //Chara1‚ª1ˆÈ‰º‚¾‚Á‚½ê‡”ñ•\¦
        {
            Debug.Log("‰Ô");
            Destroy(this.gameObject);
        }


    }
}
