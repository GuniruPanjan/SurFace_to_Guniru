using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char0010LAD : MonoBehaviour
{
    [SerializeField] private GameObject char010;

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
        if (Char010.CharCount010 >= 1)
        {
            if (rand < 50)
            {

                chara10Selection.Chara10 -= 1;

                Debug.Log("€‚Ê");

                char010.SetActive(false);

            }
            else
            {

                Debug.Log("¶‚«‚é");
                char010.SetActive(!false);


            }

        }
        else
        {
            char010.active = false;
        }
    }
}
