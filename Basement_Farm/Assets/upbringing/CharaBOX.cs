using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharaBOX : MonoBehaviour
{
    //キャラBOXへ
    //死ね
    public void OnClickCharaBOXSceneBotton()
    {
        SceneManager.LoadScene("CharaBox");
    }
}
