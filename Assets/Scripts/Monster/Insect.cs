using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Insect : MonoBehaviour {

	public GameObject slider;

	MonsterAbility insect;
	MissionProgress mis;

	int s = 0;
	// Use this for initialization
	void Start () {
		insect = GetComponent<MonsterAbility>();
		mis = GameObject.FindGameObjectWithTag("Mission").GetComponent<MissionProgress>();
	}
	
	// Update is called once per frame
	void Update () {
		if (s == 0 && mis.mission == 21 && insect.monsterHP <= 0){
			s++;
			mis.mission ++;
			slider.SetActive (false);
		}
	}
}
