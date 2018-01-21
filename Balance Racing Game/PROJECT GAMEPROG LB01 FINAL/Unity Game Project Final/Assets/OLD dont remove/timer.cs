using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {

	public Text timerText;
	public float secondsCount;
	public int minuteCount;
	public int hourCount;
	private string tempText = "Time        : ";
	public static string resultTimer = "";
	public int gameStop=0;
	void Update(){
		//if (Goal.gameOver == false) {
			UpdateTimerUI ();
		//} else if (Goal.gameOver == true){
		//	if(secondsCount<10 && minuteCount<10 && hourCount<10){
		//		resultTimer = "0" + hourCount + ";" + "0" + minuteCount + ";" + "0" + (int)secondsCount + "s";
		//	}else if(minuteCount<10&&hourCount<10){
		//		resultTimer = "0"+ hourCount +";"+ "0"+minuteCount +";"+(int)secondsCount + "s";
		//	}else if(hourCount<10){
		//		resultTimer = "0"+ hourCount +";"+ minuteCount +";"+(int)secondsCount + "s";
		//	}
		//}
	}
	//call this on update
	public void UpdateTimerUI(){
		//set timer UI
			secondsCount += Time.deltaTime;
			if(secondsCount<10 && minuteCount<10 && hourCount<10){
				timerText.text = tempText +"0"+hourCount +";"+"0"+ minuteCount+";" +"0"+(int)secondsCount + "s";
				//resultTimer = "0" + hourCount + ";" + "0" + minuteCount + ";" + "0" + (int)secondsCount + "s";
			}else if(minuteCount<10&&hourCount<10){
				timerText.text = tempText +"0"+ hourCount +";"+ "0"+minuteCount +";"+(int)secondsCount + "s";
				//resultTimer = "0"+ hourCount +";"+ "0"+minuteCount +";"+(int)secondsCount + "s";
			}else if(hourCount<10){
				timerText.text = tempText +"0"+ hourCount +";"+ minuteCount +";"+(int)secondsCount + "s";
				//resultTimer = "0"+ hourCount +";"+ minuteCount +";"+(int)secondsCount + "s";
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
