using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushManeger : MonoBehaviour
{
    public int num;
    public GameObject monster;

    // Start is called before the first frame update
    void Start()
    {
        num = 0;
        monster = GameObject.Find("Monster");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(num);

        if (num == 5)
        {
            Debug.Log("Ç‡Ç§ñ≥óù");
        }
    }

    public void Selecte()
    {
        num++;
    }
}
