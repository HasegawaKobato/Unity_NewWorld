using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mission_MA : MonoBehaviour {

	public GameObject dialogTile;
	public GameObject talk;
	public GameObject talk2;

	MissionProgress mis;
	AudioSource next;

	int s = 0;

	// Use this for initialization
	void Start () {
		mis = GameObject.FindGameObjectWithTag("Mission").GetComponent<MissionProgress>();
		next = GetComponent<AudioSource>();		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown(KeyCode.Z)) {
			if (s == 1) {
				talk.SetActive(false);
				talk2.SetActive(true);
				Time.timeScale = 0;
				next.Play();
				s++;
			}else if (s == 2) {
				dialogTile.SetActive(false);
				talk2.SetActive(false);
				Time.timeScale = 1;
				next.Play();
				s++;
			}
		}
		
	}

	void OnTriggerEnter (Collider other) {
		if (other.gameObject.CompareTag("Player")) {
			if (mis.mission == 13 && s == 0) {
				dialogTile.SetActive(true);
				talk.SetActive(true);
				mis.tenMin = true;
				Time.timeScale = 0;
				s++;
				mis.mission++;
				mis.time = Time.time;
			}
		}
	}
}
