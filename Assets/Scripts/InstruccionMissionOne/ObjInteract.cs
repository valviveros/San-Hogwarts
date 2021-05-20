using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjInteract : MonoBehaviour
{
    public TextoMission text;
    void Start(){
        FindObjectOfType<DialogueControl2>().ActivateBuble(text);
    }
}
