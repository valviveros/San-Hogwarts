using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class TopDownMoveScript : MonoBehaviour {
    private Rigidbody2D myRigidbody;
    private Vector3 change;
    private Animator animator;
    public float speed;
	private float dirX, dirY;

    // Start is called before the first frame update
    void Start() {
        animator = GetComponent<Animator>();
        myRigidbody = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update () {
        change = Vector3.zero;
        dirX = CrossPlatformInputManager.GetAxis("Horizontal");
        dirY = CrossPlatformInputManager.GetAxis("Vertical");
		change = new Vector3(dirX, dirY, 0);
        UpdateAnimationAndMove();
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
}
