﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyFuel : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}


	public void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player") {
			//coin5Song.Play ();
			Destroy (gameObject);
			fuel.countFuel+=3;
		}

	}
}
