using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara022 : MonoBehaviour
{
    public static int CharCount022 = 0;     //ゲットシーンの変数宣言

    [SerializeField] private GameObject char022;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (kabutoevolution.chara1to3 >= 1) //Chara1が1以上だった場合表示
        {

            char022.SetActive(!false);

        }
        if (kabutoevolution.chara1to3 == 0) //Chara1が1以下だった場合非表示
        {
            char022.SetActive(false);
        }
    }
}
