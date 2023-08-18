using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushManeger : MonoBehaviour
{
    public int num;

    [SerializeField] GameObject start;

    [SerializeField] GameObject monster001;
    [SerializeField] GameObject monster002;
    [SerializeField] GameObject monster003;
    [SerializeField] GameObject monster004;
    [SerializeField] GameObject monster005;

    // Start is called before the first frame update
    void Start()
    {
        num = 0;
    }

    public void Select()
    {
        num++;
        Debug.Log(num);
        if(num == 1)
        {
            monster001.active = false;
            monster002.active = false;
            monster003.active = false;
            monster004.active = false;
            monster005.active = false;
        }
    }


    // Update is called once per frame
    void Update()
    {
        if(num == 0)
        {
            start.active = false;
        }
        else
        {
            start.active = true;
        }
    }
}
