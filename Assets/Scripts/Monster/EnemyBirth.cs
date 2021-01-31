using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBirth : MonoBehaviour {

	public MonsterActions monAct;
	public MonsterAbility monAbi;

	public GameObject player;
	public GameObject monster;
	public float spawnTime = 8f;
	public bool spawn;

	float time;
	int spawnRate;

	GameObject newMonster;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		spawnRate = (int)(monAbi.monsterBirth*100);
		int s = Random.Range (0, 100);

		if (Vector3.Distance (transform.position, player.transform.position) <= 15f) {
			if (Time.time - time >= spawnTime) {
				if (s <= spawnRate) {
					if (spawn == false) {
						time = Time.time;
						newMonster = Instantiate (monster, transform.position, transform.rotation);
						spawn = true;
					}
				}
			}

		}

		if (Vector3.Distance (transform.position, player.transform.position) >= 18f) {
			Destroy (newMonster);
			spawn = false;
			newMonster = null;
		}

	}



}
