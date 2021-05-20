using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.UI;

public class SearchText : MonoBehaviour
{
    
    public TextosObjj textos2;
   
    void Start(){
        
    
        FindObjectOfType<MissionControl>().ActivateBuble(textos2);

    }
}
