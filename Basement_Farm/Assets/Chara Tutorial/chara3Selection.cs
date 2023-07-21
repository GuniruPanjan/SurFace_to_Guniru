using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chara3Selection : MonoBehaviour
{
    [SerializeField] private GameObject a = GameObject.Find("Canvas");  //GameObject型の変数aを宣言　好きなゲームオブジェクトをアタッチ

    public int Chara3 = 0;  //キャラ変数を宣言する

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
        GameObject obj1 = GameObject.Find("キャラ１");

        Debug.Log("初めてのモンスターだ！");

        //選ばれなかったキャラを破壊
        Destroy(obj);
        Destroy(obj1);

        //UIボタンを表示する
        a.SetActive(true);

        Chara3 += 1;
    }
}
