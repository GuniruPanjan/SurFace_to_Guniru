using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char007LAD : MonoBehaviour
{
    [SerializeField] private GameObject char007;

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
        if (Hanaevolution.hana2 >= 1)
        {
            if (rand < 50)
            {

                Hanaevolution.hana2 -= 1;

                Debug.Log("カエル死ぬ");

                char007.SetActive(false);

            }
            else
            {

                Debug.Log("生きる");
                char007.SetActive(!false);


            }

        }
        else
        {
            char007.active = false;
        }
    }
}
