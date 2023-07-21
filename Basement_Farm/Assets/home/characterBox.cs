using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class characterBox : MonoBehaviour
{
    public void OnClickCharaBoxButton()
    {
        SceneManager.LoadScene("CharaBox");
    }
}
