using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class BoxChara1 : MonoBehaviour
{

    [SerializeField] private GameObject a = GameObject.Find("ゲーム1");

    void Update()
    {
       
        if (chara1Selection.Chara1 >= 1) //Chara1が1以上だった場合表示
        {

            a.SetActive(!false);

        }
        if (chara1Selection.Chara1 == 0) //Chara1が1以下だった場合非表示
        {
            a.SetActive(false);
        }
        

    }
}
