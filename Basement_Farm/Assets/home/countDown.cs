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
    float CountDownTime;    // �J�E���g�_�E��
    int num;

    [SerializeField] GameObject sankaku;


    // Start is called before the first frame update
    void Start()
    {
        num = Random.Range(0, 100);     // 0�`99�������_���ɏo��

        Debug.Log(num); // �R���\�[���Ƀ����_���ɏo��������\��

        rand = Random.Range(1, 100);  //1~100�͈̔�
        Debug.Log(rand);

        CountDownTime = 10.0f;      //�@�J�E���g�_�E���J�n�b�����Z�b�g
        //minute = CountDownTime / 60;
        timer = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //�o�ߎ����������Ă���
        CountDownTime -= Time.deltaTime;


        // 0.0�b�ɂȂ�����J�E���g�_�E���^�C����0.0�ŌŒ�(�~�܂����悤�Ɍ�����)
        if (CountDownTime <= 0.0f)
        {

            SceneManager.LoadScene("getScene");

            if (rand < 30)
            {
                //1��
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
                //2��
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
                //3��
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
                //4��
                item4.SetActive(true);
            }

            Debug.Log("�I��");
            CountDownTime = 0.0f;
            if (num < 90)   // 90%�̊m���Ŏ���
            {
                timer.text = "�}�E";
                Destroy(sankaku);       // �I�u�W�F�N�g������
            }
            else    // 10%�̊m���Ő�����
            {
                timer.text = "����";    // ���������Ƃ��e�L�X�g�ŕ\��
            }

            Destroy(start);                 // �J�n�{�^�����\��
        }
        else
        {
            //�J�E���g�_�E���^�C�����`���ĕ\��
            timer.text = string.Format("{0:00}�b", CountDownTime);
            Debug.Log(CountDownTime);
        }

    }
}
