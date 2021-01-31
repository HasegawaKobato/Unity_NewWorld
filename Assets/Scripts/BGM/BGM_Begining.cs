using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM_Begining : MonoBehaviour {
	
	GameObject player;
	AudioSource mons;
	AudioSource begin;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
		begin = GetComponent<AudioSource>();
		mons = GameObject.FindGameObjectWithTag("BGM_MonsterArea").GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}



	void OnTriggerEnter (Collider other) {
		if (other.gameObject.CompareTag("Player")) {
			if (begin.isPlaying) {
				mons.Stop();
			}else if (mons.isPlaying) {
				begin.Play();
				mons.Stop();
			}

			if (begin.isPlaying == false && mons.isPlaying == false) {
				begin.Play();
			}
		}
	}
}
