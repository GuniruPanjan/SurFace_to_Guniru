using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char020LAD : MonoBehaviour
{
    [SerializeField] private GameObject char020;

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
        if (Chara020.CharCount020 >= 1)
        {
            if (rand < 50)
            {

                Bakuteriaevolution.kisei -= 1;

                Debug.Log("€‚Ê");

                char020.SetActive(false);

            }
            else
            {

                Debug.Log("¶‚«‚é");
                char020.SetActive(!false);


            }

        }
        else
        {
            char020.active = false;
        }
    }
}
