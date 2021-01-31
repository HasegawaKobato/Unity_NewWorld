using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMPValue : MonoBehaviour {
	
	public float curMp;

	Skill1 skill1;
	Skill2 skill2;
	Slider mp;
	PlayerLevelData level;

	float autoRetoreTime;
	float time;
	int restore = 0;

	// Use this for initialization
	void Start () {
		mp = GetComponent<Slider> ();
		skill1 = GameObject.FindGameObjectWithTag ("Skill1").GetComponent<Skill1> ();
		skill2 = GameObject.FindGameObjectWithTag ("Skill2").GetComponent<Skill2> ();
		level = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerLevelData> ();
	}
	
	// Update is called once per frame
	void Update () {
		curMp = mp.value;

		if (level.level == 1) {
			autoRetoreTime = 5f;
		}else if (level.level == 2){
			autoRetoreTime = 4f;
		}else if (level.level == 3){
			autoRetoreTime = 3f;
		}else if (level.level == 4){
			autoRetoreTime = 2f;
		}else if (level.level == 5){
			autoRetoreTime = 1f;
		}else if (level.level == 6){
			autoRetoreTime = 0.8f;
		}else if (level.level == 7){
			autoRetoreTime = 0.5f;
		}else if (level.level == 8){
			autoRetoreTime = 0.3f;
		}else if (level.level == 9){
			autoRetoreTime = 0.3f;
		}else if (level.level == 10){
			autoRetoreTime = 0.2f;
		}

		if (Time.time - time >= autoRetoreTime && restore == 0) {
			time = Time.time;
			mp.value += 1f;
		}
	}

	public void ReduceMP1(){
		mp.value = curMp - skill1.costMP;
	}

	public void ReduceMP2(){
		mp.value = curMp - skill2.costMP;
	}

	public void ReduceMP3(){
		mp.value = 0f;
	}

	public void Respawn() {
		mp.value = mp.maxValue;
	}

	public void Flowers() {
		mp.value += (float)((int)(mp.maxValue / 2f));
		if (mp.value >= mp.maxValue) {
			mp.value = mp.maxValue;
		}
	}

	public void TCM() {
		mp.value = mp.maxValue;
	}

	public void Compelete() {
		mp.value += 1f;
	}
}
