﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour {

	public int playerSpeed = 10;
	private bool facingRight = true;
	public int playerJumpPower = 1250;
	private float moveX;
		
	// Use this for initialization
	// void Start () {	}
	
	// Update is called once per frame
	void Update () {
		PlayerMove ();	
	}

	void PlayerMove(){
		//Controls
		moveX = Input.GetAxis("Horizontal");
		if(Input.GetButtonDown("Jump")){
			Jump (); 
		}

		//Direction
		if (moveX < 0.0f && facingRight) {
			FlipPlayer ();		
		} else if (moveX > 0.0f && !facingRight) {
			FlipPlayer ();
		}

		//Animation
		gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
			
		//Physics
	}

	void Jump(){
		//Vertical
		gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerJumpPower);

	}

	void FlipPlayer(){
		facingRight = !facingRight;
		Vector2 localScale = gameObject.transform.localScale;
		localScale.x *= -1;
		transform.localScale = localScale;
	}
}
