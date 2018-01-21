using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class myCoin : MonoBehaviour {

	public static int myCoins = 0;
	public Text myCoinsText;
	//public TMP_Text myCoinsTextMeshPro; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		updateCoin ();
	}

	public void updateCoin(){
		myCoins += scoring.resultScore;
		myCoinsText.text = "Your Coin(s) : " + myCoins;
	}
}
