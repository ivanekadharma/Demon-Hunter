using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SvDestroyEnemies : MonoBehaviour {

	float x; float y; float z;
	public Transform InstantiateMe2;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void OnTriggerEnter(Collider other){
		if(other.name == "Player"){
			Destroy (gameObject);
			x = Random.Range (-60, 55);
			z = Random.Range (-55, 55);
			y = 1.1f;
			var go = Instantiate (InstantiateMe2, transform.position = (new Vector3 (x, y, z)), Quaternion.identity);
		}
	}
}
