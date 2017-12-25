using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyCoin5 : MonoBehaviour {

	public AudioSource coin5Song;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}


	public void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player") {
			coin5Song.Play ();
			Destroy (gameObject);
			other.GetComponent<scoring> ().score+=5;
		}

	}
}
