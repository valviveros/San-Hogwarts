using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueMision : MonoBehaviour
{
    public GameObject book;
     public GameObject pointer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void activateObjective(){
        book.SetActive(true);
        pointer.SetActive(false);
        
    }

    public void desactivateObjective(){
        book.SetActive(false);
    }
}
