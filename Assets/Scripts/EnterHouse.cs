using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class EnterHouse : MonoBehaviour
{
    [SerializeField]
    private int zonas;
    public GameObject NoVolver;
    public GameObject Panelfin;

    private InventoryS inv;
    // Start is called before the first frame update
    public void Update()
    {
        inv = FindObjectOfType<InventoryS>();


    }
    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.CompareTag("Player"))
        {


            if (inv.zonas == 12)
            {
                Debug.Log("completo");
                Panelfin.SetActive(true);

            }
            else
            {
                Debug.Log("No se ha completado");
                NoVolver.SetActive(true);
            }



        }


    }
}
