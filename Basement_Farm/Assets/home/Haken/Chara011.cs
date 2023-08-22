using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara011 : MonoBehaviour
{
    public static int CharCount011 = 0;     //ゲットシーンの変数宣言

    [SerializeField] private GameObject char011;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (KusaEvolution.kusa2 >= 1) //Chara1が1以上だった場合表示
        {

            char011.SetActive(!false);

        }
        if (KusaEvolution.kusa2 == 0) //Chara1が1以下だった場合非表示
        {
            char011.SetActive(false);
        }
    }
}
