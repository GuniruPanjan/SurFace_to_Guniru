using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PushActive : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OneClick()
    {
        GetComponent<Button>().interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
