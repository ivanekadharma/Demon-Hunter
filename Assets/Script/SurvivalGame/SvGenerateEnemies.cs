using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SvGenerateEnemies : MonoBehaviour {
	public Transform InstantiateMe;
	public int totalEnemy = 2;
	float x; float y; float z;
	void Start () {

		for(int i = 0; i<=totalEnemy; i++){
			x = Random.Range (-60, 55);
			z = Random.Range (-55, 55);
			y = 1.1f;
			var go2 = Instantiate (InstantiateMe, transform.position = (new Vector3 (x, y, z)), Quaternion.identity);
		}
	}

	// Update is called once per frame
	void Update () {

	}


	/*public void OnTriggerEnter(Collider other){
		if(other.gameObject.name == "SvEnemy"){
			Destroy (other.gameObject);
			x = Random.Range (-60, 55);
			z = Random.Range (-55, 55);
			y = 1.1f;
			var go = Instantiate (InstantiateMe, transform.position = (new Vector3 (x, y, z)), Quaternion.identity);
		}
	}*/

}
