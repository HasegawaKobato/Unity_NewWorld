using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterMaxHP : MonoBehaviour {
	
	public Slider maxHPSlider;
	public HPSet maxHp;

	Text maxHP;

	// Use this for initialization
	void Start () {
		maxHP = GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
		maxHP.text = "/" + maxHp.HPOutput;
		maxHPSlider.maxValue = maxHp.HpAdditionCounting;
	}
}
