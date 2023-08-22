using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara009 : MonoBehaviour
{
    public static int CharCount009 = 0;     //ゲットシーンの変数宣言

    [SerializeField] private GameObject char009;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Eye2Evolution.ai >= 1) //Chara1が1以上だった場合表示
        {

            char009.SetActive(!false);

        }
        if (Eye2Evolution.ai == 0) //Chara1が1以下だった場合非表示
        {
            char009.SetActive(false);
        }
    }
}
