using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class DialogueControl : MonoBehaviour
{
    private Animation anim;
    public GameObject Object;
    public GameObject animate;
   
    private Queue <string> colaDialogos = new Queue<string>(); // importante poner siempre new ya que así se inicializa 
    Textos texto;
    [SerializeField] TextMeshProUGUI textoPantalla;

    void Start(){
      
        // Debug.Log(animate);
    }
    public void ActivateBuble(Textos textoObjeto){
        // anim.SetBool("BubbleD",false);
        texto = textoObjeto;
        // Debug.Log("ActivateBuble: "+ texto.arrayTextos[1]);//hasta aquí llega el array
    }

    public void ActivateTexto(){
        GetComponent<Animator>().enabled = false;
        // Debug.Log("ActivateTexto: "+colaDialogos);
        // colaDialogos.Clear(); //no existe nada porque no llega la info
        foreach (string textoGuardar in texto.arrayTextos)
        {
            colaDialogos.Enqueue(textoGuardar);
        }
        SiguienteFrase();
    }

    public void SiguienteFrase(){
        if (colaDialogos.Count == 0)
        {
            CierraCartel();
            return;
        }
        string fraseActual = colaDialogos.Dequeue();
        textoPantalla.text = fraseActual;
    }

    void CierraCartel(){
        Object.SetActive(false);
        GetComponent<Animator>().enabled = true;
        // Debug.Log("cerrar cartel");
       

    }

    void AnimateDialogue(){
        // anim.enabled=true;
        animate.GetComponent<Animator>().enabled = true;//activa animación
        // anim.Play("TransitionImg");
    }

   

   
}
