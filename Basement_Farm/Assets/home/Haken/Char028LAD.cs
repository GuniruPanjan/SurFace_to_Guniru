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
        rand = Random.Range(1, 100);  //1~100‚Ì”ÍˆÍ
        Debug.Log(rand);
    }

    // Update is called once per frame
    void Update()
    {
        if (Chara028.CharCount028 >= 1)
        {
            if (rand < 50)
            {

                TaijiEvolution.sito -= 1;

                Debug.Log("€‚Ê");

                char028.SetActive(false);

            }
            else
            {

                Debug.Log("¶‚«‚é");
                char028.SetActive(!false);


            }

        }
        else
        {
            char028.active = false;
        }
    }
}
