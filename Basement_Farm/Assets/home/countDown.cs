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
    public GameObject item1;
    public GameObject item2;
    public GameObject item3;
    public GameObject item4;

    public Text timer;
    float CountDownTime;    // カウントダウン
    int num;

    [SerializeField] GameObject sankaku;


    // Start is called before the first frame update
    void Start()
    {
        num = Random.Range(0, 100);     // 0～99をランダムに出す

        Debug.Log(num); // コンソールにランダムに出た数字を表示

        rand = Random.Range(1, 100);  //1~100の範囲
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

            SceneManager.LoadScene("getScene");

            if (rand < 30)
            {
                //1つ目
                item1.SetActive(true);
                if (rand < 10)
                {
                    item2.SetActive(true);

                    if (rand < 5)
                    {
                        item3.SetActive(true);
                    }
                }

            }
            else if (rand < 60)
            {
                //2つ目
                item2.SetActive(true);
                if (rand < 40)
                {
                    item1.SetActive(true);

                    if (rand < 35)
                    {
                        item3.SetActive(true);
                    }
                }

            }
            else if (rand < 90)
            {
                //3つ目
                item3.SetActive(true);
                if (rand < 70)
                {
                    item1.SetActive(true);

                    if (rand < 65)
                    {
                        item2.SetActive(true);
                    }
                }


            }
            else if (rand < 100)
            {
                //4つ目
                item4.SetActive(true);
            }

            Debug.Log("終了");
            CountDownTime = 0.0f;
            if (num < 90)   // 90%の確率で死ぬ
            {
                timer.text = "殉職";
                Destroy(sankaku);       // オブジェクトを消滅
            }
            else    // 10%の確率で生きる
            {
                timer.text = "生還";    // 生きたことをテキストで表示
            }

            Destroy(start);                 // 開始ボタンを非表示
        }
        else
        {
            //カウントダウンタイム整形して表示
            timer.text = string.Format("{0:00}秒", CountDownTime);
            Debug.Log(CountDownTime);
        }

    }
}
