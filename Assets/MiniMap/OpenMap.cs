using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMap : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Map;
    public GameObject pointer;

    public void OpenMAp(){
        Map.SetActive(true);
        pointer.SetActive(true);
    }   

    public void CloseMAp(){
        Map.SetActive(false);
        pointer.SetActive(false);
    }   
}
