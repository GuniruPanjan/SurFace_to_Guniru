using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara018 : MonoBehaviour
{
    public static int CharCount018 = 0;     //ゲットシーンの変数宣言

    [SerializeField] private GameObject char018;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Faceevolution.face >= 1) //Chara1が1以上だった場合表示
        {

            char018.SetActive(!false);

        }
        if (Faceevolution.face == 0) //Chara1が1以下だった場合非表示
        {
            char018.SetActive(false);
        }
    }
}
