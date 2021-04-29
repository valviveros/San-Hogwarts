using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject loadingScreen;
    public GameObject canvas;
    public GameObject[] characterList;
    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(false);
        characterList[0].SetActive(false);
        characterList[1].SetActive(false);
    }

    public void onClick()
    {
        loadingScreen.SetActive(false);
        canvas.SetActive(true);
        characterList[0].SetActive(true);
    }
}
