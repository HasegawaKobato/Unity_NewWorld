using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM_MonsterArea : MonoBehaviour {
	
	GameObject player;
	AudioSource mons;
	AudioSource begin;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
		begin = GameObject.FindGameObjectWithTag("BGM_Begining").GetComponent<AudioSource>();
		mons = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider other) {
		if (other.gameObject.CompareTag("Player")) {
			if (begin.isPlaying) {
				mons.Play();
				begin.Stop();
			}else if (mons.isPlaying) {
				begin.Stop();
			}

			if (begin.isPlaying == false && mons.isPlaying == false) {
				mons.Play();
			}
		}
	}
}
