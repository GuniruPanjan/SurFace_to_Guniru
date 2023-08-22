using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara021 : MonoBehaviour
{
    public static int CharCount021 = 0;     //ゲットシーンの変数宣言

    [SerializeField] private GameObject char021;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Bakuteriaevolution.bagu >= 1) //Chara1が1以上だった場合表示
        {

            char021.SetActive(!false);

        }
        if (Bakuteriaevolution.bagu == 0) //Chara1が1以下だった場合非表示
        {
            char021.SetActive(false);
        }
    }
}
