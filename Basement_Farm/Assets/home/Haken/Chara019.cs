using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara019 : MonoBehaviour
{
    public static int CharCount019 = 0;     //ゲットシーンの変数宣言

    [SerializeField] private GameObject char019;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GetGenerator.Chara9 >= 1) //Chara1が1以上だった場合表示
        {

            char019.SetActive(!false);

        }
        if (GetGenerator.Chara9 == 0) //Chara1が1以下だった場合非表示
        {
            char019.SetActive(false);
        }
    }
}
