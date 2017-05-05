﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchPadController : MonoBehaviour {
	
	public float upForce = 200f;
	public GameObject dynamicObj;
	private Rigidbody2D rb2d;
	private Vector3 lastPos;
	/*public GameObject mainCam;
	Vector3 offset;
	public Vector3 PlayerlastPos = new Vector3(0f,0f,0f);*/


	void Start(){
		rb2d = dynamicObj.GetComponent<Rigidbody2D> ();
		lastPos = dynamicObj.transform.position;

		/*offset = mainCam.transform.position - this.transform.position;
		PlayerlastPos = gameObject.transform.position;*/
	} 

	public void playerJump(){
		rb2d.velocity = new Vector2(0f,0f);
		rb2d.AddForce (new Vector2(0,upForce*-1));


	}

	void FixedUpdate(){

		if (dynamicObj.transform.position.y > lastPos.y) {
			rb2d.gravityScale = 0f;
			rb2d.velocity = new Vector2(0f,0f);
		} else {
			rb2d.gravityScale = -1f;
		}

		if(dynamicObj.transform.position.y<lastPos.y){
			lastPos = dynamicObj.transform.position;
		}

		print (lastPos.y);
		print (dynamicObj.transform.position.y);
	}
}
