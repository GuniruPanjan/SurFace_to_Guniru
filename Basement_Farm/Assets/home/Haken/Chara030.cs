using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara030 : MonoBehaviour
{
    public static int CharCount030 = 0;     //ゲットシーンの変数宣言

    [SerializeField] private GameObject char030;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Tukievolution.ajin >= 1) //Chara1が1以上だった場合表示
        {

            char030.SetActive(!false);

        }
        if (Tukievolution.ajin == 0) //Chara1が1以下だった場合非表示
        {
            char030.SetActive(false);
        }
    }
}
