
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

    public static int ka = 0;

   
    public void Update()
    {
       
        if (chara1Selection.Chara1 >= 1) //Chara1が1以上だった場合表示
        {

            a.SetActive(!false);

        }
        if (chara1Selection.Chara1 <= 0) //Chara1が1以下だった場合非表示
        {
            Debug.Log("兜");
            Destroy(this.gameObject);
        }

       
    }
}
