using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityStandardAssets.CrossPlatformInput;

public enum PlayerState
{
    walk,
    attack,
    interact,
    stagger,
    idle
}

public class TopDownMoveScript : MonoBehaviour {
    public PlayerState currentState;
    private Rigidbody2D myRigidbody;
    private Vector3 change;
    private Animator animator;
    public float speed;
    private float auxSpeed;
	private float dirX, dirY;
    public VectorValue startingPosition;
    private bool aButtonPressed;
    private bool bButtonPressed;

    // Start is called before the first frame update
    void Start() {
        currentState = PlayerState.walk;
        animator = GetComponent<Animator>();
        myRigidbody = GetComponent<Rigidbody2D>();
        transform.position = startingPosition.initialValue;
        aButtonPressed = false;
        bButtonPressed = false;
	}

	// Update is called once per frame
	void Update () {
        change = Vector3.zero;
        dirX = CrossPlatformInputManager.GetAxis("Horizontal");
        dirY = CrossPlatformInputManager.GetAxis("Vertical");
		change = new Vector3(dirX, dirY, 0);
        if (aButtonPressed && currentState != PlayerState.attack && currentState != PlayerState.stagger)
        {
            StartCoroutine(AttackCo());
        }
        else if (currentState == PlayerState.walk)
        {
            UpdateAnimationAndMove();    
        }
	}

    private IEnumerator AttackCo()
    {
        animator.SetBool("attacking", true);
        currentState = PlayerState.attack;
        yield return null;
        animator.SetBool("attacking", false);
        yield return new WaitForSeconds(.8f);
        currentState = PlayerState.walk;
    }

    void UpdateAnimationAndMove()
    {
        if (change != Vector3.zero)
        {
            MoveCharacter();
            animator.SetFloat("moveX", dirX);
            animator.SetFloat("moveY", dirY);
            animator.SetBool("moving", true);
        }
        else
        {
            animator.SetBool("moving", false);
        }
    }

    void MoveCharacter()
    {
        myRigidbody.MovePosition(
            transform.position + change * speed * Time.deltaTime
        );
    }

    public void OnPointerDown() {
        aButtonPressed = true;
    }

    public void OnPointerUp()
    {
        aButtonPressed = false;
    }

    public void OnPointerBDown() {
        bButtonPressed = true;
        auxSpeed = speed;
        speed = 7;
    }

    public void OnPointerBUp()
    {
        bButtonPressed = false;
        speed = auxSpeed;
    }

    public void Knock(float knockTime)
    {
        StartCoroutine(KnockCo(knockTime));
    }

    private IEnumerator KnockCo(float knockTime)
    {
        if (myRigidbody != null)
        {
            yield return new WaitForSeconds(knockTime);
            myRigidbody.velocity = Vector2.zero;
            currentState = PlayerState.idle;
            myRigidbody.velocity = Vector2.zero;
        }
    }
}