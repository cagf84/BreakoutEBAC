using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuFinNivel : MonoBehaviour
{

/**
    * Administra las acciones del Menu: \n
    * Siguiente Nivel \n
*/
    public void SiguienteNivel()
    {
        var siguienteNivel1 = SceneManager.GetActiveScene().buildIndex + 1;
        if (SceneManager.sceneCountInBuildSettings > siguienteNivel1)
        {
            SceneManager.LoadScene(siguienteNivel1);
        }
        else
        {
            CargarMenuPrincipal();
        }
    }

/**
    * Administra las acciones del Menu: \n
    * Cargar MenuPrincipal \n
*/
    public void CargarMenuPrincipal()
    {
        SceneManager.LoadScene(0);
    }

/**
    * Administra las acciones del Menu: \n
    * Reintentar Nivel \n
*/
    public void ReintentarNivel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
    }
}

