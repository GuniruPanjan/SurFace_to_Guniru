using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char009LAD : MonoBehaviour
{
    [SerializeField] private GameObject char009;

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
        if (Char009.CharCount009 >= 1)
        {
            if (rand < 50)
            {

                chara9Selection.Chara9 -= 1;

                Debug.Log("死ぬ");

                char009.SetActive(false);

            }
            else
            {

                Debug.Log("生きる");
                char009.SetActive(!false);


            }

        }
        else
        {
            char009.active = false;
        }
    }
}
