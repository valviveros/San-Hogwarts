using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPanel : MonoBehaviour
{
    public GameObject destroy;

    void Destroy(){
        Destroy(destroy);
    }
   
}
