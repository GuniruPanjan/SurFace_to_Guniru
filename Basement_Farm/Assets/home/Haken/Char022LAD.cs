using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char022LAD : MonoBehaviour
{
    [SerializeField] private GameObject char022;

    public int rand;

    // Start is called before the first frame update
    void Start()
    {
        rand = Random.Range(1, 100);  //1~100の範囲
        Debug.Log(rand);
    }

    // Update is called once per frame
    void Update()
    {
        if (Chara022.CharCount022 >= 1)
        {
            if (rand < 50)
            {

                kabutoevolution.chara1to3 -= 1;

                Debug.Log("ゲームキャラ2分岐死ぬ");

                char022.SetActive(false);

            }
            else
            {

                Debug.Log("生きる");
                char022.SetActive(!false);


            }

        }
        else
        {
            char022.active = false;
        }
    }
}
