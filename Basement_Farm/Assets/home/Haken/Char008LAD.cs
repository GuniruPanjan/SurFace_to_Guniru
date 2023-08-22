using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char008LAD : MonoBehaviour
{
    [SerializeField] private GameObject char008;

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
        if (kabutoevolution.chara1to3 >= 1)
        {
            if (rand < 50)
            {

                kabutoevolution.chara1to3 -= 1;

                Debug.Log("€‚Ê");

                char008.SetActive(false);

            }
            else
            {

                Debug.Log("¶‚«‚é");
                char008.SetActive(!false);


            }

        }
        else
        {
            char008.active = false;
        }
    }
}
