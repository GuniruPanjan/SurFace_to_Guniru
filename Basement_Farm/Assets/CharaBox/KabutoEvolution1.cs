using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SocialPlatforms.GameCenter;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KabutoEvolution1 : MonoBehaviour
{
    [SerializeField] private GameObject a;


    public void Update()
    {

        if (kabutoevolution.chara1to2 >= 1) //Chara1が1以上だった場合表示
        {

            a.SetActive(!false);

        }
        if (kabutoevolution.chara1to2 == 0) //Chara1が1以下だった場合非表示
        {
            a.SetActive(false);
        }

    }
}
