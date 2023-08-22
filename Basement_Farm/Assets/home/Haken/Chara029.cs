using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara029 : MonoBehaviour
{
    public static int CharCount029 = 0;     //ゲットシーンの変数宣言

    [SerializeField] private GameObject char029;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (TaijiEvolution.tuki >= 1) //Chara1が1以上だった場合表示
        {

            char029.SetActive(!false);

        }
        if (TaijiEvolution.tuki == 0) //Chara1が1以下だった場合非表示
        {
            char029.SetActive(false);
        }
    }
}
