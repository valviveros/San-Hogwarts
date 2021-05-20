using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteractive : MonoBehaviour
{
  public Textos textos;
 
  // public GameObject aa;
  void Start(){
    
    // aa.SetActive(true);
    // Debug.Log("epa: " +textos.arrayTextos[1]);
    FindObjectOfType<DialogueControl>().ActivateBuble(textos);

  }

  //  void Start()
  //   {
  //     // Object.FindObjectOfType<DialogueControl>().ActivateBuble(textos);
  //     Debug.Log(Object.FindObjectOfType<DialogueControl>());
  //   }
}
