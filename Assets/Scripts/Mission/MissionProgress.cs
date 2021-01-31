using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionProgress : MonoBehaviour {
	
	public int mission = 1;
	public GameObject dialogTile;
	public GameObject[] talk;

	public bool tenMin = false;
	public float time;

	AudioSource next;

	int s = 0;

	// Use this for initialization
	void Start () {
		next = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if (mission == 1 && s == 0) {
			Time.timeScale = 0;
			talk[s].SetActive(true);
			dialogTile.SetActive(true);
			Next();
		}else if (mission == 1 && s == 1) {
			Next();
		}else if (mission == 1 && s == 2) {
			Next();
		}else if (mission == 1 && s == 3) {
			Next();
		}else if (mission == 1 && s == 4) {
			Last();
		}

		if (mission == 2 && s == 5) {
			Time.timeScale = 0;
			talk[s].SetActive(true);
			dialogTile.SetActive(true);
			Next();
		}else if (mission == 2 && s == 6) {
			Next();
		}else if (mission == 2 && s == 7) {
			Next();
		}else if (mission == 2 && s == 8) {
			Last();
		}

		if (mission == 15 && s <= 9) {
			s = 10;
			talk[s].SetActive(true);
			dialogTile.SetActive(true);
			Time.timeScale = 0;
		}else if (mission == 15 & s == 10){
			if (Input.GetKeyDown(KeyCode.Z)){
				talk[s].SetActive(false);
				dialogTile.SetActive(false);
				Time.timeScale = 1;
				next.Play();
				s ++ ;
				mission ++;
			}
		}


		if (tenMin && Time.time - time >= 600f && mission == 5){
			dialogTile.SetActive(true);
			talk[s].SetActive(true);
			tenMin = false;
			Time.timeScale = 0;
		}
		if (Input.GetKey(KeyCode.Z)) {
			if (tenMin == false && mission == 5) {
				dialogTile.SetActive(false);
				talk[s].SetActive(false);
				Time.timeScale = 1;
				next.Play();
				s++;
			}
		}

	}


	void Next () {
		if (Input.GetKeyDown(KeyCode.Z)){
			talk[s].SetActive(false);
			talk[s+1].SetActive(true);
			Time.timeScale = 0;
			next.Play();
			s ++;				
		}
	}

	void Last () {
		if (Input.GetKeyDown(KeyCode.Z)){
			talk[s].SetActive(false);
			dialogTile.SetActive(false);
			Time.timeScale = 1;
			next.Play();
			s ++ ;
			mission ++;
		}
	}
}
