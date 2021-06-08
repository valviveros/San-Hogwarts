using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Control : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform objetivo;
    public NavMeshAgent agente;
    private Animator anim;
    Vector3 initialPosition, target;
    public float movSpeed;

    void Start()
    {
        agente = GetComponent<NavMeshAgent>();
        agente.updateRotation = false;
        agente.updateUpAxis = false;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
 
        float distance = Vector3.Distance(transform.position, objetivo.position);
        if (distance>1.5)
        {
            agente.destination = objetivo.position;
            Vector3 dir = objetivo.position - transform.position;
            ChangeAnim(dir);
            anim.SetBool("wakeUp", true);
        }
        else
        {
            anim.SetBool("wakeUp", false);
        }

    }
    private void SetAnimFloat(Vector2 setVector)
    {
        anim.SetFloat("moveX", setVector.x);
        anim.SetFloat("moveY", setVector.y);
    }
    private void ChangeAnim(Vector2 direction)
    {
        if (Mathf.Abs(direction.x) > Mathf.Abs(direction.y))
        {
            if (direction.x > 0)
            {
                SetAnimFloat(Vector2.right);
            }
            else if (direction.x < 0)
            {
                SetAnimFloat(Vector2.left);
            }
        }
        else if (Mathf.Abs(direction.x) < Mathf.Abs(direction.y))
        {
            if (direction.y > 0)
            {
                SetAnimFloat(Vector2.up);
            }
            else if (direction.y < 0)
            {
                SetAnimFloat(Vector2.down);
            }
        }
    }
}
