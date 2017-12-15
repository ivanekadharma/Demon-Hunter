using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyCoin : MonoBehaviour {



	public AudioSource abc;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player") {
			abc.Play ();
			Destroy (gameObject);
			other.GetComponent<scoring> ().score++;
		}

	}
}
