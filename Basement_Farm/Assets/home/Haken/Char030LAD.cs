using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char030LAD : MonoBehaviour
{
    [SerializeField] private GameObject char030;

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
        if (Chara030.CharCount030 >= 1)
        {
            if (rand < 50)
            {

                Tukievolution.ajin -= 1;

                Debug.Log("€‚Ê");

                char030.SetActive(false);

            }
            else
            {

                Debug.Log("¶‚«‚é");
                char030.SetActive(!false);


            }

        }
        else
        {
            char030.active = false;
        }
    }
}
