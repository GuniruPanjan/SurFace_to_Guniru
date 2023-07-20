using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class HomeScene : MonoBehaviour
{
    //ƒz[ƒ€‰æ–Ê‚Ö
    public void OnClickHomeSceneButton()
    {
        SceneManager.LoadScene("homeScene");
    }
}
