using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControl2 : MonoBehaviour {

	public float velocity;
	private Rigidbody2D rigiBody;
	bool facingRight;
	private float movementHorizontal = 0f;
	private float movementVertical = 0f;
	public bool CanMove = true;


	void Start()
	{
		rigiBody = GetComponent<Rigidbody2D>();
		facingRight = true;
	}
	private void onDisable()
	{

	}

	void Flipping()
	{
		facingRight = !facingRight;
		transform.Rotate (Vector3.up * 180);
	}

	void FixedUpdate()
	{
		//HORIZONTAL MOVEMENT WITH FLIPPING <3
		movementHorizontal = Input.GetAxis ("Horizontal");
		if (movementHorizontal < 0) {
			rigiBody.velocity = new Vector3 (movementHorizontal 
				* velocity, rigiBody.velocity.y);
		}
		if (movementHorizontal > 0) {
			rigiBody.velocity = new Vector3 (movementHorizontal *
				velocity, rigiBody.velocity.y);
		}
		if(movementHorizontal < 0 && facingRight)
		{
			Flipping ();

		}
		if(movementHorizontal > 0 && !facingRight)
		{
			Flipping ();
		}
		//VERTICAL MOVEMENT, NO FLIPPING
		movementVertical = Input.GetAxis("Vertical");
		if (movementVertical < 0) {
			rigiBody.velocity = new Vector2(0,Mathf.Lerp(0, Input.GetAxis("Vertical")* velocity, 0.8f));
		}
		if (movementVertical > 0) { 
			rigiBody.velocity = new Vector2(0,Mathf.Lerp(0, Input.GetAxis("Vertical")* velocity, 0.8f));
		}

	}
}
