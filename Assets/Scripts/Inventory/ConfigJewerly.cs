using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfigJewerly : MonoBehaviour
{
    public GameObject jewerly;
    public AudioSource audioData;
    public AudioSource audioData2;

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
            audioData2.Play();
            jewerly.SetActive(false);
            inventoryS.updateInventory(sprite);
        }
    }
}
