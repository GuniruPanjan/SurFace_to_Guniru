using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char018LAD : MonoBehaviour
{
    [SerializeField] private GameObject char018;

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
        if (Chara018.CharCount018 >= 1)
        {
            if (rand < 50)
            {

                Faceevolution.face -= 1;

                Debug.Log("死ぬ");

                char018.SetActive(false);

            }
            else
            {

                Debug.Log("生きる");
                char018.SetActive(!false);


            }

        }
        else
        {
            char018.active = false;
        }
    }
}
