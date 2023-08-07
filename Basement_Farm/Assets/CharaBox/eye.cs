using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SocialPlatforms.GameCenter;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class eye : MonoBehaviour
{

    [SerializeField] private GameObject b = GameObject.Find("ゲームキャラ2");

    public void Update()
    {

        if (chara2Selection.Chara2 >= 1) //Chara1が1以上だった場合表示
        {

            b.SetActive(!false);

        }
        if (chara2Selection.Chara2 == 0) //Chara1が1以下だった場合非表示
        {
            b.SetActive(false);
        }


    }
}
