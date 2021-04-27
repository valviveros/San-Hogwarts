using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class CharacterSelector : MonoBehaviour
{
    public GameObject[] characterList;
    bool pressedWitch = false;
    bool pressedWizard = false;
    static public int index;
    public GameObject canvas;
    public GameObject fadeInpanel;
    public GameObject fadeOutPanel;
    public float fadeWait;

    // Start is called before the first frame update
    void Start()
    {
        characterList[0].gameObject.SetActive(true);
        characterList[1].gameObject.SetActive(false);
        pressedWitch = true;
    }

    public void onClick()
    {
        if (EventSystem.current.currentSelectedGameObject.name == "Witch")
        {
            characterList[0].gameObject.SetActive(true);
            characterList[1].gameObject.SetActive(false);
            pressedWitch = true;
            pressedWizard = false;
        }
        if (EventSystem.current.currentSelectedGameObject.name == "Wizard")
        {
            characterList[0].gameObject.SetActive(false);
            characterList[1].gameObject.SetActive(true);
            pressedWitch = false;
            pressedWizard = true;
        }
    }

    private void Awake()
    {
        if (fadeInpanel != null)
        {
            GameObject panel = Instantiate(fadeInpanel, Vector3.zero, Quaternion.identity) as GameObject;
            Destroy(panel, 1);
        }
    }

    public void CallCouroutine(string sceneName)
    {
        StartCoroutine(SceneToLoad(sceneName));
    }

    public IEnumerator SceneToLoad(string sceneName)
    {
        if (pressedWitch)
        {
            index = 0;
        }
        else if (pressedWizard)
        {
            index = 1;
        }
        if (fadeOutPanel != null)
        {
            Instantiate(fadeOutPanel, Vector3.zero, Quaternion.identity);
        }
        yield return new WaitForSeconds(fadeWait);
        canvas.SetActive(false);
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneName);
        while (!asyncOperation.isDone)
        {
            yield return null;
        }
    }
}
