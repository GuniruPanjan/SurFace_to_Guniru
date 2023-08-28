using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char019LAD : MonoBehaviour
{
    [SerializeField] private GameObject char019;

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
        if (GetGenerator.Chara9 >= 1)
        {
            if (rand < 50)
            {

                GetGenerator.Chara9 -= 1;

                Debug.Log("オールバクテリア死ぬ");

                char019.SetActive(false);

            }
            else
            {

                Debug.Log("生きる");
                char019.SetActive(!false);


            }

        }
        else
        {
            char019.active = false;
        }
    }
}
