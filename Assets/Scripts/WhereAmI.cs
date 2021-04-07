using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhereAmI : MonoBehaviour
{
    public GameObject room;
    static public Vector2 maxPosition;
    static public Vector2 minPosition;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player") && room.name == "WhereAmI")
        {
            maxPosition.x = 70.1f;
            maxPosition.y = 167.9f;
            minPosition.x = -91f;
            minPosition.y = 0f;
        } 
    }
}
