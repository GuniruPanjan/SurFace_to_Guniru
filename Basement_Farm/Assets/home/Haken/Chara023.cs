using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara023 : MonoBehaviour
{
    public static int CharCount023 = 0;     //ゲットシーンの変数宣言

    [SerializeField] private GameObject char023;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (kusa.Chara7 >= 1) //Chara1が1以上だった場合表示
        {

            char023.SetActive(!false);

        }
        if (kusa.Chara7 == 0) //Chara1が1以下だった場合非表示
        {
            char023.SetActive(false);
        }
    }
}
