using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{

    public GameObject menuPausa;
    public GameObject menuOpciones;

/**
    * Administra las acciones del Menu: \n
    * Mostrar MenuPausa \n
*/
    public void MostrarMenuPausa()
    {
        menuPausa.SetActive(true);
        if (menuOpciones.activeInHierarchy) menuOpciones.SetActive(false);
    }

/**
    * Administra las acciones del Menu: \n
    * Ocultar MenuPausa \n
*/
    public void OcultarMenuPausa()
    {
        menuPausa.SetActive(false);
    }

/**
    * Administra las acciones del Menu: \n
    * Regresar A Pantalla Principal \n
*/
    public void RegresarAPantallaPrincipal()
    {
        SceneManager.LoadScene(0);
    }

/**
    * Administra las acciones del Menu: \n
    * Mostrar MenuOpciones \n
*/
    public void MostrarMenuOpciones()
    {
        menuPausa.SetActive(false);
        menuOpciones.SetActive(true);
    }
}
