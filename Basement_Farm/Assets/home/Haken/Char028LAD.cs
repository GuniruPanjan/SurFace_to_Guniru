using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char028LAD : MonoBehaviour
{
    [SerializeField] private GameObject char028;

    public int rand;

    // Start is called before the first frame update
    void Start()
    {
        rand = Random.Range(1, 100);  //1~100�͈̔�
        Debug.Log(rand);
    }

    // Update is called once per frame
    void Update()
    {
        if (Kaoevolution.kao2 >= 1)
        {
            if (rand < 50)
            {

                Faceevolution.face -= 1;

                Debug.Log("����");

                char028.SetActive(false);

            }
            else
            {

                Debug.Log("������");
                char022.SetActive(!false);


            }

        }
        else
        {
            char028.active = false;
        }
    }
}