using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char025LAD : MonoBehaviour
{
    [SerializeField] private GameObject char025;

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
        if (Char025.CharCount025 >= 1)
        {
            if (rand < 50)
            {

                chara25Selection.Chara25 -= 1;

                Debug.Log("€‚Ê");

                char025.SetActive(false);

            }
            else
            {

                Debug.Log("¶‚«‚é");
                char025.SetActive(!false);


            }

        }
        else
        {
            char025.active = false;
        }
    }
}
