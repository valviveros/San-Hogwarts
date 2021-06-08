using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour
{

    [Tooltip("Tiempo inicial en segundos")]
    public int tiempoInicial;

    [Tooltip("Escala del tiempo del reloj")]
    [Range(-10.0f, 10.0f)]

    public float escalaDeTiempo = 1;

    public Text myText;
    private float tiempoDelFrameConTimeScale = 0f;
    private float tiempoAMostrarEnSegundos = 0f;
    private float escalaDeTiempoAlPausar, escalaDeTiempoInicial;
    private bool estaPausado = false;

    void Start(){
        escalaDeTiempoInicial = escalaDeTiempo;

        myText = GetComponent<Text>();

        tiempoAMostrarEnSegundos = tiempoInicial;

        ActualizarReloj(tiempoInicial);
    }

    void Update (){
        tiempoDelFrameConTimeScale = Time.deltaTime * escalaDeTiempo;
        tiempoAMostrarEnSegundos += tiempoDelFrameConTimeScale;
        ActualizarReloj(tiempoAMostrarEnSegundos);

    }

   public void ActualizarReloj(float tiempoEnSegundos){
       int minutos = 0;
       int segundos = 0;
       string textoDelReloj;

       if (tiempoEnSegundos < 0) tiempoEnSegundos = 0;
       
       minutos = (int)tiempoEnSegundos / 60;
       segundos = (int)tiempoEnSegundos % 60;

       textoDelReloj = minutos.ToString("00") + ":" + segundos.ToString("00");

        myText.text = textoDelReloj;
   }
   
}
