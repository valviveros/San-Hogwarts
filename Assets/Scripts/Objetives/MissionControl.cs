using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MissionControl : MonoBehaviour
{
   
  
    private Queue <string> colaDialogos2 = new Queue<string>(); // importante poner siempre new ya que así se inicializa 
    TextosObjj  texto2;
    [SerializeField] TextMeshProUGUI textoPantalla2;

    public void ActivateBuble(TextosObjj textoObjeto2){
        texto2 = textoObjeto2;
        ActivateTexto();
        
    }

    public void ActivateTexto(){
        
        // GetComponent<Animator>().enabled = false;
        Debug.Log("ActivateTexto: "+colaDialogos2);
        
        foreach (string textoGuardar2 in texto2.arrayTextos2)
        {
            colaDialogos2.Enqueue(textoGuardar2);
            
            
        }
        SiguienteFrase();
    }

    public void SiguienteFrase(){
        if (colaDialogos2.Count == 0)
        {
            // CierraCartel();
            
            Debug.Log("siguiente misión");            
        }
        string fraseActual2 = colaDialogos2.Dequeue();
        textoPantalla2.text = fraseActual2;
    }

    // void CierraCartel(){
    //     Object.SetActive(false);
    //     GetComponent<Animator>().enabled = true;
    //     Debug.Log("cerrar cartel");
       

    // }

    // void AnimateDialogue(){
    //     // anim.enabled=true;
    //     animate.GetComponent<Animator>().enabled = true;//activa animación
    //     // anim.Play("TransitionImg");
    // }
}
