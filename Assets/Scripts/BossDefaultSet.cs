using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossDefaultSet : MonoBehaviour {
	
	GameObject player;
	AudioSource BOSS;
	PlayerHealth hp;

	Vector3 boss = new Vector3(0,0,-8);
	Quaternion end = new Quaternion(0,0,0,0);
	int a = 0;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
		hp = GameObject.FindGameObjectWithTag("HP").GetComponent<PlayerHealth>();
		BOSS = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time >= 0.5f && a == 0)  {
			a ++ ;
			player.transform.position = boss;
			player.transform.rotation = end;
			BOSS.volume = 1f;
		}
		if (hp.dead) {
			BOSS.Stop();
		}
		if (BOSS.isPlaying == false) {
			BOSS.Play();
		}

	}
}
