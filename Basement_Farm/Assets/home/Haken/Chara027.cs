using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara027 : MonoBehaviour
{
    public static int CharCount027 = 0;     //ゲットシーンの変数宣言

    [SerializeField] private GameObject char027;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (taiji.Chara8 >= 1) //Chara1が1以上だった場合表示
        {

            char027.SetActive(!false);

        }
        if (taiji.Chara8 == 0) //Chara1が1以下だった場合非表示
        {
            char027.SetActive(false);
        }
    }
}
