using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char013LAD : MonoBehaviour
{
    [SerializeField] private GameObject char013;

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
        if (hirusuke.Chara4 >= 1)
        {
            if (rand < 50)
            {

                hirusuke.Chara4 -= 1;

                Debug.Log("ひるすけ死ぬ");

                char013.SetActive(false);

            }
            else
            {

                Debug.Log("生きる");
                char013.SetActive(!false);


            }

        }
        else
        {
            char013.active = false;
        }
    }
}
