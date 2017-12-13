using UnityEngine;
using System.Collections;

public class SwitchColorOnTrigger : MonoBehaviour {
	private Renderer rnd;
	public Color normalColor;
	public Color triggerColor;

	void Start() {
		rnd = GetComponent<Renderer> ();
	}

	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "Player") {
			rnd.material.color = triggerColor;
		}
	}

	void OnTriggerExit(Collider col) {
		if (col.gameObject.tag == "Player") {
			rnd.material.color = normalColor;
		}
	}
}
