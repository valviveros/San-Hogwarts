using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InterationInventary : MonoBehaviour
{
    public Button yourButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void elClick(){
        // Debug.Log(gameObject.name);

       
        
    }

    // Update is called once per frame
    void Update()
    {
        yourButton.onClick.AddListener(elClick);
    }
}
