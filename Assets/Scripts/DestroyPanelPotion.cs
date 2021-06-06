using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPanelPotion : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PanelPotions;
    
    public void kill()
    {
        Destroy(PanelPotions);

    }

    // Update is called once per frame


}
