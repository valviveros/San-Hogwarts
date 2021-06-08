using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ConfigScreen_lose : MonoBehaviour
{
    public GameObject ButtonStart;
    public GameObject ButtonMenu;
    public GameObject TitleLose;
    // Start is called before the first frame update
    public void OnGameObject(){ 
        ButtonStart.SetActive(true);
        ButtonMenu.SetActive(true);
        TitleLose.SetActive(true);
      

    }

    public void Menu(){
        SceneManager.LoadScene("Menu");
    }

    public void Restart(){
       
        SceneManager.LoadScene("Potions");
    }
}
