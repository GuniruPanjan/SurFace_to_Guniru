using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;// シーン切り換えに使用するライブラリ

public class upbringing : MonoBehaviour
{
   public void OnClickGameSceneButton()
   {
        SceneManager.LoadScene("gameScene");
   }
}
