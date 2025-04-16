using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Bloque : MonoBehaviour
{
    public int resistencia = 1;
    public UnityEvent AumentarPuntaje;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bola")
        {
            RebotarBola(collision);
        }
    }

    /**
     * Funcion para rebotar la bola que colisione con este bloque, \n en este caso se hace virtual para que otros objetos puedan \n
     * heredar y hacer una sobrecarga al metodo 
     * 
     * _Parametros_
     * 
     * __colision__ : _el objeto con el que se ha detectado una colision en el evento OnCollisionEnter_
     * 
     */
    public virtual void RebotarBola(Collision collision)
    {
        Vector3 direccion = collision.contacts[0].point - transform.position;
        direccion = direccion.normalized;
        collision.rigidbody.velocity = collision.gameObject.GetComponent<Bola>().velocidadBola * direccion;
        resistencia--;
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (resistencia <= 0)
        {
            AumentarPuntaje.Invoke();
            Destroy(this.gameObject);
        }
    }

    public virtual void RebotarBola()
    {


    }
}
