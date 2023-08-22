using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara008 : MonoBehaviour
{
    public static int CharCount008 = 0;     //ゲットシーンの変数宣言

    [SerializeField] private GameObject char008;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (YadokariEvolution.chara1to3to1 >= 1) //Chara1が1以上だった場合表示
        {

            char008.SetActive(!false);

        }
        if (YadokariEvolution.chara1to3to1 == 0) //Chara1が1以下だった場合非表示
        {
            char008.SetActive(false);
        }
    }
}
