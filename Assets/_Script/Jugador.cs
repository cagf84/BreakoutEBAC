using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    [SerializeField] public int limiteX = 23;
    [SerializeField] public float VelocidadPaddle = 20f;

    Transform transform;
    Vector3 mousePos2D;
    Vector3 mousePos3D;
    // Start is called before the first frame update
    void Start()
    {
        transform = this.gameObject.transform;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bola")
        {
            Vector3 direccion = collision.contacts[0].point - transform.position;
            direccion = direccion.normalized;
            collision.rigidbody.velocity = collision.gameObject.GetComponent<Bola>().velocidadBola * direccion;
        }
    }
    // Update is called once per frame
    //void Update()
    //{
    //Teclado       
    //if (Input.GetKey(KeyCode.RightArrow))
    //{
    //    //mueve el objeto a la derecha
    //    transform.Translate(Vector3.down * VelocidadPaddle * Time.deltaTime);
    //}
    //if (Input.GetKey(KeyCode.LeftArrow))
    //{
    //    //mueve el objeto a la izquierda
    //    transform.Translate(Vector3.up * VelocidadPaddle * Time.deltaTime);
    //}
    //Vector3 pos = this.transform.position;
    //if (pos.x < -limiteX)
    //{
    //    pos.x = -limiteX;
    //}
    //else if (pos.x > limiteX)
    //{
    //    pos.x = limiteX;
    //}
    //transform.position = pos;



    //Mouse
    //mousePos2D = Input.mousePosition;
    //mousePos2D.z = -Camera.main.transform.position.z;
    //mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
    //Vector3 pos = this.transform.position;
    //pos.x = mousePos3D.x;
    //if (pos.x < -limiteX)
    //{
    //    pos.x = -limiteX;
    //}
    //else if (pos.x > limiteX)
    //{ 
    //    pos.x = limiteX;
    //}
    //this.transform.position = pos;

    //Mando y teclado
    //transform.Translate(Input.GetAxis("Horizontal") * Vector3.down * VelocidadPaddle * Time.deltaTime);
//}
void Update()
        {
            //Mouse
            if (Input.GetAxis("Mouse X") < 0 || Input.GetAxis("Mouse X") > 0)
            {
                mousePos2D = Input.mousePosition;
                mousePos2D.z = -Camera.main.transform.position.z;
                mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
                Vector3 pos1 = this.transform.position;
                pos1.x = mousePos3D.x;
                if (pos1.x < -limiteX)
                {
                    pos1.x = -limiteX;
                }
                else if (pos1.x > limiteX)
                {
                    pos1.x = limiteX;
                }
                this.transform.position = pos1;
            }

            //Mando y teclado
            transform.Translate(Input.GetAxis("Horizontal") * Vector3.down * VelocidadPaddle * Time.deltaTime);
            Vector3 pos = this.transform.position;
            if (pos.x < -limiteX)
            {
                pos.x = -limiteX;
            }
            else if (pos.x > limiteX)
            {
                pos.x = limiteX;
            }
            transform.position = pos;
        
    }
}
