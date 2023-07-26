using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countDown : MonoBehaviour
{
    int rand;   // 乱数
    public GameObject item1;    // アイテム1
    public GameObject item2;    // アイテム2
    public GameObject item3;    // アイテム3
    public GameObject item4;    // アイテム4

    public Text timer;
    float CountDownTime;    // カウントダウン
    int num;

    [SerializeField] GameObject sankaku;


    // Start is called before the first frame update
    void Start()
    {
        num = Random.Range(0, 100);     // 0～99をランダムに出す

        Debug.Log(num); // コンソールにランダムに出た数字を表示

        rand = Random.Range(1, 100);  //アイテムの乱数1~100の範囲

        Debug.Log(rand);

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
            // アイテムドロップの確率
            if (rand < 30)      // 30以下の時
            {
                //1つ目
                item1.SetActive(true);
                if (rand < 10)      // 10以下の時
                {
                    item2.SetActive(true);

                    if (rand < 5)       // 5以下の時
                    {
                        item3.SetActive(true);
                    }
                }

            }
            else if (rand < 60)     // 60以下の時
            {
                //2つ目
                item2.SetActive(true);
                if (rand < 40)      // 40以下の時
                {
                    item1.SetActive(true);

                    if (rand < 35)      // 35以下の時
                    {
                        item3.SetActive(true);
                    }
                }

            }
            else if (rand < 90)     // 90以下の時
            {
                //3つ目
                item3.SetActive(true);
                if (rand < 70)      // 70以下の時
                {
                    item1.SetActive(true);

                    if (rand < 65)      // 65以下の時
                    {
                        item2.SetActive(true);
                    }
                }


            }
            else if (rand < 100)        // 100以下の時
            {
                //4つ目
                item4.SetActive(true);
            }


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
