using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreRunas : MonoBehaviour
{

    public Text puntos; 
    private int score;
    public GameObject Puerta1;
    
    void Start()
    {
        score = 0;
    }

    private void Update()
    {
        if (score>4)
        {
            puntos.text = "El laberinto esta abierto";
            Puerta1.SetActive(false);
        }
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "runas")
        {
            score++;
            puntos.text = "Runas:" + score;
        }
    }
}
