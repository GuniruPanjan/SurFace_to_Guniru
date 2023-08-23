using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char005LAD : MonoBehaviour
{
    [SerializeField] private GameObject char005;

    public int rand;

    // Start is called before the first frame update
    void Start()
    {
        rand = Random.Range(1, 100);  //1~100の範囲
        Debug.Log(rand);
    }

    // Update is called once per frame
    void Update()
    {
        if (Chara005.CharCount005 >= 1)
        {
            if (rand < 50)
            {

                chara2Selection.Chara2 -= 1;

                Debug.Log("死ぬ");

                char005.SetActive(false);

            }
            else
            {

                Debug.Log("生きる");
                char005.SetActive(!false);


            }

        }
        else
        {
            char005.active = false;
        }
    }
}
