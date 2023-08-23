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
        rand = Random.Range(1, 100);  //1~100の範囲
        Debug.Log(rand);
    }

    // Update is called once per frame
    void Update()
    {
        if (Chara026.CharCount026 >= 1)
        {
            if (rand < 50)
            {

                Musiba2Evolution.musi -= 1;

                Debug.Log("死ぬ");

                char026.SetActive(false);

            }
            else
            {

                Debug.Log("生きる");
                char026.SetActive(!false);


            }

        }
        else
        {
            char026.active = false;
        }
    }
}
