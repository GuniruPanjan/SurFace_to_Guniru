using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara004 : MonoBehaviour
{
    public static int CharCount004 = 0;     //ゲットシーンの変数宣言

    [SerializeField] private GameObject char004;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (kabutoevolution.chara1to2 >= 1) //Chara1が1以上だった場合表示
        {

            char004.SetActive(!false);

        }
        if (kabutoevolution.chara1to2 == 0) //Chara1が1以下だった場合非表示
        {
            char004.SetActive(false);
        }
    }
}
