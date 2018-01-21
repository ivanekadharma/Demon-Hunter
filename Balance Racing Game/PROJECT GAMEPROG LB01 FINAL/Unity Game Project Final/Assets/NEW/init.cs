using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class init : MonoBehaviour {

	public static int coin = 0;
	public static float fuel = 5;
	public static int time;
	public static int livePoint = 2;
	public static int map = 0;
	public static int updateCoin = 0;
	public static int tempCoin = 0;
	public static float updateFuel = fuel;
	public static int updateLivePoint = livePoint;
	public static bool isGameOver = true;

	//timer
	public static float secondsCount;
	public static int minuteCount;
	public static int hourCount;
	public static string tempText = "Time        : ";
	public static float sec;
	public static int min;
	public static int hour;
	//----

	//checkpoint
	public static bool checkPoint = false;
	public static Vector3 placeCheckPoint;
	//----

	//List spawn map
	public static Vector3 Map01 = new Vector3(-27,10);
	public static Vector3 Map02 = new Vector3(-520,331);
	public static Vector3 Map03 = new Vector3(-33,99);
	public static Vector3 mapRest = new Vector3(-157,95);
	//----

	public static bool isOpenMap2 = false;
	public static bool isOpenMap3 = false;
	public static bool isFuelMax = false;
	public static bool isLpMax = false;
	public static int buyMaxFuel = 25;
	public static int buyMaxLp = 5;
	public GameObject stage2Button;
	public GameObject stage3Button;
	public Text isEnoughCoin;
	public static int fuelPrice = 1000;
	public static int LpPrice = 2500;

	//----

	string inputedSecretKey;
	public TMP_InputField inputedField;
	public AudioSource isSecretKeyActivedSound;

	//----

	//---- load save data
	public static string keyBuyMaxLp = "keyBuyMaxLp";
	public static string keyBuyMaxFuel = "keyBuyMaxFuel";
	public static string keyFuelPrice = "keyFuelPrice";
	public static string keyLpPrice = "keyLpPrice";
	public static string keyCoin = "keyCoin";
	public static string keyFuel = "keyFuel";
	public static string keyLivePoint= "keyLivePoint";
	public static string keyIsOpenMap2 = "keyIsOpenMap2";
	public static string keyIsOpenMap3 = "keyIsOpenMap3";
	public static string keyIsFuelMax = "keyIsFuelMax";
	public static string keyIsLpMax = "keyIsLpMax";
	public static bool isSavedData = false;

	//----

	public static string[] tagTosSpawn = {
		"bensin", "bensin2", "bensin3", "coin5", "coin10", "coin20"
	};

	public static GameObject[] listFuel1;
	public static GameObject[] listFuel2;
	public static GameObject[] listFuel3;
	public static GameObject[] listCoin5;
	public static GameObject[] listCoin10;
	public static GameObject[] listCoin20;
	//----

	//Fuel
	//public static GameObject[] listFuel03 = GameObject.FindGameObjectsWithTag ("bensin3");
	//public static GameObject[] listFuel02 = GameObject.FindGameObjectsWithTag ("bensin2");
	//public static GameObject[] listFuel01 = GameObject.FindGameObjectsWithTag ("bensin");
	//----

	public static void redeclareFuelAndcoin(){
		/*foreach(string tag in tagTosSpawn){
			GameObject[] GameObjects = GameObject.FindGameObjectsWithTag (tag);
			foreach(GameObject go in GameObjects){
				go.SetActive (true);
			}
		}*/
		listFuel1 = GameObject.FindGameObjectsWithTag ("bensin");
		listFuel2 = GameObject.FindGameObjectsWithTag ("bensin2");
		listFuel3 = GameObject.FindGameObjectsWithTag ("bensin3");
		listCoin5 = GameObject.FindGameObjectsWithTag ("coin5");
		listCoin10 = GameObject.FindGameObjectsWithTag ("coin10");
		listCoin20 = GameObject.FindGameObjectsWithTag ("coin20");

		foreach(GameObject go in listFuel1){
			go.SetActive (true);
		}foreach(GameObject go in listFuel2){
			go.SetActive (true);
		}foreach(GameObject go in listFuel3){
			go.SetActive (true);
		}foreach(GameObject go in listCoin5){
			go.SetActive (true);
		}foreach(GameObject go in listCoin10){
			go.SetActive (true);
		}foreach(GameObject go in listCoin20){
			go.SetActive (true);
		}

	}

	public static void updateFuelFunc(){
		updateFuel -= (Time.deltaTime/2);
	}

	public static void updateTimerFunc(Text timerText){
		secondsCount += Time.deltaTime;
		if (secondsCount < 10 && minuteCount < 10 && hourCount < 10) {
			timerText.text = tempText + "0" + hourCount + ";" + "0" + minuteCount + ";" + "0" + (int)secondsCount + "s";
		} else if (minuteCount < 10 && hourCount < 10) {
			timerText.text = tempText + "0" + hourCount + ";" + "0" + minuteCount + ";" + (int)secondsCount + "s";
		} else if (hourCount < 10) {
			timerText.text = tempText + "0" + hourCount + ";" + minuteCount + ";" + (int)secondsCount + "s";
		}
		if (secondsCount >= 60) {
			minuteCount++;
			secondsCount = 0;	
		} else if (minuteCount >= 60) {
			hourCount++;
			minuteCount = 0;
		}
	}

	public void buyStage2(){
		if(isOpenMap2==false){
			if ((coin-7500)>=0) {
				isOpenMap2 = true;
				stage2Button.SetActive (true);
				coin -= 7500;
				isEnoughCoin.text = "";
				//GetComponent<textCoin>().statusBuyStage2.text = "Purchased";
			} else {
				isEnoughCoin.text = "Your coin is not Enough for Buying / Upgrading this Item";
			}
		}
	}
	public void buyStage3(){
		if(isOpenMap3==false){
			if ((coin-20000)>=0) {
				isOpenMap3 = true;
				stage3Button.SetActive (true);
				coin -= 20000;
				isEnoughCoin.text = "";
				//GetComponent<textCoin>().statusBuyStage3.text = "Purchased";
			} else {
				isEnoughCoin.text = "Your coin is not Enough for Buying / Upgrading this Item";
			}
		}
	}
	public void buyFuel(){
		if(isFuelMax==false){
			if ((coin - fuelPrice) >= 0) {
				coin -= fuelPrice;
				fuelPrice += 200;
				buyMaxFuel--;
				fuel++;
				isEnoughCoin.text = "";
				if (buyMaxFuel == 0) {
					isFuelMax = true;
				}
			} else {
				isEnoughCoin.text = "Your coin is not Enough for Buying / Upgrading this Item";
			}
		}
	}
	public void buyLp(){
		if(isLpMax==false){
			if((coin-LpPrice)>=0){
				coin -= LpPrice;
				LpPrice += 1500;
				buyMaxLp--;
				livePoint++;
				isEnoughCoin.text = "";
				if(buyMaxLp==0){
					isLpMax = true;
				}
			}else{
				isEnoughCoin.text = "Your coin is not Enough for Buying / Upgrading this Item";
			}
		}
	}


	public void generateSecretKey(){
		inputedSecretKey = inputedField.text;
		if(inputedSecretKey.Equals("Mohammad Alfi Shahri")){
			coin = 1901511380;
			for(int i=0;i<3;i++){
				isSecretKeyActivedSound.Play ();
			}
		}else if(inputedSecretKey.Equals("Ivan Ekadharma Yudianto")){
			coin = 1901460000;
			for(int i=0;i<3;i++){
				isSecretKeyActivedSound.Play ();
			}
		}else if(inputedSecretKey.Equals("Luthfia Fitriani")){
			coin = 1901459030;
			for(int i=0;i<3;i++){
				isSecretKeyActivedSound.Play ();
			}
		}
		inputedField.text = "";
		inputedSecretKey = "";
	}

	public void clearMsg(){
		isEnoughCoin.text = "";
		inputedField.text = "";
		inputedSecretKey = "";
	}

	public bool intToBool(int val){
		if (val != 0) {
			return true;
		} else {
			return false;
		}
	}

	public int boolToInt(bool val){
		if (val) {
			return 1;
		} else {
			return 0;
		}
	}

	public void saveData(){
		PlayerPrefs.SetInt (keyBuyMaxFuel,buyMaxFuel);
		PlayerPrefs.SetInt (keyBuyMaxLp,buyMaxLp);
		PlayerPrefs.SetInt (keyCoin,coin);
		PlayerPrefs.SetFloat (keyFuel,fuel);
		PlayerPrefs.SetInt (keyFuelPrice, fuelPrice);
		PlayerPrefs.SetInt (keyLivePoint, livePoint);
		PlayerPrefs.SetInt (keyLpPrice, LpPrice);

		PlayerPrefs.SetInt (keyIsOpenMap2,boolToInt(isOpenMap2));
		PlayerPrefs.SetInt (keyIsOpenMap3,boolToInt(isOpenMap3));
		PlayerPrefs.SetInt (keyIsFuelMax,boolToInt(isFuelMax));
		PlayerPrefs.SetInt (keyIsLpMax,boolToInt(isLpMax));
		Debug.Log ("data saved");

	}
	public void loadData(){
			buyMaxFuel = PlayerPrefs.GetInt (keyBuyMaxFuel);
			buyMaxLp = PlayerPrefs.GetInt (keyBuyMaxLp);
			coin = PlayerPrefs.GetInt (keyCoin);
			fuel = PlayerPrefs.GetFloat (keyFuel);
			fuelPrice = PlayerPrefs.GetInt (keyFuelPrice);
			livePoint = PlayerPrefs.GetInt (keyLivePoint);
			LpPrice = PlayerPrefs.GetInt (keyLpPrice);

			isOpenMap2 = intToBool (PlayerPrefs.GetInt (keyIsOpenMap2));
			isOpenMap3 = intToBool (PlayerPrefs.GetInt (keyIsOpenMap3));
			isFuelMax = intToBool (PlayerPrefs.GetInt (keyIsFuelMax));
			isLpMax = intToBool (PlayerPrefs.GetInt (keyIsLpMax));
			stage2Button.SetActive(isOpenMap2);
			stage3Button.SetActive(isOpenMap3);		
			Debug.Log ("data loaded");
	}
	public void resetData(){
		fuelPrice = 1000;
		LpPrice = 2500;
		buyMaxFuel = 25;
		buyMaxLp = 5;
		coin = 0;
		fuel = 5;
		livePoint = 2;
		isOpenMap2 = false;
		isOpenMap3 = false;
		isFuelMax = false;
		isLpMax = false;
		isSavedData = false;
		stage2Button.SetActive(isOpenMap2);
		stage3Button.SetActive(isOpenMap3);
		Debug.Log ("data reset");
	}

}
