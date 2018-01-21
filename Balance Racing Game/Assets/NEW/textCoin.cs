using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textCoin : MonoBehaviour {

	public Text coin;
	public Text coin2;
	public Text fuel;
	public Text livePoint;
	//--------------------
	public Text statusBuyFuel;
	public Text statusBuyLP;
	public Text statusBuyStage2;
	public Text statusBuyStage3;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		coin.text = "Your coin(s) : "+init.coin;
		fuel.text = "Your Fuel(s) : " + init.fuel;
		livePoint.text = "Your Live Point(s) : " + init.livePoint;

		if (init.isFuelMax == false) {
			statusBuyFuel.text = ""+init.fuelPrice+" Coins";
		} else {
			statusBuyFuel.text = "Already MAX";
		}

		if (init.isLpMax == false) {
			statusBuyLP.text = ""+init.LpPrice+" Coins";
		} else {
			statusBuyLP.text = "Already MAX";
		}


		if (init.isOpenMap2 == false) {
			statusBuyStage2.text = "7500 Coins";
		} else {
			statusBuyStage2.text = "Purchased";
		}

		if (init.isOpenMap3 == false) {
			statusBuyStage3.text = "20000 Coins";
		} else {
			statusBuyStage3.text = "Purchased";
		}


	}
}
