﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstObjective : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject InitMission;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col){
        if (col.gameObject.tag == "Player")
        {
            InitMission.SetActive(true);
        }
    }
}