using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public GameObject MenuOpciones;
    public GameObject MenuInicial;

/**
    * Administra las acciones del Menu: \n
    * Iniciar Juego \n
*/
    public void IniciarJuego()
    {
        SceneManager.LoadScene(1);
    }

/**
    * Administra las acciones del Menu: \n
    * Finalizar Juego \n
*/
    public void FinalizarJuego()
    {
        Application.Quit();
    }

/**
    * Administra las acciones del Menu: \n
    * Mostrar Opciones \n
*/
    public void MostrarOpciones()
    {
        MenuInicial.SetActive(false);
        MenuOpciones.SetActive(true);
    }

/**
    * Administra las acciones del Menu: \n
    * Menu Principal \n
*/
    public void MostrarMenuInicial()
    {
        MenuOpciones.SetActive(false);
        MenuInicial.SetActive(true);
    }

}
