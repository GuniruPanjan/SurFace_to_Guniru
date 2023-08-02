using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homeCharacter : MonoBehaviour
{
    [SerializeField] private GameObject a1 = GameObject.Find("キャラ1");

    void Update()
    {
        if (kabuto.Home1 >= 1)  //１以上だった場合キャラが表示される
        {
            a1.SetActive(!false);
        }
        if (kabuto.Home1 == 0)  //0以下だった場合キャラが非表示
        {
            a1.SetActive(false);
        }
    }
}
