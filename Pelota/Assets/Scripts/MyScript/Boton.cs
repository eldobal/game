using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boton : MonoBehaviour
{

    public void PlayScene() {
        SceneManager.LoadScene("Menu 3D");
    }

    public void Quitgame() {
        Application.Quit();
    }
}
