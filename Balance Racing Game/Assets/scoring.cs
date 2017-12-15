using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class scoring : MonoBehaviour {

	public Text scoring2;
	public int score = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		updateScore();	
	}

	public void updateScore(){
		scoring2.text = score + " score";

	}

}
