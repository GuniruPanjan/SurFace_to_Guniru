using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetGenerator : MonoBehaviour
{

    int rand;

    public GameObject item1;
    public GameObject item2;
    public GameObject item3;
    public GameObject item4;

    // Start is called before the first frame update
    void Start()
    {
        rand = Random.Range(1, 100);  //1~100‚Ì”ÍˆÍ
        Debug.Log(rand);

        
    }

    // Update is called once per frame
    void Update()
    {
        if (rand < 30)
        {
            //1‚Â–Ú
            item1.SetActive(true);
            if (rand < 10)
            {
                item2.SetActive(true);

                if (rand < 5)
                {
                    item3.SetActive(true);
                }
            }

        }
        else if (rand < 60)
        {
            //2‚Â–Ú
            item2.SetActive(true);
            if (rand < 40)
            {
                item1.SetActive(true);

                if (rand < 35)
                {
                    item3.SetActive(true);
                }
            }

        }
        else if (rand < 90)
        {
            //3‚Â–Ú
            item3.SetActive(true);
            if (rand < 70)
            {
                item1.SetActive(true);

                if (rand < 65)
                {
                    item2.SetActive(true);
                }
            }


        }
        else if (rand < 100)
        {
            //4‚Â–Ú
            item4.SetActive(true);
        }
    }
}
