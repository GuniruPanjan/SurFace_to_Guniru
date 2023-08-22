using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara016 : MonoBehaviour
{
    public static int CharCount016 = 0;     //ゲットシーンの変数宣言

    [SerializeField] private GameObject char016;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (kao.Chara5 >= 1) //Chara1が1以上だった場合表示
        {

            char016.SetActive(!false);

        }
        if (kao.Chara5 == 0) //Chara1が1以下だった場合非表示
        {
            char016.SetActive(false);
        }
    }
}
