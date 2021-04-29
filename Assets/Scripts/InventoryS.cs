using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class InventoryS : MonoBehaviour
{
    public List<GameObject> Bag = new List<GameObject>();// lista para almacenar item
    public GameObject inv;  //inventario
    public bool Activar_inv; //desactivar o desactivar
    public GameObject Selector;
    public int ID;
    // public Button yourButton;
    public Vector2 position;
    void Start()
    {
       
        
    }
    void Update(){
        
    }
    void OnTriggerEnter2D(Collider2D coll){ //detectar contacto con un objeto
        if (coll.CompareTag("Item"))
        {  
            for (int i = 0; i < Bag.Count; i++) //tamaño de la lista
            {
                if (Bag[i].GetComponent<Image>().enabled == false) //componente imagen desactivado
                {
                    Bag[i].GetComponent<Image>().enabled = true; //si está desactivado entonces se activa
                    Bag[i].GetComponent<Image>().sprite = coll.GetComponent<SpriteRenderer>().sprite; //la imagen es igual al obj colisionado
                    break;
                }
            }
        }
    }
    public void open()
    {   
        inv.SetActive(true);
    }
    public void close(){
        inv.SetActive(false);
    }

    
}
