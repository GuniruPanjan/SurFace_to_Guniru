using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeSceneTrans : MonoBehaviour
{
    //ホームシーンへ移行
    public void OnClickToHomeSceneBotton()
    {
        SceneManager.LoadScene("HomeScene");
    }
}
