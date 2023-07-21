using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chara3Selection : MonoBehaviour
{

    //UIボタンを非表示にする
    void Start()
    {
       
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

       

    }
}
