
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SocialPlatforms.GameCenter;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class kabuto : MonoBehaviour
{

    public static int UpbringingChara1 = 0;  //育成シーンでCharaを表示させるための変数宣言
   public static int Home1 = 0;

    [SerializeField] private GameObject a = GameObject.Find("ゲーム1");

   
    public void Update()
    {
       
        if (chara1Selection.Chara1 >= 1) //Chara1が1以上だった場合表示
        {

            a.SetActive(!false);

        }
        if (chara1Selection.Chara1 == 0) //Chara1が1以下だった場合非表示
        {
            a.SetActive(false);
        }


        if (Input.GetMouseButtonDown(0)) //右クリック
        {
            UpbringingChara1 += 1;
            Debug.Log("Hello");
        }


        if (Input.GetMouseButtonDown(1)) //右クリック
        {
            Home1 += 1;
            Debug.Log("Hello");
        }

    }




}
