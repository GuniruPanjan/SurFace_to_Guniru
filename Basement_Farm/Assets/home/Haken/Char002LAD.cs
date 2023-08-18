using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char002LAD : MonoBehaviour
{
    [SerializeField] private GameObject char002;

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
        if (Char002.CharCount002 >= 1)
        {
            if (rand < 50)
            {

                chara2Selection.Chara2 -= 1;

                Debug.Log("€‚Ê");

                char002.SetActive(false);

            }
            else
            {

                Debug.Log("¶‚«‚é");
                char002.SetActive(!false);


            }

        }
        else
        {
            char002.active = false;
        }
    }
}
