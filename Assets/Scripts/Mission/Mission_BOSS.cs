using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mission_BOSS : MonoBehaviour {

	public GameObject light;

	MissionProgress mis;
	AudioSource mons;
	AudioSource town;
	AudioSource begin;

	// Use this for initialization
	void Start () {
		mis = GameObject.FindGameObjectWithTag("Mission").GetComponent<MissionProgress>();
		mons = GameObject.FindGameObjectWithTag("BGM_MonsterArea").GetComponent<AudioSource>();
		town = GameObject.FindGameObjectWithTag("BGM_Town").GetComponent<AudioSource>();
		begin = GameObject.FindGameObjectWithTag("BGM_Begining").GetComponent<AudioSource>();
	}


	void OnTriggerEnter (Collider other) {
		if (other.gameObject.CompareTag("Player")) {
			if (mis.mission == 21) {
				light.SetActive(true);
				mons.Stop();
				town.Stop();
				begin.Stop();
				SceneManager.LoadScene("Boss", LoadSceneMode.Single);
			}
		}
	}
}
