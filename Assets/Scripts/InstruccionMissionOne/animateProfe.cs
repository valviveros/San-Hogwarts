using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animateProfe : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject animatep;
    
    void AnimatePanel(){
       
        animatep.GetComponent<Animator>().enabled = true;
        
        // animatep.SetActive(false);
        
    }
   
}
