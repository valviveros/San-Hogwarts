using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COnfigPos : MonoBehaviour
{
    // Start is called before the first frame update
    
    // Start is called before the first frame update   public GameObject jewerly;
    public GameObject potion;

    public AudioSource audioData;
    // public AudioSource audioData2;

    private InventoryS inventoryS;

    public Sprite sprite;

    void Start()
    {
        inventoryS = GameObject.FindObjectOfType<InventoryS>();
        sprite = GetComponent<SpriteRenderer>().sprite;

    }
    void OnTriggerEnter2D(Collider2D collition){

        if (collition.CompareTag("Player") && collition.isTrigger)
        {
            audioData.Play();
            // audioData2.Play();
            potion.SetActive(false);
            inventoryS.updateInventory(sprite);

            
        }
    }
}
