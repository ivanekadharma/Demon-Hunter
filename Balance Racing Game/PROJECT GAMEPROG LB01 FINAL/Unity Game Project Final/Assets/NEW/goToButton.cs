using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goToButton : MonoBehaviour {

	// Use this for initialization
	public GameObject player;
		
	public void gotoMap03(){
		init.map = 3;
		init.updateFuel = init.fuel;
		init.updateLivePoint = init.livePoint;
		player.transform.position = init.Map03;
		init.isGameOver = false;
	}
	public void gotoMap01(){
		init.map = 1;
		init.updateFuel = init.fuel;
		init.updateLivePoint = init.livePoint;
		player.transform.position = init.Map01;
		init.isGameOver = false;
	}
	public void gotoMap02(){
		init.map = 2;
		init.updateFuel = init.fuel;
		init.updateLivePoint = init.livePoint;
		player.transform.position = init.Map02;
		init.isGameOver = false;
	}
	public void resetFuelAndCoin(){
		init.redeclareFuelAndcoin ();
	}
}
