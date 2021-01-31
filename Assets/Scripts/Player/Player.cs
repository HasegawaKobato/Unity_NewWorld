using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

	public PlayerHealth playerKB;

	public GameObject hikick;
	public GameObject spinkick;
	public AGISet speed;

	public float defaultHP = 100;
	public float defaultMP = 50;
	public float defaultEXP = 30;
	public float defaultATK = 10;
	public float defaultDEF = 5;
	public float defaultAVO = 1;
	public float defaultSpeed = 1;
	public float defaultKB = 2;
	public bool stop = false;

	Animator anim;

	private float inputH;
	private float inputV;

	float SkillCD = 1f;
	float timeCount;
	float timeCount2;

	Vector3 playerPosition,selfPosition,backPosition;
	Quaternion selfRotation,backRotation;


	// Use this for initialization

	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		

		inputH = Input.GetAxis("Horizontal");
		inputV = Input.GetAxis("Vertical");

		anim.SetFloat("inputH",inputH);
		anim.SetFloat("inputV",inputV);

		float moveX = inputH * 7f * Time.deltaTime;
		float moveZ = inputV * (7f * (float)(speed.SpeedAdditionCounting)) * Time.deltaTime;

		if (anim.GetCurrentAnimatorStateInfo (0).IsName ("Hikick") || anim.GetCurrentAnimatorStateInfo (0).IsName ("Spinkick") ||anim.GetCurrentAnimatorStateInfo (0).IsName ("DamageDown") || playerKB.deadDelay ||stop) {
			moveZ = 0;
			moveX = 0;
		}

		if (anim.GetCurrentAnimatorStateInfo (0).IsName ("Hikick")) {
			hikick.SetActive (true);
		} else {
			hikick.SetActive (false);
		}

		if (anim.GetCurrentAnimatorStateInfo (0).IsName ("Spinkick")) {
			spinkick.SetActive (true);
		} else {
			spinkick.SetActive (false);
		}

		if (moveZ <=0) {
			moveZ = 0;
		}
		transform.Rotate(0f,moveX*30f,0f);
		transform.Translate(0f,0f,moveZ);


		if (Input.GetKeyDown(KeyCode.LeftControl) || Input.GetKeyDown(KeyCode.RightControl)){
			if (Time.time - timeCount >= SkillCD || Time.time <= SkillCD) {
				if ((anim.GetCurrentAnimatorStateInfo(0).IsName("Hikick"))) {
					timeCount = Time.time;
					anim.SetTrigger("Spinkick");
				}else {
					anim.SetTrigger("Hikick");
				}
			}
		}
	}

}
