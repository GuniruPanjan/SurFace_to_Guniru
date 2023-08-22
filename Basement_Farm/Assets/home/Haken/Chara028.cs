using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara028 : MonoBehaviour
{
    public static int CharCount028 = 0;     //ゲットシーンの変数宣言

    [SerializeField] private GameObject char028;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (TaijiEvolution.sito >= 1) //Chara1が1以上だった場合表示
        {

            char028.SetActive(!false);

        }
        if (TaijiEvolution.sito == 0) //Chara1が1以下だった場合非表示
        {
            char028.SetActive(false);
        }
    }
}
