using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerExperience : MonoBehaviour {
	
	public MonsterAbility[] monsAbility = new MonsterAbility[7];
	public LUCSet lucky;

	PlayerHealth playerHealth;

	public float currentEXP;
	public float maxEXP;

	Slider slider;

	// Use this for initialization
	void Start () {
		slider = GameObject.FindGameObjectWithTag("EXP").GetComponent<Slider> ();
	}
	
	// Update is called once per frame
	void Update () {
		currentEXP = slider.value;
		maxEXP = slider.maxValue;


	}

	public void CactusDead() {
		slider.value += monsAbility[0].monsterEXP;
	}
	public void BlueDead() {
		slider.value += monsAbility[1].monsterEXP;
	}
	public void GoldDead() {
		slider.value += monsAbility[2].monsterEXP;
	}
	public void GreenDead() {
		slider.value += monsAbility[3].monsterEXP;
	}
	public void RedDead() {
		slider.value += monsAbility[4].monsterEXP;
	}
	public void BOSSDead() {
		slider.value += monsAbility[5].monsterEXP;
	}
	public void RhinoDead() {
		slider.value += monsAbility [6].monsterEXP;
	}



	public void ReduceEXP () {
		slider.value = currentEXP - (float)lucky.LucAdditionCounting;
	}
}
