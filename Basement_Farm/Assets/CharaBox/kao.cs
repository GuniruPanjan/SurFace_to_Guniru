using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kao : MonoBehaviour
{
    public static int Chara5 = 0;

    [SerializeField] private GameObject a;


    public void Update()
    {

        if (Chara5 >= 1) //Chara1が1以上だった場合表示
        {

            a.SetActive(!false);

        }
        if (Chara5 <= 0) //Chara1が1以下だった場合非表示
        {
            Debug.Log("顔");
            Destroy(this.gameObject);
        }


    }
}
