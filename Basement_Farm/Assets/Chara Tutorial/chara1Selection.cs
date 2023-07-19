using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SocialPlatforms.GameCenter;
using UnityEngine.UI;

public class chara1Selection : MonoBehaviour
{
    [SerializeField] private GameObject a = GameObject.Find("Canvas");  //GameObject型の変数aを宣言　好きなゲームオブジェクトをアタッチ

    //UIボタンを非表示にする
    void Start()
    {
        a.SetActive(false);
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

        //UIボタンを表示する
        a.SetActive(true);

    }


}
