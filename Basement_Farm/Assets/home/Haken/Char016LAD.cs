using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char016LAD : MonoBehaviour
{
    [SerializeField] private GameObject char016;

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
        if (kao.Chara5 >= 1)
        {
            if (rand < 50)
            {

                kao.Chara5 -= 1;

                Debug.Log("€‚Ê");

                char016.SetActive(false);

            }
            else
            {

                Debug.Log("¶‚«‚é");
                char016.SetActive(!false);


            }

        }
        else
        {
            char016.active = false;
        }
    }
}
