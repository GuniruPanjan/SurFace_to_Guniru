using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;// シーン切り換えに使用するライブラリ


public class charaBox : MonoBehaviour
{
    public void OnClickCharaBoxButton()
    {
        SceneManager.LoadScene("CharaBox");
    }
}
