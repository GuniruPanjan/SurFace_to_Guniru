using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countDown : MonoBehaviour
{
    public Text timer;
    float CountDownTime;    // �J�E���g�_�E��
    int num;

    [SerializeField] GameObject sankaku;


    // Start is called before the first frame update
    void Start()
    {
        num = Random.Range(0, 100);     // 0�`99�������_���ɏo��

        Debug.Log(num); // �R���\�[���Ƀ����_���ɏo��������\��

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
            Debug.Log("�I��");
            CountDownTime = 0.0f;
            if (num < 90)   // 90%�̊m���Ŏ���
            {
                timer.text = "�}�E";    // ���񂾂��Ƃ��e�L�X�g�ŕ\��
                Destroy(sankaku);       // �I�u�W�F�N�g������
            }
            else    // 10%�̊m���Ő�����
            {
                timer.text = "����";    // ���������Ƃ��e�L�X�g�ŕ\��
            }
        }
        else
        {
            //�J�E���g�_�E���^�C�����`���ĕ\��
            timer.text = string.Format("{0:00}�b", CountDownTime);
            Debug.Log(CountDownTime);
        }

    }
}
