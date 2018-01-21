using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inGame : MonoBehaviour {

	// Use this for initialization

	//panel status atas
	public Text coin;
	public Text fuel;
	public Text livePoint;
	public Text timer;
	//-----------------

	//panel Final Result
	public Text finalGetCoin;
	public Text finalGetTimer;
	//-----------------
	void Start () {
		Screen.SetResolution (1024 , 768, false, 60);
	}
	
	// Update is called once per frame
	void Update () {
		if (init.isGameOver != true) {
			generateScore ();
			generateFuel ();
			generateLivePoint ();
			generateTimer ();
		} else {
			generateScoreResult ();
			generateTimerResult ();
		}
	}

	public void generateScoreResult(){
		finalGetCoin.text = "" + init.tempCoin;
	}
	public void generateTimerResult(){
		if(init.sec<10 && init.min<10 && init.hour<10){
			finalGetTimer.text = "0" + init.hour + ";" + "0" + init.min + ";" + "0" + (int)init.sec + "s";
		}else if(init.min<10&&init.hour<10){
			finalGetTimer.text = "0"+ init.hour +";"+ "0"+init.min +";"+(int)init.sec + "s";
		}else if(init.hour<10){
			finalGetTimer.text = "0"+ init.hour +";"+ init.min +";"+(int)init.sec + "s";
		}
	}

	public void generateScore(){
		coin.text = "Score       : "+init.updateCoin;
	}

	public void generateTimer(){
		init.updateTimerFunc (timer);
	}

	public void generateFuel(){
		fuel.text = "Fuel         : " + init.updateFuel;
		init.updateFuelFunc ();
	}

	public void generateLivePoint(){
		livePoint.text = ""+init.updateLivePoint;
	}
}
