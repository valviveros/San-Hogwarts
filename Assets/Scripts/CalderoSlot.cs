using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CalderoSlot : MonoBehaviour, IDropHandler 
{
    public GameObject pointer;
    public GameObject CloseMission;
    public GameObject[] arrayIngredients;
    private Queue <GameObject> colaIngredients2 = new Queue<GameObject>();
    private GameObject[] arrayIngredients2;
    public GameObject Cortina;
    public GameObject Ganaste_item;
    public GameObject PotionBlue;
    public void OnDrop(PointerEventData eventData){
        
       if (eventData.pointerDrag != null)
        {    
            colaIngredients2.Enqueue(eventData.pointerDrag);
            arrayIngredients2 = colaIngredients2.ToArray();

            for (int i = 0; i < arrayIngredients2.Length; i++)
            {
                if (arrayIngredients2[i] == arrayIngredients[i])
                {
                    eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                    Debug.Log("igual");
                   if (arrayIngredients2[0] == arrayIngredients[0] && arrayIngredients2[1] == arrayIngredients[1] && arrayIngredients2[2] == arrayIngredients[2])
                    {   
                        PotionBlue.SetActive(true);
                        Ganaste_item.SetActive(true);
                        CloseMission.SetActive(false);
                        pointer.SetActive(true);
                        Destroy(CloseMission);
                    }
                    else{
                        Debug.Log("paila");
                        Cortina.SetActive(true);
                    }
                }else{
                    Debug.Log("paila");
                    Cortina.SetActive(true);
                }  
                 
            }
        }
    }
   
}
