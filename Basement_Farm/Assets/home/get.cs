using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class get : MonoBehaviour
{

    public GameObject item1;
    public GameObject item2;
    public GameObject item3;
    public GameObject item4;

    public void OnClick()
    {
        Debug.Log("‰Ÿ‚³‚ê‚½");

        Destroy(item1);
        Destroy(item2);
        Destroy(item3);
        Destroy(item4);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
