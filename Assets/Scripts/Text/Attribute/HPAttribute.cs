using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPAttribute : MonoBehaviour {
	
	public Slider maxHPSlider;
	public HPSet maxHp;

	Text hpAttribute;

	// Use this for initialization
	void Start () {
		hpAttribute = GetComponent <Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		hpAttribute.text = maxHp.HPOutput;
		maxHPSlider.maxValue = maxHp.HpAdditionCounting;
	}

}
