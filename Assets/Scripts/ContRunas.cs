using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContRunas : MonoBehaviour
{
    public GameObject runas;
    public AudioSource audioData;
    private InventoryS inventoryS;
    public Sprite sprite;

    void Start()
    {
        inventoryS = GameObject.FindObjectOfType<InventoryS>();
        sprite = GetComponent<SpriteRenderer>().sprite;

    }
    void OnTriggerEnter2D(Collider2D collition)
    {
        if (collition.CompareTag("Player") && collition.isTrigger)
        {
            audioData.Play();
            Destroy(runas.gameObject);
            inventoryS.updateInventory(sprite);
        }
    }
}
