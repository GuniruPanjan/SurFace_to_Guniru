using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara010 : MonoBehaviour
{
    public static int CharCount010 = 0;     //ゲットシーンの変数宣言

    [SerializeField] private GameObject char010;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Hana2evolution.hana3 >= 1) //Chara1が1以上だった場合表示
        {

            char010.SetActive(!false);

        }
        if (Hana2evolution.hana3 == 0) //Chara1が1以下だった場合非表示
        {
            char010.SetActive(false);
        }
    }
}
