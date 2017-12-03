using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour {

	// Use this for initialization
	//public Transform InstantiateMe;
	public Text timerText;
	public Text scoring;
	public float secondsCount;
	public int score = 0;
	public int DemonKilled=0;
	public int GameOver = 0;

	/*public void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "SvEnemy"){
			Destroy (other.gameObject);
			score++;
			float x = Random.Range (-60, 55);
			float z = Random.Range (-55, 55);
			float y = 1.1f;
			var go = Instantiate (InstantiateMe, transform.position = (new Vector3 (x, y, z)), Quaternion.identity);
		}
	}*/

	void Start(){
		secondsCount = 30;
		score = score - 1;
		DemonKilled = DemonKilled = -1;
	
	}

	void Update(){
		UpdateTimerUI ();
		UpdateScore ();	
	}
		
	public void UpdateTimerUI(){
		//set timer UI
		secondsCount -= Time.deltaTime;
		if (secondsCount >= 0) {
			timerText.text = (int)secondsCount + "s";
		} else {
			GameOver = 1;
			timerText.text = "Game Over, Your Score is "+score+", press B for back to menu";
			if(Input.GetKey(KeyCode.B)){
				Application.LoadLevel ("MainMenu");	
			}
		}

		if(DemonKilled==3){
			DemonKilled = 0;
			secondsCount = secondsCount + 5;
		}
	}
	public void UpdateScore(){
		//set score UI
		scoring.text = score + " Demon Destroyed";
	}


}
