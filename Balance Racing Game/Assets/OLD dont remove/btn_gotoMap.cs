using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btn_gotoMap : MonoBehaviour {

	public GameObject player;

	public void gotoMap03(){
		StageFlag.flags = 3;
		player.transform.position = new Vector2 (-33,99);
	}
	public void gotoMap01(){
		StageFlag.flags = 1;
		player.transform.position = new Vector2 (-27,10);
		fuel.countFuel = 5;
	}
	public void gotoMap02(){
		StageFlag.flags = 2;
	}
	public void gotoMap00(){
		StageFlag.flags = 0;
		player.transform.position = new Vector2 (1,0);
	}
}
