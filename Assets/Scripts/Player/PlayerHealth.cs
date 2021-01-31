using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {
	
	public KBSet kbSet;
	public AGISet agiSet;
	public ATKSet atkSet;
	public MonsterAbility[] monsAbility = new MonsterAbility[7];

	public bool kb;
	public bool deadDelay = false;
	public bool dead =  false;


	Slider slider;
	Slider HP;
	AudioSource hurt;
	Transform player;
	Animator anim;
	PlayerExperience exp;
	Skill1 skill1;
	Skill2 skill2;
	PlayerLevelData level;
	GameOver over;
	MissionProgress mis;

	float autoRetoreTime;
	float time;
	int restore = 0;
	int avoidRate;
	int[] damage = new int[7];
	float t = 0;

	// Use this for initialization
	void Start () {
		slider = GetComponent<Slider>();
		hurt = GetComponent<AudioSource>();
		anim = GameObject.FindGameObjectWithTag ("Player").GetComponent<Animator>();
		player = GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform>();
		level = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerLevelData> ();
		HP = GameObject.FindGameObjectWithTag ("HP").GetComponent<Slider>();
		exp = GameObject.FindGameObjectWithTag ("EXP").GetComponent<PlayerExperience> ();
		skill1 = GameObject.FindGameObjectWithTag ("Skill1").GetComponent<Skill1> ();
		skill2 = GameObject.FindGameObjectWithTag ("Skill2").GetComponent<Skill2> ();
		over = GameObject.FindGameObjectWithTag ("GameOver").GetComponent<GameOver> ();
		mis = GameObject.FindGameObjectWithTag ("Mission").GetComponent<MissionProgress> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (level.level == 1) {
			autoRetoreTime = 2f;
		}else if (level.level == 2){
			autoRetoreTime = 2f;
		}else if (level.level == 3){
			autoRetoreTime = 2f;
		}else if (level.level == 4){
			autoRetoreTime = 1f;
		}else if (level.level == 5){
			autoRetoreTime = 1f;
		}else if (level.level == 6){
			autoRetoreTime = 1f;
		}else if (level.level == 7){
			autoRetoreTime = 0.5f;
		}else if (level.level == 8){
			autoRetoreTime = 0.5f;
		}else if (level.level == 9){
			autoRetoreTime = 0.5f;
		}else if (level.level == 10){
			autoRetoreTime = 0.1f;
		}

		if (Time.time - time >= autoRetoreTime && restore == 0) {
			time = Time.time;
			HP.value += 1f;
		}


		for (int i = 0; i <= 6; i++) {
			damage[i] = (int)(monsAbility[i].monsterATK - agiSet.DefAdditionCounting);
			if (damage[i] <= 0) {
				damage[i] = 1;
			}
		}
		avoidRate = (int)(agiSet.AvoAdditionCounting * 100);
		if (avoidRate>=5000){
			avoidRate = 5000;
		}

		if (slider.value <= 0 && deadDelay == false) {
			if (skill1.skillUsing || mis.mission <= 2) {
				slider.value = 1f;
			} else {
				t = Time.time;
				deadDelay = true;
				dead = true;
				over.Dead ();
				exp.ReduceEXP ();
				anim.SetBool ("Dead", true);
			}
		}

		if (Time.time - t >= 0.6f && deadDelay) {
			Vector3 none = new Vector3 (70f, 20f, 326f);
			player.transform.position = none;
			deadDelay = false;
		}
	}

	public void CactusGetHit () {
		int random = Random.Range(0,10000);
		if (random >= avoidRate) {
			if (skill2.skillUsing) {
				slider.value -= 1f;
				hurt.Play ();
			} else {
				slider.value -= (int)damage [0];
				hurt.Play ();
			}
		}
	}
	public void BlueGetHit () {
		int random = Random.Range(0,10000);
		if (random >= avoidRate) {
			if (skill2.skillUsing) {
				slider.value -= 1f;
				hurt.Play ();
			} else {
				slider.value -= (int)damage [1];
				hurt.Play ();
			}
		}
	}
	public void GoldGetHit () {
		int random = Random.Range(0,10000);
		if (random >= avoidRate) {
			if (skill2.skillUsing) {
				slider.value -= 1f;
				hurt.Play ();
			} else {
				slider.value -= (int)damage [2];
				hurt.Play ();
			}
		}
	}
	public void GreenGetHit () {
		int random = Random.Range(0,10000);
		if (random >= avoidRate) {
			if (skill2.skillUsing) {
				slider.value -= 1f;
				hurt.Play ();
			} else {
				slider.value -= (int)damage [3];
				hurt.Play ();
			}
		}
	}
	public void RedGetHit () {
		int random = Random.Range(0,10000);
		if (random >= avoidRate) {
			if (skill2.skillUsing) {
				slider.value -= 1f;
				hurt.Play ();
			} else {
				slider.value -= (int)damage [4];
				hurt.Play ();
			}
		}
	}
	public void BOSSGetHit () {
		int random = Random.Range(0,10000);
		if (random >= avoidRate) {
			if (skill2.skillUsing) {
				slider.value -= 1f;
				hurt.Play ();
			} else {
				slider.value -= (int)damage [5];
				hurt.Play ();
			}
		}
	}
	public void RhinoGetHit () {
		int random = Random.Range(0,10000);
		if (random >= avoidRate) {
			if (skill2.skillUsing) {
				slider.value -= 1f;
				hurt.Play ();
			} else {
				slider.value -= (int)damage [6];
				hurt.Play ();
			}
		}
	}


	public void Weeds() {
		HP.value += (float)((int)(HP.maxValue / 2f));
		if (HP.value >= HP.maxValue) {
			HP.value = HP.maxValue;
		}
	}

	public void TCM() {
		HP.value = HP.maxValue;
	}

	public void Compelete() {
		HP.value += 1f;
	}

}
