using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kusa : MonoBehaviour
{
    public static int Chara7 = 0;

    [SerializeField] private GameObject a;


    public void Update()
    {

        if (Chara7 >= 1) //Chara1が1以上だった場合表示
        {

            a.SetActive(!false);

        }
        if (Chara7 <= 0) //Chara1が1以下だった場合非表示
        {
            Debug.Log("草");
            Destroy(this.gameObject);
        }


    }
}
