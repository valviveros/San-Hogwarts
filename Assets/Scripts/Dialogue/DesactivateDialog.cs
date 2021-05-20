using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesactivateDialog : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Dialogue;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void DesactivateDialogue(){
        Dialogue.SetActive(false);
        Destroy(Dialogue);
    }
}
