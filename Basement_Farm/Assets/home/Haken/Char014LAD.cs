using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char014LAD : MonoBehaviour
{
    [SerializeField] private GameObject char014;

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
        if (normalHirusuke.normal >= 1)
        {
            if (rand < 50)
            {

                normalHirusuke.normal -= 1;

                Debug.Log("死ぬ");

                char014.SetActive(false);

            }
            else
            {

                Debug.Log("生きる");
                char014.SetActive(!false);


            }

        }
        else
        {
            char014.active = false;
        }
    }
}
