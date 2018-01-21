using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyCheckpoint : MonoBehaviour {

	public static Vector3 checkpoint;
	public static int udahDapetCheckpoint = 0;
	public static float cpFuel = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter2D(Collider2D cp){
		if (cp.gameObject.tag == "checkpoints") {
			checkpoint = cp.transform.position;
			udahDapetCheckpoint = 1;
			cpFuel = fuel.countFuel;
			Destroy (cp.gameObject);
		}

	}
}
