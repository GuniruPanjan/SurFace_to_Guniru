using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara012 : MonoBehaviour
{
    public static int CharCount012 = 0;     //ゲットシーンの変数宣言

    [SerializeField] private GameObject char012;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Kusa2evolution.kusa3 >= 1) //Chara1が1以上だった場合表示
        {

            char012.SetActive(!false);

        }
        if (Kusa2evolution.kusa3 == 0) //Chara1が1以下だった場合非表示
        {
            char012.SetActive(false);
        }
    }
}
