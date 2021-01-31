using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAbility : MonoBehaviour {

	public KBSet kbSet;
	public AGISet agiSet;
	public ATKSet atkSet;

	public int monsterHP;
	public int monsterATK;
	public int monsterDEF;
	public int monsterKB;
	public float monsterBirth;
	public float monsterAVO;
	public int monsterEXP;
	public float weeds;
	public float flowers;
	public float tcm;

	public bool kb;

	public int damage;
	int avoidRate;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		avoidRate = (int)(monsterAVO * 100);
		if (avoidRate>=5000){
			avoidRate = 5000;
		}

		if (damage > monsterKB){
			kb = true;
		}else {
			kb = false;
		}
	}

	public void GetHit () {
		int random = Random.Range(0,10000);
		if (random >= avoidRate) {
			monsterHP -= damage;
		}
	}
}
