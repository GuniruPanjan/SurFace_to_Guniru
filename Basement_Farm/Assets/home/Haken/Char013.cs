using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char001 : MonoBehaviour
{
    public static int CharCount001 = 0;     //ゲットシーンの変数宣言

    [SerializeField] private GameObject char001;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (chara1Selection.Chara1 >= 1) //Chara1が1以上だった場合表示
        {

            char001.SetActive(!false);

        }
        if (chara1Selection.Chara1 == 0) //Chara1が1以下だった場合非表示
        {
            char001.SetActive(false);
        }
    }
}
