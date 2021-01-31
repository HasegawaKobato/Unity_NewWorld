using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Mission_Mayor : MonoBehaviour {

	public GameObject dialogTile;
	public GameObject[] talk;

	public float distance = 2f;
	public float facingAngle = 45f;
	public float talkAngle = 45f;

	MissionProgress mis;
	Tool3 tool;

	AudioSource next;
	Transform player;
	BoxCollider box;
	BoxCollider nest1;
	BoxCollider nest2;
	BoxCollider nestExit;

	int s = 0;
	int i = 0;
	bool loop = false;
	bool waitEnd = false;
	float wait = 0;
	// Use this for initialization
	void Start () {
		next = GetComponent<AudioSource>();		
		mis = GameObject.FindGameObjectWithTag("Mission").GetComponent<MissionProgress>();
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
		tool = GameObject.FindGameObjectWithTag("Tools3").GetComponent<Tool3>();
		box = GameObject.FindGameObjectWithTag("MA").GetComponent<BoxCollider>();
		nest1 = GameObject.FindGameObjectWithTag("Nest").GetComponent<BoxCollider>();
		nest2 = GameObject.FindGameObjectWithTag("Nest2").GetComponent<BoxCollider>();
		nestExit = GameObject.FindGameObjectWithTag("NestExit").GetComponent<BoxCollider>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Z)) {
			Talk();
		}
		if (mis.mission >= 12) {
			box.isTrigger = true;
		}
		if (i == 1 && waitEnd == false) {
			wait = Time.time;
			i++;
		}
		if (Time.time - wait >= 60f) {
			waitEnd = true;
		}
	}


	void Talk () {
		Vector3 playerPosition = player.position;
		Vector3 selfPosition = transform.position;

		float countTalkingAngle = talkAngle / 2;
		float countFacingAngle = facingAngle / 2;

		Quaternion selfRotation = transform.rotation;
		Quaternion right = transform.rotation * Quaternion.AngleAxis(countFacingAngle,Vector3.up);
		Quaternion left = transform.rotation * Quaternion.AngleAxis(countFacingAngle,Vector3.down);
		Vector3 distanceRTwoPosition = selfPosition + (right * Vector3.forward) * distance;
		Vector3 distanceLTwoPosition = selfPosition + (left * Vector3.forward) * distance;

		float resultFacingAngle1 = Vector3.Angle(transform.position-player.position,transform.position - distanceLTwoPosition);
		float resultFacingAngle2 = Vector3.Angle(transform.position-player.position,transform.position - distanceRTwoPosition);

		if (Vector3.Distance(playerPosition,selfPosition) <= distance){
			//if ((resultFacingAngle1 + resultFacingAngle2) > (facingAngle-1f) && (resultFacingAngle1 + resultFacingAngle2) < (facingAngle + 1f)) {
			if ((Math.Abs(transform.localEulerAngles.y - player.localEulerAngles.y) <= (180 + countTalkingAngle)) && (Math.Abs(transform.localEulerAngles.y - player.localEulerAngles.y) >= (180 - countTalkingAngle))) {
				if (mis.mission == 9 && s == 0 && tool.restCount >= 1) {
					Time.timeScale = 0;
					talk[s].SetActive(true);
					dialogTile.SetActive(true);
					next.Play();
					s++;
				}else if (mis.mission == 9 && s == 1 && tool.restCount >= 1) {
					Next();
				}else if (mis.mission == 9 && s == 2 && tool.restCount >= 1) {
					Next();
				}else if (mis.mission == 9 && s == 3 && tool.restCount >= 1) {
					Next();
				}else if (mis.mission == 9 && s == 4 && tool.restCount >= 1) {
					Next();
				}else if (mis.mission == 9 && s == 5 && tool.restCount >= 1) {
					Next();
				}else if (mis.mission == 9 && s == 6 && tool.restCount >= 1) {
					Next();
				}else if (mis.mission == 9 && s == 7 && tool.restCount >= 1) {
					Next();
				}else if (mis.mission == 9 && s == 8 && tool.restCount >= 1) {
					Next();
				}else if (mis.mission == 9 && s == 9 && tool.restCount >= 1) {
					Next();
				}else if (mis.mission == 9 && s == 10 && tool.restCount >= 1) {
					Next();
					tool.restCount --;
				}else if (mis.mission == 9 && s == 11) {
					Next();
				}else if (mis.mission == 9 && s == 12) {
					Next();
				}else if (mis.mission == 9 && s == 13) {
					Next();
				}else if (mis.mission == 9 && s == 14) {
					Loop();
					Last();
				}else if (mis.mission == 10 && s == 13 && loop) {
					Next();
				}else if (mis.mission == 10 && s == 14 && loop) {
					Loop();
				}else if (mis.mission == 11 && s == 13) {
					s = 14;
					Next();
				}else if (mis.mission == 11 && s == 15) {
					Next();
				}else if (mis.mission == 11 && s == 16) {
					Next();
				}else if (mis.mission == 11 && s == 17) {
					Next();
				}else if (mis.mission == 11 && s == 18) {
					Next();
				}else if (mis.mission == 11 && s == 19) {
					Next();
				}else if (mis.mission == 11 && s == 20) {
					Next();
				}else if (mis.mission == 11 && s == 21) {
					Next();
				}else if (mis.mission == 11 && s == 22) {
					Next();
				}else if (mis.mission == 11 && s == 23) {
					Next();
				}else if (mis.mission == 11 && s == 24) {
					Next();
				}else if (mis.mission == 11 && s == 25) {
					Next();
				}else if (mis.mission == 11 && s == 26) {
					Next();
				}else if (mis.mission == 11 && s == 27) {
					Next();
				}else if (mis.mission == 11 && s == 28) {
					Next();
				}else if (mis.mission == 11 && s == 29) {
					Next();
				}else if (mis.mission == 11 && s == 30) {
					Next();
				}else if (mis.mission == 11 && s == 31) {
					Next();
				}else if (mis.mission == 11 && s == 32) {
					Next();
				}else if (mis.mission == 11 && s == 33) {
					Next();
				}else if (mis.mission == 11 && s == 34) {
					Next();
				}else if (mis.mission == 11 && s == 35) {
					Next();
				}else if (mis.mission == 11 && s == 36) {
					Loop();
					Last();
					s++;
					box.isTrigger = true;
				}else if (mis.mission == 12 && s == 36 && loop) {
					Next();
				}else if (mis.mission == 12 && s == 37 && loop) {
					Loop();
					wait = Time.time;
				}else if (mis.mission == 16 && s == 36) {
					s = 37;
					Next();
				}else if (mis.mission == 16 && s == 38) {
					Next();
				}else if (mis.mission == 16 && s == 39) {
					Next();
				}else if (mis.mission == 16 && s == 40) {
					Next();
				}else if (mis.mission == 16 && s == 41) {
					Next();
				}else if (mis.mission == 16 && s == 42) {
					Next();
				}else if (mis.mission == 16 && s == 43) {
					Next();
				}else if (mis.mission == 16 && s == 44) {
					Next();
				}else if (mis.mission == 16 && s == 45) {
					Next();
				}else if (mis.mission == 16 && s == 46) {
					Next();
				}else if (mis.mission == 16 && s == 47) {
					Next();
				}else if (mis.mission == 16 && s == 48) {
					Next();
				}else if (mis.mission == 16 && s == 49) {
					Next();
				}else if (mis.mission == 16 && s == 50) {
					Next();
				}else if (mis.mission == 16 && s == 51) {
					Next();
				}else if (mis.mission == 16 && s == 52) {
					Next();
				}else if (mis.mission == 16 && s == 53) {
					Next();
				}else if (mis.mission == 16 && s == 54) {
					Loop();
					Last();
					nest1.isTrigger = true;
					nest2.isTrigger = true;
					s++;
				}else if (mis.mission == 17 && s == 54 && loop) {
					Next();
				}else if (mis.mission == 17 && s == 55 && loop) {
					Loop();
				}else if (mis.mission == 18 && s == 54) {
					s = 55;
					Next();
				}else if (mis.mission == 18 && s == 55) {
					Next();
				}else if (mis.mission == 18 && s == 56) {
					Next();
				}else if (mis.mission == 18 && s == 57) {
					Next();
				}else if (mis.mission == 18 && s == 58) {
					Next();
				}else if (mis.mission == 18 && s == 59) {
					Next();
				}else if (mis.mission == 18 && s == 60) {
					Next();
				}else if (mis.mission == 18 && s == 61) {
					Next();
				}else if (mis.mission == 18 && s == 62) {
					Next();
				}else if (mis.mission == 18 && s == 63) {
					Next();
				}else if (mis.mission == 18 && s == 64) {
					Loop();
					Last();
					s++;
					i++;
				}else if (mis.mission == 19 && s == 64 && loop && waitEnd == false) {
					Next();
				}else if (mis.mission == 19 && s == 65 && loop && waitEnd == false) {
					Loop();
				}else if (mis.mission == 19 && s == 64 && waitEnd) {
					s=65;
					Next();
				}else if (mis.mission == 19 && s == 66 && waitEnd) {
					Next();
				}else if (mis.mission == 19 && s == 67 && waitEnd) {
					Next();
				}else if (mis.mission == 19 && s == 68 && waitEnd) {
					Next();
				}else if (mis.mission == 19 && s == 69 && waitEnd) {
					Next();
				}else if (mis.mission == 19 && s == 70 && waitEnd) {
					Next();
				}else if (mis.mission == 19 && s == 71 && waitEnd) {
					Next();
				}else if (mis.mission == 19 && s == 72 && waitEnd) {
					Next();
				}else if (mis.mission == 19 && s == 73 && waitEnd) {
					Next();
				}else if (mis.mission == 19 && s == 74 && waitEnd) {
					Next();
				}else if (mis.mission == 19 && s == 75 && waitEnd) {
					Next();
				}else if (mis.mission == 19 && s == 76 && waitEnd) {
					Next();
				}else if (mis.mission == 19 && s == 77 && waitEnd) {
					Next();
				}else if (mis.mission == 19 && s == 78 && waitEnd) {
					Next();
				}else if (mis.mission == 19 && s == 79 && waitEnd) {
					Next();
				}else if (mis.mission == 19 && s == 80 && waitEnd) {
					Next();
				}else if (mis.mission == 19 && s == 81 && waitEnd) {
					Next();
				}else if (mis.mission == 19 && s == 82 && waitEnd) {
					Next();
				}else if (mis.mission == 19 && s == 83 && waitEnd) {
					Loop();
					Last();
					s++;
					nestExit.isTrigger = true;
				}else if (mis.mission == 20 && s == 83 && waitEnd && loop) {
					Next();
				}else if (mis.mission == 20 && s == 84 && waitEnd && loop) {
					Loop();
				}

			}
			//}
		}
	}


	void Next () {
		if (Input.GetKeyDown(KeyCode.Z)){
			talk[s-1].SetActive(false);
			talk[s].SetActive(true);
			dialogTile.SetActive(true);
			Time.timeScale = 0;
			next.Play();
			s ++;				
		}
	}


	void Loop () {
		if (Input.GetKeyDown(KeyCode.Z)){
			talk[s-1].SetActive(false);
			dialogTile.SetActive(false);
			Time.timeScale = 1;
			next.Play();
			s -=1;
		}
	}

	void Last () {
		if (Input.GetKeyDown(KeyCode.Z)){
			talk[s-1].SetActive(false);
			dialogTile.SetActive(false);
			loop = true;
			Time.timeScale = 1;
			next.Play();
			mis.mission ++;
		}
	}
}
