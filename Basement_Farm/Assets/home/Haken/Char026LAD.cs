using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char026LAD : MonoBehaviour
{
    [SerializeField] private GameObject char026;

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
        if (Char026.CharCount026 >= 1)
        {
            if (rand < 50)
            {

                chara26Selection.Chara26 -= 1;

                Debug.Log("����");

                char028.SetActive(false);

            }
            else
            {

                Debug.Log("������");
                char026.SetActive(!false);


            }

        }
        else
        {
            char026.active = false;
        }
    }
}
