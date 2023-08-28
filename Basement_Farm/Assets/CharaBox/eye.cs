using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SocialPlatforms.GameCenter;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class eye : MonoBehaviour
{

    [SerializeField] private GameObject b;

    public void Update()
    {

        if (chara2Selection.Chara2 >= 1) //Chara1‚ª1ˆÈã‚¾‚Á‚½ê‡•\¦
        {

            b.SetActive(!false);

        }
        if (chara2Selection.Chara2 <= 0) //Chara1‚ª1ˆÈ‰º‚¾‚Á‚½ê‡”ñ•\¦
        {
            Debug.Log("–Ú");
            Destroy(this.gameObject);
        }


    }
}
