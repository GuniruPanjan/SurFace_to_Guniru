using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetGenerator : MonoBehaviour
{

    int rand;
    int ran;

    public GameObject item1;
    public GameObject item2;
    public GameObject item3;
    public GameObject item4;
    public GameObject character1;
    public GameObject character2;
    public GameObject character3;
    public GameObject character4;
    public GameObject character5;
    public GameObject character6;
    public GameObject character7;
    public GameObject character8;

    // Start is called before the first frame update
    void Start()
    {


        rand = Random.Range(1, 100);  //1~100の範囲
        Debug.Log(rand);

        ran = Random.Range(1, 80);
        Debug.Log(ran);

        
    }

    // Update is called once per frame
    void Update()
    {
        if (rand < 30)
        {
            //1つ目
            item1.SetActive(true);
            if (rand < 10)
            {
                item2.SetActive(true);

                if (rand < 5)
                {
                    item3.SetActive(true);
                }
            }

        }
        else if (rand < 60)
        {
            //2つ目
            item2.SetActive(true);
            if (rand < 40)
            {
                item1.SetActive(true);

                if (rand < 35)
                {
                    item3.SetActive(true);
                }
            }

        }
        else if (rand < 90)
        {
            //3つ目
            item3.SetActive(true);
            if (rand < 70)
            {
                item1.SetActive(true);

                if (rand < 65)
                {
                    item2.SetActive(true);
                }
            }


        }
        else if (rand < 100)
        {
            //4つ目
            item4.SetActive(true);
        }


        //モンスターの獲得
        if (ran < 10)
        {
            character1.SetActive(true);
        }
        else if (ran < 20)
        {
            character2.SetActive(true);
        }
        else if(ran < 30)
        {
            character3.SetActive(true);
        }
        else if(ran < 40)
        {
            character4.SetActive(true);
        }
        else if(ran < 50)
        {
            character5.SetActive(true);
        }
        else if(ran < 60)
        {
            character6.SetActive(true);
        }
        else if(ran < 70)
        {
            character7.SetActive(true);
        }
        else if(ran < 80)
        {
            character8.SetActive(true);
        }
        
    }
}
