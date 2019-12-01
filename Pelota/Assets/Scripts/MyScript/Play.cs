using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    // Start is called before the first frame update

        //METODO PARA CAMBIAR DE ESCENA
   public void menu()
    {
        SceneManager.LoadScene("Mapa01");
    }

    //METODO SALIR DEL PROGRAMA
    public void quit()
    {
        Application.Quit();
    }
   
}
