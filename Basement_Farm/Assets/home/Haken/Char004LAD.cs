using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char004LAD : MonoBehaviour
{
    [SerializeField] private GameObject char004;

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
        if (Char004.CharCount004 >= 1)
        {
            if (rand < 50)
            {

                chara4Selection.Chara4 -= 1;

                Debug.Log("€‚Ê");

                char004.SetActive(false);

            }
            else
            {

                Debug.Log("¶‚«‚é");
                char004.SetActive(!false);


            }

        }
        else
        {
            char004.active = false;
        }
    }
}
