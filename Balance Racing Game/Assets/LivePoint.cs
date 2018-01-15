using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LivePoint : MonoBehaviour {

	public int LivePoints = 5;
	public Text lp;
	private int tempStage;
	private Quaternion tempRotation;
	float rotationTempSpeed = 1.0f;

	public Transform currentCheckpoint;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		updateLp ();
	}
	void OnTriggerEnter2D (Collider2D colInfo)
	{
		if (colInfo.CompareTag("jurang") || colInfo.CompareTag("Collidable"))
		{
			if(destroyCheckpoint.udahDapetCheckpoint!=1){
				LivePoints -= 1;
				tempStage = StageFlag.flags;
				GetComponent<scoring> ().score = 0;
				GetComponent<timer> ().secondsCount = 0;
				GetComponent<timer> ().minuteCount = 0;
				GetComponent<timer> ().hourCount = 0;
				fuel.countFuel = 20;
				tempRotation = GetComponent<CarController> ().originalRotationValue;
				transform.rotation = Quaternion.Slerp (transform.rotation, tempRotation, Time.time*rotationTempSpeed);
				if(tempStage==3){
					gameObject.transform.position = new Vector2 (-33, 99);
				}
			}else if(destroyCheckpoint.udahDapetCheckpoint==1){
				LivePoints -= 1;
				fuel.countFuel = destroyCheckpoint.cpFuel;
				tempRotation = GetComponent<CarController> ().originalRotationValue;
				transform.rotation = Quaternion.Slerp (transform.rotation, tempRotation, Time.time*rotationTempSpeed);
				gameObject.transform.position = destroyCheckpoint.checkpoint;
			}
	
		}
		if(colInfo.CompareTag("goalpoint")){
			tempRotation = GetComponent<CarController> ().originalRotationValue;
			transform.rotation = Quaternion.Slerp (transform.rotation, tempRotation, Time.time*rotationTempSpeed);
			gameObject.transform.position = new Vector2(-59, 95);
		}
	}
	public void updateLp(){
		lp.text = " "+LivePoints+" ";
		if(fuel.countFuel<0){
			if(destroyCheckpoint.udahDapetCheckpoint!=1){
				LivePoints -= 1;	
				tempStage = StageFlag.flags;
				GetComponent<scoring> ().score = 0;
				GetComponent<timer> ().secondsCount = 0;
				GetComponent<timer> ().minuteCount = 0;
				GetComponent<timer> ().hourCount = 0;
				fuel.countFuel = 20;
				tempRotation = GetComponent<CarController> ().originalRotationValue;
				transform.rotation = Quaternion.Slerp (transform.rotation, tempRotation, Time.time*rotationTempSpeed);
				if(tempStage==3){
					gameObject.transform.position = new Vector2 (-33, 99);
				}
			}else if(destroyCheckpoint.udahDapetCheckpoint==1){
				LivePoints -= 1;
				fuel.countFuel = destroyCheckpoint.cpFuel;
				tempRotation = GetComponent<CarController> ().originalRotationValue;
				transform.rotation = Quaternion.Slerp (transform.rotation, tempRotation, Time.time*rotationTempSpeed);
				gameObject.transform.position = destroyCheckpoint.checkpoint;
			}
		}
	}

}
