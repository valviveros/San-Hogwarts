using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class PointerConfig : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pointer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AlertObservers()
    {
        
       
       pointer.SetActive(true);
            
    }
}
