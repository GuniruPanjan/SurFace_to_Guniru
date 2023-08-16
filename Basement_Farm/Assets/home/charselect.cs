using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class charselect : MonoBehaviour
{
    public GameObject monster;
    public Button button;
    public int count = 0;
    Text text;

    public void OnClick()
    {
        if (count <= 1)
        {
            button = GetComponent<Button>();
            count += 1;
            Debug.Log(count);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        button.onClick.Invoke();
    }
}
