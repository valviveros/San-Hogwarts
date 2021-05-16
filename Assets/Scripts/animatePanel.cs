using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatePanel : MonoBehaviour
{
    public GameObject animatep;
    
     void AnimatePanel(){
       
        animatep.GetComponent<Animator>().enabled = true;
        // animatep.SetActive(false);
        
    }

   
    
   
}
