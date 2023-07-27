using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SocialPlatforms.GameCenter;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class hana : MonoBehaviour
{
    [SerializeField] private GameObject c = GameObject.Find("ゲームキャラ3");

    void Update()
    {

        if (chara3Selection.Chara3 >= 1) //Chara1が1以上だった場合表示
        {

            c.SetActive(!false);

        }
        if (chara3Selection.Chara3 == 0) //Chara1が1以下だった場合非表示
        {
            c.SetActive(false);
        }


    }
}
