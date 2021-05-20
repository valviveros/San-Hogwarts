using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punto : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform siguientenNodo;

    void Start()
    {
        //Set the tag of this GameObject to Player
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("0");
        if (other.gameObject.tag == "NPC")
        {
            Debug.Log("1");
            other.gameObject.GetComponent<Control>().objetivo = siguientenNodo;
        }
    }
}
