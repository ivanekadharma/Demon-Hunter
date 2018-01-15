using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fuel : MonoBehaviour {

	public Text fuelStatus;
	public static float countFuel = 20;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (countFuel > 0) {
			updateFuel ();
		}
	}
	public void updateFuel(){
		countFuel -= (Time.deltaTime/2);
		fuelStatus.text = "Fuel         : "+countFuel;
	}
}
