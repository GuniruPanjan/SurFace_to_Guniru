using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char011LAD : MonoBehaviour
{
    [SerializeField] private GameObject char011;

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
        if (KusaEvolution.kusa2 >= 1)
        {
            if (rand < 50)
            {

                KusaEvolution.kusa2 -= 1;

                Debug.Log("€‚Ê");

                char011.SetActive(false);

            }
            else
            {

                Debug.Log("¶‚«‚é");
                char011.SetActive(!false);


            }

        }
        else
        {
            char011.active = false;
        }
    }
}
