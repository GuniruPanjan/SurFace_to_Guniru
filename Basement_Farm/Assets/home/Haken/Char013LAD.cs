using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char013LAD : MonoBehaviour
{
    [SerializeField] private GameObject char013;

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
        if (Chara013.CharCount013 >= 1)
        {
            if (rand < 50)
            {

                hirusuke.Chara4 -= 1;

                Debug.Log("€‚Ê");

                char013.SetActive(false);

            }
            else
            {

                Debug.Log("¶‚«‚é");
                char013.SetActive(!false);


            }

        }
        else
        {
            char013.active = false;
        }
    }
}
