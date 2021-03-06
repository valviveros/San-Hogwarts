using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private CharacterSelector characterSelector;
    public GameObject[] characterList;
    public GameObject[] buttonsList;
    static public int lives = 4;
    public int numOfHearts;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    public VectorValue startingPosition;


    // Start is called before the first frame update
    void Start()
    {
        OnSceneLoaded();
    }

    private void OnSceneLoaded()
    {
        if (CharacterSelector.index == 0)
        {
            characterList[0].SetActive(true);
            characterList[1].SetActive(false);
            buttonsList[0].SetActive(true);
            buttonsList[1].SetActive(false);
            buttonsList[2].SetActive(true);
            buttonsList[3].SetActive(false);
        }
        else if (CharacterSelector.index == 1) {
            characterList[0].SetActive(false);
            characterList[1].SetActive(true);
            buttonsList[0].SetActive(false);
            buttonsList[1].SetActive(true);
            buttonsList[2].SetActive(false);
            buttonsList[3].SetActive(true);
        }
    }

    void FixedUpdate()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (lives > numOfHearts)
            {
                lives = numOfHearts;
            }
            if (i < lives)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }

    public void LifeManager()
    {
        if (lives > 1)
        {
            lives = lives - 1;
        } else
        {
            lives = 4;
            startingPosition.initialValue=new Vector2(0,0);
            SceneManager.LoadScene("Potions");
        }
    }
}
