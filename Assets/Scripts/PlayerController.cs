using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterSelector characterSelector;
    public GameObject[] characterList;

    // Start is called before the first frame update
    void Start()
    {
        OnSceneLoaded();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnSceneLoaded()
    {
        if (CharacterSelector.index == 0)
        {
            characterList[0].SetActive(true);
            characterList[1].SetActive(false);
        }
        else if (CharacterSelector.index == 1) {
            characterList[0].SetActive(false);
            characterList[1].SetActive(true);
        }
    }
}
