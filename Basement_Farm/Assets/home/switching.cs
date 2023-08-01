using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class switching : MonoBehaviour
{
    public Text ButtonText;
    [SerializeField] public GameObject reset;



    // ボタンが押された場合、今回呼び出される関数
    public void OnClick()
    {

        Debug.Log("押された");
        reset.SetActive(false);        // 獲得ボタンを表示

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
