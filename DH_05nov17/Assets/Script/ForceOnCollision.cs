using UnityEngine;
using System.Collections;

public class ForceOnCollision : MonoBehaviour {
	public float forcePower = 2000;

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.tag == "Player") {
			Vector3 heading = col.transform.position - transform.position;

			col.gameObject.GetComponent<Rigidbody> ().AddForce (heading * forcePower);
		}
	}
}
