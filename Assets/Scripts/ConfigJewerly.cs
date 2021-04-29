using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigJewerly : MonoBehaviour
{
    public GameObject jewerly;
    public AudioSource audioData;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D colition){

        audioData.Play();
        jewerly.SetActive(false);
        
       
    }
   
}
