using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Opciones", menuName ="Herramientas/Opciones", order =1)]
public class Opciones : PuntajePersistente
{
    public float velocidadBola = 30;
    public dificultad NivelDificultad = dificultad.facil;

/**
    * Funcion para administrar dificultad del Juego
    * 
    *_Parametros_
    * 
    * __Ninguno__
    * 
*/
    public enum dificultad
    {
        facil,
        normal,
        dificil
    }

/**
    * Funcion para cambiar velocidad bola
    * 
    *_Parametros_
    * 
    * __nuevaVelocidad__ : _velocidad de la Bola_
    * 
*/
    public void CambiarVelocidad(float nuevaVelocidad)
    {
        velocidadBola = nuevaVelocidad;
    }

/**
    * Funcion que asigna la dificultad seleccionada
    * 
    *_Parametros_
    * 
    * __nuevaDificultad__ : _Dificultad del juego_
    * 
*/
    public void CambiarDificultad(int nuevaDificultad)
    {
        NivelDificultad = (dificultad)nuevaDificultad;
    }
}
