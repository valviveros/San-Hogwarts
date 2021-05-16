using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueMision : MonoBehaviour
{
    public GameObject book;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void activateObjective(){
        book.SetActive(true);
    }

    public void desactivateObjective(){
        book.SetActive(false);
    }
}
