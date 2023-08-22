using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara025 : MonoBehaviour
{
    public static int CharCount025 = 0;     //ゲットシーンの変数宣言

    [SerializeField] private GameObject char025;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Musibaevolution.musiba2 >= 1) //Chara1が1以上だった場合表示
        {

            char025.SetActive(!false);

        }
        if (Musibaevolution.musiba2 == 0) //Chara1が1以下だった場合非表示
        {
            char025.SetActive(false);
        }
    }
}
