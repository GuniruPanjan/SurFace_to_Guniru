using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara017 : MonoBehaviour
{
    public static int CharCount017 = 0;     //ゲットシーンの変数宣言

    [SerializeField] private GameObject char017;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Kaoevolution.kao2 >= 1) //Chara1が1以上だった場合表示
        {

            char017.SetActive(!false);

        }
        if (Kaoevolution.kao2 == 0) //Chara1が1以下だった場合非表示
        {
            char017.SetActive(false);
        }
    }
}
