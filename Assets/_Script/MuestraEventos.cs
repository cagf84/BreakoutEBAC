using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MuestraEventos : MonoBehaviour
{
    public UnityEvent MiEventoUnity;
    public event EventHandler EnCasoDeEspacioPresionado; // OnSpacePressed
    // Start is called before the first frame update
    void Start()
    {
        EnCasoDeEspacioPresionado += EventoEscuchado;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            EnCasoDeEspacioPresionado.Invoke(this, EventArgs.Empty);
            MiEventoUnity.Invoke();
        }
    }

    public void EventoEscuchado(object sender, EventArgs e)
    {
        Debug.Log("El evento se escucho correctamente");
    }

    public void EventoUnityDisparado()
    {
        Debug.Log("El Evento Unity se disparo correctamente");
    }

}
