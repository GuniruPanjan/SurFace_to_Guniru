using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara026 : MonoBehaviour
{
    public static int CharCount026 = 0;     //ゲットシーンの変数宣言

    [SerializeField] private GameObject char026;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Musiba2Evolution.musi >= 1) //Chara1が1以上だった場合表示
        {

            char026.SetActive(!false);

        }
        if (Musiba2Evolution.musi == 0) //Chara1が1以下だった場合非表示
        {
            char026.SetActive(false);
        }
    }
}
