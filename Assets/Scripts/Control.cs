using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Control : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform objetivo;
    public NavMeshAgent agente;

     void Start()
    {
        agente = GetComponent<NavMeshAgent>();
        agente.updateRotation = false;
        agente.updateUpAxis = false;
    }

    // Update is called once per frame
    void Update()
    {
        agente.destination = objetivo.position;
    }
}
