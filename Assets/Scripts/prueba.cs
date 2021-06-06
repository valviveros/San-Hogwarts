using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class prueba : MonoBehaviour
{

    // Start is called before the first frame update
    public GameObject intro;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void scene(){
        intro.SetActive(false);
        
        SceneManager.LoadScene("Menu");
    }
}
