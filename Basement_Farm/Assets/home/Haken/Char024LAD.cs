using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char024LAD : MonoBehaviour
{
    [SerializeField] private GameObject char024;

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
        if (Musibaevolution.musiba >= 1)
        {
            if (rand < 50)
            {

                Musibaevolution.musiba -= 1;

                Debug.Log("死ぬ");

                char024.SetActive(false);

            }
            else
            {

                Debug.Log("生きる");
                char024.SetActive(!false);


            }

        }
        else
        {
            char024.active = false;
        }
    }
}
