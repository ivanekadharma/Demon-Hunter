﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour {

	// Use this for initialization
	public Transform tempPost;
	private float x,y,z;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter2D(Collider2D other){
		if (other.CompareTag("Player")) {
			
			Destroy (gameObject);
		}

	}
}
