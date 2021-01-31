using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Mission_Villager : MonoBehaviour {

	public GameObject dialogTile;
	public GameObject[] talk;

	public float distance = 2f;
	public float facingAngle = 45f;
	public float talkAngle = 45f;

	MissionProgress mis;

	AudioSource next;
	Transform player;

	int s = 0;
	bool loop = false;
	// Use this for initialization
	void Start () {
		next = GetComponent<AudioSource>();		
		mis = GameObject.FindGameObjectWithTag("Mission").GetComponent<MissionProgress>();
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Z)) {
			Talk();
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
				if (mis.mission == 3 && s == 0) {
					Time.timeScale = 0;
					talk[s].SetActive(true);
					dialogTile.SetActive(true);
					next.Play();
					s++;
				}else if (mis.mission == 3 && s == 1) {
					Next();
				}else if (mis.mission == 3 && s == 2) {
					Next();
				}else if (mis.mission == 3 && s == 3) {
					Next();
				}else if (mis.mission == 3 && s == 4) {
					Next();
				}else if (mis.mission == 3 && s == 5) {
					Next();
				}else if (mis.mission == 3 && s == 6) {
					Next();
				}else if (mis.mission == 3 && s == 7) {
					Next();
				}else if (mis.mission == 3 && s == 8) {
					Next();
				}else if (mis.mission == 3 && s == 9) {
					Next();
				}else if (mis.mission == 3 && s == 10) {
					Loop();
					Last();
				}else if (mis.mission == 4 && s == 8 && loop) {
					Next();
				}else if (mis.mission == 4 && s == 9 && loop) {
					Next();
				}else if (mis.mission == 4 && s == 10 && loop) {
					Loop();
				}else if (mis.mission == 10 && s == 8) {
					s = 10;
					Next();
				}else if (mis.mission == 10 && s == 11) {
					Next();
				}else if (mis.mission == 10 && s == 12) {
					Next();
				}else if (mis.mission == 10 && s == 13) {
					Next();
				}else if (mis.mission == 10 && s == 14) {
					Next();
				}else if (mis.mission == 10 && s == 15) {
					Next();
				}else if (mis.mission == 10 && s == 16) {
					Next();
				}else if (mis.mission == 10 && s == 17) {
					Next();
				}else if (mis.mission == 10 && s == 18) {
					Next();
				}else if (mis.mission == 10 && s == 19) {
					Next();
				}else if (mis.mission == 10 && s == 20) {
					Next();
				}else if (mis.mission == 10 && s == 21) {
					Next();
				}else if (mis.mission == 10 && s == 22) {
					Next();
				}else if (mis.mission == 10 && s == 23) {
					Next();
				}else if (mis.mission == 10 && s == 24) {
					Loop();
					Last();
				}else if (mis.mission == 11 && s == 22 && loop) {
					Next();
				}else if (mis.mission == 11 && s == 23 && loop) {
					Next();
				}else if (mis.mission == 11 && s == 24 && loop) {
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
			s -=2;
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
