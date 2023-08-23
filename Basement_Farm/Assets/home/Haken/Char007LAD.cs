using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char007LAD : MonoBehaviour
{
    [SerializeField] private GameObject char007;

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
        if (Chara007.CharCount007 >= 1)
        {
            if (rand < 50)
            {

                Hanaevolution.hana2 -= 1;

                Debug.Log("€‚Ê");

                char007.SetActive(false);

            }
            else
            {

                Debug.Log("¶‚«‚é");
                char007.SetActive(!false);


            }

        }
        else
        {
            char007.active = false;
        }
    }
}
