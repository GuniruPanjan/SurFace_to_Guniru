using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class HomeScene : MonoBehaviour
{
    //ホーム画面へ
    public void OnClickHomeSceneButton()
    {
        SceneManager.LoadScene("homeScene");
    }
}
