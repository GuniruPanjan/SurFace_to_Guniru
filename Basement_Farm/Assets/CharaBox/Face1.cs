using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face1 : MonoBehaviour
{
    [SerializeField] private GameObject a;


    public void Update()
    {

        if (Faceevolution.face >= 1) //Chara1が1以上だった場合表示
        {

            a.SetActive(!false);

        }
        if (Faceevolution.face == 0) //Chara1が1以下だった場合非表示
        {
            a.SetActive(false);
        }


    }
}
