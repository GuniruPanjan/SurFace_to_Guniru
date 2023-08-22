using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char003 : MonoBehaviour
{
    public static int CharCount003 = 0;     //ゲットシーンの変数宣言

    [SerializeField] private GameObject char003;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (chara3Selection.Chara3 >= 1) //Chara1が1以上だった場合表示
        {

            char003.SetActive(!false);

        }
        if (chara3Selection.Chara3 == 0) //Chara1が1以下だった場合非表示
        {
            char003.SetActive(false);
        }
    }

}
