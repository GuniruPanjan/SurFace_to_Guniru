using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char019LAD : MonoBehaviour
{
    [SerializeField] private GameObject char019;

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
        if (Chara019.CharCount019 >= 1)
        {
            if (rand < 50)
            {

                GetGenerator.Chara9 -= 1;

                Debug.Log("€‚Ê");

                char019.SetActive(false);

            }
            else
            {

                Debug.Log("¶‚«‚é");
                char019.SetActive(!false);


            }

        }
        else
        {
            char019.active = false;
        }
    }
}
