using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour {

	// Use this for initialization
	public Text timerText;
	public Text scoring;
	float secondsCount;
	public int score = 0;


	void Start(){
		secondsCount = 30;
	
	}

	void Update(){
		UpdateTimerUI ();
		UpdateScore ();	
	}
	//call this on update
	public void UpdateTimerUI(){
		//set timer UI
		secondsCount -= Time.deltaTime;
		if (secondsCount >= 0) {
			timerText.text = (int)secondsCount + "s";
		} else {
			timerText.text = "Game Over";
		}
	}
	public void UpdateScore(){
		//set score UI
		scoring.text = score + " Demon Destroyed";
	}
}
