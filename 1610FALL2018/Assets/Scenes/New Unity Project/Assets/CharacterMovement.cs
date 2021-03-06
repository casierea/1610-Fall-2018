﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent( typeof(CharacterController))]
public class CharacterMovement : MonoBehaviour
{

	public float speed = 6.0F;
	public float jumpSpeed = 8.0F;
	public float gravity = 20.0F;

	public FloatData MoveX, MoveY, MoveZ;

	private Vector3 moveDirection = Vector3.zero;
	private CharacterController controller;

	private void Start()
	{
		controller = GetComponent <CharacterController>();
	}

	void Update() {
		
			if (controller.isGrounded) {
				moveDirection.Set(MoveX.Value, MoveY.Value, MoveZ.Value);
				moveDirection = transform.TransformDirection(moveDirection);
				
				if (Input.GetButton("Jump"))
					moveDirection.y = jumpSpeed;
			}

			moveDirection.y -= gravity * Time.deltaTime;
			controller.Move(moveDirection * Time.deltaTime);
		}
		
	}
	
	// Use this for initialization
	//void Start () {
		
	//}
	
	// Update is called once per frame
	//void Update () {
		
	//}
//}
