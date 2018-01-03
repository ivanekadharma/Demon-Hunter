﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {

	public Text timerText;
	private float secondsCount;
	private int minuteCount;
	private int hourCount;
	private string tempText = "Your time : ";
	void Update(){
		UpdateTimerUI();
	}
	//call this on update
	public void UpdateTimerUI(){
		//set timer UI
		secondsCount += Time.deltaTime;
		if(secondsCount<10 && minuteCount<10 && hourCount<10){
			timerText.text = tempText +"0"+hourCount +";"+"0"+ minuteCount+";" +"0"+(int)secondsCount + "s";
		}else if(minuteCount<10&&hourCount<10){
			timerText.text = tempText +"0"+ hourCount +";"+ "0"+minuteCount +";"+(int)secondsCount + "s";
		}else if(hourCount<10){
			timerText.text = tempText +"0"+ hourCount +";"+ minuteCount +";"+(int)secondsCount + "s";
		}
		//timerText.text = tempText + hourCount +"h;"+ minuteCount +"m;"+(int)secondsCount + "s";
		if(secondsCount >= 60){
			minuteCount++;
			secondsCount = 0;	
		}else if(minuteCount >= 60){
			hourCount++;
			minuteCount = 0;
		}    
	}

}