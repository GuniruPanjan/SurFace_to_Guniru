using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char029LAD : MonoBehaviour
{
    [SerializeField] private GameObject char029;

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
        if (Chara029.CharCount029 >= 1)
        {
            if (rand < 50)
            {

                TaijiEvolution.tuki -= 1;

                Debug.Log("月死ぬ");

                char029.SetActive(false);

            }
            else
            {

                Debug.Log("生きる");
                char029.SetActive(!false);


            }

        }
        else
        {
            char029.active = false;
        }
    }
}
