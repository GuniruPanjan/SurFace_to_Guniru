using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara015 : MonoBehaviour
{
    public static int CharCount015 = 0;     //ゲットシーンの変数宣言

    [SerializeField] private GameObject char015;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Hirusukeevolution.hirunann >= 1) //Chara1が1以上だった場合表示
        {

            char015.SetActive(!false);

        }
        if (Hirusukeevolution.hirunann == 0) //Chara1が1以下だった場合非表示
        {
            char015.SetActive(false);
        }
    }
}
