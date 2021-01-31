using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Mission_Guard : MonoBehaviour {

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

	int s = 0;
	int i = 0;

	bool loop = false;
	// Use this for initialization
	void Start () {
		next = GetComponent<AudioSource>();		
		mis = GameObject.FindGameObjectWithTag("Mission").GetComponent<MissionProgress>();
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
		tool = GameObject.FindGameObjectWithTag("Tools3").GetComponent<Tool3>();
		box = GameObject.FindGameObjectWithTag("TownKey").GetComponent<BoxCollider>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Z)) {
			Talk();
		}
		if (tool.restCount >= 1) {
			loop = false;
		}
		if (i >10) {
			loop = false;
		}
		if (mis.mission >= 9) {
			gameObject.SetActive(false);
			box.isTrigger = true;
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
				if (mis.mission == 6 && s == 0) {
					Time.timeScale = 0;
					talk[s].SetActive(true);
					dialogTile.SetActive(true);
					next.Play();
					s++;
				}else if (mis.mission == 6 && s == 1) {
					Next();
				}else if (mis.mission == 6 && s == 2) {
					Next();
				}else if (mis.mission == 6 && s == 3) {
					Next();
				}else if (mis.mission == 6 && s == 4) {
					Next();
				}else if (mis.mission == 6 && s == 5) {
					Next();
				}else if (mis.mission == 6 && s == 6) {
					Next();
				}else if (mis.mission == 6 && s == 7) {
					Next();
				}else if (mis.mission == 6 && s == 8) {
					Next();
				}else if (mis.mission == 6 && s == 9) {
					Next();
				}else if (mis.mission == 6 && s == 10) {
					Next();
				}else if (mis.mission == 6 && s == 11) {
					Next();
				}else if (mis.mission == 6 && s == 12) {
					Loop();
					Last();
				}else if (mis.mission == 7 && s == 10 && loop && i <= 10) {
					Next();
				}else if (mis.mission == 7 && s == 11 && loop && i <= 10) {
					Next();
				}else if (mis.mission == 7 && s == 12 && loop && i <= 10) {
					Loop();
				}else if ((mis.mission == 7 || mis.mission == 8) && s == 10 && i > 10 && tool.restCount < 1) {
					s=12;
					Next();
					mis.mission = 8;
					s--;
				}else if ((mis.mission == 7 || mis.mission == 8) && s == 12 && i > 10 && tool.restCount < 1) {
					talk[s].SetActive(false);
					Loop();
				}else if ((mis.mission == 7 || mis.mission == 8) && tool.restCount >= 1 && s == 10) {
					s = 13;
					Next();
				}else if ((mis.mission == 7 || mis.mission == 8) && tool.restCount >= 1 && s == 14) {
					Next();
				}else if ((mis.mission == 7 || mis.mission == 8) && tool.restCount >= 1 && s == 15) {
					Next();
				}else if ((mis.mission == 7 || mis.mission == 8) && tool.restCount >= 1 && s == 16) {
					Next();
				}else if ((mis.mission == 7 || mis.mission == 8) && tool.restCount >= 1 && s == 17) {
					Next();
				}else if ((mis.mission == 7 || mis.mission == 8) && tool.restCount >= 1 && s == 18) {
					Next();
				}else if ((mis.mission == 7 || mis.mission == 8) && tool.restCount >= 1 && s == 19) {
					Next();
				}else if ((mis.mission == 7 || mis.mission == 8) && tool.restCount >= 1 && s == 20) {
					Next();
				}else if ((mis.mission == 7 || mis.mission == 8) && tool.restCount >= 1 && s == 21) {
					Next();
				}else if ((mis.mission == 7 || mis.mission == 8) && tool.restCount >= 1 && s == 22) {
					Next();
				}else if ((mis.mission == 7 || mis.mission == 8) && tool.restCount >= 1 && s == 23) {
					Next();
				}else if ((mis.mission == 7 || mis.mission == 8) && tool.restCount >= 1 && s == 24) {
					Next();
				}else if ((mis.mission == 7 || mis.mission == 8) && tool.restCount >= 1 && s == 25) {
					Next();
				}else if ((mis.mission == 7 || mis.mission == 8) && tool.restCount >= 1 && s == 26) {
					Next();
				}else if ((mis.mission == 7 || mis.mission == 8) && tool.restCount >= 1 && s == 27) {
					Next();
				}else if ((mis.mission == 7 || mis.mission == 8) && tool.restCount >= 1 && s == 28) {
					Next();
				}else if ((mis.mission == 7 || mis.mission == 8) && tool.restCount >= 1 && s == 29) {
					Next();
				}else if ((mis.mission == 7 || mis.mission == 8) && tool.restCount >= 1 && s == 30) {
					Next();
				}else if ((mis.mission == 7 || mis.mission == 8) && tool.restCount >= 1 && s == 31) {
					box.isTrigger = true;
					Last();
					gameObject.SetActive(false);
					mis.mission = 9;
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
			s -=2;
			i ++ ;
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
