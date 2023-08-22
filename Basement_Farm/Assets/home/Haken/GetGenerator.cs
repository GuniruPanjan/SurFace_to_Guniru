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
    public GameObject character9;

    public static int item01 = 0;
    public static int item02 = 0;
    public static int item03 = 0;
    public static int item04 = 0;
   
    //public static int Chara4 = 0;
    //public static int Chara5 = 0;
    //public static int Chara6 = 0;
    //public static int Chara7 = 0;
    //public static int Chara8 = 0;
    public static int Chara9 = 0;

    // Start is called before the first frame update
    void Start()
    {


        rand = Random.Range(1, 100);  //1~100‚Ì”ÍˆÍ
        Debug.Log(rand);

        ran = Random.Range(1, 90);
        Debug.Log(ran);

        
    }

    // Update is called once per frame
    void Update()
    {
        if (rand < 30)
        {
            //1‚Â–Ú
            item1.SetActive(true);
            item01 += 1;

            if (rand < 10)
            {
                item2.SetActive(true);
                item02 += 1;

                if (rand < 5)
                {
                    item3.SetActive(true);
                    item03 += 1;
                }
            }

        }
        else if (rand < 60)
        {
            //2‚Â–Ú
            item2.SetActive(true);
            item02 += 1;

            if (rand < 40)
            {
                item1.SetActive(true);
                item01 += 1;

                if (rand < 35)
                {
                    item3.SetActive(true);
                    item03 += 1;
                }
            }

        }
        else if (rand < 90)
        {
            //3‚Â–Ú
            item3.SetActive(true);
            item03 += 1;

            if (rand < 70)
            {
                item1.SetActive(true);
                item01 += 1;

                if (rand < 65)
                {
                    item2.SetActive(true);
                    item02 +=1;
                }
            }


        }
        else if (rand < 100)
        {
            //4‚Â–Ú
            item4.SetActive(true);
            item04 += 1;
        }


        //ƒ‚ƒ“ƒXƒ^[‚ÌŠl“¾
        if (ran < 10)
        {
            character1.SetActive(true);
            chara1Selection.Chara1 += 1;
        }
      
        else if(ran < 20)
        {
            character3.SetActive(true);
            chara2Selection.Chara2 += 1;
        }
        else if(ran < 30)
        {
            character4.SetActive(true);
            chara3Selection.Chara3 += 1;
        }
        else if (ran < 40)
        {
            character2.SetActive(true);
            hirusuke.Chara4 += 1;
        }
        else if(ran < 50)
        {
            character5.SetActive(true);
            kao.Chara5 += 1;
        }
        else if(ran < 60)
        {
            character6.SetActive(true);
            musiba.Chara6 += 1;
        }
        else if(ran < 70)
        {
            character7.SetActive(true);
            kusa.Chara7 += 1;
        }
        else if(ran < 80)
        {
            character8.SetActive(true);
            taiji.Chara8 += 1;
        }
        else if(ran < 90)
        {
            character9.SetActive(true);
            Chara9 += 1;
        }
        
    }
}
