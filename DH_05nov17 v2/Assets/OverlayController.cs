using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverlayController : MonoBehaviour {
    public bool isActive = false;

	// Use this for initialization
	void Start () {
        this.gameObject.SetActive(isActive);	
	}
	
	// Update is called once per frame
	void Update () {
        isActive = !isActive;
        this.gameObject.SetActive(isActive);
	}

    public void toggleActive()
    {
        isActive = !isActive;
        this.gameObject.SetActive(isActive);
    }
}
