using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char014LAD : MonoBehaviour
{
    [SerializeField] private GameObject char014;

    public int rand;

    // Start is called before the first frame update
    void Start()
    {
        rand = Random.Range(1, 100);  //1~100�͈̔�
        Debug.Log(rand);
    }

    // Update is called once per frame
    void Update()
    {
        if (Char014.CharCount014 >= 1)
        {
            if (rand < 50)
            {

                chara14Selection.Chara14 -= 1;

                Debug.Log("����");

                char014.SetActive(false);

            }
            else
            {

                Debug.Log("������");
                char014.SetActive(!false);


            }

        }
        else
        {
            char014.active = false;
        }
    }
}
