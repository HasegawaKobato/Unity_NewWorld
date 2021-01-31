using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM_Town : MonoBehaviour {
	
	GameObject player;
	AudioSource mons;
	AudioSource town;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
		town = GetComponent<AudioSource>();
		mons = GameObject.FindGameObjectWithTag("BGM_MonsterArea").GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}



	void OnTriggerEnter (Collider other) {
		if (other.gameObject.CompareTag("Player")) {
			if (town.isPlaying) {
				mons.Stop();
			}else if (mons.isPlaying) {
				town.Play();
				mons.Stop();
			}

			if (town.isPlaying == false && mons.isPlaying == false) {
				town.Play();
			}
		}
	}
}
