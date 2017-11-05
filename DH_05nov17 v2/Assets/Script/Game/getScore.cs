using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getScore : MonoBehaviour {

	public int score = 0;
	int tempScore;
	int totalEnemiesNow;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	} 


	public void OnGUI(){
		tempScore = score-1;
		totalEnemiesNow = GetComponent<generateEnemies> ().totalEnemy;
		if (tempScore == totalEnemiesNow) {
			GUI.Label (new Rect(10, 10, 100, 20), "You Win !");
		}else GUI.Label (new Rect(10, 10, 100, 20), tempScore + " / " + totalEnemiesNow + " Demons");
	}
}
