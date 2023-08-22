using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char009LAD : MonoBehaviour
{
    [SerializeField] private GameObject char009;

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
        if (EyeEvolution.eye2 >= 1)
        {
            if (rand < 50)
            {

                EyeEvolution.eye2 -= 1;

                Debug.Log("€‚Ê");

                char009.SetActive(false);

            }
            else
            {

                Debug.Log("¶‚«‚é");
                char009.SetActive(!false);


            }

        }
        else
        {
            char009.active = false;
        }
    }
}
