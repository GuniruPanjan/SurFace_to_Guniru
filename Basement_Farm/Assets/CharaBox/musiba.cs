using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musiba : MonoBehaviour
{
    public static int Chara6 = 0;

    [SerializeField] private GameObject a;


    public void Update()
    {

        if (Chara6 >= 1) //Chara1が1以上だった場合表示
        {

            a.SetActive(!false);

        }
        if (Chara6 <= 0) //Chara1が1以下だった場合非表示
        {
            Debug.Log("虫歯");
            Destroy(this.gameObject);
        }


    }
}
