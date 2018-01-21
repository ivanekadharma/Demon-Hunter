using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitObject : MonoBehaviour {

	// Use this for initialization
	public AudioSource effectHitCoin;
	private Quaternion tempRotation;
	float rotationTempSpeed = 1.0f;
	public static float cpFuel;
	public GameObject panelGameOver;

	public static GameObject[] listFuel1;
	public static GameObject[] listFuel2;
	public static GameObject[] listFuel3;
	public static GameObject[] listCoin5;
	public static GameObject[] listCoin10;
	public static GameObject[] listCoin20;

	void Start () {
		listFuel1 = GameObject.FindGameObjectsWithTag ("bensin");
		listFuel2 = GameObject.FindGameObjectsWithTag ("bensin2");
		listFuel3 = GameObject.FindGameObjectsWithTag ("bensin3");
		listCoin5 = GameObject.FindGameObjectsWithTag ("coin5");
		listCoin10 = GameObject.FindGameObjectsWithTag ("coin10");
		listCoin20 = GameObject.FindGameObjectsWithTag ("coin20");
	}
	
	// Update is called once per frame
	void Update () {
		isEmptyFuel ();
	}

	public void carCrash(){
		if(init.checkPoint!=true){
			init.updateLivePoint -= 1;
			//init.secondsCount = 0;
			//init.minuteCount = 0;
			//init.hourCount = 0;
			init.updateFuel = init.fuel;
			tempRotation = GetComponent<CarController> ().originalRotationValue;
			transform.rotation = Quaternion.Slerp (transform.rotation, tempRotation, Time.time*rotationTempSpeed);
			if(init.map==1){
				gameObject.transform.position = init.Map01;
			}else if(init.map==2){
				gameObject.transform.position = init.Map02;
			}else if(init.map==3){
				gameObject.transform.position = init.Map03;
			}
		}else{
			init.updateLivePoint -= 1;
			init.updateFuel = cpFuel;
			tempRotation = GetComponent<CarController> ().originalRotationValue;
			transform.rotation = Quaternion.Slerp (transform.rotation, tempRotation, Time.time*rotationTempSpeed);
			gameObject.transform.position = init.placeCheckPoint;
		}

		//----

		foreach(GameObject go in listFuel1){
			go.SetActive (true);
		}foreach(GameObject go in listFuel2){
			go.SetActive (true);
		}foreach(GameObject go in listFuel3){
			go.SetActive (true);
		}

	}

	public void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "coin5") {
			other.gameObject.SetActive (false);
			effectHitCoin.Play ();
			init.updateCoin += 5;
		}else if (other.gameObject.tag == "coin10") {
			other.gameObject.SetActive (false);
			effectHitCoin.Play ();
			init.updateCoin += 10;
		}else if(other.gameObject.tag == "coin20"){
			other.gameObject.SetActive (false);
			effectHitCoin.Play ();
			init.updateCoin += 20;
		}else if(other.gameObject.tag == "bensin" || other.gameObject.tag == "bensin2" || other.gameObject.tag == "bensin3"){
			other.gameObject.SetActive (false);
			init.updateFuel += 3;
		}else if(other.gameObject.tag == "checkpoints"){
			init.checkPoint = true;
			other.gameObject.SetActive (false);
			cpFuel = init.updateFuel;
			init.placeCheckPoint = other.transform.position;
		}else if(other.gameObject.tag == "goalpoint"){
			init.isGameOver = true;
			//--
			init.checkPoint = false;
	 		init.coin += init.updateCoin;
			init.tempCoin = init.updateCoin;
			init.updateCoin = 0;
			//--
			init.sec = init.secondsCount;
			init.min = init.minuteCount;
			init.hour = init.hourCount;

			init.secondsCount = 0;
			init.minuteCount = 0;
			init.hourCount = 0;
			//--
			init.updateFuel = init.fuel;
			//--
			init.updateLivePoint = init.livePoint;

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

			

			init.redeclareFuelAndcoin ();

			tempRotation = GetComponent<CarController> ().originalRotationValue;
			transform.rotation = Quaternion.Slerp (transform.rotation, tempRotation, Time.time*rotationTempSpeed);
			gameObject.transform.position = init.mapRest;

		}

		if(other.CompareTag("jurang") || other.CompareTag("Collidable")){
			if(init.updateLivePoint-1!=0){
				carCrash ();
			}else if(init.updateLivePoint-1==0){
				destroyCarCauseLpIsZero ();
			}
		}
		//Debug.Log ("coin : "+init.coin+" / update coin : "+init.updateCoin);


	}

	public void destroyCarCauseLpIsZero(){
		init.isGameOver = true;
		init.updateCoin = 0;
		init.secondsCount = 0;
		init.minuteCount = 0;
		init.hourCount = 0;
		init.updateFuel = init.fuel;
		init.updateLivePoint = init.livePoint;

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
			
		init.redeclareFuelAndcoin ();
		tempRotation = GetComponent<CarController> ().originalRotationValue;
		transform.rotation = Quaternion.Slerp (transform.rotation, tempRotation, Time.time*rotationTempSpeed);
		gameObject.transform.position = init.mapRest;
		panelGameOver.SetActive (true);
	}

	public void isEmptyFuel(){
		if(init.updateFuel<0){
			if(init.updateLivePoint-1!=0){
				carCrash ();
			}else if(init.updateLivePoint-1==0){
				destroyCarCauseLpIsZero ();
			}
		}
	}

	public void suicideLOL(){
		if(init.updateLivePoint-1!=0){
			carCrash ();
		}else if(init.updateLivePoint-1==0){
			destroyCarCauseLpIsZero ();
		}
	}
}
