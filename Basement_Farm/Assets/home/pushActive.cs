using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pushActive : MonoBehaviour
{
    Button btn;

    // Start is called before the first frame update
    void Start()
    {
        btn = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OneClick()
    {
        btn.interactable = false;
    }

}
