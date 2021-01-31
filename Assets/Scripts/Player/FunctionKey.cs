using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionKey : MonoBehaviour {

	Skill1 skill1;
	Skill2 skill2;
	Skill3 skill3;
	Tool1 tool1;
	Tool2 tool2;
	Tool3 tool3;
	PlayerMPValue mp;
	Transform respawn;
	Animator transitions;
	PlayerHealth hp;
	AudioSource audio;
	MissionProgress mis;

	public AudioClip window;
	public AudioClip blood;
	public AudioClip hard;
	public AudioClip weeds;
	public AudioClip flowers;
	public AudioClip TCM;

	public GameObject abilityWindow;
	public GameObject skillWindow;
	public GameObject itemWindow;

	public GameObject camera1;
	public GameObject camera2;
	public GameObject camera3;
	public GameObject skillUsing1;
	public GameObject skillUsing2;
	public GameObject skillUsing3;

	public float ChangeTime = 0.25f;

	float timerStart;
	int camera = 3;
	float transitionsTime = 0;
	bool isRespawn = false;

	// Use this for initialization
	void Start () {
		skill1 = GameObject.FindGameObjectWithTag ("Skill1").GetComponent<Skill1> ();
		skill2 = GameObject.FindGameObjectWithTag ("Skill2").GetComponent<Skill2> ();
		//skill3 = GameObject.FindGameObjectWithTag ("Skill3").GetComponent<Skill3> ();
		tool1 = GameObject.FindGameObjectWithTag("Tools1").GetComponent<Tool1>();
		tool2 = GameObject.FindGameObjectWithTag("Tools2").GetComponent<Tool2>();
		tool3 = GameObject.FindGameObjectWithTag("Tools3").GetComponent<Tool3>();
		respawn = GameObject.FindGameObjectWithTag ("Respawn").GetComponent<Transform> ();
		mp = GameObject.FindGameObjectWithTag ("MP").GetComponent<PlayerMPValue> ();
		hp = GameObject.FindGameObjectWithTag ("HP").GetComponent<PlayerHealth> ();
		transitions = GameObject.FindGameObjectWithTag ("Transitions").GetComponent<Animator> ();
		audio = GetComponent<AudioSource>();
		mis = GameObject.FindGameObjectWithTag ("Mission").GetComponent<MissionProgress> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (mis.mission <= 2) {
			abilityWindow.SetActive(true);
			skillWindow.SetActive(true);
			itemWindow.SetActive(true);
		}
		//能力視窗
		if (Input.GetKeyDown (KeyCode.F) || Input.GetKeyDown(KeyCode.S)) {
			if (mis.mission > 2) {
				if (abilityWindow.activeSelf) {
					audio.clip = window;
					audio.Play();
					abilityWindow.SetActive (false);
				} else {
					audio.clip = window;
					audio.Play();
					abilityWindow.SetActive (true);
				}
			}
		}
		//技能視窗
		if (Input.GetKeyDown (KeyCode.K)) {
			if (mis.mission > 2) {
				if (skillWindow.activeSelf) {
					audio.clip = window;
					audio.Play();
					skillWindow.SetActive (false);
				} else {
					audio.clip = window;
					audio.Play();
					skillWindow.SetActive (true);
				}
			}
		}
		//道具視窗
		if (Input.GetKeyDown (KeyCode.I)) {
			if (mis.mission > 2) {
				if (itemWindow.activeSelf) {
					audio.clip = window;
					audio.Play();
					itemWindow.SetActive (false);
				} else {
					audio.clip = window;
					audio.Play();
					itemWindow.SetActive (true);
				}
			}
		}
		//切換視角
		if (Input.GetKey (KeyCode.F5)) {
			if (Time.time - timerStart >= ChangeTime) {
				if (camera == 3) {
					timerStart = Time.time;
					camera3.SetActive (false);
					camera2.SetActive (false);
					camera1.SetActive (true);
					camera = 1;
				} else if (camera == 1) {
					timerStart = Time.time;
					camera1.SetActive (false);
					camera3.SetActive (false);
					camera2.SetActive (true);
					camera++;
				} else if (camera == 2) {
					timerStart = Time.time;
					camera2.SetActive (false);
					camera1.SetActive (false);
					camera3.SetActive (true);
					camera++;
				}
			}
		}
		//------------------------------技能相關--------------------------------//
		//技能使用
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			if (mp.curMp >= (float)skill1.costMP && skill1.skillUsing == false) {
				skillUsing1.SetActive (true);
				skill1.countdown = Time.time;
				skill1.skillUsing = true;
				audio.clip = blood;
				audio.Play();
				mp.ReduceMP1 ();
			}
		}
		if (Input.GetKeyDown (KeyCode.Alpha2)) {
			if (mp.curMp >= (float)skill2.costMP && skill2.skillUsing == false) {
				skillUsing2.SetActive (true);
				skill2.countdown = Time.time;
				skill2.skillUsing = true;
				audio.clip = hard;
				audio.Play();
				mp.ReduceMP2 ();
			}
		}

		//---------------
		//回程技能暫時刪除(重生點問題)
		//---------------
		/*if (Input.GetKeyDown (KeyCode.Alpha3)) {
			if (mp.curMp >= 1f && skill3.skillUsing == false) {
				skillUsing3.SetActive (true);
				transitionsTime = Time.time;
				transitions.SetTrigger("Transitions");
				isRespawn = true;
				skill3.countdown = Time.time;
				skill3.skillUsing = true;
				mp.ReduceMP3 ();
			}
		}
		if (Time.time - transitionsTime >= 0.5f && isRespawn) {
			gameObject.transform.position = respawn.transform.position;
			transitions.SetTrigger ("TransitionsCancel");
			isRespawn = false;
		}*/
		//---------------


		//技能CD結束
		if ((skill1.cd - (int)(Time.time - skill1.countdown)) <= 0) {
			skill1.skillUsing = false;
			skillUsing1.SetActive (false);
		}
		if ((skill2.cd - (int)(Time.time - skill2.countdown)) <= 0) {
			skill2.skillUsing = false;
			skillUsing2.SetActive (false);
		}
		//---------------
		//回程技能暫時刪除(重生點問題)
		//---------------
		/*if ((skill3.cd - (int)(Time.time - skill3.countdown)) <= 0) {
			skill3.skillUsing = false;
			skillUsing3.SetActive (false);
		}*/
		//------------------------------技能相關--------------------------------//

		//------------------------------道具相關--------------------------------//
		//道具使用
		if (Input.GetKeyDown (KeyCode.Delete)) {
			if (tool1.restCount > 0) {
				tool1.restCount--;
				audio.clip = weeds;
				audio.Play();
				hp.Weeds ();
			}
		}
		if (Input.GetKeyDown (KeyCode.End)) {
			if (tool2.restCount > 0) {
				tool2.restCount--;
				audio.clip = flowers;
				audio.Play();
				mp.Flowers ();
			}
		}
		if (Input.GetKeyDown (KeyCode.PageDown)) {
			if (tool3.restCount > 0) {
				tool3.restCount--;
				audio.clip = TCM;
				audio.Play();
				hp.TCM ();
				mp.TCM ();
			}
		}


		//------------------------------道具相關--------------------------------//



	}
}
