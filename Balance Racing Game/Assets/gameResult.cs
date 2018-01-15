using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameResult : MonoBehaviour {

	// Use this for initialization
	public Text coinResult;
	public Text timeResult;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		updateResult ();
	}

	public void updateResult(){
		
		coinResult.text = "" + scoring.resultScore;
		timeResult.text = "" + timer.resultTimer;
	}
}
