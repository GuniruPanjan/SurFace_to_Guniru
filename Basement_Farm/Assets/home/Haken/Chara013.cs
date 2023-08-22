using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara013 : MonoBehaviour
{
    public static int CharCount013 = 0;     //ゲットシーンの変数宣言

    [SerializeField] private GameObject char013;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (hirusuke.Chara4 >= 1) //Chara1が1以上だった場合表示
        {

            char013.SetActive(!false);

        }
        if (hirusuke.Chara4 == 0) //Chara1が1以下だった場合非表示
        {
            char013.SetActive(false);
        }
    }
}
