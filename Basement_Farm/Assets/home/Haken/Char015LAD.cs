using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char015LAD : MonoBehaviour
{
    [SerializeField] private GameObject char015;

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
        if (rareHirusuke.rare >= 1)
        {
            if (rand < 50)
            {

                rareHirusuke.rare -= 1;

                Debug.Log("€‚Ê");

                char015.SetActive(false);

            }
            else
            {

                Debug.Log("¶‚«‚é");
                char015.SetActive(!false);


            }

        }
        else
        {
            char015.active = false;
        }
    }
}
