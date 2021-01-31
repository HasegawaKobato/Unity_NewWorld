using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossBlood : MonoBehaviour {

	MonsterAbility boss;

	Slider blood;

	// Use this for initialization
	void Start () {
		boss = GameObject.FindGameObjectWithTag("BOSS").GetComponent<MonsterAbility>();
		blood = GetComponent<Slider>();
	}
	
	// Update is called once per frame
	void Update () {
		blood.value = boss.monsterHP;
	}
}
