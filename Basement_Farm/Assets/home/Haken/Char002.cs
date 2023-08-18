using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char002 : MonoBehaviour
{
    public static int CharCount002 = 0;     //ゲットシーンの変数宣言

    [SerializeField] private GameObject char002;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (chara2Selection.Chara2 >= 1) //Chara1が1以上だった場合表示
        {

            char002.SetActive(!false);

        }
        if (chara2Selection.Chara2 == 0) //Chara1が1以下だった場合非表示
        {
            char002.SetActive(false);
        }
    }
}
