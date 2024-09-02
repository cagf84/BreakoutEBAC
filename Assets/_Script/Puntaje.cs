using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Puntaje : MonoBehaviour
{
    public Transform transformPuntajeAlto;
    public Transform transformPuntajeActual;
    public TMP_Text textoPuntajeAlto;
    //public TMP_Text textoPuntajeActual;
    public TMP_Text textoActual;
    public PuntajeAlto puntajeAltoSO;

    //public int puntos = 0;
    //public int puntajeAlto = 1000;

    // Start is called before the first frame update
    void Start()
    {
        transformPuntajeActual = GameObject.Find("PuntajeActual").transform;
        transformPuntajeAlto = GameObject.Find("PuntajeAlto").transform;
        //textoPuntajeActual = transformPuntajeActual.GetComponent<TMP_Text>();
        textoActual = transformPuntajeActual.GetComponent<TMP_Text>();
        textoPuntajeAlto = transformPuntajeAlto.GetComponent<TMP_Text>();
        //if (PlayerPrefs.HasKey("PuntajeAlto"))
        //{
        //puntajeAlto = PlayerPrefs.GetInt("PuntajeAlto");
        //textoPuntajeAlto.text = $"PuntajeAlto: {puntajeAlto}";
        //}
        puntajeAltoSO.Cargar();
        textoPuntajeAlto.text = $"PuntajeAlto: {puntajeAltoSO.puntajeAlto}";
        puntajeAltoSO.puntaje = 0;

    }

    private void FixedUpdate()
    {
        //puntos += 50;
        //puntajeAltoSO.puntaje += 50;
    }

    // Update is called once per frame
    void Update()
    {
        //textoPuntajeActual.text = $"PuntajeActual: {puntos}";
        //if (puntos > puntajeAlto)
        //{
        //    puntajeAlto = puntos;
        //    textoPuntajeAlto.text = $"PuntajeAlto: {puntajeAlto}";
        //    PlayerPrefs.SetInt("PuntajeAlto", puntos);
        //}
        textoActual.text = $"PuntajeActual: {puntajeAltoSO.puntaje}";
        if (puntajeAltoSO.puntaje > puntajeAltoSO.puntajeAlto)
        {
            puntajeAltoSO.puntajeAlto = puntajeAltoSO.puntaje;
            textoPuntajeAlto.text = $"PuntajeAlto: {puntajeAltoSO.puntajeAlto}";
            puntajeAltoSO.Guardar();
        }
    }

    public void AumentarPuntaje(int puntos)
    {
        puntajeAltoSO.puntaje += puntos;
    }







}
