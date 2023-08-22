using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char017LAD : MonoBehaviour
{
    [SerializeField] private GameObject char017;

    public int rand;

    // Start is called before the first frame update
    void Start()
    {
        rand = Random.Range(1, 100);  //1~100‚Ì”ÍˆÍ
        Debug.Log(rand);
    }

    // Update is called once per frame
    void Update()
    {
        if (Kaoevolution.kao2 >= 1)
        {
            if (rand < 50)
            {

                Kaoevolution.kao2 -= 1;

                Debug.Log("€‚Ê");

                char017.SetActive(false);

            }
            else
            {

                Debug.Log("¶‚«‚é");
                char017.SetActive(!false);


            }

        }
        else
        {
            char017.active = false;
        }
    }
}
