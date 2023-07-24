using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countDown : MonoBehaviour
{
    public Text timer;
    float CountDownTime;    // カウントダウン
    int num;

    [SerializeField] GameObject sankaku;


    // Start is called before the first frame update
    void Start()
    {
        num = Random.Range(0, 100);     // 0～99をランダムに出す

        Debug.Log(num); // コンソールにランダムに出た数字を表示

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
            Debug.Log("終了");
            CountDownTime = 0.0f;
            if (num < 90)   // 90%の確率で死ぬ
            {
                timer.text = "殉職";    // 死んだことをテキストで表示
                Destroy(sankaku);       // オブジェクトを消滅
            }
            else    // 10%の確率で生きる
            {
                timer.text = "生還";    // 生きたことをテキストで表示
            }
        }
        else
        {
            //カウントダウンタイム整形して表示
            timer.text = string.Format("{0:00}秒", CountDownTime);
            Debug.Log(CountDownTime);
        }

    }
}
