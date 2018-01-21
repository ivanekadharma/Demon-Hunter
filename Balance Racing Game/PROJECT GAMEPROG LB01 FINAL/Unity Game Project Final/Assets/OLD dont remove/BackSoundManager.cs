using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackSoundManager : MonoBehaviour {

	public AudioSource bgm_mainMenu; //0
	public AudioSource bgm_fall_map; //1
	public AudioSource bgm_summer_map; //2
	public AudioSource bgm_winter_map; //3
	public AudioSource bgm_play;
	public static int tempMap = 0;
	public Slider volume;

	// Use this for initialization
	void Start () {
		tempMap = StageFlag.flags;
		bgm_fall_map.Stop ();
		bgm_summer_map.Stop ();
		bgm_winter_map.Stop ();
		bgm_mainMenu.Stop ();
		bgm_play = bgm_mainMenu;
		bgm_play.Play ();

	}
	
	// Update is called once per frame
	void Update () {
		

	}
	public void changeMusicMenu(){
		bgm_play.Stop ();
		bgm_play = bgm_mainMenu;
		bgm_play.Play();
	}

	public void changeMusic1(){
		bgm_play.Stop ();
		bgm_play = bgm_fall_map;
		bgm_play.Play ();
	}

	public void changeMusic2(){
		bgm_play.Stop ();
		bgm_play = bgm_summer_map;
		bgm_play.Play ();
	}

	public void changeMusic3(){
		bgm_play.Stop ();
		bgm_play = bgm_winter_map;
		bgm_play.Play ();
	}

	public void ChangeVol(float newValue) {
		float newVol = AudioListener.volume;
		newVol = newValue;
		AudioListener.volume = newVol;
	}
}
