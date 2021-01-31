using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mission_Rhino : MonoBehaviour {

	MissionProgress mis;
	MonsterAbility mons;
	GameObject spawn;

	// Use this for initialization
	void Start () {
		mis = GameObject.FindGameObjectWithTag("Mission").GetComponent<MissionProgress>();
		mons = GameObject.FindGameObjectWithTag("Rhino").GetComponent<MonsterAbility>();
		spawn = GameObject.FindGameObjectWithTag("MissionRhinoSpawn");
	}
	
	// Update is called once per frame
	void Update () {
		if (mis.mission == 14) {
			if (mons.monsterHP <= 1000) {
				mis.mission = 15;
				spawn.SetActive(false);
			}
		}
	}
}
