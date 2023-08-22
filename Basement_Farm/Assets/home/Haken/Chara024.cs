using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara024 : MonoBehaviour
{
    public static int CharCount024 = 0;     //ゲットシーンの変数宣言

    [SerializeField] private GameObject char024;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (musiba.Chara6 >= 1) //Chara1が1以上だった場合表示
        {

            char024.SetActive(!false);

        }
        if (musiba.Chara6 == 0) //Chara1が1以下だった場合非表示
        {
            char024.SetActive(false);
        }
    }
}
