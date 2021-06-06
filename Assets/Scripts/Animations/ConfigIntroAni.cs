using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ConfigIntroAni : MonoBehaviour
{
    public GameObject image;
    
    public GameObject video;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void activeVideo(){
        video.SetActive(true);
        image.SetActive(false);
    }

    public void zonas(){
        
       
        SceneManager.LoadScene("Menu");
    }
}
