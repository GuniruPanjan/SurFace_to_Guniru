using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class countDown : MonoBehaviour
{
    [SerializeField] public GameObject start;
    [SerializeField] public GameObject reset;

    int rand;

    public Text timer;      // テキストタイマー
    float CountDownTime;    // カウントダウン
    int num;


    // Start is called before the first frame update
    void Start()
    {
        CountDownTime = 10.0f;      //　カウントダウン開始秒数をセット
        //minute = CountDownTime / 60;
        timer = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //経過時刻を引いていく
        CountDownTime -= Time.deltaTime;


        // 0.0秒になったらカウントダウンタイムを0.0で固定(止まったように見せる)
        if (CountDownTime <= 0.0f)
        {
            SceneManager.LoadScene("getScene");
        }
        else
        {
            //カウントダウンタイム整形して表示
            timer.text = string.Format("{0:00}秒", CountDownTime);
            Debug.Log(CountDownTime);
        }

    }

}
