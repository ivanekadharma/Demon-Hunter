using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateEnemies : MonoBehaviour {

	// Use this for initialization
	public Transform InstantiateMe;
	public int totalEnemy = 20;
	float x; float y; float z;
	void Start () {
		for(int i = 0; i<=totalEnemy; i++){
			x = Random.Range (-60, 55);
			z = Random.Range (-55, 55);
			y = 1;
			var go = Instantiate (InstantiateMe, transform.position = (new Vector3 (x, y, z)), Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}