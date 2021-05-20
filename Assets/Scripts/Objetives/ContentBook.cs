using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContentBook : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject BookOpen;
    public GameObject Pointer;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenBook(){
        BookOpen.SetActive(true);
        Pointer.SetActive(false);
    }
    public void CloseBook(){
         BookOpen.SetActive(false);
    }
    
}
