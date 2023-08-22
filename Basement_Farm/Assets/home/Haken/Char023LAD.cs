using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char023LAD : MonoBehaviour
{
    [SerializeField] private GameObject char023;

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
        if (chara3Selection.Chara3 >= 1)
        {
            if (rand < 50)
            {

                chara3Selection.Chara3 -= 1;

                Debug.Log("€‚Ê");

                char023.SetActive(false);

            }
            else
            {

                Debug.Log("¶‚«‚é");
                char023.SetActive(!false);


            }

        }
        else
        {
            char023.active = false;
        }
    }
}
