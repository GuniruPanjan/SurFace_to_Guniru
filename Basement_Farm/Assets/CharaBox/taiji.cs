using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class taiji : MonoBehaviour
{
    public static int Chara8 = 0;

    [SerializeField] private GameObject a;


    public void Update()
    {

        if (Chara8 >= 1) //Chara1が1以上だった場合表示
        {

            a.SetActive(!false);

        }
        if (Chara8 <= 0) //Chara1が1以下だった場合非表示
        {
            Debug.Log("胎児");
            Destroy(this.gameObject);
        }


    }
}
