using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SocialPlatforms.GameCenter;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class chara1Selection : MonoBehaviour
{

    public static int Chara1 = 0;     //キャラの変数を宣言

    //オブジェクトクリックで選んだキャラ以外が消失
    public void OnTouched()
    {
        //選ばれなかったキャラを宣言
        GameObject obj = GameObject.Find("monster");
        GameObject obj2 = GameObject.Find("花");

        Debug.Log("初めてのモンスターだ！");

        //選ばれなかったキャラを破壊
        Destroy(obj);
        Destroy(obj2);

        Chara1 += 1;

        
    }
}





