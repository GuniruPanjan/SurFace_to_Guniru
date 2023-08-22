using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara014 : MonoBehaviour
{
    public static int CharCount014 = 0;     //ゲットシーンの変数宣言

    [SerializeField] private GameObject char014;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Hirusukeevolution.hiruku >= 1) //Chara1が1以上だった場合表示
        {

            char014.SetActive(!false);

        }
        if (Hirusukeevolution.hiruku == 0) //Chara1が1以下だった場合非表示
        {
            char014.SetActive(false);
        }
    }
}
