using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char012LAD : MonoBehaviour
{
    [SerializeField] private GameObject char012;

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
        if (Kusa2evolution.kusa3 >= 1)
        {
            if (rand < 50)
            {

                Kusa2evolution.kusa3 -= 1;

                Debug.Log("€‚Ê");

                char012.SetActive(false);

            }
            else
            {

                Debug.Log("¶‚«‚é");
                char012.SetActive(!false);


            }

        }
        else
        {
            char012.active = false;
        }
    }
}
