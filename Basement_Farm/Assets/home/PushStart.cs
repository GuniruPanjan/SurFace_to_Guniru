using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushStart : MonoBehaviour
{

    [SerializeField] GameObject monster001;
    [SerializeField] GameObject monster002;
    [SerializeField] GameObject monster003;
    [SerializeField] GameObject monster004;
    [SerializeField] GameObject monster005;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Click()
    {
        monster001.active = false;
        monster002.active = false;
        monster003.active = false;
        monster004.active = false;
        monster005.active = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
