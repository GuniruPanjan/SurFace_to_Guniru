using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bakuteria : MonoBehaviour
{
    [SerializeField] private GameObject a;


    public void Update()
    {

        if (GetGenerator.Chara9 >= 1) //Chara1が1以上だった場合表示
        {

            a.SetActive(!false);

        }
        if (GetGenerator.Chara9 <= 0) //Chara1が1以下だった場合非表示
        {
            Debug.Log("バクテリア");
            Destroy(this.gameObject);
        }


    }
}
