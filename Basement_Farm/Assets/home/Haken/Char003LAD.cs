using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char003LAD : MonoBehaviour
{
    [SerializeField] private GameObject char003;

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
        if (Char003.CharCount003 >= 1)
        {
            if (rand < 50)
            {

                chara3Selection.Chara3 -= 1;

                Debug.Log("死ぬ");

                char003.SetActive(false);

            }
            else
            {

                Debug.Log("生きる");
                char003.SetActive(!false);


            }

        }
        else
        {
            char003.active = false;
        }
    }
}
