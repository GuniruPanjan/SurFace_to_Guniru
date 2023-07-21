using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SocialPlatforms.GameCenter;
using UnityEngine.UI;

public class chara1Selection : MonoBehaviour
{

    public int Chara1 = 0;   //キャラ変数を宣言する
    //UIボタンを非表示にする
    public void Start()
    {

    }

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
