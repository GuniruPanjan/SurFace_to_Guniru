using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char001Count : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Onclick()
    {
        Char001.CharCount001 += 1;
        Debug.Log(Char001.CharCount001);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
