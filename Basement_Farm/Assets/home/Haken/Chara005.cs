using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara005 : MonoBehaviour
{
    public static int CharCount005 = 0;     //ゲットシーンの変数宣言

    [SerializeField] private GameObject char005;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (EyeEvolution.eye2 >= 1) //Chara1が1以上だった場合表示
        {

            char005.SetActive(!false);

        }
        if (EyeEvolution.eye2 == 0) //Chara1が1以下だった場合非表示
        {
            char005.SetActive(false);
        }
    }
}
