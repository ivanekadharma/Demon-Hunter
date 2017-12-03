using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveSceneMenu : MonoBehaviour {

	// Use this for initialization
	public void changeMenuSceneTo(string sceneName){
		Application.LoadLevel (sceneName);
	}
}
