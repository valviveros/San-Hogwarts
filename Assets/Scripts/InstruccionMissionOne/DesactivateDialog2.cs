using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesactivateDialog2 : MonoBehaviour
{
    public GameObject Dialogue;
     public void DesactivateDialogue(){
        Dialogue.SetActive(false);
        Destroy(Dialogue);
    }
}
