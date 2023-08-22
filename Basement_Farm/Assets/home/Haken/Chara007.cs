using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara007 : MonoBehaviour
{
    public static int CharCount007 = 0;     //ゲットシーンの変数宣言

    [SerializeField] private GameObject char007;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Hanaevolution.ka >= 1) //Chara1が1以上だった場合表示
        {

            char007.SetActive(!false);

        }
        if (Hanaevolution.ka == 0) //Chara1が1以下だった場合非表示
        {
            char007.SetActive(false);
        }
    }
}
