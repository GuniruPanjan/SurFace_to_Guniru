using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char021LAD : MonoBehaviour
{
    [SerializeField] private GameObject char021;

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
        if (Chara021.CharCount021 >= 1)
        {
            if (rand < 50)
            {

                Bakuteriaevolution.bagu -= 1;

                Debug.Log("€‚Ê");

                char021.SetActive(false);

            }
            else
            {

                Debug.Log("¶‚«‚é");
                char021.SetActive(!false);


            }

        }
        else
        {
            char021.active = false;
        }
    }
}
